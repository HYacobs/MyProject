﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
     public class Class10
 {
     public string Name { get; }
     public string Salary { get; }
     public Class11 Class11 { get; }
     
     
     public Class10(string name, string salary, Class11 class11)
     {
         this.Name = name;
         this.Salary = salary;
         this.Class11 = class11;
     }
 }
}