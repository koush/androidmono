package com.koushikdutta.monojavabridge;

import java.io.File;
import java.io.IOException;

import android.util.Log;

public class MonoBridge {
	private final static String LOGTAG = "MonoBridge";
	public static boolean initialize(String debuggerAgentOptions)
	{
		Log.i(LOGTAG, "Initializing Mono...");
		Log.i(LOGTAG, "Debugger Agent Options: " + debuggerAgentOptions);
		if (mInitialized)
			return true;
		
		if (System.getenv("LD_LIBRARY_PATH").contains("/system/lib"))
		{
			try
			{
				System.load("/data/data/com.koushikdutta.mono/libmono.so");
			}
			catch (Exception ex)
			{
				ex.printStackTrace();
				return false;
			}
		}
		else
		{
			try 
			{
				System.load(new File("libmonojavabridge.so").getCanonicalPath());
			} 
			catch (IOException e) {
				e.printStackTrace();
				return false;
			}
		}
		
		try
		{
			return mInitialized = initializeMono(debuggerAgentOptions);
		}
		catch (Exception ex)
		{
			ex.printStackTrace();
			return false;
		}
	}


	private static boolean mInitialized = false;
	private static native boolean initializeMono(String debuggerAgentOptions);

	public static Class getPrimitiveClass(String className)
	{
		if (className.equals("boolean"))
		{
			return boolean.class;
		}
		else if (className.equals("byte"))
		{
			return byte.class;
		}
		else if (className.equals("char"))
		{
			return char.class;
		}
		else if (className.equals("short"))
		{
			return short.class;
		}
		else if (className.equals("int"))
		{
			return int.class;
		}
		else if (className.equals("long"))
		{
			return long.class;
		}
		else if (className.equals("float"))
		{
			return float.class;
		}
		else if (className.equals("double"))
		{
			return double.class;
		}
		else if (className.equals("void"))
		{
			return void.class;
		}

		return null;
	}
	
	@SuppressWarnings("unchecked")
	public static native void link(Class clazz, String methodName, String methodSignature, String methodParameters);
	public static native void loadAssembly(String assemblyName);
}
