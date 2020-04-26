using System;

namespace Vending_machine
{
    public class Bank
    {
        public bool Withdraw(int inputNumber, User user)
        {
            if (inputNumber <= user.BankAccount && inputNumber >= 0)
            {
                user.BankAccount = user.BankAccount - inputNumber;
                user.CardAccount = inputNumber + user.CardAccount;
                return true;
            }
            return false;
        }
        
        public void DisplayBank(User user)
        {
            Console.WriteLine();
            Console.WriteLine("****************************************");
            Console.WriteLine("******** Welcome to the bank! **********");
            Console.WriteLine("* Please select an option in the menu: *");
            Console.WriteLine("****************************************");
            
            while (true)
            {
                Console.WriteLine("* Menu");
                Console.WriteLine("* 1] Withdraw credits");
                Console.WriteLine("* 2] Check balance");
                Console.WriteLine("* Q] Quit");
                Console.WriteLine();
                Console.Write("Select your option: ");
                string input = Console.ReadLine();
                    
                if (input == "1")
                {
                    while (true)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Your current balance is {user.BankAccount} on your bank account");
                        Console.WriteLine("How much do you want to withdraw?");
                        int.TryParse(Console.ReadLine(), out int inputNumber);
                        if (Withdraw(inputNumber, user))
                        {
                            Console.WriteLine();
                            Console.WriteLine($"You withdrew {inputNumber} credits from your bank account");
                            Console.WriteLine();
                            break;
                        }
                        Console.WriteLine("You don't have enough credits");
                    }

                }
                else if (input == "2")
                {
                    Console.WriteLine();
                    Console.WriteLine($"Your bank account balance is: {user.BankAccount}");
                    Console.WriteLine($"Your card account balance is: {user.CardAccount}");
                    Console.WriteLine();
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
                    Console.WriteLine();
                }
            }
        }
    }
}