using Client_Mvc.Enum;
using MongoDB.Bson.Serialization.Attributes;
using System.Net;

namespace Client_Mvc.Domain.Models
{
    [BsonIgnoreExtraElements]
    public class Client
    {
        public Client()
        {
            Key = Guid.NewGuid().ToString();
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            IsActive = true;
        }
        public string Key { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
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
