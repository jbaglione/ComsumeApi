using System;
using JsonRequest;
using System.Configuration;
namespace JsonRequest.Methods
{
    public class SendMethods
    {
        Request request = new Request();
        static string server = ConfigurationManager.AppSettings["serverTest"];
        public bool ConfirmOrder()
        {
            var order = new Order { preIncidentId = 7, message = "Orden ingresada correctamente" };
            return (bool)request.Execute<bool>(server + "/Notification/ConfirmOrder", order, "POST");
        }
        public bool OrderMobileAssigned()
        {
            var orderMobileAssigned = new OrderMobileAssigned
                {   preIncidentId = 7,
                    mobileNumber= "865251",
                    doctor= "Dr. Gonzalez Marcos",
                    nurse= "Dra. Gonzalez Ana",
                    driver= "Juan Perez",
                    estimatedTime= "01:45",
                    message= "Móvil asignado!"  };

            return (bool)request.Execute<bool>(server + "/Notification/OrderMobileAssigned", orderMobileAssigned, "POST");
        }
        public bool CompleteOrder()
        {
            var completeOrder = new CompleteOrder
            {
                preIncidentId = 7,
                diagnostic = "Diagnostico",
                treatment = "Tratamiento recomendado: ...",
            };
            return (bool)request.Execute<bool>(server + "/Notification/CompleteOrder", completeOrder, "POST");
        }
        public bool PushText()
        {
            var pushText = new PushText
            {
                shamanUserId = 7,
                messageHeader = "Publicidad",
                messageText = "Nueva aplicación"
            };
            return (bool)request.Execute<bool>(server + "/Notification/ConfirmOrder", pushText, "POST");
        }

    }
}
