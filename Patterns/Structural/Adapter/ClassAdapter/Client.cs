
namespace Structural.AdapterPattern.ClassAdapter
{

    public class ModernClass
    {

        public void DoSomethingNew(ICompatibleInterface operation)
        {
            //you can pass an object of Adapter to this method--
            //in order to using the functionality of Incompatile class such as Adaptee
            //In Fact Adapter put a wrapper around Adaptee to facilate its usage in Modern Class
            //or anywhere you want 
            operation.SpecificlOperation();
        }

    }

}