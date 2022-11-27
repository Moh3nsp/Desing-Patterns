namespace Design_Patterns.Patterns.Creational.Singletone
{
    public class RunSingletonePattern : RunPatterns
    {
        public void Run()
        {
            var obj1 = Singletone.GetInstance();
            var obj2 = Singletone.GetInstance();
            Console.WriteLine(obj1 == obj2);
        }
    }
}