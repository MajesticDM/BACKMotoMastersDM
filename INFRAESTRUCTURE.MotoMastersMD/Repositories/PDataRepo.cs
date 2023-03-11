using CORE.MotoMastersMD.Entities;
using CORE.MotoMastersMD.Interfaces;
using INFRAESTRUCTURE.MotoMastersMD.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace INFRAESTRUCTURE.MotoMastersMD.Repositories
{
    public class PDataRepo : IPData
    {
        private readonly MOTO_MASTERS_MDContext _context;
        public PDataRepo(MOTO_MASTERS_MDContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PersonalData>> GetPData()
        {
            var MMD = await _context.PersonalData.ToListAsync();
            return MMD;
        }

        public async Task<PersonalData> GetxId(int Id)
        {
            var MMD = await _context.PersonalData.FirstOrDefaultAsync(x => x.PersonalDataId == Id);
            return MMD;
        }

        public async Task Post(PersonalData MMD)
        {
            _context.Add(MMD);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> Update(PersonalData MMD)
        {
            var dat = await GetxId((int)MMD.PersonalDataId);

            dat.Name = MMD.Name;
            dat.LastName = MMD.LastName;
            dat.PhoneNumber = MMD.PhoneNumber;
            dat.Email = MMD.Email;
            dat.Photo= MMD.Photo;
            dat.Status = MMD.Status;
            
            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> Delete(int Id)
        {
            var Delete = await GetxId(Id);
            _context.PersonalData.Remove(Delete);

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }
    }
}
