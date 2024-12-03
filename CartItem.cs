using System.Globalization;

namespace OPP;

public class CartItem
{
    public static int CartItemsCount; // shared with all instances
    
    private const int DEFAULT_QUANTITY = 1;
    private const decimal DEFAULT_PRICE = decimal.Zero;
    private readonly CultureInfo _culture = CultureInfo.CreateSpecificCulture("pt-BR");
    
    public string Id { get; private set; }

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
    
    public string TotalPriceFormatted => (Price * Quantity).ToString("C", _culture);
    
    public CartItem(string name, decimal price = DEFAULT_PRICE, int quantity = DEFAULT_QUANTITY)
    {
        Id = Guid.NewGuid().ToString().Substring(0, 8);
        Name = name;
        Quantity = quantity;
        Price = price;
        CartItemsCount++;
    }
}

