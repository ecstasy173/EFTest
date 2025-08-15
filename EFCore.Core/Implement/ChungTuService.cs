using AutoMapper;
using EFCore.Core.Domain.Dto;
using EFCore.Core.Domain.Entities;
using EFCore.Core.Interface;
using EFCore.Core.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Core.Implement
{
    public class ChungTuService : IChungTuService
    {
        private readonly ChungTuRepository _chungTuRepository;
        private readonly ChungTuChiTietRepository _chungTuChiTietRepository;
        private readonly IMapper _mapper;

        public ChungTuService(ChungTuRepository chungTuRepository, IMapper mapper,ChungTuChiTietRepository chungTuChiTietRepository)
        {
            _chungTuRepository = chungTuRepository;
            _mapper = mapper;
            _chungTuChiTietRepository = chungTuChiTietRepository;
        }

        public async Task<ChungTuDto?> GetByIdAsync(long id)
        {
            var entity = await _chungTuRepository.GetByIdAsync(id);
            return entity == null ? null : _mapper.Map<ChungTuDto>(entity);
        }
        public async Task<ChungTuDto?> GetByIdLazyLoadingAsync(long id, bool loadDetails)
        {
            // Lấy ChungTu cơ bản (không có chi tiết)
            var entity = await _chungTuRepository.GetByIdWithLazyLoadingAsync(id);
            if (entity == null) return null;

            var dto = _mapper.Map<ChungTuDto>(entity);

            // Chỉ tải chi tiết khi cần thiết 
            if (loadDetails)
            {
                // Tải chi tiết theo yêu cầu
                var chiTiets = await _chungTuChiTietRepository.LoadChiTietsAsync(id);
                dto.ChungTuChiTiets = _mapper.Map<ICollection<ChungTuChiTietDto>>(chiTiets);
            }

            return dto;
        }

        public async Task<List<ChungTuDto>> GetAllAsync()
        {
            var entities = await _chungTuRepository.GetAllAsync();
            return _mapper.Map<List<ChungTuDto>>(entities);
        }

        public async Task AddAsync(ChungTuDto dto)
        {
            var entity = _mapper.Map<ChungTu>(dto);
            await _chungTuRepository.AddAsync(entity);
        }

        public async Task UpdateAsync(ChungTuDto dto)
        {
            var existing = await _chungTuRepository.GetByIdAsync(dto.Id);
            if (existing == null) return;
            if (!existing.RowVersion.SequenceEqual(dto.RowVersion))
                throw new DbUpdateConcurrencyException("Dữ liệu đã bị thay đổi bởi người khác.");

            // Cập nhật các trường của chứng từ
            _mapper.Map(dto, existing);

            // Xử lý collection chi tiết
            // Xóa chi tiết cũ không còn trong DTO
            if (existing.ChungTuChiTiets != null && dto.ChungTuChiTiets != null)
            {
                var toRemove = existing.ChungTuChiTiets
                    .Where(old => !dto.ChungTuChiTiets.Any(newCt => newCt.Id == old.Id))
                    .ToList();

                foreach (var item in toRemove)
                {
                    existing.ChungTuChiTiets.Remove(item);
                }
            }

            // Thêm hoặc cập nhật chi tiết mới
            if (dto.ChungTuChiTiets != null)
            {
                foreach (var newCtDto in dto.ChungTuChiTiets)
                {
                    var oldCt = existing.ChungTuChiTiets.FirstOrDefault(x => x.Id == newCtDto.Id);
                    if (oldCt == null)
                    {
                        // Thêm mới
                        var newCt = _mapper.Map<ChungTuChiTiet>(newCtDto);
                        existing.ChungTuChiTiets.Add(newCt);
                    }
                    else
                    {
                        // Cập nhật
                        _mapper.Map(newCtDto, oldCt);
                    }
                }
            }

            await _chungTuRepository.UpdateAsync(existing);
        }

        public async Task DeleteAsync(long id)
        {
            await _chungTuRepository.DeleteAsync(id);
        }
        public async Task<(IList<ChungTuDto>, long)> GetByFilterAsync(
            bool trangThaiChungTu,
            string? keyword,
            DateTime fromdate,
            DateTime todate,
            int pageindex,
            int pagesize)
        {
            var query = _chungTuRepository.Query
                .Where(x => x.NgayPhatSinh >= fromdate && x.NgayPhatSinh <= todate && x.IsDraft == trangThaiChungTu);

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(x =>
                    (x.SoChungTu != null && x.SoChungTu.Contains(keyword)) ||
                    (x.NoiDungPhatSinh != null && x.NoiDungPhatSinh.Contains(keyword))
                );
            }

            var total = await query.CountAsync();

            // Paging and mapping
            var entities = await query
                .OrderByDescending(x => x.NgayPhatSinh)
                .Skip((pageindex - 1) * pagesize)
                .Take(pagesize).Select(x => new ChungTuDto
                {
                    SoChungTu = x.SoChungTu,
                    NgayPhatSinh = x.NgayPhatSinh,
                    TongTienChuaThue = x.TongTienChuaThue
                })
                .ToListAsync();

            var projectedQuery = query
        .OrderByDescending(x => x.NgayPhatSinh)
        .Skip((pageindex - 1) * pagesize)
        .Take(pagesize)
        .Select(x => new
        {
            x.SoChungTu,
            x.NgayPhatSinh,
            x.TongTienChuaThue
        });

            Console.WriteLine(projectedQuery.ToQueryString());
            return (entities, total);
        }
    }
}
