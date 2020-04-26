using System;
using System.Collections.Generic;

namespace Vending_machine
{
    public class VendingMachine
    {
        GoodsItem GoodsItem1 = new GoodsItem("Cola", 10, 5);
        GoodsItem GoodsItem2 = new GoodsItem("Cake", 35, 2);
        GoodsItem GoodsItem3 = new GoodsItem("Candy bar", 5, 12);

        public void DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine("** List of items **");
            Console.WriteLine($"* 1] {GoodsItem1.Name} - {GoodsItem1.Price} credits [{GoodsItem1.Inventory} QTY] *");
            Console.WriteLine($"* 2] {GoodsItem2.Name} - {GoodsItem2.Price} credits [{GoodsItem2.Inventory} QTY] *");
            Console.WriteLine($"* 3] {GoodsItem3.Name} - {GoodsItem3.Price} credits [{GoodsItem3.Inventory} QTY] *");
            Console.WriteLine();
        }

        public void Purchase(User user)
        {
            
            var receipt = new List<string>();
            var total = 0;
            
            while (true)
            {
                DisplayMenu();
                Console.WriteLine("To quit and recieve a receipt, press Q");
                Console.WriteLine("Select the item you want to purchase: ");
                string inputItem = Console.ReadLine();
                
                if (inputItem == "1")
                {
                    if (GoodsItem1.Inventory == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Sorry, {GoodsItem1.Name} is out of stock!");
                        Console.WriteLine("Please select another item");
                        Console.WriteLine();
                    }
                    else if (GoodsItem1.Price <= user.CardAccount)
                    {
                        user.CardAccount = user.CardAccount - GoodsItem1.Price;
                        GoodsItem1.Inventory = GoodsItem1.Inventory - 1;
                        total = total + GoodsItem1.Price;
                        receipt.Add(GoodsItem1.Name + " - " + GoodsItem1.Price + " credits");
                        Console.WriteLine();
                        Console.WriteLine($"You have purchased 1 {GoodsItem1.Name}!");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Sorry, you don't have enough credits on your account");
                        Console.WriteLine();
                    }
                }
                else if (inputItem == "2")
                {
                    if (GoodsItem2.Inventory == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Sorry, {GoodsItem2.Name} is out of stock!");
                        Console.WriteLine("Please select another item");
                        Console.WriteLine();
                    }
                    else if (GoodsItem2.Price <= user.CardAccount)
                    {
                        user.CardAccount = user.CardAccount - GoodsItem2.Price;
                        GoodsItem2.Inventory = GoodsItem2.Inventory - 1;
                        total = total + GoodsItem2.Price;
                        receipt.Add(GoodsItem2.Name + " - " + GoodsItem2.Price + " credits");
                        Console.WriteLine();
                        Console.WriteLine($"You have purchased 1 {GoodsItem2.Name}!");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Sorry, you don't have enough credits on your account");
                        Console.WriteLine();
                    }
                }
                else if (inputItem == "3")
                {
                    if (GoodsItem3.Inventory == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Sorry, {GoodsItem3.Name} is out of stock!");
                        Console.WriteLine("Please select another item");
                        Console.WriteLine();
                    }
                    else if (GoodsItem3.Price <= user.CardAccount)
                    {
                        user.CardAccount = user.CardAccount - GoodsItem3.Price;
                        GoodsItem3.Inventory = GoodsItem3.Inventory - 1;
                        total = total + GoodsItem3.Price;
                        receipt.Add(GoodsItem3.Name + " - " + GoodsItem3.Price + " credits");
                        Console.WriteLine();
                        Console.WriteLine($"You have purchased 1 {GoodsItem3.Name}!");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Sorry, you don't have enough credits on your account");
                        Console.WriteLine();
                    }
                }
                else if (inputItem == "Q" || inputItem == "q")
                {
                    Console.WriteLine();
                    Console.WriteLine("*****************");
                    Console.WriteLine("**** Receipt ****");
                    Console.WriteLine("*****************");
                    foreach (var item in receipt)
                    {
                        Console.WriteLine($"** {item} **");
                    }

                    Console.WriteLine("** Total: " + total + " credits **");
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid selection. Please re-enter your selection: ");
                }
            }
        }
        
        public void DisplayVendingMachine(User user)
        {

            Console.WriteLine();
            Console.WriteLine("*****************************************");
            Console.WriteLine("**** Welcome to the Vending Machine! ****");
            Console.WriteLine("* Please select an option in the menu: **");
            Console.WriteLine("*****************************************");

            while (true)
            {
                Console.WriteLine("* Menu");
                Console.WriteLine("* 1] Display items");
                Console.WriteLine("* 2] Purchase");
                Console.WriteLine("* Q] Quit");
                
                Console.Write("Select your option: ");
                string input = Console.ReadLine();
                
                if (input == "1")
                {
                    DisplayMenu();
                }
                else if (input == "2")
                {
                    Purchase(user);
                }
                else if (input == "Q" || input == "q")
                {
                    Console.WriteLine("Bye bye!");
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid selection!");
                    Console.WriteLine("Please select [1], [2] or [Q]");
                    Console.WriteLine();
                }
            }
        }
    }
}