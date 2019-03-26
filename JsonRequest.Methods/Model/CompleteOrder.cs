namespace JsonRequest.Methods
{
    public class CompleteOrder
    {
        //var completeOrder = new CompleteOrder
        //{
        //    preIncidentId = 7,
        //    diagnostic = "Diagnostico",
        //    treatment = "Tratamiento recomendado: ...",
        //};
        public int preIncidentId { get; set; }
        public string diagnostic { get; set; }
        public string treatment { get; set; }
    }
}
