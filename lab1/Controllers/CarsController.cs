using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using lab1.Models;
using lab1;

namespace lab1.Controllers
{
    public enum Source {
        table,
        list
    }

    public class CarInfo
    {
        public Car? car { get; set; }
        public Source? source { get; set; }
    }

    public class CarsController : Controller
    {
        public IActionResult GetAll()
        {
            var cars = Car.GetCars();
            return View(cars);
        }

        public IActionResult GetDetailsForCar(string carModel, Source? source)
        {
            var car = Car.GetCars().FirstOrDefault(c => c.Model == carModel);
            CarInfo info = new CarInfo();
            info.source = source;
            return View(info);
        }
    }
}
