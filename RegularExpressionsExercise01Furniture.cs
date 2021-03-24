using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Regular_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // RegularExpressionsExercise01Furniture
            string text = Console.ReadLine();

            string pattern = @">>([A-z]+)<<(\d+\.?\d*)!(\d+)";
            List<string> furnitureList = new List<string>();
            double totalPrice = 0.00;

            while (text != "Purchase")
            {
                Regex shopPattern = new Regex(pattern);
                Match match = shopPattern.Match(text);
                string furnitureName = match.Groups[1].ToString();
                if (match.Success)
                {
                    furnitureList.Add(furnitureName);
                    totalPrice += double.Parse(match.Groups[2].ToString()) * int.Parse(match.Groups[3].ToString());

                }

                text = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            foreach (var item in furnitureList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {totalPrice:F2}");
            //
        }
    }
}
