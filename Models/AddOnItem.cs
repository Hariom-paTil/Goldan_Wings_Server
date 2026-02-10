using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserLogin.Models
{
    public class AddOnItem
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

     
        public decimal Price { get; set; }

   
        public string ImageUrl { get; set; }

       
        public string Description { get; set; }

        public bool IsPopular { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
