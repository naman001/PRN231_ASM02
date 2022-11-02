using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObject
{
    public class Publisher
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name ="Publisher ID")]
        public int pub_id { get; set; }

        [Display(Name = "Publisher Name")]
        [Required(ErrorMessage = "Publisher Name cannot be blank!")]
        [StringLength(50, ErrorMessage = "Publisher Name can only have 50 characters!")]
        public string publisher_name { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "City cannot be blank!")]
        [StringLength(50, ErrorMessage = "City can only have 50 characters!")]
        public string city { get; set; }

        [Display(Name = "State")]
        [Required(ErrorMessage = "State cannot be blank!")]
        [StringLength(50, ErrorMessage = "State can only have 50 characters!")]
        public string state { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country cannot be blank!")]
        [StringLength(50, ErrorMessage = "Country can only have 50 characters!")]
        public string country { get; set; }

        public virtual IEnumerable<User> Users { get; set; }
        public virtual IEnumerable<Book> Books { get; set; }
    }
}
