namespace Infrastructure
{
    public static class Globals
    {
        public static A3 A { get; private set; }
        public static B3 B { get; private set; }

        static Globals()
        {
            A = new A3();
            B = new B3();
        }
    }
}