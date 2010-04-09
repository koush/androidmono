package com.koushikdutta.monojavabridge;

import java.io.File;
import java.io.IOException;

public class MonoBridge {
	static 
	{
		try {
			System.load(new File("libmonojavabridge.so").getCanonicalPath());
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	public static void prelink(Class clazz)
	{
		prelink(clazz.getCanonicalName());
	}
	
	static native void prelink(String className);
}
