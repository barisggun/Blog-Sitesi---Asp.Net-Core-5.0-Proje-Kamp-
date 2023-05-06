using Microsoft.AspNetCore.Mvc;

namespace Asp.NetProjeKampi.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error1(int code)
        {

            return View();
        }
    }
}
