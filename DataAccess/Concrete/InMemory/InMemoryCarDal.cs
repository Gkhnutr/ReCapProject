using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 50, Description = "Megane", ModelYear = 2020},
                new Car {Id = 2, BrandId = 1, ColorId = 2, DailyPrice = 150, Description = "Clio", ModelYear = 2018},
                new Car {Id = 3, BrandId = 2, ColorId = 3, DailyPrice = 250, Description = "Egea", ModelYear = 2021},
                new Car {Id = 4, BrandId = 2, ColorId = 3, DailyPrice = 350, Description = "Egea Cross", ModelYear = 2023},
                new Car {Id = 5, BrandId = 3, ColorId = 1, DailyPrice = 450, Description = "Focus", ModelYear = 2019},
                new Car {Id = 6, BrandId = 4, ColorId = 2, DailyPrice = 550, Description = "Transporter", ModelYear = 2017}
            };
        }
        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(p => p.Id == id).ToList();
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            car.Description = car.Description;
            car.DailyPrice = car.DailyPrice;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
