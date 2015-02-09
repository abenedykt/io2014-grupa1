﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz
{
    class FizzBuzz
    {
        static void Main()
        {
            Console.WriteLine(
            String.Join(
              Environment.NewLine,
              Enumerable.Range(1, 100)
                .Select(n => n % 15 == 0 ? "FizzBuzz"
                           : n % 3 == 0 ? "Fizz"
                           : n % 5 == 0 ? "Buzz"
                           : n.ToString())
            ));

        }









    }



}