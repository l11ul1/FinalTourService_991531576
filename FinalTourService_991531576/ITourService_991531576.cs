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
    public interface ITourService_991531576
    {
        [OperationContract]
        void DoWork();
    }
}
