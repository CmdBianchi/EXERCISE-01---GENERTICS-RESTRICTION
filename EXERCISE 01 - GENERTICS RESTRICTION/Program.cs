using System;
using System.Collections.Generic;
using Services;
using Entities;
namespace EXERCISE_01___GENERTICS_RESTRICTION {
    //-----> START
    ///////////////////////////////////////////////////////////////////////////////////////////
    class Program {
        static void Main(string[] args) {
            List<Product> list = new List<Product>();
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                string[] vect = Console.ReadLine().Split(',');
                double price = double.Parse(vect[1]);
                list.Add(new Product(vect[0], price));
            }

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(list);

            Console.WriteLine("Max: ");
            Console.WriteLine(max);

        }
    }
    ////////////////////////////////////////////////////////////////////////////////////////////
    //-----> END
}
