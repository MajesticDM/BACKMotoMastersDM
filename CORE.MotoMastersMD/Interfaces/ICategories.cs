using CORE.MotoMastersMD.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CORE.MotoMastersMD.Interfaces
{
    public interface ICategories
    {
        Task<IEnumerable<Categories>> GetCategories();
        Task<Categories> GetxId(int Id);
        Task Post(Categories MMD);
        Task<bool> Update(Categories MMD);
        Task<bool> Delete(int Id);
    }
}
