using Microsoft.AspNetCore.Mvc;
using Models.Breakfast;

namespace  Client.Controllers;
public class BreackfastController : Controller
{
    public IActionResult Index()
        {
            var breakfasts = new List<Breakfast>{
                new Breakfast{Name = "Pinto", CreateDatetime = DateTime.Now, Description = "Pinto con huevo y salchicon", ImageUrl =$"~/img/option{1}.png"},
                new Breakfast{Name = "Pinto", CreateDatetime = DateTime.Now, Description = "Pinto con huevo y salchicon", ImageUrl =$"~/img/option{2}.png"},
                new Breakfast{Name = "Pinto", CreateDatetime = DateTime.Now, Description = "Pinto con huevo y salchicon", ImageUrl =$"~/img/option{3}.png"},
                new Breakfast{Name = "Pinto", CreateDatetime = DateTime.Now, Description = "Pinto con huevo y salchicon", ImageUrl =$"~/img/option{4}.png"},
                new Breakfast{Name = "Pinto", CreateDatetime = DateTime.Now, Description = "Pinto con huevo y salchicon", ImageUrl =$"~/img/option{5}.png"},
                new Breakfast{Name = "Pinto", CreateDatetime = DateTime.Now, Description = "Pinto con huevo y salchicon", ImageUrl =$"~/img/option{6}.png"},
            };

           return View(breakfasts);
        }
}
    