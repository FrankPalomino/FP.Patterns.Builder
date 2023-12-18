namespace FP.Patterns.Builder
{
    internal class NormalBuilder : IBuilder
    {
        private Product _product = new Product();

        public void BuildChassis()
        {
            _product.SetChassis(new BasicChassis());
        }

        public void BuildEngine()
        {
            _product.SetEngine(new BasicEngine());
        }

        public void BuildWheels()
        {
            _product.SetWheels(new SmallWheel());
        }

        public Product GetResult()
        {
            return _product;
        }
    }
}
