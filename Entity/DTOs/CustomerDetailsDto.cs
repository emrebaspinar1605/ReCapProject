using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.DTOs
{
    public class CustomerDetailsDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string CompanyName { get; set; }
        public string Password { get; set; }
    }
}
