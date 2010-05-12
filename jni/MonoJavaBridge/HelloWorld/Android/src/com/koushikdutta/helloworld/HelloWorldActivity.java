package com.koushikdutta.helloworld;

import android.app.Activity;
import android.os.Bundle;

import com.koushikdutta.monojavabridge.MonoBridge;

public class HelloWorldActivity extends Activity
{
	static
	{
		MonoBridge.link(HelloWorldActivity.class, "onCreate", "(Landroid/os/Bundle;)V", "android.os.Bundle");
		//MonoBridge.link(HelloWorldActivity.class, "_init", "()V", null);
	}
	
	@Override
	protected native void onCreate(Bundle savedInstanceState);
	
	private native void _init();
	
	public HelloWorldActivity()
	{
		super();
		//_init();
	}
}
