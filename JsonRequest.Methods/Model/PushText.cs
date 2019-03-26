using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonRequest.Methods
{
    public class PushText
    {
        //var pushText = new PushText
        //{
        //    shamanUserId = 7,
        //    messageHeader = "Publicidad",
        //    messageText = "Nueva aplicación"
        //};
        public int shamanUserId { get; set; }
        public string messageHeader { get; set; }
        public string messageText { get; set; }
    }
}
