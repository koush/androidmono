using System;
using android.app;
using android.widget;
using android.os;
using System.Threading;
using net.sf.jni4net.jni;
using net.sf.jni4net.utils;
using System.Xml.Serialization;
using System.Net;
using System.Net.Sockets;
using android.view;

namespace com.koushikdutta.twitter
{
    public static class Narf
    {
        public static void Barf ()
        {
            Console.WriteLine (System.Uri.IsHexDigit ('c'));
            var ff = System.Uri.EscapeUriString ("foobareadaed");
            Console.WriteLine (ff);
            Uri uri = new Uri ("http://www.yahoo.com");
            Console.WriteLine (uri);
            Console.WriteLine (WebRequest.Create (uri));
            
        }
    }


    public class MainActivity : Activity, java.lang.Runnable, android.view.View.OnClickListener
    {
        void DoStuff ()
        {
            Console.WriteLine ("resolving");
            var entry = Dns.Resolve ("api.twitter.com");
            if (entry == null) {
                Console.WriteLine ("Failed");
                return;
            }
            foreach (var addr in entry.AddressList) {
                Console.WriteLine (addr);
            }
        }


        Handler mHandler = new Handler ();
        public void onClick (android.view.View arg0)
        {
            Console.WriteLine ("shitbar");
            Console.WriteLine ("Foo");
            Console.WriteLine (AppDomain.CurrentDomain.SetupInformation.ConfigurationFile == null);
            
            //DoStuff ();
            
            t = new Thread (() =>
            {
                try {
                    DoStuff ();
                    
                    {
                        Console.WriteLine ("aa");
                        HttpWebRequest req = WebRequest.Create ("http://api.twitter.com/1/statuses/home_timeline.json") as HttpWebRequest;
                        Console.WriteLine ("aaa");
                        req.Credentials = new NetworkCredential ("herrodere", "foobar");
                        Console.WriteLine ("a");
                        var resp = req.GetResponse ();
                        Console.WriteLine ("asdsad");
                        var respStream = resp.GetResponseStream ();
                        Console.WriteLine ("shtifuckl");
                        byte[] b = new byte[100];
                        respStream.Read (b, 0, b.Length);
                        Console.WriteLine ("read some stuff>");
                        var text = new System.IO.StreamReader (respStream).ReadToEnd ();
                        Console.WriteLine ("I read it all");
                        Console.WriteLine (text);
                    }
                } catch (Exception ex) {
                    Console.WriteLine (ex.Message);
                }
            });
            t.Start ();
        }

        Thread t = null;
        
        protected override void onCreate (android.os.Bundle arg0)
        {
            base.onCreate (arg0);
            
            LinearLayout layout = new LinearLayout(this);
            layout.setOrientation(LinearLayout.VERTICAL);
            Button btn = new Button (this);
            btn.setOnClickListener (this);
            btn.setText("threaD");
            layout.addView(btn);
            
            var btn2 = new Button(this);
            btn2.setText("debug");
            btn2.setOnClickListener(new com.koushikdutta.monojavabridge.android.OnClickListener()
                                    {
                OnClick = (v) =>
                {
                    Console.WriteLine("Foobar");
                    t.Resume();
                }
            });
            layout.addView(btn2);
            setContentView (layout);
            
        }
            /*
                      
                {
                    Console.WriteLine("aa");
                    HttpWebRequest req = WebRequest.Create("http://api.twitter.com/1/statuses/home_timeline.xml") as HttpWebRequest;
                        Console.WriteLine("aaa");
                    req.Credentials = new NetworkCredential("herrodere", "foobar");
                    Console.WriteLine("a");
                    var text = new System.IO.StreamReader(req.GetResponse().GetResponseStream()).ReadToEnd();
                    Console.WriteLine(text);
                }
                */            
            
        
        // This constructor is a requirement for all CLR classes that inherit from java.lang.Object
                protected MainActivity (net.sf.jni4net.jni.JNIEnv env) : base(env)
        {
        }

        public void run ()
        {
        }
    }
}

