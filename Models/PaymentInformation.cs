namespace EcommerceDay1.Models
{
    public class PaymentInformation
    {
        public int PaymentID { get; set; }
        public int Customer_ID { get; set; }
        public string PaymentMethod { get; set; }
        public string CardNumber { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string CVV { get; set; }

        public Customer Customer { get; set; }
    }
}
