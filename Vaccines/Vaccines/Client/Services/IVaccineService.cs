using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vaccines.Shared;

namespace Vaccines.Client.Services
{
    public interface IVaccineService
    {
        event Action OnChange;
        List<VaccineInfo> vacine { get; set; }
        Task<List<VaccineInfo>> GetVaccine();

        Task<List<VaccineInfo>> Createvac(VaccineInfo vacc);
    }
}
