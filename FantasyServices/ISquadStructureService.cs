using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FantasyServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISquadStructureService" in both code and config file together.
    [ServiceContract]
    public interface ISquadStructureService
    {
        [OperationContract]
        bool UpdateSquadStructure(string obj, string id);
        [OperationContract]
        string ReadSquadStructure(string ID);
    }
}
