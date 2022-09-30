using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BTVN_dotNet.Models;

namespace BTVN_dotNet.Controllers;

public class HomeController : Controller
{
      private int delta;
      private double x1;
      private double x2;
      private float x3;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult PTBN(float a, float b)
    {
        if (Convert.ToBoolean(a))
        {
            if (a == 0)
            {
                ViewBag.Result = "Phuong trinh vo nghiem";
            }
            else
            {
                ViewBag.Result = $"Phuong trinh co nghiem là: x = {-b / a}";
            }
        }
        return View(PTBN);
    }

    public IActionResult PTB2(float a, float b, float c)
    {
        
         if (Convert.ToBoolean(a))
            {
                
                if (a == 0)
                {
                    if (b == 0)
                    {
                        ViewBag.Result = "Phuong trinh vo nghiem";
                    }
                    else
                    {
                        ViewBag.Result = $"Phuong trinh co 1 nghiem: x = {-c / b}";
                    }
                }
                else
                {
                    float delta, x1, x2, x3;
                    delta = b * b - 4 * a * c;

                }
                if (delta > 0)
                {
                    x1 = ((-b + Math.Sqrt(delta)) / (2 * a));
                    x2 = ((-b - Math.Sqrt(delta)) / (2 * a));
                    ViewBag.Result = "Phuong trinh co 2 nghiem la: x1 = {x1}, x2 = {x2}";
                }
                else if (a == 0)
                {
                    x3 = (-b / (2 * a));
                    ViewBag.Result = $"Phuong trinh co 1 nghiem kep: x1 = x2 = {x3}";
                }
                else
                {
                    ViewBag.Result = "Phuong trinh vo nghiem";
                }
        
    }
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
