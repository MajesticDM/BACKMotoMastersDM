using CORE.MotoMastersMD.Entities;
using CORE.MotoMastersMD.Interfaces;
using INFRAESTRUCTURE.MotoMastersMD.Data;
using INFRAESTRUCTURE.MotoMastersMD.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Infrastructure.Repositories
{
    public class SecurityRepo : ISecurity
    {
        private readonly MOTO_MASTERS_MDContext _context;
        public SecurityRepo(MOTO_MASTERS_MDContext context) {
            _context = context;
        }

        public async Task<Users> GetLoginByCredential(Security login)
        {
            Users users = await _context.Users.FirstOrDefaultAsync(x => x.UserName == login.userName && x.Password == login.password);
            return users;
        }
    }
}
