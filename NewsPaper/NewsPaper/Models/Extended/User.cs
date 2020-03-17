using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NewsPaper.Models
{
    [MetadataType(typeof(UserMetadata))]
    public partial class User
    {
        public string ConfirmPassword { get; set; }
    }
    public class UserMetadata
    {
        [Display(Name ="First Name")]
        [Required(AllowEmptyStrings =false,ErrorMessage ="First Name Required")]
        public string FirstName { get; set; }

        [Display(Name ="LastName")]
        [Required(AllowEmptyStrings =false,ErrorMessage ="Last Name Required")]
        public string LastName { get; set; }

        [Display(Name ="Email ID")]
        [Required(AllowEmptyStrings =false,ErrorMessage ="Email ID Required")]
        [DataType(DataType.EmailAddress)]
        public string EmailID { get; set; }

        [Display(Name ="Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode =true,DataFormatString ="{0:MM-dd-yyyy")]
        public DateTime DateOfBirth { get; set; }

        [Required(AllowEmptyStrings =false,ErrorMessage ="Password is Required")]
        [DataType(DataType.Password)]
        [MinLength(6,ErrorMessage ="Minimum Six Characters Required")]
        public string Password { get; set; }

        [Display(Name ="Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Confirm Password and password does not match")]
        public string ConfirmPassword { get; set; }
    }
}