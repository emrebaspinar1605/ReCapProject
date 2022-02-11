using Business.Concrete;
using DataAccess.Concrete.EntityFrameworkDal;
using Entity.Concrete;
using System;

namespace ConsolUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CarTest();
            //CarTest2();
            //RentalMenager rentalMenager = new RentalMenager(new EfRentalDal());
            //foreach (var rent in rentalMenager.GetAll())
            //{
            //    Console.WriteLine(rent.);
            //}
            
            
        }

        private static void CarTest2()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAll();
            if (result.Success == true)
            {
                foreach (var car in carManager.GetAll().Data)
                {

                }

            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAll();
            if (result.Success == false)
            {
                foreach (var car in carManager.GetAll().Data)
                {
                    Console.WriteLine(car.Description);
                }


            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }


    }
}
