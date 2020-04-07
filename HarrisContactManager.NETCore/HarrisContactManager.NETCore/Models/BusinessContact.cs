using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarrisContactManager.NETCore.Models
{
    public class BusinessContact
    {
        public int ID { get; set; }
        public string BusinessFName { get; set; }
        public string BusinessLName { get; set; }
        public string BusinessEmail { get; set; }
        public string BusinessTel { get; set; }
        public string BusinessAddr1 { get; set; }
        public string BusinessAddr2 { get; set; }
        public string BusinessCity { get; set; }
        public string BusinessPostcode { get; set; }
        public string BusinessBusinessTel { get; set; }
    }
}
