using System;

namespace com.koushikdutta.twitter
{
    public static class Program
    {
        public static void Main (string[] args)
        {
            string appNamespace = typeof(Program).Namespace;
            Console.WriteLine ("Starting the application via Activity Manager (am). This process will exit.");
            var arguments = string.Format ("-c 'am start -a android.intent.action.MAIN -n {0}/{0}.MainActivity'", appNamespace);
            var psi = new System.Diagnostics.ProcessStartInfo { Arguments = arguments, FileName = "/system/bin/sh" };
            try {
                var p = System.Diagnostics.Process.Start (psi);
                if (p == null)
                    throw new Exception ("No Process returned.");
                Console.WriteLine ("Activity launched. This process will sleep until terminated by the user. The application's standard output can be viewed in logcat.");
                System.Threading.Thread.Sleep (System.Threading.Timeout.Infinite);
            } catch (Exception ex) {
                Console.WriteLine ("Error starting activity!");
                Console.WriteLine (ex);
                Console.WriteLine (ex.Message);
            }
        }
    }
}

