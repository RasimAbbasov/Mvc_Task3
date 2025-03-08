using EternaApp.Models;

namespace EternaApp.ViewModels
{
    public class BlogVm
    {
        public List<Blog> Blogs { get; set; }
        public List<Category> BlogCategories { get; set; }
        public List<Blog> RecentBlogs { get; set; }

    }
}
