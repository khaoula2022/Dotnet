﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class Chemical:Product
    {
     
        public String LabName { get; set; }

        public Address address  { get; set; }
        public override void GetMyType()
        {
            base.GetMyType();
            Console.WriteLine("Chemical");
        }
    }
}
