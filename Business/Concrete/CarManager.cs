using Business.Abstract;
using Business.Constant;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConserns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
              ValidationTool.Validate(new CarValidator(), car);
            _carDal.Add(car);
            return new Result(true, Messages.CarAdded);
        }

        public IDataResult<List<Car>> GetAll()
        {

            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }



        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == brandId));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == colorId));
        }

        public IResult Delete(Car car)
        {
            ValidationTool.Validate(new CarValidator(), car);
            _carDal.Delete(car);
            return new Result(true, Messages.CarDeleted);
        }

        public IResult Update(Car car)
        {
             ValidationTool.Validate(new CarValidator(), car);
            _carDal.Update(car);
            return new Result(true, Messages.CarUpdated);
        }
    }
}
