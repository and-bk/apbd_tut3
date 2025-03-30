namespace ContainerLoadingApp;

public class RefrigeratedContainer(double tareWeight, double maxPayload, double temperature, string productType)
{
    public double CargoMass { get; set; } = tareWeight;
    public double TareWeight {get; set;} = tareWeight;
    public double CargoWeight { get; set; }
    public double MaxPayload {get; set;} = maxPayload;
    public string SerialNumber { get; set; } = GenerateSerialNumber();
    public double Temperature {get; set;} = temperature;
    public string ProductType {get; set;} = productType;
    
    public static string GenerateSerialNumber()
    { 
        Random rnd = new Random();
        int num  = rnd.Next(1, 100);
        return "KON-R-" + num;
    }
    
    public void EmptyCargo()
    {
        CargoWeight = 0;
        CargoMass = TareWeight + CargoWeight;
        Console.WriteLine("Container was emptied");
        Console.WriteLine("Container is 0% full");
    }

    public void LoadCargo(string product, double weight)
    {
        if (product == productType)
        {
            Console.WriteLine("Loading cargo to container: " + SerialNumber);
            CargoWeight += weight;
            CargoMass += CargoWeight;
            double fillPercent = (CargoWeight / MaxPayload) * 100;
            Console.WriteLine("Container is " + fillPercent + "% full");
            if (CargoWeight> MaxPayload)
            {
                CargoMass = TareWeight;
                throw new OverfillException("Cargo weight cannot be greater than max payload!!!");
            }
        }
        else
            Console.WriteLine("Wrong product type");
    }
    
    
}