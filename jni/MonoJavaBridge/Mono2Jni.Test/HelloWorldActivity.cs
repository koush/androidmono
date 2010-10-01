using System;
using android.app;
using android.widget;
using android.os;
using com.koushikdutta.monojavabridge.android;
using android.content.res;
using android.content;

namespace com.koushikdutta.helloworld
{
    public class HelloWorldActivity : Activity
    {
        #region Gross Boilerplate
        protected HelloWorldActivity(global::net.sf.jni4net.jni.JNIEnv @__env)
            : base(@__env)
        {
        }
        #endregion
        Button button;
        protected override void onCreate(Bundle arg0)
        {
            base.onCreate(arg0);

            LinearLayout layout = new LinearLayout(this);
            layout.setOrientation(LinearLayout.VERTICAL);

            TextView tv = new TextView(this);
            tv.setText("Hello");
            tv.setTextSize(20);
            layout.addView(tv);

            tv = new TextView(this);
            tv.setText("World!");
            tv.setTextSize(15);
            tv.setTextColor(unchecked((int)0xFF00FFFF));
            layout.addView(tv);

            button = new Button(this);
            button.setText("wtf");
            layout.addView(button);
            button.setOnClickListener(new OnClickListener()
            {
                OnClick = (v) =>
                {
                    Console.WriteLine(toString());
                    button.setText(System.Environment.TickCount.ToString());
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

        public override Resources.Theme getTheme()
        {
            return base.getTheme();
        }

        public override void onLowMemory()
        {
            base.onLowMemory();
        }

        public virtual void onCreate(string hello)
        {

        }

        public class MemoryCallback : ComponentCallbacks
        {

            #region ComponentCallbacks Members

            public void onConfigurationChanged(Configuration arg0)
            {
                
            }

            public void onLowMemory()
            {
                
            }

            #endregion
        }
    }
}
