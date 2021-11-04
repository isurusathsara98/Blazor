using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vaccinedetails;
namespace Task_1.Client.Pages
{
    
    public class Editvaccinebase : ComponentBase
    {
        public Vaccineinfo Vaccinemod = new Vaccineinfo();
        protected override Task OnInitializedAsync()
        {
            initializeData();
            return base.OnInitializedAsync();
        }
        private void initializeData()
        {
            Vaccineinfo Sino = new Vaccineinfo
            {
                BatchNo = 400,
                Name = "Sinopharm",
                distribution = "Galle",
                NoofDoses = 1000
            };
            Vaccineinfo Ast = new Vaccineinfo
            {
                BatchNo = 200,
                Name = "Astrasenica",
                distribution = "Colombo",
                NoofDoses = 2000
            };
            Vaccineinfo phi = new Vaccineinfo
            {
                BatchNo = 500,
                Name = "Pfizer",
                distribution = "Hambanthota",
                NoofDoses = 23312
            };
            Vaccineinfo Sino1 = new Vaccineinfo
            {
                BatchNo = 100,
                Name = "Sinopharm",
                distribution = "Gampaha",
                NoofDoses = 2321
            };


            Vaccines = new List<Vaccineinfo> { Sino, Ast, phi, Sino1};
            
        }
        public List<Vaccineinfo> Vaccines { get; private set; }

        public void OnValidSubmit()
        {

           for(int i=0;i<Vaccines.Count;i++){
                if(Vaccines[i].BatchNo==Vaccinemod.BatchNo)
                {
                    Vaccines[i].Name = Vaccinemod.Name;
                    Vaccines[i].distribution = Vaccinemod.distribution;
                    Vaccines[i].NoofDoses = Vaccinemod.NoofDoses;
                }
                else if(i==Vaccines.Count-1)
                {

                }
            }
           
        }
    }
}
