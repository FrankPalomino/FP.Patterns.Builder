namespace FP.Patterns.Builder
{
    internal interface IBuilder
    {
        void BuildEngine();
        void BuildWheels();
        void BuildChassis();
    }
}
