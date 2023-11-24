namespace _02_pracownicy_imalyi
{
    public sealed class Identifier
    {
        private static Identifier _instance;
        private static uint current_id = 0;
        private Identifier()
        {
        }

        public static Identifier GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Identifier();
            }

            return _instance;
        }

        public static uint GenerateUniqueId()
        {
            current_id += 1;
            return current_id;
        }
    }
}
