namespace ContainerLoadingApp;

public class LiquidContainer(double tareWeight, double maxPayload) : IHazardNotifier
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
        return "KON-L-" + num;
    }

    public void EmptyCargo()
    {
        CargoWeight = 0;
        CargoMass = TareWeight;
        Console.WriteLine("Container was emptied");
        Console.WriteLine("Container is 0% full");
    }

    public void LoadOrdinaryCargo(double cargoWeight)
    {
        Console.WriteLine("Loading cargo to container: " + SerialNumber);
        CargoWeight += cargoWeight;
        CargoMass += cargoWeight;
        double fillPercent = (CargoWeight / MaxPayload) * 100;
        Console.WriteLine("Container is " + fillPercent + "% full");

        if (fillPercent > 90)
        {
            CargoMass = 0;
            throw new OverfillException("Cargo weight cannot be greater than 90% of the payload!!!");
        }
    }

    public void Notify()
    {
        Console.WriteLine("Hazardous situation in " + SerialNumber);
    }
    public void LoadHazardCargo(double cargoWeight)
    {
        Console.WriteLine("Loading cargo to container: " + SerialNumber);
        Notify();
        CargoWeight += cargoWeight;
        CargoMass += cargoWeight;
        double fillPercent = (CargoWeight / MaxPayload) * 100;
        Console.WriteLine("Container is " + fillPercent + "% full");

        if (fillPercent > 50)
        {
            CargoMass = TareWeight;
            throw new OverfillException("Hazard cargo weight cannot be greater than 50% of the payload!!!");
        }
    }
    
}