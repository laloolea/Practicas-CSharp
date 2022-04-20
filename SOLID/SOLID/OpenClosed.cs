namespace SOLID;



public class Drink
{
    public string Name { get; set; }
    
    public string Type { get; set; }
    public decimal Price { get; set; }
    
    
}

public interface IDrink
{
    public string Name { get; set; }
    
    public decimal Price { get; set; }
    public decimal Invoice { get; set; }

    public decimal GetPrice();

}

public class Water : IDrink
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public decimal Invoice { get; set; }

    public decimal GetPrice()
    {
        return Price * Invoice;
    }
}

public class Alcohol : IDrink
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public decimal Invoice { get; set; }
    public decimal Promo { get; set; }
    public decimal GetPrice()
    {
        return (Price - Promo) * Invoice;
    }
}
public class Invoice
{
    public decimal GetTotal(IEnumerable<IDrink> IstDrink)
    {
        decimal total = 0;
        foreach (var drink in IstDrink)
        {
            total += drink.GetPrice();

            //Esto es muy malo porque repites mucho codigo
            // if(drink.Type == "Agua")
            //     total += drink.Price;
            // else if(drink.Type == "Azucar")
            //     total += drink.Price * 0.33m;
            // else if(drink.Type == "Alcohol")
            //     total += drink.Price * 0.50m;
        }

        return total;
    }
}