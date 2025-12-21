namespace UserLogin.DTO
{
    public class UserOrderInfoDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public List<CakeOrderListDto> Cakes { get; set; }

    }
}
