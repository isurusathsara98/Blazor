
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vaccines.Server.Services;
using Vaccines.Shared;

namespace Vaccines.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaccineController : ControllerBase
    {
        private readonly IVaccineInformation _vaccineInformation;
       
        public VaccineController(IVaccineInformation vaccineInformation)
        {
            _vaccineInformation = vaccineInformation;
        }

        [HttpGet]
        public async Task<IActionResult> GetVaccine()
        {
          
            return Ok(_vaccineInformation.GetVaccine());
        }
        [HttpPost]
        public async Task<IActionResult> Createvac(VaccineInfo vac)
        {
            return Ok(_vaccineInformation.createVac(vac));
        }
    }
}
