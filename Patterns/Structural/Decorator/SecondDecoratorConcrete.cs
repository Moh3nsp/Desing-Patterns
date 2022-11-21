namespace Structural.DecoratorPattern
{
    public class SecondDecoratorConcrete : Decorator
    {
        public SecondDecoratorConcrete(Component component) : base(component)
        {
        }
        public override void PreviousOperators()
        {
            base.PreviousOperators();
            SecondNewFeature();
        }

        public void SecondNewFeature()
        {
            Console.WriteLine("this message is from NewFeature method ");
        }
    }
}