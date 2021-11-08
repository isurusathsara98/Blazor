using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vaccines.Shared;

namespace Vaccines.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaccineController : ControllerBase
    {
        static List<VaccineInfo> vaccine = new List<VaccineInfo>
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

        [HttpGet]
        public async Task<IActionResult> GetVaccine()
        {
            return Ok(vaccine);
        }
        [HttpPost]
        public async Task<IActionResult> Createvac(VaccineInfo vac)
        {
            vac.Id = vaccine.Max(h => h.Id + 1);
            vaccine.Add(vac);
            return Ok(vaccine);
        }
    }
}
