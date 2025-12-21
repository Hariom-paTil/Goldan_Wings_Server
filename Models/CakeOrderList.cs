using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserLogin.Models
{
    public class CakeOrderList
    {
        [Key]
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public string CakeName { get; set; }
        public decimal Price { get; set; }


       
        public UserOrderInfo Order { get; set; }
    }
}
