namespace _02_pracownicy_imalyi
{
    public class Address
    {
        public string Street { get; set; }
        public uint BuildingNumber { get; set; }
        public uint ApartmentNumber { get; set; }
        public string City { get; set; }

        public Address(string street, uint buildingNumber, uint apartmentNumber, string city)
        {
            Street = street;
            BuildingNumber = buildingNumber;
            ApartmentNumber = apartmentNumber;
            City = city;
        }
}
}