namespace BJLogicLevel.Model
{
    class Singleton
    {
        private static Singleton instance;

        public int IDGame;

        private Singleton()
        {
            IDGame = 0;
        }

        public static Singleton getInstance()
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }
    }
}
