using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Logic.Models;
using Common.Models;
using Data.Exceptions;
using Common.Mappers;

namespace Logic
{
    public class WorkerLogic
    {
        private WorkerData _workerData;

        public WorkerLogic()
        {
            _workerData = new WorkerData();
        }

        public StatusModel<WorkerModel> LoadWorker(int workerId)
        {
            var status = new StatusModel<WorkerModel>();

            try
            {
                var result = _workerData.LoadWorker(workerId).ToModel();
                status.SetStatus(System.Net.HttpStatusCode.OK, result);
            }
            catch (NotFoundException e)
            {
                status.SetStatus(System.Net.HttpStatusCode.NotFound, e.Message);
            }
            catch (Exception e)
            {
                status.SetStatus(System.Net.HttpStatusCode.InternalServerError, e.Message, e.StackTrace, "Error on Load Worker");
            }
            return status;
        }

        public StatusModel<string> SaveWorker(WorkerModel worker)
        {
            var status = new StatusModel<string>();
            // TODO: Put try catch here for exception
            _workerData.SaveWorker(worker.ToEntity());
            status.SetStatus(System.Net.HttpStatusCode.OK, "Worker saved successfully");

            return status;
        }

        public StatusModel<string> UpdateWorkerInfo(WorkerModel worker)
        {
            var status = new StatusModel<string>();

            try
            {
                _workerData.UpdateWorker(worker.ToEntity());
                status.SetStatus(System.Net.HttpStatusCode.OK, "Worker updated successfully");
            }
            catch (NotFoundException e)
            {
                status.SetStatus(System.Net.HttpStatusCode.NotFound, e.Message);
            }
            catch (Exception e)
            {
                status.SetStatus(System.Net.HttpStatusCode.InternalServerError, e.Message, e.StackTrace, "Error on Update Worker");
            }

            return status;
        }
    }
}
