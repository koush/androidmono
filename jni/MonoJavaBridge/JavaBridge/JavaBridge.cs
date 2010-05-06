using System;
using System.Runtime.InteropServices;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

using net.sf.jni4net;
using net.sf.jni4net.jni;
using net.sf.jni4net.utils;

namespace com.koushikdutta.monojavabridge.test
{
	public class BridgeTest
	{
	}
}

namespace MonoJavaBridge
{

	public class JavaBridge
	{
		static JavaVM myVM;
		static JavaBridge()
		{
		}
		
		static void Initialize(IntPtr vm)
		{
			Console.WriteLine("Mono initialized.");
			myVM = new JavaVM(vm);
			var env = Bridge.SetJVM(myVM);
			
			Registry.RegisterType(typeof(java.lang.reflect.Method), true, env);
			var clazz = env.FindClass("com/koushikdutta/monojavabridge/test/BridgeTest");
			var method = clazz.getMethod("foo", null);
			method.invoke(null, null);
			string thing = method.getName();
			Bridge.Setup.VeryVerbose = true;
			Bridge.Setup.Verbose = true;
			Registry.RegisterType(typeof(com.koushikdutta.monojavabridge.test.BridgeTest), true, env);
			Bridge.Setup.VeryVerbose = false;
			Bridge.Setup.Verbose = false;

			java.lang.Class._class.getDeclaredMethods();
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		extern static object mono_pointer_to_object(IntPtr ptr);
		
		[MethodImpl(MethodImplOptions.InternalCall)]
		extern static IntPtr mono_object_to_pointer(Object o);
		
		public static void Prelink(IntPtr className)
		{
			Console.WriteLine("Prelinking!");
		}
	}
}
