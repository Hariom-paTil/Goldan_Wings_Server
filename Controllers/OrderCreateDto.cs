namespace UserLogin.Controllers
{
    public class OrderCreateDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public List<OrderItemDto> Cakes { get; set; }

    }
}
