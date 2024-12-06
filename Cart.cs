using OPP.Payment;

namespace OPP;

public class Cart
{
    private readonly IList<CartItem> _items;

    public IEnumerable<CartItem> Items
    {
        get { return _items.AsEnumerable(); }
    }

    public Cart()
    {
        _items = new List<CartItem>();
    }

    public void AddItem(CartItem item)
    {
        _items.Add(item);
    }

    public void RemoveItem(CartItem item)
    {
        _items.Remove(item);
    }

    public void PrintItems()
    {
        Console.WriteLine($"Items count: {_items.Count}");
        foreach (var cartItem in _items)
        {
            Console.WriteLine($"{cartItem.Id}: {cartItem.Name} {cartItem.TotalPriceFormatted}");
        }
    }

    public decimal GetTotalPrice()
    {
        decimal totalPrice = 0;
        foreach (var item in _items)
        {
            totalPrice += item.TotalPrice;
        }

        return totalPrice;
    }

    public void Pay(IPayment paymentMethod)
    {
        paymentMethod.ProcessPayment(this);
    }
}
