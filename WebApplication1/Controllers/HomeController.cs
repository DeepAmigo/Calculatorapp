using System.Web.Mvc;
using WebApplication1.Models;
using CalculatorLib;
using System.Net.Http;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        public async Task<ActionResult> Calculator(Calc model, string command)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44358/");

            Calculator clac = new Calculator();
            if (command == "add")
            {
                    var response = await client.GetAsync(string.Format("Calculator/Add?value1={0}&value2={1}", model.A, model.B));


                    //To store result of web api response.   
                    if (response.IsSuccessStatusCode)
                    {
                        var result = response.Content.ReadAsStringAsync().Result;
                        model.Result = result;
                    }
                    
            }
            if (command == "sub")
            {
                    var response = await client.GetAsync(string.Format("Calculator/Sub?value1={0}&value2e={1}", model.A, model.B));


                    //To store result of web api response.   
                    if (response.IsSuccessStatusCode)
                    {
                        var result = response.Content.ReadAsStringAsync().Result;
                        model.Result = result;
                    }
                }
            if (command == "mul")
            {
                    var response = await client.GetAsync(string.Format("Calculator/Mul?value1={0}&value2e={1}", model.A, model.B));


                    //To store result of web api response.   
                    if (response.IsSuccessStatusCode)
                    {
                        var result = response.Content.ReadAsStringAsync().Result;
                        model.Result = result;
                    }
                }
            if (command == "div")
            {
                    var response = await client.GetAsync(string.Format("Calculator/Div?value1={0}&value2e={1}", model.A, model.B));


                    //To store result of web api response.   
                    if (response.IsSuccessStatusCode)
                    {
                        var result = response.Content.ReadAsStringAsync().Result;
                        model.Result = result;
                    }
                }
        }
            return View(model);
        }
    }
}