using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonRequest.Methods
{
    public class PushText
    {
        public int shamanUserId { get; set; }
        public string messageHeader { get; set; }
        public string messageText { get; set; }
    }
}
