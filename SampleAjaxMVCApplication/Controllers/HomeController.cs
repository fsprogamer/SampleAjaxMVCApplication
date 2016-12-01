using System.Web.Mvc;
using SampleAjaxMVCApplication.Models;

namespace SampleAjaxMVCApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Feedback()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Feedback(FeedbackModel model)
        {
            if (ModelState.IsValid)
            {
                //-------------------------------
                // реальная отправка сообщения
                // не показана в примере
                //-------------------------------
                if (Request.IsAjaxRequest())
                {
                    return PartialView("FeedbackSent");
                }

                return View("FeedbackSent");
            }
            return View();
        }
    }

}