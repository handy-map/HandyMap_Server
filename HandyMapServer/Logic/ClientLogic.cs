using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Common.Models;
using Data;
using Data.DB_Models;

namespace Logic
{
    public class ClientLogic
    {
        private ClientData _clientData;
        public ClientLogic()
        {
            _clientData = new ClientData();
        }

        public ClientModel LoadClient(int clientId)
        {
            return _clientData.LoadClient(clientId).ToModel();
        }

        public void SaveClient(Client client)
        {
            _clientData.SaveClient(client);
        }
    }
}
