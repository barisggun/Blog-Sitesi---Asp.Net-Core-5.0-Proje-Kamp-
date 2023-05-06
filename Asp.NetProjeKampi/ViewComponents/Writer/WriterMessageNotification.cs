using Microsoft.AspNetCore.Mvc;

namespace Asp.NetProjeKampi.ViewComponents.Writer
{
    public class WriterMessageNotification:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
 