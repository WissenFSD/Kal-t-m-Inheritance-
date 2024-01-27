namespace Inheritance_Ctor_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass c = new DerivedClass("Foo");


            Console.WriteLine(c.Name);

            Console.ReadLine();
        }
    }
}