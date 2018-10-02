using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace JsonRequest.Methods
{
    public class OrderMobileAssigned
    {
        public int preIncidentId { get; set; }
        public string mobileNumber { get; set; }
        public string doctor { get; set; }
        public string nurse { get; set; }
        public string driver { get; set; }
        public string estimatedTime { get; set; }
        public string message { get; set; }
    }
}
