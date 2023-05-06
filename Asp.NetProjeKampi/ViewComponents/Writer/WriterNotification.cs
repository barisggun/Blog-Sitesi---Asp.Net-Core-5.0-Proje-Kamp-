using Microsoft.AspNetCore.Mvc;

namespace Asp.NetProjeKampi.ViewComponents.Writer
{
    public class WriterNotification:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
