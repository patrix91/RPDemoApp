namespace MVCDemo.Models;

public class Car : Vehicle
{
    public int Id { get; set; }
    public Car(string brand, string type)
    {
        Brand = brand;
        Type = type;
    }

    public string Brand { get; set; }
    public string Type { get; set; }

    public override Energy EnergyType => Energy.NotSpecified;

    public override void DisplayStatus()
    {
        //base.DisplayStatus();
        Console.WriteLine($"Speed {Speed} Brand {Brand} Type {Type} Energy {EnergyType}");
    }
}

