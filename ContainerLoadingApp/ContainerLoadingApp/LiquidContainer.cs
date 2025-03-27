namespace ContainerLoadingApp;

public class LiquidContainer(double height, double depth, double tareWeight, double maxPayload) : IHazardNotifier
{
    public double CargoMass { get; set; } = tareWeight;
    public double Height {get; set;} = height;
    public double TareWeight {get; set;} = tareWeight;
    public double CargoWeight { get; set; }
    public double Depth {get; set;} = depth;
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
    }

    public void LoadOrdinaryCargo(double cargoWeight)
    {
        CargoWeight += cargoWeight;
        CargoMass += cargoWeight;
        double fillPercent = (CargoWeight / MaxPayload) * 100;
        Console.WriteLine(fillPercent + "%");

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
        Notify();
        CargoWeight += cargoWeight;
        CargoMass += cargoWeight;
        double fillPercent = (CargoWeight / MaxPayload) * 100;
        Console.WriteLine(fillPercent + "%");

        if (fillPercent > 50)
        {
            CargoMass = 0;
            throw new OverfillException("Hazard cargo weight cannot be greater than 50% of the payload!!!");
        }
    }
    
}