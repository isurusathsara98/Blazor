using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccines.Shared
{
    public class VaccineInfo
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public int BatchNo { get; set; }
        public string Area { get; set; }

        public int NoofDoses { get; set; }
    }
}
