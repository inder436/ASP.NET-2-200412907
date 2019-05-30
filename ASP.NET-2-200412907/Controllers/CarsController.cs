using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NET_2_200412907.Models;
namespace ASP.NET_2_200412907.Controllers
{
    public class CarsController : Controller
    {
        // GET: Cars
        public ActionResult Index()
        {
            return View(carList);
        }
        public ActionResult Details(int? Id)
        {
            if (Id == null || Id > carList.Count)
            {
                return Content("invalid car id");
            }
            var ind = Convert.ToInt32(Id) - 1;
            var car = carList[ind];

            return View(car);
        }
        List<Car> carList = new List<Car>()

        {

            new Car {Id = 1, Brand = "toyota", Model = "corolla", Type = "compact", Year = 2017 },
            new Car {Id = 2, Brand = "ford", Model = "F-150", Type = "Truck", Year = 2019},
            new Car {Id = 3, Brand = "dodge", Model = "caravan", Type = "minivan", Year = 2015 } };
    }
}