using System.ComponentModel.DataAnnotations;

namespace UserLogin.DTO
{
    public class AddOnItemDto
    {
       

        public string Name { get; set; }

        public string Category { get; set; }


        public decimal Price { get; set; }


        public string ImageUrl { get; set; }


        public string Description { get; set; }

        public bool IsPopular { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
