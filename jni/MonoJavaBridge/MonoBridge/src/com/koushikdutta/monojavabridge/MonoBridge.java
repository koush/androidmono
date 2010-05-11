package com.koushikdutta.monojavabridge;

import java.io.File;
import java.io.IOException;

public class MonoBridge {
	static 
	{
		if (System.getenv("LD_LIBRARY_PATH").contains("/system/lib"))
		{
			System.load("/data/data/com.koushikdutta.mono/libmono.so");
		}
		else
		{
			try 
			{
				System.load(new File("libmonojavabridge.so").getCanonicalPath());
			} 
			catch (IOException e) {
				e.printStackTrace();
			}
		}
	}

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
	public static native void link(Class clazz, String methodName, String methodSignature);
	public static native void loadAssembly(String assemblyName);
}
