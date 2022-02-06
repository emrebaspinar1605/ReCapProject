using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal=carDal; 
        }

        public void Add(Car car)
        {
            if (car.Description.Length>2 && car.DailyPrice>0)
            {
                _carDal.Add(car);
                Console.WriteLine("Araba Eklenmiştir");
            }
            else
            {
                Console.WriteLine("Araba eklenememiştir.Lütfen Açıklamayı uzun tutun veya günlük kirasını 0'dan büyük tutun");
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

   

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(p => p.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
           return _carDal.GetAll(p=>p.ColorId==colorId);
        }
    }
}
