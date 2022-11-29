namespace Patterns.Creational.Builder
{
    public class ComplexClass
    {
        public string HardworkPart1 = "";
        public string HardworkPart2 = "";

        public void Display()
        {
            Console.WriteLine("HardworkPart1 : " + HardworkPart1);
            Console.WriteLine("HardworkPart2 : " + HardworkPart2);
        }
    }


}