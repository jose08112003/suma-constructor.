﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suma_constructor
{
    class clsuma
    {
        private int num1;
        private int num2;

        
        public clsuma(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        
        public int suma()
        {
            return (num1 + num2);
        }
    }
}
