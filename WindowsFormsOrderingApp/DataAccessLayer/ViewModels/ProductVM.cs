﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.ViewModels
{
    public class ProductVM
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string JMJ { get; set; }
        public decimal Cijena { get; set; }
        public string Grupa { get; set; }
    }
}
