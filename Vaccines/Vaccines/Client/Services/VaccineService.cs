using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Vaccines.Shared;

namespace Vaccines.Client.Services
{
    public class VaccineService : IVaccineService
    {
        private readonly HttpClient _httpClient;

        public VaccineService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public List<VaccineInfo> vacine { get; set; } = new List<VaccineInfo>();

        public event Action OnChange;

        public async Task<List<VaccineInfo>> Createvac(VaccineInfo vacc)
        {
            var result = await _httpClient.PostAsJsonAsync<VaccineInfo>($"api/Vaccine", vacc);
            vacine = await result.Content.ReadFromJsonAsync<List<VaccineInfo>>();
            OnChange.Invoke();
            return vacine;
        }

        public async Task<List<VaccineInfo>> GetVaccine()
        {
            vacine = await _httpClient.GetFromJsonAsync<List<VaccineInfo>>("api/Vaccine");
            return vacine;
        }
    }
}
