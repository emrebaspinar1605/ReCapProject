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
    public class RentalMenager : IRentAlService
    {
        IRentalDal _rentalDal;

        public RentalMenager(IRentalDal rentalDal)
        {
            _rentalDal=rentalDal;
        }
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

        public IDataResult<List<Rental>> GetAll()
        {
            return new DataResult<List<Rental>>(_rentalDal.GetAll(), true, Messages.RentalListed);
        }

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
