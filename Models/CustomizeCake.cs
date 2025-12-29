using System.ComponentModel.DataAnnotations;

namespace UserLogin.Models
{
    public class CustomizeCake
    {
        [Key]
        public int CakeId { get; set; }

        public string CakeName { get; set; }

        public decimal BasePrice { get; set; }

        public string ImagePath { get; set; }
    }
}
