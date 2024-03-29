﻿using System;
using System.Collections.Generic;
using System.Globalization;
using Exercicio_her___poli.Entities;

namespace Exercicio_her___poli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            List<Product> list = new List<Product>();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Product #{0} data: ",i);
                Console.Write("Common, used or imported (c/u/i)? ");
                string type = Console.ReadLine();
                while (type != "c" && type != "u" && type != "i")
                {
                    Console.WriteLine("Faz de novo, Faz direito");
                    Console.WriteLine("Product #{0} data: ", i);
                    Console.Write("Common, used or imported (c/u/i)? ");
                    type = Console.ReadLine();
                }
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == "c")
                {
                    list.Add(new Product(name, price));
                }
                else if(type == "u")
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                }
                else if(type == "i")
                {
                    Console.Write("Customs fee: ");
                    double tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, tax));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach(Product obj in list)
            {
                Console.WriteLine(obj.PriceTag());
            }
        }
    }
}
