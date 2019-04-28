using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


public class Service : IService
{
    handyEntities handyEntities = new handyEntities();

    bool IService.AddCategory(string email, string name)
    {
        throw new NotImplementedException();
    }

    bool IService.AddCertificate(string email, string name, string issuedby)
    {
        throw new NotImplementedException();
    }

    User IService.Deregister(string email, string password)
    {
        throw new NotImplementedException();
    }

    User IService.Login(string email, string password)
    {
        throw new NotImplementedException();
    }

    Client IService.RegisterClient(string email, string password, string firsname, string lastname)
    {
        throw new NotImplementedException();
    }

    Worker IService.RegisterWorker(string email, string password, string firsname, string lastname, double ratebase)
    {
        throw new NotImplementedException();
    }

    bool IService.RemoveCategory(string email, string name)
    {
        throw new NotImplementedException();
    }

    bool IService.RemoveCertificate(string email, string name)
    {
        throw new NotImplementedException();
    }
}
