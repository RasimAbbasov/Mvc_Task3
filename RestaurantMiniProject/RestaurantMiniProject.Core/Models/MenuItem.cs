using RestaurantMiniProject.Core.Enums;

namespace RestaurantMiniProject.Core.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }  
        public CategoryItem CategoryName { get; set; }
    }
}
