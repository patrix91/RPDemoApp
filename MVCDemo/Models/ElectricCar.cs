using MVCDemo.Interfaces;

namespace MVCDemo.Models;

public class ElectricCar : Car, IAndroidAudio
{
    public ElectricCar() : base("Tesla", "p90") { }
    public override Energy EnergyType => Energy.Electric;

    public void BluetoothConnection()
    {
        Console.WriteLine("Bluetooth connected");
    }

    public override void DisplayStatus()
    {
        base.DisplayStatus();
    }

    public override void SpeedUp()
    {
        Speed += 4;
    }
}

