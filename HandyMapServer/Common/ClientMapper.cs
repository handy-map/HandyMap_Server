using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;
using Data.DB_Models;

namespace Common
{
    public static class ClientMapper
    {
        public static ClientModel ToModel(this Client item)
        {
            return new ClientModel()
            {
                client_id = item.client_id,
                contact_number = item.contact_number,
                email = item.email,
                name = item.name,
                password = item.password,
                surname = item.surname
            };
        }

        public static Client ToEntity(this ClientModel item)
        {
            return new Client()
            {
                client_id = item.client_id,
                contact_number = item.contact_number,
                email = item.email,
                name = item.name,
                password = item.password,
                surname = item.surname
            };
        }

        public static IEnumerable<ClientModel> ToModel(this List<Client> item)
        {
            return item.Select(x => x.ToModel());
        }

        public static IEnumerable<Client> ToEntity(this List<ClientModel> item)
        {
            return item.Select(x => x.ToEntity());
        }
    }
}
