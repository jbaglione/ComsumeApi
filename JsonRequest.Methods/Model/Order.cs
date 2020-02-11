namespace JsonRequest.Methods
{
    public class Order
    {
        //var order = new Order { preIncidentId = 7, message = "Orden ingresada correctamente" };
        public long preIncidentId { get; set; }
        public string NroServicio { get; set; }
        public string message { get; set; }
    }
}
