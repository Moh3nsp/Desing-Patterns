namespace Patterns.Creational.Builder
{

    public class ConcreteBuilder2 : Builder
    {
        public override void BuilderPart1()
        {
            complexClass.HardworkPart1 = "HardworkPart1 modified by builder 2";
        }

        public override void BuilderPart2()
        {
            complexClass.HardworkPart2 = "HardworkPart2 modified by bulder 2";

        }
        public override ComplexClass GetResult()
        {
            return base.GetResult();
        }
    }

}