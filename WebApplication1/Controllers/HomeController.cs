using System.Web.Mvc;
using WebApplication1.Models;
using CalculatorLib;
namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Calculator()
        {
           

            return View();
        }

        [HttpPost]
        public ActionResult Calculator(Calc model, string command)
        {
          Calculator clac = new Calculator();
            if (command == "add")
            {
                
                model.Result = clac.Add( model.A ,model.B);
            }
            if (command == "sub")
            {
                model.Result = clac.Subtract(model.A, model.B);
            }
            if (command == "mul")
            {
                model.Result = clac.Multiply(model.A, model.B);
            }
            if (command == "div")
            {
                model.Result = clac.Division(model.A, model.B);
            }
            return View(model);
        }
    }
}