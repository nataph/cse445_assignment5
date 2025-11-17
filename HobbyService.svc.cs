using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace assignment_5
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HobbyService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select HobbyService.svc or HobbyService.svc.cs at the Solution Explorer and start debugging.
    public class HobbyService : IHobbyService
    {
       public string WordCharacters(String word)
        {
            if (word == null)
            {
                return "Please enter a hobby"; 
            }

            string Hobby = word.Trim(); 
            int len = Hobby.Length;

            string size;
            if (len <= 5)
            {
                size = "short";
            }
            else if (len <= 10)
            {
                size = "medium"; 
            }
            else
            {
                size = "long"; 
            }
                return size;
        }
    }
}
