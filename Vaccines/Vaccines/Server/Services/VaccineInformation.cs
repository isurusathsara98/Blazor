using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Vaccines.Shared;

namespace Vaccines.Server.Services
{
    public class VaccineInformation : IVaccineInformation
    {
       
        public static List<VaccineInfo> vaccine = new List<VaccineInfo>
        {
            new VaccineInfo
            {
                Id=1,
                Name="Sinopharm",
                BatchNo=200,
                Area="Galle",
                NoofDoses=14000
            },
            new VaccineInfo
            {
                Id=2,
                Name="Astraseni",
                BatchNo=400,
                Area="Gampaha",
                NoofDoses=20000
            },

        };

        public List<VaccineInfo> createVac(VaccineInfo vac)
        {
            vac.Id = vaccine.Max(h => h.Id + 1);
            vaccine.Add(vac);
            return vaccine;
        }

        public List<VaccineInfo> GetVaccine()
        {
            return VaccineInformation.vaccine;
        }

      
    }
}
