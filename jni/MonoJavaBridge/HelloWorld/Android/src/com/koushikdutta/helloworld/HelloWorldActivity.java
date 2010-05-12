package com.koushikdutta.helloworld;

import android.app.Activity;
import android.os.Bundle;

import com.koushikdutta.monojavabridge.MonoBridge;

public class HelloWorldActivity extends Activity
{
	static
	{
		MonoBridge.link(HelloWorldActivity.class, "onCreate", "(Landroid/os/Bundle;)V", "android.os.Bundle");
	}
	
	@Override
	protected native void onCreate(Bundle savedInstanceState);
	
	public HelloWorldActivity()
	{
		super();
	}
}
 