namespace OPP;

public class Cart
{
    public List<CartItem> Items { get; private set; }

    public Cart()
    {
        Items = new List<CartItem>();
    }

    public void AddItem(CartItem item)
    {
        Items.Add(item);
    }

    public void RemoveItem(string itemId)
    {
        Items.RemoveAll(i => i.Id == itemId);
    }

    public void PrintItems()
    {
        Console.WriteLine($"Items count: {Items.Count}");
        foreach (var cartItem in Items)
        {
            Console.WriteLine($"{cartItem.Id}: {cartItem.Name} {cartItem.TotalPriceFormatted}");
        }
    }
}