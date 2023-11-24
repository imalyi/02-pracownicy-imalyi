using System;

namespace _02_pracownicy_imalyi
{
    public class IQOutOfRangeException : Exception
    {
        public IQOutOfRangeException()
        {
        }
    }
    public class PhysicalStrengthOutOfRangeException : Exception
    {
        public PhysicalStrengthOutOfRangeException()
        {
        }
        
    }

    public class InvalidNameException : Exception
    {
        public InvalidNameException(string message): base(message)
        {
            
        }
    }

    public class InvalidNumberException : Exception
    {
        public InvalidNumberException(string message) : base(message)
        {
            
        }
    }
}