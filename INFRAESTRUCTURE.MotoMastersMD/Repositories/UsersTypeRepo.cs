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
    public class UsersTypeRepo : IUsersType
    {
        private readonly MOTO_MASTERS_MDContext _context;
        public UsersTypeRepo(MOTO_MASTERS_MDContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<UsersType>> GetUsersType()
        {
            var MMD = await _context.UsersType.ToListAsync();
            return MMD;
        }

        public async Task<UsersType> GetxId(int Id)
        {
            var MMD = await _context.UsersType.FirstOrDefaultAsync(x => x.UserTypeId == Id);
            return MMD;
        }

        public async Task Post(UsersType MMD)
        {
            _context.Add(MMD);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> Update(UsersType MMD)
        {
            var dat = await GetxId((int)MMD.UserTypeId);

            dat.UserType = MMD.UserType;
            dat.Status = MMD.Status;

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> Delete(int Id)
        {
            var Delete = await GetxId(Id);
            _context.UsersType.Remove(Delete);

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }
    }
}
