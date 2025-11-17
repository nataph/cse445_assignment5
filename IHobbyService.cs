using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace assignment_5
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHobbyService" in both code and config file together.
    [ServiceContract]
    public interface IHobbyService
    {
        [OperationContract]
        string WordCharacters(String word); 
    }
}
