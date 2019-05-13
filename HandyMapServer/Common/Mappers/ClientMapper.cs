using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;
using Data.DB_Models;

namespace Common.Mappers
{
    public static class ClientMapper
    {
        public static ClientModel ToModel(this Client item)
        {
            var toReturn = new ClientModel()
            {
                Client_id = item.client_id,
                Contact_number = item.contact_number,
                Email = item.email,
                Name = item.name,
                Password = item.password,
                Surname = item.surname,
                ProfilePicture = item.profile_picure
            };

            toReturn.Jobs = new List<JobModel>();
            if (item.Jobs != null)
            {
                foreach (var job in item.Jobs)
                {
                    toReturn.Jobs.Add(new JobModel()
                    {
                        Client_id = job.client_id,
                        Job_id = job.job_id,
                        Worker_id = job.worker_id,
                        Title = job.title,
                        Description = job.description,
                        Address = new AddressModel()
                        {
                            Job_id = job.Address.job_id,
                            Address_line_1 = job.Address.address_line_1,
                            Address_line_2 = job.Address.address_line_2,
                            Address_line_3 = job.Address.address_line_3,
                            City = job.Address.city,
                            Province = job.Address.province,
                            Zip_code = job.Address.zip_code
                        }
                    });
                }
            }

            return toReturn;
        }

        public static Client ToEntity(this ClientModel item)
        {
            var toReturn = new Client()
            {
                client_id = item.Client_id,
                contact_number = item.Contact_number,
                email = item.Email,
                name = item.Name,
                password = item.Password,
                surname = item.Surname,
                profile_picure = item.ProfilePicture
            };

            toReturn.Jobs = new List<Job>();
            if (item.Jobs != null)
            {
                foreach (var job in item.Jobs)
                {
                    toReturn.Jobs.Add(new Job()
                    {
                        client_id = job.Client_id,
                        job_id = job.Job_id,
                        worker_id = job.Worker_id,
                        title = job.Title,
                        description = job.Description,
                        Address = new Address()
                        {
                            job_id = job.Address.Job_id,
                            address_line_1 = job.Address.Address_line_1,
                            address_line_2 = job.Address.Address_line_2,
                            address_line_3 = job.Address.Address_line_3,
                            city = job.Address.City,
                            province = job.Address.Province,
                            zip_code = job.Address.Zip_code
                        }
                    });
                }
            }

            return toReturn;
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
