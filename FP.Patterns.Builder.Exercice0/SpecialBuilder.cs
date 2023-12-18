namespace FP.Patterns.Builder
{
    internal class SpecialBuilder : IBuilder
    {
        private readonly Product _product = new Product();

        public void BuildEngine()
        {
            _product.SetEngine(new BigEngine());
        }

        public void BuildWheels()
        {
            _product.SetWheels(new BigWheel());
        }

        public void BuildChassis()
        {
            _product.SetChassis(new EspecialChassis());
        }

        public Product GetResult()
        {
            return _product;
        }
    }
}
