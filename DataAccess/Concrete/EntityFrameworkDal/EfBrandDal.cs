﻿using DataAccess.Abstract;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFrameworkDal
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            using (RentCarContext context = new RentCarContext())
            {
                var addedBrand = context.Entry(entity);
                addedBrand.State = EntityState.Added;
                context.SaveChanges();

            }
        }

        public void Delete(Brand entity)
        {
            using (RentCarContext context = new RentCarContext())
            {
                var deletedBrand = context.Entry(entity);
                deletedBrand.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            using (RentCarContext context= new RentCarContext())
            {
                return context.Set<Brand>().SingleOrDefault();
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (RentCarContext context=new RentCarContext())
            {
                return filter ==null ? context.Set<Brand>().ToList():
                 context.Set<Brand>().Where(filter).ToList();
            }
        }

        public void Update(Brand entity)
        {
            using (RentCarContext context = new RentCarContext())
            {
                var updatedBrand = context.Entry(entity);
                updatedBrand.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
