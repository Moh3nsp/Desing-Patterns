namespace Patterns.Creational.Builder
{
    public class RunBuilder : RunPatterns
    {
        public void Run()
        {
            Director director = new Director();
            ConcreteBuilder1 builder1 = new ConcreteBuilder1();
            director.SetBuilder(builder1);
            director.Construct();
            var complexClass = builder1.GetResult();
            complexClass.Display();

            ConcreteBuilder2 builder2 = new ConcreteBuilder2();
            director.SetBuilder(builder2);
            director.Construct();
            var complexClass2 = builder2.GetResult();
            complexClass2.Display();

        }
    }

}