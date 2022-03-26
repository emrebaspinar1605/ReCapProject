using Business.Abstract;
using Business.BusinessAspects;
using Business.Constant;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.DTOs;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal=rentalDal;
        }
        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        }

        [SecuredOperation("admin,rental.add")]
        [CacheRemoveAspect("IRentalService.Get")]
        public IResult Add(Rental rental)
        {
            if (rental.RentDate==null)
            {
                return new ErrorResult(Messages.RentalInValid);
            }
            _rentalDal.Add(rental);
            return new Result(true,Messages.RentalAdded);
        }

        public IResult Delete(Rental rental)
        {

            if (rental.RentDate == null)
            {
                return new ErrorResult(Messages.RentalInValid);
            }
            _rentalDal.Delete(rental);
            return new Result(true,Messages.RentalDeleted);
        }
        [CacheAspect]
        public IDataResult<List<Rental>> GetAll()
        {
            return new DataResult<List<Rental>>(_rentalDal.GetAll(), true, Messages.RentalListed);
        }
        [CacheAspect]
        public IDataResult<List<Rental>> GetById(int rentalId)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(u=>u.Id==rentalId));
        }

        public IResult RentalCar(Rental rental)
        {
            if (rental.ReturnDate >DateTime.Now)
            {
                return new Result(true, Messages.CarRentable);
            }
            return new Result(false, Messages.CarUnRentable);
        }
        [ValidationAspect(typeof(RentalValidator))]
        [CacheRemoveAspect("IRentalService.Get")]
        public IResult Update(Rental rental)
        {

            if (rental.RentDate == null)
            {
                return new ErrorResult(Messages.RentalInValid);
            }
            _rentalDal.Update(rental);
            return new Result(true,Messages.RentalUpdated);
        }
    }
}
