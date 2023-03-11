using CORE.MotoMastersMD.Entities;
using CORE.MotoMastersMD.Interfaces;
using INFRAESTRUCTURE.MotoMastersMD.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace INFRAESTRUCTURE.MotoMastersMD.Repositories
{
    public class ServicesGivenRepo : IServicesGiven
    {
        private readonly MOTO_MASTERS_MDContext _context;
        public ServicesGivenRepo(MOTO_MASTERS_MDContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ServicesGiven>> GetServicesGiven()
        {
            var MMD = await _context.ServicesGiven.ToListAsync();
            return MMD;
        }

        public async Task<ServicesGiven> GetxId(int Id)
        {
            var MMD = await _context.ServicesGiven.FirstOrDefaultAsync(x => x.ServiceGivenId == Id);
            return MMD;
        }

        public async Task Post(ServicesGiven MMD)
        {
            _context.Add(MMD);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> Update(ServicesGiven MMD)
        {
            var dat = await GetxId((int)MMD.ServiceGivenId);

            dat.IdxService = MMD.IdxService;
            dat.IdxClient = MMD.IdxClient;
            dat.ClientLeftKeys = MMD.ClientLeftKeys;
            dat.KeysAppearance = MMD.KeysAppearance;
            dat.DifferentVehicle = MMD.DifferentVehicle;
            dat.VehiclePlate = MMD.VehicleBrand;
            dat.VehicleColor = MMD.VehicleColor;
            dat.VehicleBrand = MMD.VehicleBrand;
            dat.AditionalCost = MMD.AditionalCost;
            dat.TotalCost = MMD.TotalCost;
            dat.DateProvisionService= MMD.DateProvisionService;


            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> Delete(int Id)
        {
            var Delete = await GetxId(Id);
            _context.ServicesGiven.Remove(Delete);

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }
    }
}
