using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        ColorManager(IColorDal colorDal)
        {
            _colorDal=colorDal; 
        }

        public IResult Add(Color color)
        {
          _colorDal.Add(color);
            return new Result(true,Messages.ColorAdded) ;
        }

        public IDataResult<Color> ColorGetById(int colorId)
        {
            return new SuccessDataResult<Color>( _colorDal.Get(c => c.ColorId==colorId));
            
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new Result(true, Messages.CarDeleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>> (_colorDal.GetAll());
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new Result(true, Messages.ColorUpdated);
        }
    }
}
