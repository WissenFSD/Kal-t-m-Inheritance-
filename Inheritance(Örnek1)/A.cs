using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Örnek1_
{
    public class A
    {
        public string AProp { get; set; }
    }
    public class B
    {
        public string BProp { get; set; }
    }


    // Bir sınıf ancak tek bir sınıfı kalıtım olarak alabilir.

    //public class ChildClass :A,B
    //{

    //}
    // Bir sınıf tek bir sınıftan kalıtım alabilir. ancak istediği kadar interface implement edebilir.
    
    public class ChildClass : A, IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
