using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console
{
    class Program
    {
        static void Main(string[] args) 
        {
            CarManager carManager = new CarManager(new InMemoryCar());
            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.Id + " " + car.BrandId + " " + car.ModelYear + " " + car.ColorId + " " + car.Description + " " + car.DailyPrice);
            }
        }
    }
}
