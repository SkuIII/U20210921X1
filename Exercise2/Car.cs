﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Km { get; set; }
        public int Price { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"{Make} {Model} {Year}";
        }
    }
}
