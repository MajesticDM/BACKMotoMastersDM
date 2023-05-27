using CORE.MotoMastersMD.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CORE.MotoMastersMD.Interfaces
{
    public interface ISecurity
    {
        Task<Users> GetLoginByCredential(Security login);
    }
}
