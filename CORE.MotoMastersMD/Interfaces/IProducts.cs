using CORE.MotoMastersMD.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CORE.MotoMastersMD.Interfaces
{
    public interface IProducts
    {
        Task<IEnumerable<Products>> GetProducts();
        Task<Products> GetxId(int Id);
        Task Post(Products MMD);
        Task<bool> Update(Products MMD);
        Task<bool> Delete(int Id);
    }
}
