using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserLogin.Models
{
    [Table("OrderItems")]
    public class CakeOrderList
    {
        [Key]
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public string CakeName { get; set; }
        public decimal Price { get; set; }


        [ForeignKey("OrderId")]
        public UserOrderInfo Order { get; set; }
    }
}
