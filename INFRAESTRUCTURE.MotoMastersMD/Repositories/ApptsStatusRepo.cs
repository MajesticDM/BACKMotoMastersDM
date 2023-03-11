using CORE.MotoMastersMD.Entities;
using CORE.MotoMastersMD.Interfaces;
using INFRAESTRUCTURE.MotoMastersMD.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace INFRAESTRUCTURE.MotoMastersMD.Repositories
{
    public class ApptsStatusRepo : IApptsStatus
    {
        private readonly MOTO_MASTERS_MDContext _context;
        public ApptsStatusRepo(MOTO_MASTERS_MDContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AppointmentsStatus>> GetApptsStatus()
        {
            var MMD = await _context.AppointmentsStatus.ToListAsync();
            return MMD;
        }

        public async Task<AppointmentsStatus> GetxId(int Id)
        {
            var MMD = await _context.AppointmentsStatus.FirstOrDefaultAsync(x => x.StatusId == Id);
            return MMD;
        }

        public async Task Post(AppointmentsStatus MMD)
        {
            _context.Add(MMD);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> Update(AppointmentsStatus MMD)
        {
            var dat = await GetxId((int)MMD.StatusId);

            dat.AppointmentsStatus1 = MMD.AppointmentsStatus1;


            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> Delete(int Id)
        {
            var Delete = await GetxId(Id);
            _context.AppointmentsStatus.Remove(Delete);

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }
    }
}
