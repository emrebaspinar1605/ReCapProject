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
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal=userDal;
        }
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
            return new DataResult<List<User>>(_userDal.GetAll(),true,Messages.UserListed);
        }

        public IDataResult<List<User>> GetById(int userId)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(u=>u.Id==userId));
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
