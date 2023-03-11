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
    public class ClientsRepo : IClients
    {
        private readonly MOTO_MASTERS_MDContext _context;
        public ClientsRepo(MOTO_MASTERS_MDContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Clients>> GetClients()
        {
            var MMD = await _context.Clients.ToListAsync();
            return MMD;
        }

        public async Task<Clients> GetxId(int Id)
        {
            var MMD = await _context.Clients.FirstOrDefaultAsync(x => x.ClientId == Id);
            return MMD;
        }

        public async Task Post(Clients MMD)
        {
            _context.Add(MMD);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> Update(Clients MMD)
        {
            var dat = await GetxId((int)MMD.ClientId);

            dat.CompleteName = MMD.CompleteName;
            dat.PhoneNumber = MMD.PhoneNumber;
            dat.HasVehicle = MMD.HasVehicle;
            dat.VehiclePlate = MMD.VehiclePlate;
            dat.VehicleColor = MMD.VehicleColor;
            dat.VehicleBrand = MMD.VehicleBrand;
            dat.ClientPhoto = MMD.ClientPhoto;
            dat.RegularClient = MMD.RegularClient;


            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> Delete(int Id)
        {
            var Delete = await GetxId(Id);
            _context.Clients.Remove(Delete);

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }
    }
}
