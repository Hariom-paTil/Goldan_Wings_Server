using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserLogin.Models
{
    [Table("Orders")]
    public class UserOrderInfo
    {
        [Key]
        public int OrderId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }


        public List<CakeOrderList> OrderItems { get; set; } = new List<CakeOrderList>();
    }
}
