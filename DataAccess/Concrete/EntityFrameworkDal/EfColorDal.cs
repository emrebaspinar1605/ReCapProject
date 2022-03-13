using Entity.Concrete;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFrameworkDal
{
    public class EfColorDal : EfEntityRepositoryBase<Color, RentCarContext>, IColorDal
    {
      
    }
}
