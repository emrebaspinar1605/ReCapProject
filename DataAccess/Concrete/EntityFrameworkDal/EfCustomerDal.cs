using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Core.DataAccess.EntityFramework;
using Entity.DTOs;


namespace DataAccess.Concrete.EntityFrameworkDal
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, RentCarContext>, ICustomerDal

    {
        public List<CustomerDetailsDto> GetCustomerDetails()
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from c in context.Customers
                             join u in context.Users on c.UserId equals u.Id
                             select new CustomerDetailsDto
                             {
                                 Id = u.Id,
                                 UserName = u.FirstName,
                                 CompanyName = c.CompanyName,
                                 Password = u.Password

                             };
                return result.ToList();

            }
           
        }
    }
}
