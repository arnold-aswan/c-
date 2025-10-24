namespace ShopKeeper;

public class Shop
{
    private Inventory _inventory { get; } = new Inventory();

    public Shop()
    {
        _inventory = new Inventory();
    }

    public void BuyItem(Item item) => _inventory.AddItem(item);
    public void SellItem(Item item) => _inventory.RemoveItem(item);
    public void ListStock() => _inventory.ListItems();
    public Item GetItem(int index) => _inventory.FindItem(index);
}