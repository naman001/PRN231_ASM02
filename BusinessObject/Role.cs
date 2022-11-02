using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObject
{
    public class Role
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Role ID")]
        public int role_id { get; set; }
        
        [Required(ErrorMessage = "Role Description cannot be null!")]
        [StringLength(50, ErrorMessage = "Role Description cannot have more than 50 characters!")]
        [Display(Name = "Role Description")]
        public string role_desc { get; set; }
        
        public virtual IEnumerable<User> users { get; set; }
    }
}
