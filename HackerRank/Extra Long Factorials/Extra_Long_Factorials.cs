﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Extra_Long_Factorials
{
    public class Extra_Long_Factorials
    {
        // Complete the extraLongFactorials function below.
        static public BigInteger ExtraLongFactorials(int n)
        {
            BigInteger factorial;
            factorial = 1;
            if (n < 0)
                factorial = 0;
            else if (n == 0)
                factorial = 1;
            else if (n == 1)
                factorial = 1;
            else if (n > 1)
                for (int i = n; i > 1; i--)
                    factorial *= i;
            return factorial;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(ExtraLongFactorials(n));
        }
    }
}
