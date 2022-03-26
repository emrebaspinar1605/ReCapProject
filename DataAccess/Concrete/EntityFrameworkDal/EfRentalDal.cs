using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.DTOs;
using Entity.Concrete;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFrameworkDal
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentCarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from re in context.Rentals
                             join ca in context.Cars
                             on re.CarId equals ca.CarId
                             join br in context.Brands
                             on ca.BrandId equals br.BrandId
                             join cu in context.Customers
                             on re.CustomerId equals cu.UserId
                             join us in context.Users
                             on cu.UserId equals us.Id
                             select new RentalDetailDto
                             {
                                 BrandName = br.BrandName,
                                 CarName = ca.Description,
                                 FirstName = us.FirstName,
                                 LastName = us.LastName,
                                 RentDate = re.RentDate,
                                 ReturnDate = re.ReturnDate,
                             };
                return result.ToList();
            }
        }
    }
}
