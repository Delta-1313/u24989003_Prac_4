using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace u2498903_Prac_4.Models
{
    public class StudyGroupModel
    {
        [Display(Name = "Student Number")]
        public string StudentNum { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Info On Each Member")]
        public string myLink { get; set; }

        [Display(Name = "Delete")]
        public string Delete { get; set; }
    }
}