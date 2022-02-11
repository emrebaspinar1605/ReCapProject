using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFramework;
using Core.Entities;
using System.Linq.Expressions;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFrameworkDal
{
    public class EfColorDal : EfEntityRepositoryBase<Color, RentCarContext>, IColorDal
    {
      
    }
}
