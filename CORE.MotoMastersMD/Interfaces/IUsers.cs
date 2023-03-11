using CORE.MotoMastersMD.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CORE.MotoMastersMD.Interfaces
{
    public interface IUsers
    {
        Task<IEnumerable<Users>> GetUsers();
        Task<Users> GetxId(int Id);
        Task Post(Users MMD);
        Task<bool> Update(Users MMD);
        Task<bool> Delete(int Id);
    }
}
