namespace Structural.DecoratorPattern
{
    public class DecoratorConcrete : Decorator
    {
        public DecoratorConcrete(Component component) : base(component)
        {
        }
        public override void PreviousOperators()
        {
            base.PreviousOperators();
            NewFeature();
        }

        public void NewFeature()
        {
            Console.WriteLine("this message is from NewFeature method ");
        }
    }
}