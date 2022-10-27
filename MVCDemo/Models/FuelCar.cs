using MVCDemo.Interfaces;

namespace MVCDemo.Models
{
    public class FuelCar : Car, IAndroidAudio
    {
        public FuelCar() : base("vw", "golf") { }

        public override Energy EnergyType => Energy.Fuel;

        public void BluetoothConnection()
        {
            Console.WriteLine("Not connected!");
        }

        public override void SpeedUp()
        {
            Speed += 2;
        }

    }
}
