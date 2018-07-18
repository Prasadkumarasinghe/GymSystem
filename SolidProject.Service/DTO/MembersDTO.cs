using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidProject.Service.DTO
{
   public class MembersDTO
    {
        public int id { get; set; }
        public string MemberId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Mob { get; set; }
        public DateTime DOB { get { return DateTime.Now; } }
    }


    public class VIP : MembersDTO
    {
        public string SecreatCode { get; set; }
        public string NoOfSpecialDays { get; set; }
        public bool isCarParkAvailable { get; set; }
    }

    public class Premium : MembersDTO
    {
        public int NoOfExtraDays { get; set; }
        public string isElectricMachinesAllowed { get; set; }
    }

}
