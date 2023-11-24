namespace _02_pracownicy_imalyi
{
    public abstract class Employee
    {
        private byte _age;
        private string _name;
        private string _surname;
        private byte _experience;
        
        public uint Id { get;}

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
               
                _name = 
            }
        }

        public string Surname{ get; set;  }
        public byte Age { get; set; }
        public byte Experience { get; set; }
        public Address Address { get; set; }
        
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