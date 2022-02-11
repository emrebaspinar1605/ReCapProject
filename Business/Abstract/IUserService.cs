﻿using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<List<User>> GetById(int userId);
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
    }
}
