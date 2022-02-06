﻿using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class Color:ICar
    {
        public int ColorId { get; set; }
        public string ColorName { get; set; }
    }
}