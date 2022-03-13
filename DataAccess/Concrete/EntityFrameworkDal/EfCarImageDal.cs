using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;


namespace DataAccess.Concrete.EntityFrameworkDal
{
    public class EfCarImageDal:EfEntityRepositoryBase<CarImage,RentCarContext>,ICarImageDal
    {
    }
}
