
using System.Collections.Generic;
public interface RunPatterns
{
    public void Run();
}


public class PatternRunnerList
{
    public static Dictionary<int, RunPatterns> Patterns;
    static PatternRunnerList()
    {
        Patterns= new Dictionary<int, RunPatterns>();
        Patterns[(int)PatternEnums.Decorator] = new DecoratorPattern.RunDecoratorPattern();
    }
}