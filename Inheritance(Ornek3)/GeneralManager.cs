using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Ornek3_
{

    public class Person
    {

        public int Age { get; set; }

        public string University { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string City { get; set; }

    }
    public class GeneralManager:Person
    {
        public string SignatureAccess { get; set; }

        public bool BoardMember { get; set; }

    }
    public class Evp:Person
    {
        public string Department { get; set; }

       
    }
    public class TeamLeader:Person {

        public string Department { get; set; }
        public int TeamSize { get; set; }

      


    }
  

}
