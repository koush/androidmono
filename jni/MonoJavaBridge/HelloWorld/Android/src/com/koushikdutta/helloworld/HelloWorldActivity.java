package com.koushikdutta.helloworld;

import android.app.Activity;
import android.os.Bundle;

import com.koushikdutta.monojavabridge.MonoBridge;

public class HelloWorldActivity extends Activity
{
	static
	{
		MonoBridge.prelink(HelloWorldActivity.class);
	}
	
	@Override
	protected native void onCreate(Bundle savedInstanceState);
}
