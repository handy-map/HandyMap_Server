using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.DB_Models;
using Data.Exceptions;

namespace Data
{
    public class ClientData
    {
        private HandyMapEntities _dbContext;

        public ClientData()
        {
            if (_dbContext == null)
                _dbContext = new HandyMapEntities();
        }

        public Client LoadClient(int clientId)
        {
            var data = _dbContext.Clients.FirstOrDefault(x => x.client_id == clientId);

            if (data == null)
            {
                throw new NotFoundException("Client not found");
            }
            else
            {
                return data;
            }
        }

        public void SaveClient(Client client)
        {
            _dbContext.Clients.Add(client);
        }

        public IEnumerable<Client> GetClients()
        {
            var data = _dbContext.Clients;

            return data;
        }

        public void UpdateClient(Client client)
        {
            var clientToUpdate = _dbContext.Clients.FirstOrDefault(x => x.client_id == client.client_id);

            if (clientToUpdate == null)
            {
                throw new NotFoundException("Client not found");
            }
            else
            {
                clientToUpdate.contact_number = client.contact_number;
                clientToUpdate.email = client.email;
                clientToUpdate.name = client.name;
                clientToUpdate.surname = client.surname;
                clientToUpdate.profile_picure = client.profile_picure;
                clientToUpdate.password = client.password;
            }
        }
    }
}
