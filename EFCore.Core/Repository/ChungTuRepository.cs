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
            return await _dbSet
                .Include(ct => ct.ChungTuChiTiets)
                .FirstOrDefaultAsync(ct => ct.Id == id);
        }
    }
}
