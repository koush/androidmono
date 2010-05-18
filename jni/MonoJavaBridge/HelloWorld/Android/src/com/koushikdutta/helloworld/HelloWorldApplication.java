package com.koushikdutta.helloworld;

import android.app.Application;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.utilities.AssetExtractor;

public class HelloWorldApplication extends Application {
	@Override
	public void onCreate() {
		super.onCreate();
		
		AssetExtractor.extractAssets(this, false);
		MonoBridge.loadAssembly("/data/data/com.koushikdutta.mono/android.dll");
		MonoBridge.loadAssembly(AssetExtractor.getAppRoot(this) + "/HelloWorld.dll");
	}
}
