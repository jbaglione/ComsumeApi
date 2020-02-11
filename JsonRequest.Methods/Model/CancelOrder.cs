using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonRequest.Methods
{
    public class CancelOrder
    {
        public long preIncidentId { get; set; }
        public string message { get; set; }
    }
}
