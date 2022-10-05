using Client_Mvc.Domain.Models;

namespace Client_Mvc.Repository.Interface
{
    public interface IClientRepository
    {
        List<Client> GetAllClient();
        Client GetClientByKey(string Key);
        Client PostClient(Client client);
        Client PutClient(Client client);

        
    }
}
