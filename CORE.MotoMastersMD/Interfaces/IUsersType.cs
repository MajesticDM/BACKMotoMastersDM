using CORE.MotoMastersMD.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CORE.MotoMastersMD.Interfaces
{
    public interface IUsersType
    {
        Task<IEnumerable<UsersType>> GetUsersType();
        Task<UsersType> GetxId(int Id);
        Task Post(UsersType MMD);
        Task<bool> Update(UsersType MMD);
        Task<bool> Delete(int Id);
    }
}
