namespace UserLogin.DTO
{
    public class CustomCakeDto
    {
        public int CustomCakePK { get; set; }

        public int CakeId { get; set; }

        public string CakeName { get; set; }

        public string? CakeCommonSize { get; set; }

        public string? Flower { get; set; } // ? this insure that came data is null possible. 

        public string? ImageUrl { get; set; } // can be null 

    }
}
