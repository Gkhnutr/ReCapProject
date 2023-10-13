using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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
                new Car {CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 50, CarName = "Megane", ModelYear = 2020},
                new Car {CarId = 2, BrandId = 1, ColorId = 2, DailyPrice = 150, CarName = "Clio", ModelYear = 2018},
                new Car {CarId = 3, BrandId = 2, ColorId = 3, DailyPrice = 250, CarName = "Egea", ModelYear = 2021},
                new Car {CarId = 4, BrandId = 2, ColorId = 3, DailyPrice = 350, CarName = "Egea Cross", ModelYear = 2023},
                new Car {CarId = 5, BrandId = 3, ColorId = 1, DailyPrice = 450, CarName = "Focus", ModelYear = 2019},
                new Car {CarId = 6, BrandId = 4, ColorId = 2, DailyPrice = 550, CarName = "Transporter", ModelYear = 2017}
            };
        }
        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(p => p.CarId == id).ToList();
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            car.CarName = car.CarName;
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

        public List<CarDetailsDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
