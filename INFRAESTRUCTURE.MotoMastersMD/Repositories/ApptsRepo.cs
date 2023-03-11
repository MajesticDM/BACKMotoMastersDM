using CORE.MotoMastersMD.Entities;
using CORE.MotoMastersMD.Interfaces;
using INFRAESTRUCTURE.MotoMastersMD.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace INFRAESTRUCTURE.MotoMastersMD.Repositories
{
    public class ApptsRepo : IAppts
    {
        private readonly MOTO_MASTERS_MDContext _context;
        public ApptsRepo(MOTO_MASTERS_MDContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Appointments>> GetAppts()
        {
            var MMD = await _context.Appointments.ToListAsync();
            return MMD;
        }

        public async Task<Appointments> GetxId(int Id)
        {
            var MMD = await _context.Appointments.FirstOrDefaultAsync(x => x.ApptId == Id);
            return MMD;
        }

        public async Task Post(Appointments MMD)
        {
            _context.Add(MMD);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> Update(Appointments MMD)
        {
            var dat = await GetxId((int)MMD.ApptId);

            dat.IdxClient = MMD.IdxClient;
            dat.IdxUserCreator = MMD.IdxUserCreator;
            dat.IdxService = MMD.IdxService;
            dat.IdxStatus = MMD.IdxStatus;
            dat.ApptDate = MMD.ApptDate;

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> Delete(int Id)
        {
            var Delete = await GetxId(Id);
            _context.Appointments.Remove(Delete);

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }
    }
}
