
namespace Structural.AdapterPattern.ClassAdapter
{

    public class Adapter : Adaptee, ICompatibleInterface
    {
        public void SpecificlOperation()
        {
            var message = "This is a message from SpecificExternalOperation method  with a compatible way";
            SpecificExternalOperation(message);
        }
    }

}