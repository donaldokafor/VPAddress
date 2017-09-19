using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VPA.Models
{
    public class accountEnquiryResponse
    {
        public accountInformation accountInformation { get; set; }
        public personalInformation personalInformation { get; set; }
    }
}
