using CORE.MotoMastersMD.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CORE.MotoMastersMD.Interfaces
{
    public interface IPData
    {
        Task<IEnumerable<PersonalData>> GetPData();
        Task<PersonalData> GetxId(int Id);
        Task Post(PersonalData MMD);
        Task<bool> Update(PersonalData MMD);
        Task<bool> Delete(int Id);
    }
}
