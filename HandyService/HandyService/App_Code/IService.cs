using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

[ServiceContract]
public interface IService
{

	[OperationContract]
	Worker RegisterWorker(string email, string password, string firsname, string lastname, double ratebase);
    [OperationContract]
    Client RegisterClient(string email, string password, string firsname, string lastname);
    [OperationContract]
    User Login(string email, string password);
    [OperationContract]
    User Deregister(string email, string password);
    [OperationContract]
    bool AddCertificate(string email,string name, string issuedby);
    [OperationContract]
    bool RemoveCertificate(string email,string name);
    [OperationContract]
    bool AddCategory(string email, string name);
    [OperationContract]
    bool RemoveCategory(string email, string name);


}