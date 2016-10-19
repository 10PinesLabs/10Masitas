using System.Web.Mvc;

namespace _10Masitas.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult CreateOrder()
        {
            return View();
        }
    }
}