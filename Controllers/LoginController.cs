using Microsoft.AspNetCore.Mvc;

namespace Billing_Management_System.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
