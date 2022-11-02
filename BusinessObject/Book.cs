using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObject
{
    public class Book
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Book ID")]
        public int book_id { get; set; }
        [Display(Name = "Title")]
        [Required(ErrorMessage = "Title cannot be blank!")]
        [StringLength(50, ErrorMessage = "Title cannot have more than 50 characters!")]
        public string title { get; set; }
        [Display(Name = "Type")]
        [Required(ErrorMessage = "Type cannot be blank!")]
        public string type { get; set; }
        [Display(Name = "Publisher ID")]
        [Required(ErrorMessage = "Publisher ID cannot be blank!")]
        public int pub_id { get; set; }
        [Display(Name = "Price")]
        [Required(ErrorMessage = "Price cannot be blank!")]
        public decimal price { get; set; }
        [Display(Name = "Advance")]
        [Required(ErrorMessage = "Advance cannot be blank!")]
        public string advance { get; set; }
        [Display(Name = "Royalty")]
        [Required(ErrorMessage = "Royalty cannot be blank!")]
        public decimal royalty { get; set; }
        [Display(Name = "ytd sales")]
        [Required(ErrorMessage = "ytd sales cannot be blank!")]
        public int ytd_sales { get; set; }
        [Display(Name = "Notes")]
        public string notes { get; set; }
        [Display(Name = "Published Date")]
        public DateTime published_date { get; set; } = DateTime.Today;
        public virtual Publisher Publisher { get; set; }
        public virtual IEnumerable<BookAuthor> BookAuthors { get; set; }
    }
}
