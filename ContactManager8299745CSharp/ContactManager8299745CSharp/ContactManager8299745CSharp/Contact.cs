using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager8299745CSharp
{
    public abstract class Contact
    {
        public int ContactID { get; set; }

        public string ContactFName { get; set; }

        public string ContactLName { get; set; }

        public string ContactEmail { get; set; }

        public string ContactTel { get; set; }

        public string ContactAddr1 { get; set; }

        public string ContactAddr2 { get; set; }

        public string ContactCity { get; set; }

        public string ContactPostcode { get; set; }

    }
}
