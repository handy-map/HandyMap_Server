using Data.DB_Models;
using Data.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class WorkerData
    {
        private HandyMapEntities _dbContext;

        public WorkerData()
        {
            if (_dbContext == null)
                _dbContext = new HandyMapEntities();
        }

        public Worker LoadWorker(int workerId)
        {
            var data = _dbContext.Workers.FirstOrDefault(x => x.worker_id == workerId);

            if (data == null)
            {
                throw new NotFoundException("Worker not found");
            }
            else
            {
                return data;
            }
        }

        public void SaveWorker(Worker Worker)
        {
            _dbContext.Workers.Add(Worker);
        }

        public IEnumerable<Worker> GetWorkers()
        {
            var data = _dbContext.Workers;

            return data;
        }

        public IEnumerable<Worker> GetWorkersByPrimarySkill(int skill_id)
        {
            var data = _dbContext.Workers.Where(x => x.Skills.First().skill_id == skill_id);

            return data.ToList();
        }

        public void UpdateWorker(Worker worker)
        {
            var workerToUpdate = _dbContext.Workers.FirstOrDefault(x => x.worker_id == worker.worker_id);

            if (workerToUpdate == null)
            {
                throw new NotFoundException("Worker not found");
            }
            else
            {
                workerToUpdate.contact_number = worker.contact_number;
                workerToUpdate.email = worker.email;
                workerToUpdate.name = worker.name;
                workerToUpdate.surname = worker.surname;
                workerToUpdate.profile_picture = worker.profile_picture;
                workerToUpdate.password = worker.password;

                workerToUpdate.Skills = new List<Skill>();
                foreach (var skill in worker.Skills)
                {
                    workerToUpdate.Skills.Add(new Skill()
                    {
                        skill_id = skill.skill_id,
                        skill_name = skill.skill_name
                    });
                }
            }
        }
    }
}
