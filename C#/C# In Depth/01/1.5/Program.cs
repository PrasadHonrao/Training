﻿using System;
using System.Collections;

public class Program
{
    class Product
    {
        string name;
        public string Name
        {
            get
            {
                return name;
            }
        }

        decimal price;
        public decimal Price
        {
            get
            {
                return price;
            }
        }

        public Product(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public static ArrayList GetSampleProducts()
        {
            ArrayList list = new ArrayList();
            list.Add(new Product("West Side Story", 9.99m));
            list.Add(new Product("Assassins", 14.99m));
            list.Add(new Product("Frogs", 13.99m));
            list.Add(new Product("Sweeny Todd", 10.99m));
            return list;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", name, price);
        }
    }

    class ProductNameComparer : IComparer
    {
        public int Compare(Object x, Object y)
        {
            Product first = (Product)x;
            Product second = (Product)y;
            return first.Name.CompareTo(second.Name);
        }
    }

    public static void Main(string[] args)
    {
        ArrayList products = Product.GetSampleProducts();
        products.Sort(new ProductNameComparer());
        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }
    }
}
