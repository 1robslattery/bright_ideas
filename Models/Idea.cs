using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace BrightIdeas.Models
{
	public class Idea
	{
		[Key]
		public int IdeaID {get;set;}

		[Required(ErrorMessage = "Idea is Required")]
		[MinLength(4, ErrorMessage = "At least 5 characters are Required!")]
		public string IdeaPost {get;set;}

		public int UserID {get;set;}
		public int Likes {get;set;}
		public User Creator {get; set;}

		// The below line Associates Idea.cs file to User.cs file and all their objects
		public List<Association> Users {get;set;}

		public DateTime CreatedAt {get; set;} = DateTime.Now;
		public DateTime UpdatedAt {get; set;} = DateTime.Now;
	}
}