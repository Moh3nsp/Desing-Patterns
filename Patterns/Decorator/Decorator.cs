
namespace DecoratorPattern
{
    public  class Decorator:Component
    {
        Component BaseComponent;
        public Decorator(Component component)
        {
            BaseComponent = component;
        }

        public override void PreviousOperators()
        {
          BaseComponent.PreviousOperators();
        }

    }
}