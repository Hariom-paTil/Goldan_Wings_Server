using System.ComponentModel.DataAnnotations;

namespace UserLogin.Models
{
    public class CustomCakes
    {
        [Key]
        public int CustomCakePK { get; set; }

        public int CakeId { get; set; }

        public string CakeName { get; set; }

        public string? CakeCommonSize { get; set; }

        public string? Flower { get; set; }

        public string? ImageUrl { get; set; }
    }
}
