using System;
using android.app;
using android.widget;
using android.os;
using System.Threading;
using net.sf.jni4net.jni;
using net.sf.jni4net.utils;
using System.Xml.Serialization;
using System.Net;


namespace com.koushikdutta.twitter
{
    public class FooRunnable : java.lang.Object, java.lang.Runnable
    {
     #region Runnable implementation
     public void run ()
     {
            Console.WriteLine("Beef Boof");
     }
     
     #endregion
           
    }

    public class MainActivity : Activity, java.lang.Runnable
    {        
        Handler mHandler = new Handler();
        TextView tv;
        string stuff;
        
        protected override void onCreate (android.os.Bundle arg0)
        {
            base.onCreate (arg0);
            tv = new TextView (this);
            tv.setText ("Hello World!");
            setContentView (tv);
            
            
                      
                {
                    Console.WriteLine("aa");
                    HttpWebRequest req = WebRequest.Create("http://api.twitter.com/1/statuses/home_timeline.xml") as HttpWebRequest;
                        Console.WriteLine("aaa");
                    req.Credentials = new NetworkCredential("herrodere", "foobar");
                    Console.WriteLine("a");
                    var text = new System.IO.StreamReader(req.GetResponse().GetResponseStream()).ReadToEnd();
                    Console.WriteLine(text);
                }
                
            
            var thread = new Thread(() =>
            {
                try
                {
                   //var env = JNIEnv.ThreadEnv;
                    
                    
                    {
                        Console.WriteLine("aa");
                        HttpWebRequest req = WebRequest.Create("http://api.twitter.com/1/statuses/home_timeline.json") as HttpWebRequest;
                        Console.WriteLine("aaa");
                        req.Credentials = new NetworkCredential("herrodere", "foobar");
                        Console.WriteLine("a");
                        var resp = req.GetResponse();
                        Console.WriteLine("asdsad");
                        var respStream = resp.GetResponseStream();
                        Console.WriteLine("shtifuckl");
                        byte[] b = new byte[100];
                        respStream.Read(b, 0, b.Length);
                        Console.WriteLine("read some stuff>");
                        var text = new System.IO.StreamReader(respStream).ReadToEnd();
                        Console.WriteLine("I read it all");
                        Console.WriteLine(text);
                    }
                    
                
                Console.WriteLine("About to create WebClient");
                using (WebClient client = new WebClient())
                {
                    Console.WriteLine("WebClient created");
                    client.Credentials = new NetworkCredential("herrodere", "foobar");
                    Console.WriteLine("1");
                    var stream = client.OpenRead("http://api.twitter.com/1/statuses/home_timeline.json");
                    Console.WriteLine("2");
                    var text = new System.IO.StreamReader(stream).ReadToEnd();
                    Console.WriteLine(text);
                    stuff = text;
                    
                    //var serializer = new XmlSerializer(typeof(statuses));
                    //var stats = serializer.Deserialize(stream) as statuses;
                    //Console.WriteLine(stats.status.Length);
                    //foreach (var s in stats.status)
                    //{
                    //    Console.WriteLine("{0}: {1}", s.user, s.text);
                    //}
                }
                
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
                
                Registry.RegisterType(typeof(java.lang.Runnable), true, JNIEnv.ThreadEnv);
                mHandler.post(this);
                JNIEnv.defaultVM.DetachCurrentThread();
                
            });
            thread.Start();
            //thread.Join();
        }

        // This constructor is a requirement for all CLR classes that inherit from java.lang.Object
        protected MainActivity (net.sf.jni4net.jni.JNIEnv env) : base(env)
        {
        }
        
        public void run ()
        {
            tv.setText(stuff);
            Console.WriteLine("Foo");
        }
    }
}

