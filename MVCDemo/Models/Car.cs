namespace MVCDemo.Models
{
    public class Car : Vehicle
    {
        public Car(string brand, string type)
        {
            Brand = brand;
            Type = type;
        }

        public string Brand { get; }
        public string Type { get; }

        public override Energy EnergyType => Energy.NotSpecified;

        public override void DisplayStatus()
        {
            //base.DisplayStatus();
            Console.WriteLine($"Speed {Speed} Brand {Brand} Type {Type} Energy {EnergyType}");
        }
    }
}
