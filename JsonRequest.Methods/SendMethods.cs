using System;
using JsonRequest;
using System.Configuration;
namespace JsonRequest.Methods
{
    public class SendMethods
    {
        Request request = new Request();
        static string server = ConfigurationManager.AppSettings["serverTest"];

        public bool ConfirmOrder(Order order) => (bool)request.Execute<bool>(server + "/Notification/ConfirmOrder", order, "POST");
        public bool OrderMobileAssigned(OrderMobileAssigned orderMobileAssigned) => (bool)request.Execute<bool>(server + "/Notification/OrderMobileAssigned", orderMobileAssigned, "POST");
        public bool CompleteOrder(CompleteOrder completeOrder) => (bool)request.Execute<bool>(server + "/Notification/CompleteOrder", completeOrder, "POST");
        public bool PushText(PushText pushText) => (bool)request.Execute<bool>(server + "/Notification/PushText", pushText, "POST");
        public bool CancelOrder(CancelOrder cancelOrder) => (bool)request.Execute<bool>(server + "/Notification/CancelOrder", cancelOrder, "POST");
        public bool ArriveOrder(ArriveOrder arriveOrder) => (bool)request.Execute<bool>(server + "/Notification/ArriveOrder", arriveOrder, "POST");
    }
}
