namespace _02_pracownicy_imalyi
{
    public enum Effectiveness
    {
        LOW = 60,
        MEDIUM = 90,
        HIGH = 120
    }
    public class Salesperson: Employee
    {
        public Effectiveness Effectiveness;
        public float CommissionRate;

        public Salesperson(string name, string surname, byte age, byte experience, Address address,
            Effectiveness effectiveness, int commissionRate): base(name, surname, age, experience, address)
        {
            Effectiveness = effectiveness;
            CommissionRate = commissionRate;
        }

        public override float ValueForCorporation()
        {
            return (float)(Experience * (int)Effectiveness);
        }
    }
}
