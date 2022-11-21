namespace Structural.AdapterPattern.ObjectiveAdapter
{
    public class RunAdapterPattern : RunPatterns
    {
        public void Run()
        {
            Target adapter = new Adapter();
            adapter.SpecificOperation();
        }
    }
}