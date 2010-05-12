
using System;
using android.app;
using android.widget;
using android.os;

namespace com.koushikdutta.helloworld
{
    [global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class HelloWorldActivity : Activity
	{
        #region Gross Boilerplate
        internal new static global::java.lang.Class staticClass; 
        static HelloWorldActivity() 
        { 
            global::net.sf.jni4net.utils.Registry.RegisterType(typeof(HelloWorldActivity), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
        } 
        protected HelloWorldActivity(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
        { 
        } 
        private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
        { 
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
            { 
                return new HelloWorldActivity(@__env); 
            } 
        } 
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
        {
            staticClass = @__class;
        }
        #endregion
		protected override void onCreate (Bundle arg0)
		{
            Console.WriteLine("oh yeah, I'm here.");
			base.onCreate (arg0);
		
            LinearLayout layout = new LinearLayout(this);
            layout.setOrientation(LinearLayout.VERTICAL);

            TextView tv = new TextView(this);
            tv.setText((java.lang.String)"Hello");
            tv.setTextSize(20);
            layout.addView(tv);
            
            tv = new TextView(this);
            tv.setText((java.lang.String)"I");
            tv.setTextSize(15);
            tv.setTextColor(unchecked((int)0xFF00FFFF));
            layout.addView(tv);
            
            tv = new TextView(this);
            tv.setText((java.lang.String)"am shocked");
            layout.addView(tv);
            
            tv = new TextView(this);
            tv.setText((java.lang.String)"this even works.");
            layout.addView(tv);
			
			setContentView(layout);
		}
	}
}
