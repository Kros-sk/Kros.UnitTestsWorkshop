using System.Collections.Concurrent;

namespace Kros.UnitTestsWorkshop.EShop
{
    public interface IClientRepository
    {
        Client? GetById(Guid clientId);
        IEnumerable<Client> GetAll();
        Guid Save(Client client);
    }

    public class ClientRepository : IClientRepository
    {
        private readonly ConcurrentDictionary<Guid, Client> _data = new();

        public IEnumerable<Client> GetAll() => _data.Values;

        public Client? GetById(Guid clientId)
            => _data.TryGetValue(clientId, out Client? client) ? client : null;

        public Guid Save(Client client)
        {
            if (client.Id == Guid.Empty)
            {
                client.Id = Guid.NewGuid();
            }
            _data[client.Id] = client;
            return client.Id;
        }
    }
}
