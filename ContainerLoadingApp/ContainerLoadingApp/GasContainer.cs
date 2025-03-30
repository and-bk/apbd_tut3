namespace ContainerLoadingApp;

public class GasContainer(double tareWeight, double maxPayload) : IHazardNotifier
{
    public double CargoMass { get; set; } = tareWeight;
    public double TareWeight {get; set;} = tareWeight;
    public double CargoWeight { get; set; }
    public double MaxPayload {get; set;} = maxPayload;
    public string SerialNumber { get; set; } = GenerateSerialNumber();
    
    public static string GenerateSerialNumber()
    { 
        Random rnd = new Random();
        int num  = rnd.Next(1, 100);
        return "KON-G-" + num;
    }
    
    public void EmptyCargo()
    {
        CargoWeight = CargoWeight * 0.05;
        CargoMass = TareWeight + CargoWeight;
        Console.WriteLine("Container was emptied");
        Console.WriteLine("Container is 5% full");
    }
    
    public void Notify()
    {
        Console.WriteLine("Hazardous situation in " + SerialNumber);
    }
    
    public void LoadCargo(double cargoWeight)
    {
        Console.WriteLine("Loading cargo to container: " + SerialNumber);
        Notify();
        CargoWeight += cargoWeight;
        CargoMass += cargoWeight;
        double fillPercent = (CargoWeight / MaxPayload) * 100;
        Console.WriteLine("Container is " + fillPercent + "% full");

        if (CargoWeight> MaxPayload)
        {
            CargoMass = TareWeight;
            throw new OverfillException("Cargo weight cannot be greater than max payload!!!");
        }
    }
    
    
}