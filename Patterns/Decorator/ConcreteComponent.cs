namespace DecoratorPattern
{

    public class ConcreteComponent : Component 
    {
        public override void PreviousOperators()
        {
            Console.WriteLine("this is an email from ConcreteComponent class !!!");
        }
    }
}