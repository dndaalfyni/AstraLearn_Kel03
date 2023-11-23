using Microsoft.AspNetCore.Mvc;

namespace AstraLearn_Kel03.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Login(string username, string password, bool remember)
		{
			// Logika autentikasi dapat ditambahkan di sini
			// Misalnya, periksa username dan password dari database

			if (username == "example" && password == "password")
			{
				// Autentikasi berhasil, redirect ke halaman lain
				return RedirectToAction("Index", "Home");
			}
			else
			{
				// Autentikasi gagal, kembalikan view dengan pesan kesalahan
				ModelState.AddModelError(string.Empty, "Invalid username or password");
				return View("Index");
			}
		}
	}
}
