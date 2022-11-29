namespace Patterns.Creational.Builder
{
    public class Director
    {
        public Builder builder;
        public void SetBuilder(Builder builder)
        {
            this.builder = builder;
        }
        public void Construct()
        {
            builder.BuilderPart1();
            builder.BuilderPart2();
        }



    }
}