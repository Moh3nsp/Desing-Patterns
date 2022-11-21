
namespace Structural.DecoratorPattern
{
    public class Decorator : Component
    {
        Component BaseComponent;
        public Decorator(Component component)
        {
            BaseComponent = component;
        }

        public override void PreviousOperators()
        {
            BaseComponent.PreviousOperators();
            //you can write your additional code here if  only have one different use case
            //or you can using another class, DecoratorConcrete,
            //if you have multiple different use cases
        }

    }
}