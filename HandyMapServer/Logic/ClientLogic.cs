using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Common.Mappers;
using Common.Models;
using Data;
using Data.DB_Models;
using Data.Exceptions;
using Logic.Models;

namespace Logic
{
    public class ClientLogic
    {
        private ClientData _clientData;
        public ClientLogic()
        {
            _clientData = new ClientData();
        }

        public StatusModel<ClientModel> LoadClient(int clientId)
        {
            var status = new StatusModel<ClientModel>();

            try
            {
                var result = _clientData.LoadClient(clientId).ToModel();
                status.SetStatus(System.Net.HttpStatusCode.OK, result);
            }
            catch (NotFoundException e)
            {
                status.SetStatus(System.Net.HttpStatusCode.NotFound, e.Message);
            }
            catch (Exception e)
            {
                status.SetStatus(System.Net.HttpStatusCode.InternalServerError, e.Message, e.StackTrace, "Error on Load Client");
            }
            return status;
        }

        public StatusModel<string> SaveClient(ClientModel client)
        {
            var status = new StatusModel<string>();
            // TODO: Put try catch here for exception
            _clientData.SaveClient(client.ToEntity());
            status.SetStatus(System.Net.HttpStatusCode.OK, "Client saved successfully");

            return status;
        }

        public StatusModel<string> UpdateClientInfo(ClientModel client)
        {
            var status = new StatusModel<string>();

            try
            {
                _clientData.UpdateClient(client.ToEntity());
                status.SetStatus(System.Net.HttpStatusCode.OK, "Client updated successfully");
            }
            catch (NotFoundException e)
            {
                status.SetStatus(System.Net.HttpStatusCode.NotFound, e.Message);
            }
            catch (Exception e)
            {
                status.SetStatus(System.Net.HttpStatusCode.InternalServerError, e.Message, e.StackTrace, "Error on Update Client");
            }

            return status;
        }
    }
}
