namespace Structural.AdapterPattern.ClassAdapter
{
    public class Adaptee : IIncompatibleInterface
    {
        public void SpecificExternalOperation(string message)
        {
            Console.WriteLine(message);
        }
    }
}