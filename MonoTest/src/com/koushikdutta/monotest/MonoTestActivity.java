package com.koushikdutta.monotest;

import com.koushikdutta.monodalvikbridge.MonoBridge;
import com.koushikdutta.monodalvikbridge.MonoObject;

import android.app.Activity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;

public class MonoTestActivity extends Activity {
    /** Called when the activity is first created. */
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.main);
    }


	MenuItem mTestItem;
	MenuItem mInvokeItem;
	@Override
	public boolean onCreateOptionsMenu(Menu menu)
	{
		mTestItem = menu.add("Test");
		mInvokeItem = menu.add("Invoke");
		return super.onCreateOptionsMenu(menu);
	}

	@Override
	public boolean onMenuItemSelected(int featureId, MenuItem item)
	{
		if (item == mTestItem)
		{
			MonoBridge.Initialize();
		}
		else if (item == mInvokeItem)
		{
			try
			{
				//String ret = (String)MonoBridge.invoke("MonoDalvikBridge.DalvikBridge, MonoDalvikBridge", String.class, "Echo", "hello");
				//Log.i(LOGTAG, String.format("MonoActivity %s", ret == null ? "null" : ret));
				
				//MonoObject one = MonoBridge.newMonoObject("MonoDalvikBridge.TestObject, MonoDalvikBridge");
				//MonoObject two = MonoBridge.newMonoObject("MonoDalvikBridge.TestObject, MonoDalvikBridge", "Test");
				
				//one.invoke("Foo");
				//two.invoke("Foo");
				
				MonoObject args = MonoBridge.newMonoObject("System.Object[]", 1); 
				byte[] runtimeTypes = new byte[2];
				runtimeTypes[0] = MonoBridge.String;
				runtimeTypes[1] = MonoBridge.Int32;
				//MonoObject javaClass = (MonoObject)MonoBridge.invoke("System.String", MonoObject.class, "Intern", new Object[] { "com.koushikdutta.monodalvikbridge.MonoBridge" });
				//MonoObject javaMethod = (MonoObject)MonoBridge.invoke("System.String", MonoObject.class, "Intern", new Object[] { "echo" });
				args.invoke(void.class, "SetValue", new Object[] { "boof", 0 }, runtimeTypes);
				MonoBridge.invoke("MonoDalvikBridge.DalvikBridge, MonoDalvikBridge", "Invoke", "com.koushikdutta.monodalvikbridge.MonoBridge", "echo", args);
			}
			catch (Exception e)
			{
				e.printStackTrace();
			}
		}
		return super.onMenuItemSelected(featureId, item);
	}
}