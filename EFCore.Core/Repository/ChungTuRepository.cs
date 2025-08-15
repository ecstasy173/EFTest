using EFCore.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Core.Repository
{
    public class ChungTuRepository : Repository<ChungTu, long>
    {
        public ChungTuRepository(QlvtthanDongBacOfficialContext context) : base(context) { }

        public override async Task<ChungTu?> GetByIdAsync(long id)
        {
            try
            {


                return await _dbSet
                    .Include(ct => ct.ChungTuChiTiets)
                    .FirstOrDefaultAsync(ct => ct.Id == id);
            }
            catch (Exception ex)
            {
                // Log the exception (not implemented here)
                throw new Exception("An error occurred while retrieving the ChungTu by ID.", ex);
            }
        }
        public async Task<ChungTu?> GetByIdWithLazyLoadingAsync(long id)
        {
            // Không sử dụng Include() - các chi tiết sẽ được tải khi truy cập
            return await _dbSet.AsNoTracking().FirstOrDefaultAsync(ct => ct.Id == id);
        }
    }
}
