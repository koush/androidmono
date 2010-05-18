using System;
using android.app;
using android.widget;
using android.os;
using com.koushikdutta.monojavabridge.android;

namespace com.koushikdutta.helloworld
{
	public class HelloWorldActivity : Activity
	{
        #region Gross Boilerplate
        protected HelloWorldActivity(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
        { 
        } 
        #endregion
        Button button;
		protected override void onCreate (Bundle arg0)
		{
			base.onCreate (arg0);
		
            LinearLayout layout = new LinearLayout(this);
            layout.setOrientation(LinearLayout.VERTICAL);

            TextView tv = new TextView(this);
            tv.setText((java.lang.String)"Hello");
            tv.setTextSize(20);
            layout.addView(tv);
            
            tv = new TextView(this);
            tv.setText((java.lang.String)"World!");
            tv.setTextSize(15);
            tv.setTextColor(unchecked((int)0xFF00FFFF));
            layout.addView(tv);

            Console.WriteLine("adding button");
            net.sf.jni4net.Bridge.Setup.VeryVerbose = true;
            //var good = new com.koushikdutta.monojavabridge.android.OnClickListener();
            button = new Button(this);
            button.setText((java.lang.String)"wtf");
            layout.addView(button);
			button.setOnClickListener(new OnClickListener()
            {
                OnClick = (v) =>
                {
                    button.setText((java.lang.String)System.Environment.TickCount.ToString());
                }
            });
            /* 
             * Normally in Java, you'd handle the onClickListener with an inner class.
             * In C# there is no inner class construct.
            button.setOnClickListener(new OnClickListener()
            {
                @Override
                public void onClick()
                {
                }
            });
            */
            
			setContentView(layout);
		}
    }
}
