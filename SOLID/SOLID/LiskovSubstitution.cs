namespace SOLID;

public abstract class T
{
    public abstract string GetName();



}
public class S1 : T
{
    public override string GetName()
    {
        return "S1";
    }
}
public class S2 : T
{
    public override string GetName()
    {
        return "S2";
    }
}

public abstract class AbstractSale
{
    protected decimal amount;
    protected string customer;
    protected decimal taxes;
    public abstract void Generate();
    public abstract void CalculateTaxes();
}

public class Sale : AbstractSale
{
    public Sale(decimal amount, string customer,decimal taxes)
    {
        this.amount = amount;
        this.customer = customer;
        this.taxes = taxes;
    }
    public override void Generate()
    {
        Console.WriteLine("Generating");
    }

    public override void CalculateTaxes()
    {
        Console.WriteLine("Calculating taces");
    }
}
    
public class ForeignSale : AbstractSale
{
    public ForeignSale(decimal amount, string customer,decimal taxes)
    {
        this.amount = amount;
        this.customer = customer;
        this.taxes = taxes;
    }
    public override void Generate()
    {
        Console.WriteLine("Generating");
    }

    public override void CalculateTaxes()
    {
        //No necesita este metodo
    }
}
