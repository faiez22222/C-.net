using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetail
{
    internal class RestrauntOrder2cs
    {
        public static void Main()
        {
            int[] itemArray = new int[] { 1, 2, 3, 4, 5 };
            int[] priceOfItem = new int[] {50 , 60 , 100 , 50 , 30};
            int[] itemPurchased = new int[10];
            int[] itemQuantityPurchased = new int[5] { 0, 0, 0, 0, 0 };
            PurchaseItemandQuantity(itemPurchased , itemQuantityPurchased);
            CalculateBill(priceOfItem, itemQuantityPurchased);
        }

        public static void CalculateBill(int[] priceOfItem , int[] itemQuantityPurchased)
        {
            int total = 0;
            for (int i=0;i<5;i++)
            {
                total += (priceOfItem[i] * itemQuantityPurchased[i]); ;
            }
            Console.WriteLine("total: "+ total);   
        }

        public static void ShowMenu()
        {
            Console.WriteLine("Select the item from the menu you want to order:");
            Console.WriteLine("1. Coffee    :40 Rs");
            Console.WriteLine("2. Grilled Sandwich    :80Rs");
            Console.WriteLine("3. French Fries    :60Rs");
            Console.WriteLine("4. Noodles    :50Rs");
            Console.WriteLine("5. Pizza    :120Rs");
        }

        public static void PurchaseItemandQuantity(int[] itemPurchased , int[] itemQuantityPurchased)
        {
            bool moreItems = true;
            while (moreItems)
            {
                ShowMenu();

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
                        itemPurchased[itemPurchased.Length] = selectedItem;
                        itemQuantityPurchased[selectedItem]++;
                        break;
                    case 2:
                        itemPurchased[itemPurchased.Length] = selectedItem;
                        itemQuantityPurchased[selectedItem]++;
                        break;
                    case 3:
                        itemPurchased[itemPurchased.Length] = selectedItem;
                        itemQuantityPurchased[selectedItem]++;
                        break;
                    case 4:
                        itemPurchased[itemPurchased.Length] = selectedItem;
                        itemQuantityPurchased[selectedItem]++;
                        break;
                    case 5:
                        itemPurchased[itemPurchased.Length] = selectedItem;
                        itemQuantityPurchased[selectedItem]++;
                        break;
                }

                Console.WriteLine($"You selected {selectedItemName}");
                Console.Write("Quantity: ");
                while (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0)
                {
                    Console.WriteLine("Invalid quantity. Please enter a positive number.");
                }
                Console.Write("Do you want to add more items? (Y/N): ");
                string addMore = Console.ReadLine().Trim().ToUpper();
                moreItems = addMore == "Y";
            }
        }

    }
}
