using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace FantasyServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAdminService" in both code and config file together.
    [ServiceContract]
    public interface IAdminService
    {
        [OperationContract]
        bool IsValid(string user, string password);
        [OperationContract]
        bool CreateAdmin(string obj);
        [OperationContract]
        bool UpdateAdmin(string obj, string email);
        [OperationContract]
        bool DeleteAdmin(string email);
        [OperationContract]
        string ReadAdmin(string email);
        [OperationContract]
        List<string> ReadAllAdmins();
    }
}
