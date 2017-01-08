﻿using System;
using System.Collections.Generic;

public class Program
{
    class Product
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        Product() { }

        public static List<Product> GetSampleProducts()
        {
            return new List<Product>()
            {
                new Product("West Side Story", 9.99m),
                new Product("Assassins", 14.99m),
                new Product("Frogs", 13.99m),
                new Product("Sweeny Todd", 10.99m)
            };
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", Name, Price);
        }
    }
}
