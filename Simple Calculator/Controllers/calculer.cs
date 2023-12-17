using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class calculer : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       public IActionResult resultat(int num1, string cal, int num2)
        {
            if (cal == "add")
            {
                ViewData["resultat"] = num1 + num2;
            }else if (cal == "minus")
            {
                ViewData["resultat"] = num1 - num2;
            }
            else if (cal == "mult")
            {
                ViewData["resultat"] = num1 * num2;
            }
            else if (cal == "div")
            {
                ViewData["resultat"] = num1 / num2;
            }
            return View();
        }
    }
}
