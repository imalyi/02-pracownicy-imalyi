using System;

namespace _02_pracownicy_imalyi
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var address = new Address("street", 12, 12, "city");
            var employee = new OfficeEmployee( "name", "surname", 12, 10, address, 100, 11);
            var physical = new PhysicalWorker( "name", "surname", 11, 41, address, 45);
            Console.WriteLine(physical.ValueForCorporation());
        }
    }
}