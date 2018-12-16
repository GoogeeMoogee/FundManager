using FundManager.Web.Models;
using System.Web.Mvc;

namespace FundManager.Web.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginModel loginModel)
        {
            return View();
        }
    }
}