using CORE.MotoMastersMD.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CORE.MotoMastersMD.Interfaces
{
    public interface ISoldProducts
    {
        Task<IEnumerable<SoldProducts>> GetSoldProducts();
        Task<SoldProducts> GetxId(int Id);
        Task Post(SoldProducts MMD);
        Task<bool> Update(SoldProducts MMD);
        Task<bool> Delete(int Id);
    }
}
