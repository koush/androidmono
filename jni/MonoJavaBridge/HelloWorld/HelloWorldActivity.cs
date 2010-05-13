
using System;
using android.app;
using android.widget;
using android.os;

namespace com.koushikdutta.helloworld
{
	public class HelloWorldActivity : Activity
	{
        #region Gross Boilerplate
        protected HelloWorldActivity(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
        { 
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
