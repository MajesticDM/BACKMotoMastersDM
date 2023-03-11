using CORE.MotoMastersMD.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CORE.MotoMastersMD.Interfaces
{
    public interface IServicesGiven
    {
        Task<IEnumerable<ServicesGiven>> GetServicesGiven();
        Task<ServicesGiven> GetxId(int Id);
        Task Post(ServicesGiven MMD);
        Task<bool> Update(ServicesGiven MMD);
        Task<bool> Delete(int Id);
    }
}
