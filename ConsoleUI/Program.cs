using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new InMemoryCarDal());

foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.CarName);
}