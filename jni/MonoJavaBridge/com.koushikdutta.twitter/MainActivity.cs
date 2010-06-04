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
using com.koushikdutta.monojavabridge;
using MonoJavaBridge;

namespace com.koushikdutta.twitter
{
    public class MainActivity : Activity, java.lang.Runnable, View.OnClickListener
    {
        string result;
        
        Handler mHandler = new Handler ();
        public void onClick (android.view.View arg0)
        {
            Thread t = new Thread (() =>
            {
                try {
                    MonoJavaBridge.JavaBridge.Log("1");
                    HttpWebRequest req = WebRequest.Create ("http://api.twitter.com/1/statuses/home_timeline.json") as HttpWebRequest;
                    MonoJavaBridge.JavaBridge.Log("2");
                    req.Credentials = new NetworkCredential ("herrodere", "foobar");
                    var resp = req.GetResponse ();
                    var respStream = resp.GetResponseStream ();
                    byte[] b = new byte[100];
                    respStream.Read (b, 0, b.Length);
                    var text = new System.IO.StreamReader (respStream).ReadToEnd ();
                    Console.WriteLine (text);
                    result = text;
                    MonoJavaBridge.JavaBridge.Log("done");
                    mHandler.post(this);
                    JNIEnv.defaultVM.DetachCurrentThread();
                } catch (Exception ex) {
                    Console.WriteLine (ex.Message);
                }
            });
            t.Start ();
        }
        
        Button btn2;
        TextView tv;
        protected override void onCreate (android.os.Bundle arg0)
        {
            base.onCreate (arg0);
            
            LinearLayout layout = new LinearLayout (this);
            layout.setOrientation (LinearLayout.VERTICAL);
            Button btn = new Button (this);
            btn.setOnClickListener (this);
            btn.setText ("threaD");
            layout.addView (btn);
            
            btn2 = new Button (this);
            btn2.setText ("debug");
            btn2.setOnClickListener (new com.koushikdutta.monojavabridge.android.OnClickListener { OnClick = v =>
            {
                Console.WriteLine ("Foobar");
            } });
            layout.addView (btn2);
            
            tv = new TextView(this);
            layout.addView(tv);
            setContentView (layout);
            
        }

        // This constructor is a requirement for all CLR classes that inherit from java.lang.Object
        protected MainActivity (net.sf.jni4net.jni.JNIEnv env) : base(env)
        {
        }

        public void run ()
        {
            tv.setText(result);
        }
    }
}

