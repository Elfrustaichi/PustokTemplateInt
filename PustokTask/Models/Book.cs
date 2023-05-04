namespace PustokTask.Models
{
    public class Book
    {
        public int AuthorId { get; set; }

        public int GenreId { get; set; }
        public int Id { get; set; }

        public double Price { get; set; }

        public int Discount { get; set; }

        public string Count { get; set; }

        public Author Author { get; set; }

        public Genre Genre { get; set; }
    }
}
