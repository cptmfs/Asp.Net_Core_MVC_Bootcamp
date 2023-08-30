﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string? ProductImage { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; }


    }
}
