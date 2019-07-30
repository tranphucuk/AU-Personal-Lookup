using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Australia_Scanner.LicenseModule
{
    public class LicenseInfo
    {
        public string ActiveKey { get; set; }
        public long ActiveDateInUtc { get; set; }
        public int UsingDayAccepted { get; set; }
        public LicenseType Type { get; set; }
    }
}
