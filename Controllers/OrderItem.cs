namespace UserLogin.Controllers
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public string CakeName { get; set; }
        public decimal Price { get; set; }

        public Order Order { get; set; }
    }
}
