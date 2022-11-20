using Structural.AdapterPattern;

namespace AdapterPattern{

    public class Adaptee:IIncompatibleInterface
    {
       public void SpecificExternalOperation(string message)
       {
         Console.WriteLine(message);
       }
    }

}