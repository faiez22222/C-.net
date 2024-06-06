using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetail
{
    internal class RestrauntOrder
    {
        public static void main()
        {
            int coffeeQuantity = 0;
            int sandwichQuantity = 0;
            int friesQuantity = 0;
            int noodlesQuantity = 0;
            int pizzaQuantity = 0;
            int coffeePrice = 40;
            int sandwitchPrice = 80;
            int frenchFriesPrice = 60;
            int noodelsPrice = 50;
            int pizzaPrice = 120;

            bool moreItems = true;
            int price = 0;

            while (moreItems)
            {
                Console.WriteLine("Select the item from the menu you want to order:");
                Console.WriteLine("1. Coffee    :40 Rs");
                Console.WriteLine("2. Grilled Sandwich    :80Rs");
                Console.WriteLine("3. French Fries    :60Rs");
                Console.WriteLine("4. Noodles    :50Rs");
                Console.WriteLine("5. Pizza    :120Rs");

                int selectedItem;
                while (!int.TryParse(Console.ReadLine(), out selectedItem) || selectedItem < 1 || selectedItem > 5)
                {
                    Console.WriteLine("Invalid selection. Please select a valid item number.");
                }

                string selectedItemName = "";
                int quantity = 0;

                switch (selectedItem)
                {
                    case 1:
                        selectedItemName = "Coffee";
                        break;
                    case 2:
                        selectedItemName = "Grilled Sandwich";
                        break;
                    case 3:
                        selectedItemName = "French Fries";
                        break;
                    case 4:
                        selectedItemName = "Noodles";
                        break;
                    case 5:
                        selectedItemName = "Pizza";
                        break;
                }

                Console.WriteLine($"You selected {selectedItemName}");
                Console.Write("Quantity: ");
                while (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0)
                {
                    Console.WriteLine("Invalid quantity. Please enter a positive number.");
                }

                switch (selectedItem)
                {
                    case 1:
                        coffeeQuantity += quantity;
                        break;
                    case 2:
                        sandwichQuantity += quantity;
                        break;
                    case 3:
                        friesQuantity += quantity;
                        break;
                    case 4:
                        noodlesQuantity += quantity;
                        break;
                    case 5:
                        pizzaQuantity += quantity;
                        break;
                }

                Console.Write("Do you want to add more items? (Y/N): ");
                string addMore = Console.ReadLine().Trim().ToUpper();
                moreItems = addMore == "Y";
            }
            price = price + coffeePrice * coffeeQuantity + sandwichQuantity * sandwitchPrice + frenchFriesPrice * friesQuantity + noodelsPrice * noodlesQuantity + pizzaQuantity * pizzaPrice;
            double cgst = price * 0.05;
            double sgst = price * 0.18;
            Console.Write("Items selected by you:");
            int totalItems = 0;

            if (coffeeQuantity > 0)
            {
                Console.Write($"{coffeeQuantity} Coffee");
                totalItems += coffeeQuantity;
            }
            if (sandwichQuantity > 0)
            {
                Console.Write($"{sandwichQuantity} Grilled Sandwich");
                totalItems += sandwichQuantity;
            }
            if (friesQuantity > 0)
            {
                Console.Write($"{friesQuantity} French Fries");
                totalItems += friesQuantity;
            }
            if (noodlesQuantity > 0)
            {
                Console.Write($"{noodlesQuantity} Noodles");
                totalItems += noodlesQuantity;
            }
            if (pizzaQuantity > 0)
            {
                Console.WriteLine($"{pizzaQuantity} Pizza");
                totalItems += pizzaQuantity;
            }

            Console.WriteLine($"\nTotal Items: {totalItems}");
            Console.WriteLine($"Total Bill: {price}");
            Console.WriteLine($"CGST 5%: {cgst}");
            Console.WriteLine($"SGST 18%: {sgst}");
            Console.WriteLine($"Total amout to pay: {price+cgst+sgst}");
        }
    }
}
