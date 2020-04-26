namespace Vending_machine
{
    public class GoodsItem
    {
        public string Name { get; set; }
        public int Price { get; set; }
        
        public int Inventory { get; set; }

        public GoodsItem(string name, int price, int inventory)
        {
            Name = name;
            Price = price;
            Inventory = inventory;
        }
    }
}