
using System;
using android.app;
using android.widget;
using android.os;

namespace com.koushikdutta.helloworld
{
    public class onClickListener : java.lang.Object, android.view.View.OnClickListener
    {
        #region OnClickListener implementation
        void android.view.View.OnClickListener.onClick (android.view.View arg0)
        {
            onClick(arg0);
        }
        #endregion
        public delegate void onClickHandler (android.view.View arg0);
        
        public onClickHandler onClick;
    }
    
	public class HelloWorldActivity : Activity, android.view.View.OnClickListener
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
			
            int i = 0;
            b = new Button(this);
            b.setText((java.lang.String)"wtf");
            layout.addView(b);
            b.setOnClickListener(new onClickListener()
            {
                onClick = (v) => 
                {
                    Console.WriteLine("Hello");
                }
            }
            );
            
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
        
        Button b;
        
        #region OnClickListener implementation
        public void onClick (android.view.View arg0)
        {
            b.setText((java.lang.String)System.Environment.TickCount.ToString());
        }
        #endregion
    }
}
