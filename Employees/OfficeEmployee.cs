namespace _02_pracownicy_imalyi
{
    public class OfficeEmployee: Employee
    {
        private int _iq;
        public int PostionId { get; set; }

        public int IQ
        {
            get { return _iq;}
            set
            {
                if (value < 70 || value > 150)
                {
                    throw new IQOutOfRangeException();
                }
                else
                {
                    _iq = value;
                }
            }
        }

        public OfficeEmployee(string name, string surname, byte age, byte experience, Address address, int iq, int positionId) : base(name, surname, age, experience, address)
        {
            PostionId = positionId;
            IQ = iq;
        }
        public override float ValueForCorporation()
        {
            return Experience * IQ;
        }
    }
}