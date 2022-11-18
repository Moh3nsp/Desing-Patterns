namespace DecoratorPattern
{

    public class ConcreteComponent : Component 
    {
        public override void SendMail()
        {
            Console.WriteLine("this is an email from ConcreteComponent class !!!");
        }
    }
}