package com.koushikdutta.helloworld;

import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.util.Enumeration;
import java.util.Vector;
import java.util.zip.ZipEntry;
import java.util.zip.ZipFile;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.utilities.AssetExtractor;

import android.app.Application;
import android.util.Log;

public class HelloWorldApplication extends Application {
	@Override
	public void onCreate() {
		super.onCreate();
		
		AssetExtractor.extractAssets(this, false);
		MonoBridge.loadAssembly("/data/data/com.koushikdutta.mono/android.dll");
		MonoBridge.loadAssembly(AssetExtractor.getAppRoot(this) + "/HelloWorld.dll");
	}
}
