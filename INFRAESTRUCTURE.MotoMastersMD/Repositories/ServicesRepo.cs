using CORE.MotoMastersMD.Entities;
using CORE.MotoMastersMD.Interfaces;
using INFRAESTRUCTURE.MotoMastersMD.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace INFRAESTRUCTURE.MotoMastersMD.Repositories
{
    public class ServicesRepo : IServices
    {
        private readonly MOTO_MASTERS_MDContext _context;
        public ServicesRepo(MOTO_MASTERS_MDContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Services>> GetServices()
        {
            var MMD = await _context.Services.ToListAsync();
            return MMD;
        }

        public async Task<Services> GetxId(int Id)
        {
            var MMD = await _context.Services.FirstOrDefaultAsync(x => x.ServiceId == Id);
            return MMD;
        }

        public async Task Post(Services MMD)
        {
            _context.Add(MMD);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> Update(Services MMD)
        {
            var dat = await GetxId((int)MMD.ServiceId);

            dat.Service = MMD.Service;
            dat.Description = MMD.Description;
            dat.RegularCost = MMD.RegularCost;
            dat.Status = MMD.Status;
            
            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> Delete(int Id)
        {
            var Delete = await GetxId(Id);
            _context.Services.Remove(Delete);

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }
    }
}
