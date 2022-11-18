namespace DecoratorPattern
{
    public class RunDecoratorPattern:RunPatterns
    {
        public  void Run()
        {
            ConcreteComponent concreteComponent = new ConcreteComponent();    
            concreteComponent.SendMail();        
        }
    }
}