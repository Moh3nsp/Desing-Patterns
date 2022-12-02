namespace Patterns.Behavioral.Observer
{
    public class RunObserver : RunPatterns
    {
        public void Run()
        {
            ConcreteSubject concreteSubject = new ConcreteSubject();

            concreteSubject.Attach(new ConcreteObserver("observer 1", concreteSubject));
            concreteSubject.Attach(new ConcreteObserver("observer 2", concreteSubject));
            concreteSubject.Attach(new ConcreteObserver("observer 3", concreteSubject));
            concreteSubject.Attach(new ConcreteObserver("observer 4", concreteSubject));
            concreteSubject.Attach(new ConcreteObserver("observer 5", concreteSubject));

            Observer observer6 = new ConcreteObserver("observer 6", concreteSubject);
            concreteSubject.Attach(observer6);

            concreteSubject.subjectState = "it chaged at :" + DateTime.Now.ToShortTimeString();
            concreteSubject.Notify();

            Console.WriteLine("***********************************");

            concreteSubject.Dettach(observer6);
            concreteSubject.subjectState = "it chaged at :" + DateTime.Now.ToShortTimeString();
            concreteSubject.Notify();
        }
    }
}