using CORE.MotoMastersMD.Entities;
using CORE.MotoMastersMD.Interfaces;
using INFRAESTRUCTURE.MotoMastersMD.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace INFRAESTRUCTURE.MotoMastersMD.Repositories
{
    public class UsersRepo : IUsers
    {
        private readonly MOTO_MASTERS_MDContext _context;
        public UsersRepo(MOTO_MASTERS_MDContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Users>> GetUsers()
        {
            var MMD = await _context.Users.ToListAsync();
            return MMD;
        }

        public async Task<Users> GetxId(int Id)
        {
            var MMD = await _context.Users.FirstOrDefaultAsync(x => x.UserId == Id);
            return MMD;
        }

        public async Task Post(Users MMD)
        {
            _context.Add(MMD);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> Update(Users MMD)
        {
            var dat = await GetxId((int)MMD.UserId);

            dat.IdxUserType = MMD.IdxUserType; 
            dat.IdxPersonalData = MMD.IdxPersonalData;
            dat.UserName = MMD.UserName;
            dat.Password = MMD.Password;
            dat.CreationDate = MMD.CreationDate;
            dat.Status = MMD.Status;
            dat.Photo = MMD.Photo;
            
            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> Delete(int Id)
        {
            var Delete = await GetxId(Id);
            _context.Users.Remove(Delete);

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }
    }
}
