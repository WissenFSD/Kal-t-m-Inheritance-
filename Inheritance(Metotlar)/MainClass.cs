using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Metotlar_
{
    public class MainClass
    {
        public string MainProp { get; set; }
        public void FirstMethod()
        {

            Console.WriteLine("ben Main class'ının bir metoduyum");
        }
    }

    public class ChildClass:MainClass
    { 
        public ChildClass()
        {
            // Base anahtar kelimesi direk olarak main class'ın öğelerine erişmek için bir kısa yoldur.
            base.MainProp = "base anahtar sözcüğü ile main class'ın bir prop'ına değer atadım";
        }
        public void SecondMethod()
        {
            // base anahtar sözcüğüne ctor ve metot içerisinde kullanabilirsiniz.
        }


        // Override keyword'ü bir üst sınıfa ait metotların davranışlarını değiştirmek için kullanılır.
        // Aşağıda ToString metodunun davranışını değiştirdik.
        // Yani ToString metodu artık eskiden verdiği sonucu vermiyor :)


        // Override konusu Polymorfizm konusunda daha detaylandırılacaktır.
        public override string ToString()
        {
            return "ben chid sınıf için çalışmaktayım";
        }

    } 
}
