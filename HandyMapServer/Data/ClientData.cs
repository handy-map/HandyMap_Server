using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.DB_Models;

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
                return new Client();
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
    }
}
