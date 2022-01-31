using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsolUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                if (car.ModelYear>2015 && car.DailyPrice>150 )
                {
                    Console.WriteLine(car.BrandId+"/"+car.Description);
                }
            }
        }
    }
}
