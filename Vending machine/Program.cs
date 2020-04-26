using System;

namespace Vending_machine
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new VendingMachine();
            Bank bank = new Bank();
            User user = new User(300, 30);

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Where do you want to go?");
                Console.WriteLine("1] Bank");
                Console.WriteLine("2] Vending Machine");
                Console.WriteLine("Q] Quit");

                Console.Write("Select your option: ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    bank.DisplayBank(user);
                }
                else if (input == "2")
                { 
                    vendingMachine.DisplayVendingMachine(user);
                }
                else if (input == "Q" || input == "q")
                {
                    Console.WriteLine("Bye bye!");
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Please try again");
                }
            }
        }
    }
}