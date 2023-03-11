using CORE.MotoMastersMD.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CORE.MotoMastersMD.Interfaces
{
    public interface IClients
    {
        Task<IEnumerable<Clients>> GetClients();
        Task<Clients> GetxId(int Id);
        Task Post(Clients Clients);
        Task<bool> Update(Clients Clients);
        Task<bool> Delete(int Id);
    }
}
