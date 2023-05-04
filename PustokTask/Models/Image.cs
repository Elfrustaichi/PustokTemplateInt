namespace PustokTask.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool ImgPosition { get; set; }   
        public int BookId { get; set; }

        public Book Book { get; set; }
    }
}
