using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Domain
{
    public class Customer
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public bool isActive { get; set; }
    }
}
