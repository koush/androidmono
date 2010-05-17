using System;
using android.app;
using android.widget;
using android.os;

namespace com.koushikdutta.helloworld
{
	public class HelloWorldActivity : Activity, android.view.View.OnClickListener
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

            b = new Button(this);
            b.setText((java.lang.String)"wtf");
            layout.addView(b);
            b.setOnClickListener(this);
            /* 
             * Normally in Java, you'd handle the onClickListener with an inner class.
             * In C# there is no inner class construct.
            b.setOnClickListener(new OnClickListener()
            {
                @Override
                public void onClick()
                {
                }
            });
            */
            
			setContentView(layout);
		}
        
        #region OnClickListener implementation
        public void onClick (android.view.View arg0)
        {
            button.setText((java.lang.String)System.Environment.TickCount.ToString());
        }
        #endregion
    }
}
