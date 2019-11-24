using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace BrightIdeas.Models
{
	public class User
	{
		// auto-implemented properties need to match the columns in your table
		// the [Key] attribute is used to mark the Model property being used for your table's Primary Key
		[Key]
		public int UserID {get; set;}

		// Name
		[Required(ErrorMessage = "Name Required")]
		[StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
		[RegularExpression("^[A-Za-z ]+$", ErrorMessage = "Name must be at least 8 characters and contains: upper case (A-Z), lower case (a-z), and spaces!!!!")]
		public string Name {get; set;}

		// Alias
		[Required(ErrorMessage = "Alias Required")]
		[StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
		[RegularExpression("^[0-9A-Za-z]+$", ErrorMessage = "Alias must be at least 8 characters and contains: upper case (A-Z), lower case (a-z), and numbers only, NO SPACES STUPID!!!!")]
		public string Alias {get; set;}

		// Email		
		[Required(ErrorMessage = "Email Required")]
		[EmailAddress]
		public string Email {get; set;}

		// Password
		[Required]
		[DataType(DataType.Password)]
		[StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
		[Display(Name = "Password")]
		[RegularExpression("^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$", ErrorMessage = "Passwords must be at least 8 characters and contain at 3 of 4 of the following: upper case (A-Z), lower case (a-z), number (0-9) and special character (e.g. !@#$%^&*)")]
		public string Password {get; set;}

		[NotMapped]
		[DataType(DataType.Password)]
		[Display(Name = "Confirm password")]
		[Compare("Password", ErrorMessage = "The passwords do not match.")]
		public string ConfirmPassword {get; set;}

		public int Posts {get;set;}

		// The below line Associates User.cs file to Idea.cs file and all their objects
		public List<Association> Ideas {get;set;}
		
		public DateTime CreatedAt {get; set;} = DateTime.Now;
		public DateTime UpdatedAt {get; set;} = DateTime.Now;
	}
}