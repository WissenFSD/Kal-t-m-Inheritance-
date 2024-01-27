using System.Linq.Expressions;

namespace Inheritance_Ornek3_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TeamLeader leader = new TeamLeader() {

                Age = 35,
                City = "Erzincan",
                Department = "Sales",
                Name = "Özhan",
                Surname = "Özbek",
                TeamSize = 10,
                University = "YTÜ"
            };

            GetPerson(leader);
        }
        static void GetPerson(Person p)
        {
            //Console.WriteLine(p.Name);
            //Console.WriteLine(p.Surname); 
            //Console.WriteLine(p.City);
            //Console.WriteLine(p.University);
            //Reflection konusu daha sonra göreceğiz(tüm property ve tüm valueleri ekrana yazdırdık)
            foreach (var item in p.GetType().GetProperties())
            {
                var value = item.GetValue(p);
                Console.WriteLine("{0}:{1}",item.Name,value);
            }


        }

    }
}