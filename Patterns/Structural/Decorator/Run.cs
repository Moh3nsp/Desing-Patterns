namespace Structural.DecoratorPattern
{
    public class RunDecoratorPattern : RunPatterns
    {
        public void Run()
        {
            ConcreteComponent concreteComponent = new ConcreteComponent();
            DecoratorConcrete decorator = new DecoratorConcrete(concreteComponent);
            decorator.PreviousOperators();
        }
    }
}