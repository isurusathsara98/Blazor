using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vaccines.Shared;

namespace Vaccines.Server.Services
{
    public interface IVaccineInformation
    {
        public static List<VaccineInfo> vacine { get; set; }
        public List<VaccineInfo> GetVaccine();

        public List<VaccineInfo> createVac(VaccineInfo vac);

    }
}
