namespace UserLogin.Controllers
{
    public class Order
    {

        public int OrderId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public List<OrderItem> OrderItems { get; set; }
    }
}
