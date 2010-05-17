using System;
using System.Reflection;

namespace HelloWorldReflector
{
    class MainClass
    {
        public static void Main (string[] args)
        {
            var ass = Assembly.Load("HelloWorld");
            
            foreach (var t in ass.GetTypes())
            {
                Console.WriteLine(t);
            }
        }
    }
}
