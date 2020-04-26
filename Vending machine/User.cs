namespace Vending_machine
{
    public class User
    {
        public int BankAccount { get; set; }
        public int CardAccount { get; set; }

        public User(int bankAccount, int cardAccount)
        {
            BankAccount = bankAccount;
            CardAccount = cardAccount;
        }
    }
}