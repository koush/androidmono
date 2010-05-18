using System;
using System.Reflection;

namespace HelloWorldReflector
{
    class MainClass
    {
        public static void Main (string[] args)
        {
            var ass = Assembly.Load("android");
            var t = ass.GetType("com.koushikdutta.monojavabridge.android.OnClickListener");
            Console.WriteLine(t);
            var mm = t.GetMethod("android.view.View.OnClickListener.onClick", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly | BindingFlags.Instance);
            foreach (var m in t.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly | BindingFlags.Instance))
            {
                Console.WriteLine(m);
            }
        }
    }
}
