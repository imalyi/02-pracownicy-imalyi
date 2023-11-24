namespace _02_pracownicy_imalyi
{
    public abstract class Employee
    {
        public uint Id { get;}
        public string Name { get; set; }
        public string Surname{ get; set;  }
        public int Age { get; set; }
        public int Experience { get; set; }
        public  Address Address { get; set; }
        
        public Employee(string name, string surname, byte age, byte experience, Address address)
        {
            Id = Identifier.GenerateUniqueId();
            Name = name;
            Surname = surname;
            Age = age;
            Experience = experience;
            Address = address;
        }
        public abstract float ValueForCorporation();
    }
    
}