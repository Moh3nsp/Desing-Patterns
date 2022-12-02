namespace Patterns.Behavioral.Observer
{
    public class ConcreteObserver : Observer
    {
        public string name { get; set; } = "";
        public string observerState { get; set; } = "";
        public ConcreteSubject concreteSubject { get; set; }
        public ConcreteObserver(string name, ConcreteSubject concreteSubject)
        {
            this.name = name;
            this.concreteSubject = concreteSubject;
        }

        public override void update()
        {
            Console.WriteLine(string.Format("the changes is observed by {0}, it is : {1}", this.name, this.concreteSubject.subjectState));
        }

    }

}