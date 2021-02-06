using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
            new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=15,ModelYear=2010,Description="Mercedes"},
            new Car {Id=2,BrandId=2,ColorId=2,DailyPrice=20,ModelYear=2011,Description="Bmw"},
            new Car {Id=3,BrandId=3,ColorId=3,DailyPrice=30,ModelYear=2012,Description="Audi"},
            new Car {Id=4,BrandId=4,ColorId=2,DailyPrice=40,ModelYear=2013,Description="Bmw"},
            new Car {Id=5,BrandId=5,ColorId=3,DailyPrice=50,ModelYear=2019,Description="Toyota"}

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            //İd olan aramalarda Single
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllById(int Id)
        {
            return _cars.Where(p => p.Id == Id).ToList();
        }

        public void Uptade(Car car)
        {
            Car carToUptade = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUptade.Id = car.Id;
            carToUptade.BrandId = car.BrandId;
            carToUptade.ColorId = car.ColorId;
            carToUptade.DailyPrice = car.DailyPrice;
            carToUptade.ModelYear = car.ModelYear;
            carToUptade.Description = car.Description;

            

        }
    }
}
