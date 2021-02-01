using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCar : ICarDal
    {
        List<Car> _car;

        public InMemoryCar()
        {
            _car = new List<Car> {
                new Car{Id = 1, BrandId = "Mercedes", ColorId = "Siyah", DailyPrice = 580000, ModelYear= 2021, Description = "Kalite"},
                new Car{Id = 2, BrandId = "Audi", ColorId = "Beyaz", DailyPrice = 460000, ModelYear= 2021, Description = "Duruş"},
                new Car{Id = 3, BrandId = "Bmw", ColorId = "Mavi", DailyPrice = 390000, ModelYear= 2021, Description = "Ayrıcalık"},
                new Car{Id = 4, BrandId = "Volvo", ColorId = "Füme", DailyPrice = 360000, ModelYear= 2021, Description = "Sağlamlık"},
                new Car{Id = 5, BrandId = "Range Rover", ColorId = "gri", DailyPrice = 670000, ModelYear= 2021, Description = "Profil"},
            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int id)
        {
            var getCarById = _car.Where(c => c.Id == id).ToList();
            return getCarById;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
