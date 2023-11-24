namespace _02_pracownicy_imalyi
{
    public class PhysicalWorker: Employee
    {
        private int _physicalStrength;
        public int PhysicalStrength
        {
            get
            {
                return _physicalStrength;
            }set
            {
                if (value < 1 || value > 100)
                {
                    throw new PhysicalStrengthOutOfRangeException();
                }
                else
                {
                    _physicalStrength = value;
                }
            }
        }

        public PhysicalWorker(string name, string surname, byte age, byte experience, Address address, int physicalStrength) 
            : base(name, surname, age, experience, address)
        {
            PhysicalStrength = physicalStrength;
        }
        public override float ValueForCorporation()
        {
            return (float)Experience * PhysicalStrength / Age;
        }
    }
}