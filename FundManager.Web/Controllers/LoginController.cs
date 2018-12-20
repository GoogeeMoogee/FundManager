using FundManager.Web.Models;
using System.Web.Mvc;
using FundManager.Core;

namespace FundManager.Web.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            var conn = ConfigurationManager.Vault["DBConnectionString"];

            return new EmptyResult(); //View();
        }

        [HttpPost]
        public ActionResult Index(LoginModel loginModel)
        {
            return new EmptyResult(); // View();
        }
    }
}