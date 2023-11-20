using Microsoft.AspNetCore.Mvc;

namespace eCommerce.API.Controllers
{
	public class UsuariosController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
