using EFCore.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Core.Repository
{
    public class ChungTuChiTietRepository : Repository<ChungTuChiTiet, long>
    {
        public ChungTuChiTietRepository(QlvtthanDongBacOfficialContext context) : base(context) { }

        // Lấy tất cả chi tiết theo Id chứng từ cha
        public async Task<List<ChungTuChiTiet>> GetByChungTuIdAsync(long chungTuId)
        {
            return await _dbSet
                .Where(ctct => ctct.IdchungTu == chungTuId)
                .ToListAsync();
        }
        public async Task<ICollection<ChungTuChiTiet>> LoadChiTietsAsync(long chungTuId)
        {
            return await _dbSet
                .Where(ct => ct.IdchungTu == chungTuId)
                .ToListAsync();
        }


    }
}
