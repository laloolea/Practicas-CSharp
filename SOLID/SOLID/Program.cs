// See https://aka.ms/new-console-template for more information
namespace SOLID;

class Program
{
    static void Main(string[] args)
    {
        T t = new S1();

        t = new S2();

        AbstractSale sale = new Sale(10,"customer",10);
        sale.CalculateTaxes();
        sale.Generate();
        
        
    }
}

