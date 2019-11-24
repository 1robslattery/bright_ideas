using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;

namespace BrightIdeas.Models
{
	public class Association
	{
		[Key]
		public int AssociationID {get; set;}

		public int UserID {get; set;}
		public int IdeaID {get; set;}

		public User User {get; set;}
		public Idea Idea {get; set;}
	}
}