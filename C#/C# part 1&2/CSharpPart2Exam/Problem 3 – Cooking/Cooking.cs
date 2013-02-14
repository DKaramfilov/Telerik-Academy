using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

class Program
{
    static List<string> Products = new List<string>();
    static List<decimal> recipeAmount = new List<decimal>();
    static List<string> originalUnit = new List<string>();

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int productCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < productCount; i++)
        {
            string recipeLine = Console.ReadLine();
            string[] tokens = recipeLine.Split(':');
            decimal amount = decimal.Parse(tokens[0]);
            string unit = tokens[1];
            string product = tokens[2];
            AddProduct(product, amount, unit);

        }
        int addedproductCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < addedproductCount; i++)
        {
            string recipeLine = Console.ReadLine();
            string[] tokens = recipeLine.Split(':');
            decimal amount = decimal.Parse(tokens[0]);
            string unit = tokens[1];
            string product = tokens[2];
            RemoveProduct(product, amount, unit);

        }
        for (int i = 0; i < Products.Count; i++)
        {
            if (recipeAmount[i] > 0)
            {
                Console.WriteLine("{0:F2}:{1}:{2}", ConvertToUnits(originalUnit[i], recipeAmount[i]), originalUnit[i], Products[i]);
            }
        }
    }
    private static void RemoveProduct(string product, decimal amount, string unit)
    {
        decimal amountMilliters = ConvertToMilliters(unit, amount);
        for (int i = 0; i < Products.Count; i++)
        {
            if (string.Compare(Products[i], product, true) == 0)
            {
                recipeAmount[i] -= amountMilliters;
                return;
            }
        }



    }
    private static void AddProduct(string product, decimal amount, string unit)
    {
        decimal amountMilliters = ConvertToMilliters(unit, amount);
        for (int i = 0; i < Products.Count; i++)
        {
            if (string.Compare(Products[i], product, true) == 0)
            {
                recipeAmount[i] += amountMilliters;
                return;
            }
        }
        Products.Add(product);
        recipeAmount.Add(amountMilliters);
        originalUnit.Add(unit);


    }
    static decimal ConvertToMilliters(string unit, decimal amount)
    {
        switch (unit)
        {
            case "liters":
            case "ls": return amount * 1000;

            case "tablespoons":
            case "tbsps": return amount * 15;

            case "fluid ounces":
            case "fl ozs": return amount * 30;

            case "teaspoons":
            case "tsps": return amount * 5;

            case "gallons":
            case "gals": return amount * 3840;

            case "pints":
            case "pts": return amount * 480;

            case "quarts":
            case "qts": return amount * 960;

            case "cups": return amount * 240;

            case "milliliters":
            case "mls": return amount;

            default:
                throw new ArgumentException("invlaid unit");

        }
    }
    static decimal ConvertToUnits(string unit, decimal amount)
    {
        switch (unit)
        {
            case "liters":
            case "ls": return amount / 1000;

            case "tablespoons":
            case "tbsps": return amount / 15;

            case "fluid ounces":
            case "fl ozs": return amount / 30;

            case "teaspoons":
            case "tsps": return amount / 5;

            case "gallons":
            case "gals": return amount / 3840;

            case "pints":
            case "pts": return amount / 480;

            case "quarts":
            case "qts": return amount / 960;

            case "cups": return amount / 240;

            case "milliliters":
            case "mls": return amount;

            default:
                throw new ArgumentException("invlaid unit");

        }
    }
}

