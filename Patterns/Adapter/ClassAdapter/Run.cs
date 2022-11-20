namespace Structural.AdapterPattern
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