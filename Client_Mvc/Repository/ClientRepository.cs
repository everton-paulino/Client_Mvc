using Client_Mvc.Domain.Models;
using Client_Mvc.Repository.Interface;
using MongoDB.Driver;

namespace Client_Mvc.Repository
{
    public class ClientRepository : IClientRepository
    {
        private readonly IMongoCollection<Client> _collectionClient;
        public ClientRepository()
        {
            var client = new MongoClient(Environment.GetEnvironmentVariable("CLIENTE_DB_CONNECTIONSTRING"));
            var database = client.GetDatabase("DBCRUD");
            _collectionClient = database.GetCollection<Client>("Cliente");
        }
        public List<Client> GetAllClient()
        {
            var clients = _collectionClient.Find(b => b.IsActive).ToList();

            return clients;        }

        public Client GetClientByKey(string Key)
        {
            var client = _collectionClient.Find(b => b.Key == Key).FirstOrDefault();

            return client;
        }

        public Client PostClient(Client client)
        {
            _collectionClient.InsertOne(client);

            return client;
        }

        public Client PutClient(Client client)
        {
            _collectionClient.ReplaceOneAsync(c => c.Key == client.Key, client);

            return client;
        }
    }
}
