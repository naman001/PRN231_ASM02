using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObject
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "User ID")]
        public int user_Id { get; set; }
        
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Email Address cannot be blank!")]
        [DataType(DataType.EmailAddress)]
        public string email_address { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password cannot be blank!")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Display(Name = "Source")]
        public string source { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name cannot be blank!")]
        [StringLength(50, ErrorMessage = "First Name can have only 50 characters!")]
        public string first_name { get; set; }

        [Display(Name = "Middle Name")]
        [Required(ErrorMessage = "Middle Name cannot be blank!")]
        [StringLength(50, ErrorMessage = "Middle Name can have only 50 characters!")]
        public string middle_name { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name cannot be blank!")]
        [StringLength(50, ErrorMessage = "Last Name can have only 50 characters!")]
        public string last_name { get; set; }

        [Display(Name = "Role ID")]
        [Required(ErrorMessage = "Role ID cannot be blank!")]
        public int role_id { get; set; }

        [Display(Name = "Publisher ID")]
        [Required(ErrorMessage = "Publisher ID cannot be blank!")]
        public int pub_id { get; set; }

        [Display(Name = "Hire Date")]
        [Required(ErrorMessage = "Hire Date cannot be blank!")]
        [DataType(DataType.Date)]
        public DateTime hire_date { get; set; }

        public virtual Role Role { get; set; }
        public virtual Publisher Publisher { get; set; }
    }
}
