using EFCore.Core.Domain.Dto;
using EFCore.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Core.Interface
{
    public interface IChungTuService
    {
        Task<ChungTuDto?> GetByIdAsync(long id);
        Task<List<ChungTuDto>> GetAllAsync();
        Task AddAsync(ChungTuDto entity);
        Task UpdateAsync(ChungTuDto entity);
        Task DeleteAsync(long id);
        Task<(IList<ChungTuDto>, long)> GetByFilterAsync(
            bool trangThaiChungTu,
            string? keyword,
            DateTime fromdate,
            DateTime todate,
            int pageindex,
            int pagesize);
    }
}
