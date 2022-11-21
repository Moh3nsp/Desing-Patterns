namespace Structural.AdapterPattern.ClassAdapter
{
    public class RunAdapterPattern : RunPatterns
    {
        public void Run()
        {
            ICompatibleInterface adapter = new Adapter();
            adapter.SpecificlOperation();
        }
    }
}