namespace ShopKeeper;

public class Player
{
    private int Gold { get; set; }
    private Inventory _inventory { get; } = new Inventory();

    public Player()
    {
        Gold = 100;
        _inventory = new Inventory();
    }

    public void BuyItem(Item item)
    {
        if (item.Value > Gold)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You do not have enough gold to buy it.");
        }
        else
        {
            Gold -= item.Value;
            _inventory.AddItem(item);
        }
        PrintBalance();
    }

    public void SellItem(Item item)
    {
        Gold += item.Value;
        _inventory.RemoveItem(item);
    }
    public void ListItems() => _inventory.ListItems();
    private void PrintBalance()=> Console.WriteLine("Balance: " + Gold);
    public Item GetItem(int index) => _inventory.FindItem(index);
}