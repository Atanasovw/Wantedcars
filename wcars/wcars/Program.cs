using System.Linq;
using System.Xml.Linq;
using wcars;

try
{
    Console.WriteLine("Enter amount of cars");
    int count = int.Parse(Console.ReadLine());
    StreamWriter writeWcars = new("wcars.txt");
    using (writeWcars)
    {

        List<CarsInfo> cars = new List<CarsInfo>();

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Enter: Brand, License Plate" + new string(' ', 9));
            var danni = Console.ReadLine().Split();
            CarsInfo c1 = new CarsInfo(danni[0], int.Parse(danni[1]));
            cars.Add(c1);
        }

        Console.WriteLine(new string('=', 60));
        Console.Write(new string(' ', 9)+ "Enter plates to search for a specific car: ");
        
        int plates = int.Parse(Console.ReadLine());
        CarsInfo foundplate = cars.Where(c1 => c1.LicensePlate == plates).FirstOrDefault();
        string neshtosi = foundplate.Print();
        Console.WriteLine(new string('=', 60));
        Console.WriteLine(new string(' ', 18) + "Car found by the plates"+  new string(' ', 9));
        Console.WriteLine(new string(' ', 9) + neshtosi);
        Console.WriteLine(new string('=', 60));
        Console.Write("Which brand do you want to get a count on? : ");
  
        string brands = Console.ReadLine();
        Console.WriteLine(new string('=', 60));
        Console.WriteLine(new string(' ', 9) + $"Count of wanted cars by the make: {brands}"+ new string(' ', 9));
        Console.WriteLine(new string('=', 60));
        Console.Write(new string(' ', 9) + "The amount of wanted Audi's is: ");
        WantedBrands(cars, brands);

        cars.Sort();
        Console.WriteLine(new string('=', 60));
        Console.WriteLine(new string(' ', 9)+ "List of wanted cars sorted by license plates" + new string(' ', 9));
        Console.WriteLine(new string('=', 60));
        foreach (var item in cars)
        {
            Console.WriteLine(item.Print() + new string('*', 40));
        }
        Console.WriteLine(new string('=', 60));

    }
}
catch (ArgumentException exception)
{
    Console.WriteLine($"ArgException: {exception.Message}");
    throw;
}

 void WantedBrands(List<CarsInfo> cars, string brands)
{
    Console.WriteLine(cars.Count(x => x.Brand == brands));
}
