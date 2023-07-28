using System;
using System.Reflection;
  
namespace Reflection_Demo {
     
class Program {
    static void Main(string[] args)
    {
        // Initialise t as typeof string
        Type t = typeof(string);
		//Type t=Type.GetType("Reflection_Demo.Program");
        Console.WriteLine("Name : {0}", t.Name);
        Console.WriteLine("Full Name : {0}", t.FullName);
        Console.WriteLine("Namespace : {0}", t.Namespace);
        Console.WriteLine("Base Type : {0}", t.BaseType);
    }
}
}