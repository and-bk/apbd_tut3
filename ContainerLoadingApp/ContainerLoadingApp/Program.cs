using System.Collections;
using System.Drawing;
using ContainerLoadingApp;

Dictionary<string, double> ordinaryCargo = new Dictionary<string, double>();
ordinaryCargo.Add("Water", 3);
ordinaryCargo.Add("Milk", 3);

Dictionary<string, double> hazardCargo = new Dictionary<string, double>();
hazardCargo.Add("Diesel", 6);
hazardCargo.Add("Biodiesel", 6);

Dictionary<string, double> gasCargo = new Dictionary<string, double>();
gasCargo.Add("Propane", 5);
gasCargo.Add("Octane", 5);

Dictionary<string, double> products = new Dictionary<string, double>();
products.Add("Bananas", 13.3);
products.Add("Eggs", 19);
products.Add("Pomelo", 20);

while (true)
{
    Console.WriteLine("Choose a container you want to load: ");
    Console.WriteLine("1. Liquid Container");
    Console.WriteLine("2. Gas Container");
    Console.WriteLine("3. Refrigerated Container");
    Console.WriteLine("4. Break");
    int chooseContainer = int.Parse(Console.ReadLine());
    
    if (chooseContainer == 1)
    {
        Console.WriteLine("Choose type of cargo: ");
        Console.WriteLine("1. Ordinary cargo");
        Console.WriteLine("2. Hazardous cargo");
        int chooseCargo = int.Parse(Console.ReadLine());
        if (chooseCargo == 1)
        {
            LiquidContainer lq = new LiquidContainer(10, 30);
            while (true)
            {
                Console.WriteLine("Choose liquid: ");
                Console.WriteLine("1. Water");
                Console.WriteLine("2. Milk");
                Console.WriteLine("3. Empty container");
                Console.WriteLine("4. Break");
                int chooseOrdLiquid = int.Parse(Console.ReadLine());
                if (chooseOrdLiquid == 1)
                {
                    lq.LoadOrdinaryCargo(ordinaryCargo["Water"]);
                    Console.WriteLine("---------------------------------------------------------------");
                }
                else if (chooseOrdLiquid == 2)
                {
                    lq.LoadOrdinaryCargo(ordinaryCargo["Milk"]);
                    Console.WriteLine("---------------------------------------------------------------");
                }
                else if (chooseOrdLiquid == 3)
                {
                    lq.EmptyCargo();
                    Console.WriteLine("---------------------------------------------------------------");
                }
                else if (chooseOrdLiquid == 4)
                {
                    Console.WriteLine("---------------------------------------------------------------");
                    break;
                }
            }
        }
        else if (chooseCargo == 2)
        {
            LiquidContainer lq = new LiquidContainer( 10, 30);
            while (true)
            {
                Console.WriteLine("Choose hazard liquid: ");
                Console.WriteLine("1. Diesel");
                Console.WriteLine("2. Biodiesel");
                Console.WriteLine("3. Empty container");
                Console.WriteLine("4. Break");
                int chooseHzrdLiquid = int.Parse(Console.ReadLine());
                if (chooseHzrdLiquid == 1)
                {
                    lq.LoadHazardCargo(hazardCargo["Diesel"]);
                    Console.WriteLine("---------------------------------------------------------------");
                }
                else if (chooseHzrdLiquid == 2)
                {
                    lq.LoadHazardCargo(hazardCargo["Biodiesel"]);
                    Console.WriteLine("---------------------------------------------------------------");
                }
                else if (chooseHzrdLiquid == 3)
                {
                    lq.EmptyCargo();
                    Console.WriteLine("---------------------------------------------------------------");
                }
                else if (chooseHzrdLiquid == 4)
                {
                    Console.WriteLine("---------------------------------------------------------------");
                    break;
                }
            }
        }
    }
    else if (chooseContainer == 2)
    {
        GasContainer gs = new GasContainer(10, 20);
        while (true)
        {
            Console.WriteLine("Choose gas: ");
            Console.WriteLine("1. Propane");
            Console.WriteLine("2. Octane");
            Console.WriteLine("3. Empty container");
            Console.WriteLine("4. Break");
            int chooseGas = int.Parse(Console.ReadLine());
            if (chooseGas == 1)
            {
                gs.LoadCargo(gasCargo["Propane"]);
                Console.WriteLine("---------------------------------------------------------------");
            }
            else if (chooseGas == 2)
            {
                gs.LoadCargo(gasCargo["Octane"]);
                Console.WriteLine("---------------------------------------------------------------");
            }
            else if (chooseGas == 3)
            {
                gs.EmptyCargo();
                Console.WriteLine("---------------------------------------------------------------");
            }
            else if (chooseGas == 4)
            {
                Console.WriteLine("---------------------------------------------------------------");
                break;
            }
        }
    }
    else if (chooseContainer == 3)
    {
        while (true)
        {
            Console.WriteLine("Choose type of product: ");
            Console.WriteLine("1. Bananas");
            Console.WriteLine("2. Eggs");
            Console.WriteLine("3. Pomelo");
            Console.WriteLine("4. Break");
            int chooseProduct = int.Parse(Console.ReadLine());
            if (chooseProduct == 1)
            {
                RefrigeratedContainer rg = new RefrigeratedContainer(10, 40, 13.3, "Bananas");
                while (true)
                {
                    Console.WriteLine("Write type of product you want to load (\"Empty\" to empty the container or \"Break\"): ");
                    string product = Console.ReadLine();
                    if (product == "Empty")
                    {
                        rg.EmptyCargo();
                    }
                    else if (product == "Break")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter weight of cargo: ");
                        double weight = double.Parse(Console.ReadLine());
                        rg.LoadCargo(product, weight);
                        Console.WriteLine("---------------------------------------------------------------");
                    }
                }
            }

            if (chooseProduct == 2)
            {
                RefrigeratedContainer rg = new RefrigeratedContainer(10, 40, 19, "Eggs");
                while (true)
                {
                    Console.WriteLine("Write type of product you want to load (\"Empty\" to empty the container or \"Break\"): ");
                    string product = Console.ReadLine();
                    if (product == "Empty")
                    {
                        rg.EmptyCargo();
                    }
                    else if (product == "Break")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter weight of cargo: ");
                        double weight = double.Parse(Console.ReadLine());
                        rg.LoadCargo(product, weight);
                        Console.WriteLine("---------------------------------------------------------------");
                    }
                }
            }
            else if (chooseProduct == 3)
            {
                RefrigeratedContainer rg = new RefrigeratedContainer(10, 40, 20, "Pomelo");
                while (true)
                {
                    Console.WriteLine("Write type of product you want to load (\"Empty\" to empty the container or \"Break\"): ");
                    string product = Console.ReadLine();
                    if (product == "Empty")
                    {
                        rg.EmptyCargo();
                    }
                    else if (product == "Break")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter weight of cargo: ");
                        double weight = double.Parse(Console.ReadLine());
                        rg.LoadCargo(product, weight);
                        Console.WriteLine("---------------------------------------------------------------");
                    }
                }
            }
            else if (chooseProduct == 4)
            {
                Console.WriteLine("---------------------------------------------------------------");
                break;
            }
        }
    }
    else if (chooseContainer == 4)
    {
        break;
    }
}