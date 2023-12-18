namespace FP.Patterns.Builder
{
    internal class Director
    {
        public void Construct(IBuilder builder)
        {
            builder.BuildChassis();
            builder.BuildWheels();
            builder.BuildEngine();
        }
    }
}
