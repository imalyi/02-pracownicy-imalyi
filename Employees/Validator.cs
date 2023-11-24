namespace _02_pracownicy_imalyi
{
    public static class ValidationHelper
    {
        public static void ValidateString(string value, string propertyName)
        {
            if (value.Length < 2)
            {
                throw new InvalidNameException($"{propertyName} length must be >= 2");
            }
        }

        public static void ValidateNumber(int value, string propertyName)
        {
            if (value <= 0)
            {
                throw new InvalidNumberException($"{propertyName} must be >= 1");
            }
        }
    }
}