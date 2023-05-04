namespace PustokTask.Models
{
    public class Item
    {
        public int Id { get; set; }

        public int BookId { get; set; }

        public int Count { get; set; }

        public Book Book { get; set; }
    }
}
