namespace RawSqlApi.Models
{
    public class CreateOrderRequest
    {
        public int CustomerId { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
    }
}