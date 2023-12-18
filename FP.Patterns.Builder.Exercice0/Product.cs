namespace FP.Patterns.Builder
{
    internal class Product
    {
        private IEngine engine;
        private IWheels wheels;
        private IChassis chassis;

        public void SetEngine(IEngine engine)
        {
            this.engine = engine;
        }

        public void SetWheels(IWheels wheels)
        {
            this.wheels = wheels;
        }

        public void SetChassis(IChassis chassis)
        {
            this.chassis = chassis;
        }

        public void Show()
        {
            System.Console.WriteLine("Engine: " + engine.Specifications());
            System.Console.WriteLine("Wheels: " + wheels.Size());
            System.Console.WriteLine("Chassis: " + chassis.Features());
        }
    }
}
