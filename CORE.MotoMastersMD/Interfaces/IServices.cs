using CORE.MotoMastersMD.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CORE.MotoMastersMD.Interfaces
{
    public interface IServices
    {
        Task<IEnumerable<Services>> GetServices();
        Task<Services> GetxId(int Id);
        Task Post(Services MMD);
        Task<bool> Update(Services MMD);
        Task<bool> Delete(int Id);
    }
}
