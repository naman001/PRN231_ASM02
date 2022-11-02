using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObject
{
    public class Author
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Author ID")]
        public int author_id { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name cannot be blank!")]
        [StringLength(50, ErrorMessage = "Last Name can only have 50 characters!")]
        public string last_name { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name cannot be blank!")]
        [StringLength(50, ErrorMessage = "First Name can only have 50 characters!")]
        public string first_name { get; set; }
        [Display(Name = "Phone")]
        [Required(ErrorMessage = "Phone cannot be blank!")]
        [RegularExpression(@"0\d{9,10}", ErrorMessage = "Phone number is not correct!")]
        public string phone { get; set; }
        [Display(Name = "Address")]
        [Required(ErrorMessage = "Address cannot be blank!")]
        [StringLength(50, ErrorMessage = "Address can only have 50 characters!")]
        public string address { get; set; }
        [Display(Name = "City")]
        [Required(ErrorMessage = "City cannot be blank!")]
        [StringLength(50, ErrorMessage = "City can have only 50 characters!")]
        public string city { get; set; }
        [Display(Name = "State")]
        [Required(ErrorMessage = "State cannot be blank!")]
        [StringLength(50, ErrorMessage = "State can have only 50 characters!")]
        public string state { get; set; }
        [Display(Name = "Zip")]
        public string zip { get; set; } = "abc123";
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Email Address cannot be blank!")]
        [DataType(DataType.EmailAddress)]
        public string email_address { get; set; }
        public virtual IEnumerable<BookAuthor> BookAuthors { get; set; }
    }

}
