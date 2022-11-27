namespace Design_Patterns.Patterns.Creational.Singletone
{
    public class Singletone
    {
        private static Singletone UniqueInstance = new Singletone();

        public static Singletone GetInstance()
        {
            return UniqueInstance;
        }

    }
}