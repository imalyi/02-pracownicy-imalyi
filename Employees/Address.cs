namespace _02_pracownicy_imalyi
{
    public class Address
    {
        private string _street;
        private int _buildingNumber;
        private int _apartmentNumber;
        private string _city;
        
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                ValidationHelper.ValidateString(value, "street");
                _street = value;
            }
        }

        public int BuildingNumber
        {
            get
            {
                return _buildingNumber;
            }
            set
            {
               ValidationHelper.ValidateNumber(value, "Building Number");
                _buildingNumber = value;
            }
        }

        public int ApartmentNumber
        {
            get
            {
                return _apartmentNumber;
            }
            set
            {
                ValidationHelper.ValidateNumber(value, "Apartment Number");
                _apartmentNumber = value;
            }
        }

        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                ValidationHelper.ValidateString(value, "City");
                _city = value;
            }
        }

        public Address(string street, int buildingNumber, int apartmentNumber, string city)
        {
            Street = street;
            BuildingNumber = buildingNumber;
            ApartmentNumber = apartmentNumber;
            City = city;
        }
}
}