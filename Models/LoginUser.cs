using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace BrightIdeas.Models
    {
		// User is being referenced in mycontexts.cs "DbSet<User>"
        public class LoginUser
        {

			// Email
			[Required(ErrorMessage="Email is required!")]
			[MinLength(8, ErrorMessage="Enter a valid Email.")]
            public string LoginEmail {get; set;}

			// Password
			[DataType(DataType.Password)]
			[Required]
			[StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
			[Display(Name = "Password")]
			[RegularExpression("^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$", ErrorMessage = "Passwords must be at least 8 characters and contain at 3 of 4 of the following: upper case (A-Z), lower case (a-z), number (0-9) and special character (e.g. !@#$%^&*)")]
            public string LoginPassword {get; set;}

        }
    }