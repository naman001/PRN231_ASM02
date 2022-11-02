using System.ComponentModel.DataAnnotations;

namespace BusinessObject
{
    public class BookAuthor
    {
        [Key]
        [Display(Name = "Author ID")]
        public int author_id { get; set; }
        [Key]
        [Display(Name = "Book ID")]
        public int book_id { get; set; }
        [Display(Name = "Author Order")]
        [Required(ErrorMessage = "Author Order cannot be blank!")]
        public int author_order { get; set; }
        [Display(Name ="Royality Percentage")]
        [Required(ErrorMessage = "Royality Percentage")]
        public decimal royality_percentage { get; set; }
        public virtual Author Author { get; set; }
    }
}
