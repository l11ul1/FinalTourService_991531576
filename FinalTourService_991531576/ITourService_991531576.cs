using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FinalTourService_991531576
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITourService_991531576" in both code and config file together.
    [ServiceContract]
    public interface AuthenticationUser
    {
        [OperationContract]
        string Validate(string username, string pass);
    }

    [ServiceContract]
    public interface DBOperations
    {
        [OperationContract]
        string InsertATour(TourInfo tour);

        [OperationContract]
        List<TourInfo> RetrieveTourInfo();
    }
}
