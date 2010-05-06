
using System;
using android.app;
using android.widget;
using android.os;

namespace com.koushikdutta.helloworld
{
	public class HelloWorld : Activity
	{
		protected override void onCreate (Bundle arg0)
		{
			base.onCreate (arg0);
			
			TextView tv = new TextView(this);
			tv.setText((java.lang.String)"Hello");
			
			setContentView(tv);
		}
	}
}
