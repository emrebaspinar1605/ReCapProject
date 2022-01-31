using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car>()
            {
            new Car{CarId=1,BrandId=1,ColorId=2,DailyPrice=350,ModelYear=2015,Description="Nissan Nismo" },
            new Car{CarId=2,BrandId=1,ColorId=1,DailyPrice=250,ModelYear=2018,Description="Nissan Qasqhai" },
            new Car{CarId=3,BrandId=2,ColorId=3,DailyPrice=100,ModelYear=2012,Description="Bmw 320i" },
            new Car{CarId=4,BrandId=3,ColorId=4,DailyPrice=120,ModelYear=2014,Description="Audi A6" },
            new Car{CarId=5,BrandId=4,ColorId=5,DailyPrice=160,ModelYear=2020,Description="Mercedes Cla 200" },
            };
        }
        public void Add(Car car)
        {
             _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.CarId == car.CarId);
            _car.Remove(carToDelete);   
        }

        public List<Car> GetAll( )
        {
            return _car;
        }

        public List<Car> GetById(Car car )
        {
            return _car.Where(c=>c.CarId==car.CarId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.CarId == car.CarId);
            car.ColorId=carToUpdate.ColorId; 
            car.ModelYear=carToUpdate.ModelYear;    
            car.BrandId=carToUpdate.BrandId;    
            car.DailyPrice=carToUpdate.DailyPrice;  
            car.Description=carToUpdate.Description;   
            _car.Add(carToUpdate);
        }
    }
}
