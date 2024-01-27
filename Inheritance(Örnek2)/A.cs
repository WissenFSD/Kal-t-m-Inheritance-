using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Örnek2_
{
    public class A
    {
        public string AProp { get; set; }

       
    }
    public class B : A
    {
        public B()
        {
            AProp = string.Empty;
        }
        public string BProp { get; set; }
    }

    public class Child : B
    {

        // B Sınıfı katılım yolu ile A sınıfındaki tüm öğeleri alabilir.
        // Child Sınıfıda B sınıfındaki tüm öğeleri kalıtım yolu ile alır.


        // Dolayısı ile A sınıfının öğeleri Child sınıfına örnekte olduğu gibi geçmiştir.
        public Child()
        {
            AProp = string.Empty;
            BProp = string.Empty;
        }

    }

}
