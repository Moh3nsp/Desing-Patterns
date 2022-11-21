namespace Structural.AdapterPattern.ObjectiveAdapter
{
    public class Adapter : Target
    {
        Adaptee externalIncompatibleAdaptee;
        public Adapter()
        {
            externalIncompatibleAdaptee = new Adaptee();
        }
        public override void SpecificOperation()
        {
            externalIncompatibleAdaptee.SpecificExternalOperation();
        }
    }
}