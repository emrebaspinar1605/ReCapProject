using Business.Concrete;
using DataAccess.Concrete.EntityFrameworkDal;
using System;

namespace ConsolUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId+"/"+car.BrandId+"/"+car.ColorId+"/"+car.ModelYear+"/"+car.DailyPrice+"/"+car.Description);
            }
        }
    }
}
