using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidProject.Entities.Models
{
    public class Members
    {
        public int id { get; set; }
        public string MemberId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Mob { get; set; }
        public DateTime DOB { get; set; }
        
    }
}
