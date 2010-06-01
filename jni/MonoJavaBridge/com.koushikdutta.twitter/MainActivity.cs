using System;
using android.app;
using android.widget;
using android.os;

namespace com.koushikdutta.twitter
{
    public class MainActivity : Activity, java.lang.Runnable
    {
        Handler mHandler = new Handler();
        
        protected override void onCreate (android.os.Bundle arg0)
        {
            base.onCreate (arg0);
            var tv = new TextView (this);
            tv.setText ("Hello World!");
            setContentView (tv);
            
            mHandler.post(this);
        }

        // This constructor is a requirement for all CLR classes that inherit from java.lang.Object
        protected MainActivity (net.sf.jni4net.jni.JNIEnv env) : base(env)
        {
        }
        
        public void run ()
        {
            Console.WriteLine("Foo");
        }
    }
}

