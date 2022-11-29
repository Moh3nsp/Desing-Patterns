namespace Patterns.Creational.Builder
{
    public abstract class Builder
    {
        public ComplexClass complexClass;

        public Builder()
        {
            complexClass = new ComplexClass();
        }
        public abstract void BuilderPart1();
        public abstract void BuilderPart2();

        public virtual ComplexClass GetResult()
        {
            return complexClass;
        }
    }

}