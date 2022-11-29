namespace Patterns.Creational.Singletone
{
    public class RunSingletonePattern : RunPatterns
    {
        public void Run()
        {
            var obj1 = Singletone.GetInstance();
            var obj2 = Singletone.GetInstance();
            Console.WriteLine("Both objects are equal : " + (obj1 == obj2));
        }
    }
}