using Microsoft.EntityFrameworkCore;
using PustokTask.Models;

namespace Pustok.DAL
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public List<Author> Authors { get; set; }

        public List<Book> Books { get; set; }
        public List<BookTag> BookTags { get; set; }
        public List<Genre> Genres { get; set; }
        public List<Image> Images { get; set; }
        public List<Item> Items { get; set; }
        public List<Order> Orders { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public List<Tag> Tags { get; set; }







    }
}
