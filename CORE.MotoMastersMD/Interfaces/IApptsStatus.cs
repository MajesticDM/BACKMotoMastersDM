using CORE.MotoMastersMD.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CORE.MotoMastersMD.Interfaces
{
    public interface IApptsStatus
    {
        Task<IEnumerable<AppointmentsStatus>> GetApptsStatus();
        Task<AppointmentsStatus> GetxId(int Id);
        Task Post(AppointmentsStatus MMD);
        Task<bool> Update(AppointmentsStatus MMD);
        Task<bool> Delete(int Id);
    }
}
