using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarrisContactManager.NETCore.Models
{
    public class PersonalContact
    {
        public int ID { get; set; }
        public string PersonalFName { get; set; }
        public string PersonalLName { get; set; }
        public string PersonalEmail { get; set; }
        public string PersonalTel { get; set; }
        public string PersonalAddr1 { get; set; }
        public string PersonalAddr2 { get; set; }
        public string PersonalCity { get; set; }
        public string PersonalPostcode { get; set; }
        public string PersonalHomeTel { get; set; }
    }
}
