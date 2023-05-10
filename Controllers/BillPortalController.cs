using Azure.Core;
using Billing_Management_System.Data;
using Billing_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Net.WebSockets;
using System.Text;
using System.Text.Encodings.Web;

namespace Billing_Management_System.Controllers
{
	public class BillPortalController : Controller
	{
		private readonly AppDbContext _context;
        public BillPortalController(AppDbContext context)
        {
			_context = context;
        }
        public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Login(IFormCollection frm)
		{
			string userID = frm["email"];
			string password = frm["Pwd"];

			UserModel user = _context.Users.Find(userID);
			if (user != null && user.Password == password)
			{
				return RedirectToAction("User");
			}
			else
			{
				ViewData["ErrorFlag"] = "Invalid Email or Password!";
				return View("Index");
			}
		}

		[HttpGet]
		public IActionResult Bill()
		{
			return View();
		}

		[HttpGet]
		public IActionResult Bill_Listing()
		{
			return View();
		}

		[HttpGet]
		public IActionResult User()
		{
			return View();
		}

		[HttpGet]
		public IActionResult Vendor_Bill()
		{
			return View();
		}

		[HttpGet]
		public IActionResult Vendor_Master()
		{
			return View();
		}

		
		[HttpPost]
		public IActionResult RegisterUser(UserModel user)
		{
			UserModel emailExists = _context.Users.Find(user.Email);
			if(emailExists != null)
			{
				
			}
			if (ModelState.IsValid)
			{
				_context.Users.Add(user);
				_context.SaveChanges();
				return View("User");
			}
			return Redirect("User");
		}
	}
}
