using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public string CustomerType { get; set; }
        public DateTime DateStamp { get; set; }

        public Customer(string name, string type, DateTime dateStamp)
        {
            CustomerName = name;
            CustomerType = type;
            DateStamp = dateStamp;
        }

        public Customer() { }

        public override string ToString()
        {
            return $"{CustomerName} ({CustomerType}) - {DateStamp:MM/dd/yyyy}";
        }
    }

    public class Menu
        {
            private string[] sizes = { "TALL", "GRANDE", "VENTI" };

            private decimal[,] frappePrices =
            {
            {130, 145, 155},
            {140, 155, 165},
            {140, 155, 165},
            {145, 160, 170}
            };

            private string[] frappeNames = { "MOCHA", "CAPPUCCINO", "COFFEE JELLY", "JAVA CHIP" };

            private decimal[,] hotPrices =
            {
            {120, 130, 140},
            {120, 140, 150},
            {135, 145, 155},
            {140, 150, 160}
            };

            private string[] hotNames = { "MOCHA", "CAPPUCCINO", "COFFEE JELLY", "JAVA CHIP" };

            private string[] pastryNames = { "CHOCO DONUT", "STICKY CINNAMON", "PIZZA SLICE", 
                "HAM AND CHEESE SANDWICH", "CHIP COOKIES", "SLICED CAKE" };
            private decimal[] pastryPrices = { 80, 100, 80, 90, 85, 120 };

            public decimal GetPrice(string type, string name, string size = "N/A")
            {
                if (type == "FRAPPE")
                {
                    int drinkIndex = Array.IndexOf(frappeNames, name);
                    int sizeIndex = Array.IndexOf(sizes, size);
                    if (drinkIndex >= 0 && sizeIndex >= 0)
                        return frappePrices[drinkIndex, sizeIndex];
                }

                if (type == "HOT")
                {
                    int drinkIndex = Array.IndexOf(hotNames, name);
                    int sizeIndex = Array.IndexOf(sizes, size);
                    if (drinkIndex >= 0 && sizeIndex >= 0)
                        return hotPrices[drinkIndex, sizeIndex];
                }

                if (type == "PASTRY")
                {
                    int pastryIndex = Array.IndexOf(pastryNames, name);
                    if (pastryIndex >= 0)
                        return pastryPrices[pastryIndex];
                }

                return 0;
            }
        }
    }

public class CustomerInfo
{
    public string CustomerName { get; set; }
    public string CustomerType { get; set; }
    public DateTime DateStamp { get; set; }

    public CustomerInfo(string name, string type, DateTime dateStamp)
    {
        CustomerName = name;
        CustomerType = type;
        DateStamp = dateStamp;
    }

    public CustomerInfo() { }

    public override string ToString()
    {
        return $"{CustomerName} ({CustomerType}) - {DateStamp:MM/dd/yyyy}";
    }
}


