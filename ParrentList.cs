
public interface RunPatterns
{
    public void Run();
}


public class PatternRunnerList
{
    public static Dictionary<int, RunPatterns> Patterns;
    static PatternRunnerList()
    {
        Patterns = new Dictionary<int, RunPatterns>();
        Patterns[(int)PatternEnums.Decorator] = new Structural.DecoratorPattern.RunDecoratorPattern();
        Patterns[(int)PatternEnums.Adapter_Wrapper_ClassAdapter] = new Structural.AdapterPattern.ClassAdapter.RunAdapterPattern();
        Patterns[(int)PatternEnums.Adapter_Wrapper_ObjectAdapter] = new Structural.AdapterPattern.ObjectiveAdapter.RunAdapterPattern();
    }
}