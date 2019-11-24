using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BrightIdeas.Models;
using System.Linq;
using System;

namespace BrightIdeas.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

		//  Create a Register model/constructor
		[HttpPost("register")]
		public IActionResult Register(User u)
		{
			if(ModelState.IsValid)
			{
				// u is the user in the database (u.Email) and we're checking to see if the email already exists
				// if the email does not equal to null (meaning it's not unique), display the error message.
				User userMatchingEmail = dbContext.Users.FirstOrDefault(user => user.Email == u.Email);
				if(userMatchingEmail != null)
				{
					ModelState.AddModelError("Email", "Email already in use!");
					return View("Index");
				}
				else
				{
					// The below two lines ensures we're not passing plain text for the password.
					// NOTE: dbContext is coming from the last model/constructor on this page.
					// If you ever get an error, say, SetInt32, click on SetInt32 and then click on the yellow lightbulb.
					PasswordHasher<User> Hasher = new PasswordHasher<User>();
					u.Password = Hasher.HashPassword(u, u.Password);
					dbContext.Users.Add(u);
					dbContext.SaveChanges();
					HttpContext.Session.SetInt32("LoggedInUser", u.UserID);
					return Redirect("bright_idea");
				}
			}
				return View("Index");
		}
		
		//  Create a Login model/constructor. LoginUser is referencing LoginUser.cs.  U is a variable we're passing.
		[HttpPost("login")]
		public IActionResult Login(LoginUser u)
		{
			if(ModelState.IsValid)
			{
				// u is the user in the database (u.LoginEmail) and we're checking to see if the email already exists
				// if the email does not equal to null (meaning it's not unique), display the error message.
				// 
				User userMatchingEmail = dbContext.Users.FirstOrDefault(user => user.Email == u.LoginEmail);
				if(userMatchingEmail == null)
				{
					ModelState.AddModelError("LoginEmail", "Unknown Email!");
					return View("Index");
				}
				else
				{
					// The below two lines ensures we're not passing plain text for the password.
					PasswordHasher<LoginUser> Hasher = new PasswordHasher<LoginUser>();
					var result = Hasher.VerifyHashedPassword(u, userMatchingEmail.Password, u.LoginPassword);
					if(result == 0)
					{
						ModelState.AddModelError("LoginPassword", "Incorrect Password!");
						return View("Index");
					}
					else
					{
						HttpContext.Session.SetInt32("LoggedInUser", userMatchingEmail.UserID);
						return Redirect("bright_idea");
					}
				}
			}
			return View("Index");
		}

		[HttpGet("bright_idea")]
		public IActionResult bright_idea()
		{
			int? LoggedInUser = HttpContext.Session.GetInt32("LoggedInUser");
			if(LoggedInUser == null)
			{
				return Redirect("/");
			}
			else
			{
				List<Idea> allIdeas = dbContext.Ideas
											.Include(i => i.Creator)
											.Include(i => i.Users)
											.ThenInclude(a => a.User)
											.OrderByDescending(i => i.Likes)
                                            .ToList();
				ViewBag.allIdeas = allIdeas;

				User LIU = dbContext.Users.FirstOrDefault(user => user.UserID == (int)LoggedInUser);
				ViewBag.LoggedInUser = LIU;

				return View();    
			}
		}

		[HttpPost("IdeaProcess")]
		public IActionResult IdeaProcess(Idea NewIdea)
		{
			int? LoggedInUser = HttpContext.Session.GetInt32("LoggedInUser");
			User Temp = dbContext.Users.FirstOrDefault(u => u.UserID == (int)LoggedInUser);
			ViewBag.LoggedInUser = Temp;
	
			if(ModelState.IsValid)
			{
				User SelectedUser = dbContext.Users.FirstOrDefault(i => i.UserID == Temp.UserID);
				SelectedUser.Posts++;

				dbContext.Add(NewIdea);
				dbContext.SaveChanges();
				return RedirectToAction("bright_idea");
			}
			else
			{
			 	return View("bright_idea");   
			}
		}

		[HttpGet("Likes/{IdeaID}")]
		public IActionResult Likes(int IdeaID)
		{
			int? LoggedInUser = HttpContext.Session.GetInt32("LoggedInUser");
			
			Association newAssociation = new Association();
			newAssociation.UserID = (int)LoggedInUser;
			newAssociation.IdeaID = IdeaID;

			Idea SelectedIdea = dbContext.Ideas.FirstOrDefault(i => i.IdeaID == IdeaID);
			SelectedIdea.Likes++;

			dbContext.Add(newAssociation);
			dbContext.SaveChanges();
				return Redirect("/bright_idea");
		}

		[HttpGet("unLike/{IdeaID}")]
		public IActionResult unLike(int IdeaID)
		{
			int? LoggedInUser = HttpContext.Session.GetInt32("LoggedInUser");
			Idea SelectedIdea = dbContext.Ideas.FirstOrDefault(i => i.IdeaID==IdeaID);
			SelectedIdea.Likes--;

			Association SelectedAssociation = dbContext.Associations.FirstOrDefault(u => u.UserID == (int)LoggedInUser && u.IdeaID == IdeaID);
			dbContext.Associations.Remove(SelectedAssociation);
			dbContext.SaveChanges();
			return Redirect("/bright_idea");
		}

		[HttpGet("bright_ideas/{IdeaID}")]
		public IActionResult bright_ideas(int IdeaID)
		{
			int? LoggedInUser = HttpContext.Session.GetInt32("LoggedInUser");
			if (LoggedInUser == null)
			{
				return Redirect("/");
			}
			else
			{
				Idea SelectedIdea = dbContext.Ideas
											.Include(i => i.Creator)
											.Include(i => i.Users)
											.ThenInclude(a => a.User)
											.FirstOrDefault(i => i.IdeaID == IdeaID);
				ViewBag.SelectedIdea = SelectedIdea;
				ViewBag.LoggedInUser = (int)LoggedInUser;
				
				User LIU = dbContext.Users.FirstOrDefault(user => user.UserID == (int)LoggedInUser);
				ViewBag.LoggedInUser = LIU;

				return View("bright_ideas");
			}
		}

		[HttpGet("users/{UserID}")]
		public IActionResult users(int UserID)
		{
			int? LoggedInUser = HttpContext.Session.GetInt32("LoggedInUser");
			if (LoggedInUser == null)
			{
				return Redirect("/");
			}
			else
			{
				User SelectedUser = dbContext.Users
											.Include(i => i.Ideas)
											.ThenInclude(a => a.Idea)
											.FirstOrDefault(i => i.UserID == UserID);
				ViewBag.SelectedUser = SelectedUser;
				ViewBag.LoggedInUser = (int)LoggedInUser;
				
				User LIU = dbContext.Users.FirstOrDefault(user => user.UserID == (int)LoggedInUser);
				ViewBag.LoggedInUser = LIU;

				return View("users");
			}
		}

		[HttpGet("Delete/{IdeaID}")]
		public IActionResult Delete(int IdeaID)
		{
			int? LoggedInUser = HttpContext.Session.GetInt32("LoggedInUser");
			User Temp = dbContext.Users.FirstOrDefault(u => u.UserID == (int)LoggedInUser);

			Idea SelectedIdea = dbContext.Ideas.Include(u => u.Users).FirstOrDefault(i => i. IdeaID == IdeaID);
			User SelectedUser = dbContext.Users.FirstOrDefault(i => i.UserID == Temp.UserID);
			SelectedUser.Posts--;
			dbContext.Ideas.Remove(SelectedIdea);
			dbContext.SaveChanges();
			return Redirect("/bright_idea");
		}














		[HttpGet("Logout")]
		public IActionResult Logout()
		{
			HttpContext.Session.Clear();
			return Redirect("/");
		}

		private MyContext dbContext;
		public HomeController(MyContext context)
		{
			dbContext = context;
		}
    }
}
