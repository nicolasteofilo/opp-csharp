namespace OPP;

public class CartItem
{
    public static int CartItemsCount; // shared with all instances
    
    private const int DEFAULT_QUANTITY = 1;
    private const decimal DEFAULT_PRICE = decimal.Zero;
    
    private string _name;
    public string Name
    {
        get => _name;
        set
        {
            if(string.IsNullOrEmpty(value)) throw new ArgumentNullException(nameof(Name));
            _name = value;
        }
    }
    
    public int Quantity { get; private set; }
    
    private decimal _price;
    public decimal Price
    {
        get => _price;
        set
        {
            if(value < 0) throw new ArgumentException("Price cannot be negative");
            _price = value;
        }
    }
    
    public CartItem(string name, decimal price = DEFAULT_PRICE, int quantity = DEFAULT_QUANTITY)
    {
        Name = name;
        Quantity = quantity;
        Price = price;
        CartItemsCount++;
    }

}

