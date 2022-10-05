namespace Client_Mvc.Domain.Models
{
    public class Address
    {
        public string Street { get; set; }
        public int NumberHouse {get; set; }
        public string Complement { get; set; }
        public string Neighborhood { get; set; }
        public int PostalCode { get; set; }
        public string City { get; set; }
    }
}
