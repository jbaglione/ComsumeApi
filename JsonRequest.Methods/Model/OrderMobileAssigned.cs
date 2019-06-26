using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace JsonRequest.Methods
{
    public class OrderMobileAssigned
    {
        //var orderMobileAssigned = new OrderMobileAssigned
        //    {   preIncidentId = 7,
        //        mobileNumber= "865251",
        //        doctor= "Dr. Gonzalez Marcos",
        //        nurse= "Dra. Gonzalez Ana",
        //        driver= "Juan Perez",
        //        estimatedTime= "01:45",
        //        message= "Móvil asignado!"  };
        public long preIncidentId { get; set; }
        public string mobileNumber { get; set; }
        public string doctor { get; set; }
        public string nurse { get; set; }
        public string driver { get; set; }
        public string estimatedTime { get; set; }
        public string message { get; set; }
    }
}
