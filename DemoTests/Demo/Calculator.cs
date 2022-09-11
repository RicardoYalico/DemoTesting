using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DemoTests.Demo
{
    public class Calculator
    {


        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Prod(int a, int b)
        {
            return a*b;
        }

        public int SumProd(int a, int b)
        {

            return a + b + a*b;
        }



    }
}
