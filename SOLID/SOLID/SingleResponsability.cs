namespace SOLID;



public class Beer
{
    public string Name { get; set; }
    
    public string Brand { get; set; }

    public int Alcohol { get; set; }

    public Beer(string Name, string Brand, int  Alcohol)
    {
        this.Name = Name;
        this.Brand = Brand;
        this.Alcohol = Alcohol;
    }

    public class BeerDB
    {
        private readonly Beer _beer;
        public  BeerDB(Beer beer)
        {
            _beer = beer;
        }
        public void Save()
        {
            Console.WriteLine($"Save {_beer} ");
        }
    }

    public class BeerRequest
    {
        private readonly Beer _beer;
        public  BeerRequest(Beer beer)
        {
            _beer = beer;
        }
        public void Send()
        {
            Console.WriteLine($"Saving {_beer}");
        }
    }
}