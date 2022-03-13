using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Core.Entities.Concrete;
using System.Collections.Generic;
using Core.Aspects.Autofac.Validation;
using Business.ValidationRules.FluentValidation;
using System;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal=userDal;
        }
        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(User user)
        {

            if (user.FirstName.Length<2)
            {
                return new ErrorResult(Messages.UserNameInValid);
            }
            _userDal.Add(user);
            return new Result(true,Messages.UserAdded);
        }

        public IResult Delete(User user)
        {

            if (user.FirstName.Length < 2)
            {
                return new ErrorResult(Messages.UserNameInValid);
            }
            _userDal.Delete(user);
            return new Result(true, Messages.UserDeleted);
        }

        

        public IDataResult<List<User>> GetAll()
        {
            List<User> users;
            try
            {
                users = _userDal.GetAll();
            }
            catch (Exception exception)
            {
                return new ErrorDataResult<List<User>>(exception.Message);
            }
            return new SuccessDataResult<List<User>>(users);
        }

        public IDataResult<List<User>> GetById(int userId)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(u=>u.Id==userId));
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }

        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            return new SuccessDataResult<List<OperationClaim>>(_userDal.GetClaims(user));
        }

        public IResult Update(User user)
        {

            if (user.FirstName==null)
            {
                return new ErrorResult(Messages.UserNameInValid);
            }
            _userDal.Update(user);
            return new Result(true, Messages.UserUpdated);
        }
    }
}
