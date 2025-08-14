using dev_utilities.Models;
using Microsoft.AspNetCore.Mvc;

namespace dev_utilities.Controllers
{
    public class TimeFormatterController : Controller
    {
        TimeFormatter model = new TimeFormatter();
        public IActionResult Index()
        {
            model.TimeFormat = "00:00:00";

            return View(model);
        }

        public IActionResult FormatFromMinutes(TimeFormatter model)
        {            
            var mins = model.Minutes > 0 ? model.Minutes : 0;           
            

            return View(model);
        }

        public IActionResult FormatFromSeconds(TimeFormatter model)
        {
            int secs = model.Seconds > 0 ? model.Seconds : 0;

            model.TimeFormat = "00:00:"+secs.ToString();

            return View(model);
        }
    }
}
