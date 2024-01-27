using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Ctor_
{
    public class MainClass
    {
        public string Name { get; set; }
        public MainClass()
        {
            Name = "Default değer atanmıştır.";
        }
        public MainClass(string name)
        {
            // alt sınıfın ctor'u burayı çağırmaktadır. Bu ctor sayesinde üst sınıf'ta belleğe çıkarken alt sınıftan gelen parametre ile belleğe çıkıyor.
            this.Name=name;
        }
    }
    public class DerivedClass:MainClass
    {
        // Alt sınıf belleğe çıkarken aşağıdaki ctor'u kullanıyor. Ancak alt sınıf bellege çıkarken üst sınıfında çıkması gerekiyor. Bu sebeple alt sınıf'ın ctor'undan üst sınıfın ctor'una bir yönlendirme yapıyoruz
        public DerivedClass(string name):base(name)
        {     // this.Name = name;   
        }
        public DerivedClass()
        {
            Name = "name alanına alt  sınıf tarafından değer atandı";
        }
    }
}
