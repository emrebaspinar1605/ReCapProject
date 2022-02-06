using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class Brand: ICar
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
