using Client_Mvc.Enum;

namespace Client_Mvc.Domain.Models
{
    public class ClientRequest
    {
        public string ClientName { get; set; }
        public ClientType clientType { get; set; }
        public string ClientEmail { get; set; }
        public Contact ContactName { get; set; }
        public Contact LContactPhone { get; set; }
        public Contact Email { get; set; }
        public Address Street { get; set; }
        public Address NumberHouse { get; set; }
        public Address Complement { get; set; }
        public Address Neighborhood { get; set; }
        public Address PostalCode { get; set; }
        public Address City { get; set; }
        public States states { get; set; }
    }
}
