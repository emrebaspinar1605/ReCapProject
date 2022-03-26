using Business.Abstract;
using Business.BusinessAspects;
using Business.Constant;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        [SecuredOperation("admin,customer.add")]
        [ValidationAspect(typeof(CustomerValidator))]
        [CacheRemoveAspect("ICustomerService.Get")]
        public IResult Add(Customer customer)
        {
            if (customer.CompanyName.Length < 2)
            {
                return new ErrorResult(Messages.CustomerNameInValid);
            }
            _customerDal.Add(customer);
            return new Result(true,Messages.CustomerAdded);
        }

        public IResult Delete(Customer customer)
        {
            if (customer.CompanyName.Length < 2)
            {
                return new ErrorResult(Messages.CustomerNameInValid);
            }
            _customerDal.Delete(customer);
            return new Result(true, Messages.CustomerDeleted);
        }
        [CacheAspect]
        public IDataResult<List<Customer>> GetAll()
        {
            return new DataResult<List<Customer>>(_customerDal.GetAll(),true,Messages.CustomerListed);
        }
        [CacheAspect]
        public IDataResult<List<Customer>> GetById(int customerId)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(c=>c.UserId==customerId));
        }
        [ValidationAspect(typeof(CustomerValidator))]
        [CacheRemoveAspect("ICustomerService.Get")]
        public IResult Update(Customer customer)
        {
            if (customer.CompanyName.Length<2)
            {
                return new ErrorResult(Messages.CustomerNameInValid);
            }
            _customerDal.Update(customer);
            return new Result(true, Messages.CustomerUpdated);
        }
    }
}
