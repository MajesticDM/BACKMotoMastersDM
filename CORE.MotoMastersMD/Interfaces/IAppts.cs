using CORE.MotoMastersMD.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CORE.MotoMastersMD.Interfaces
{
    public interface IAppts
    {
        Task<IEnumerable<Appointments>> GetAppts();
        Task<Appointments> GetxId(int Id);
        Task Post(Appointments MMD);
        Task<bool> Update(Appointments MMD);
        Task<bool> Delete(int Id);
    }
}
