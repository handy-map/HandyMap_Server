using Common.Models;
using Data.DB_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Mappers
{
    public static class WorkerMapper
    {
        public static WorkerModel ToModel(this Worker item)
        {
            var toReturn = new WorkerModel()
            {
                Worker_id = item.worker_id,
                Contact_number = item.contact_number,
                Email = item.email,
                Name = item.name,
                Password = item.password,
                Surname = item.surname,
                ProfilePicture = item.profile_picture,
                Jobs = new List<JobModel>(),
                Skills = new List<SkillModel>()
            };

            foreach (var job in item.Jobs)
            {
                toReturn.Jobs.Add(new JobModel()
                {
                    Worker_id = job.worker_id,
                    Job_id = job.job_id,
                    Client_id = job.client_id,
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

            foreach (var skill in item.Skills)
            {
                toReturn.Skills.Add(new SkillModel()
                {
                    Skill_id = skill.skill_id,
                    Skill_name = skill.skill_name
                });
            }

            return toReturn;
        }

        public static Worker ToEntity(this WorkerModel item)
        {
            var toReturn = new Worker()
            {
                worker_id = item.Worker_id,
                contact_number = item.Contact_number,
                email = item.Email,
                name = item.Name,
                password = item.Password,
                surname = item.Surname,
                profile_picture = item.ProfilePicture,
                Jobs = new List<Job>(),
                Skills = new List<Skill>()
            };

            foreach (var job in item.Jobs)
            {
                toReturn.Jobs.Add(new Job()
                {
                    worker_id = job.Worker_id,
                    job_id = job.Job_id,
                    client_id = job.Worker_id,
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

            foreach (var skill in item.Skills)
            {
                toReturn.Skills.Add(new Skill()
                {
                    skill_id = skill.Skill_id,
                    skill_name = skill.Skill_name
                });
            }
            return toReturn;
        }

        public static IEnumerable<WorkerModel> ToModel(this List<Worker> item)
        {
            return item.Select(x => x.ToModel());
        }

        public static IEnumerable<Worker> ToEntity(this List<WorkerModel> item)
        {
            return item.Select(x => x.ToEntity());
        }
    }
}
