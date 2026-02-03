using System.ComponentModel.DataAnnotations;

namespace UserLogin.Models
{
    public class CustomCakeOrder
    {

        [Key]
        public int CakeID { get; set; }

        public int CakeIdentityID { get; set; }

        public string CakeName { get; set; }

        public string CakeSize { get; set; }

        public string FlowerDecoration { get; set; }

        public string Notes { get; set; }

        public  string ImageURL { get; set; }

        public int OrderID { get; set; }


    }
}
