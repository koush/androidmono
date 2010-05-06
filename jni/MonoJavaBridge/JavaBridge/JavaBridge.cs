using System;
using System.Runtime.InteropServices;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

using net.sf.jni4net;
using net.sf.jni4net.jni;
using net.sf.jni4net.utils;

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
			Bridge.Setup.BindStatic = false;
			Bridge.Setup.BindCLRTypes = false;
			JNIEnv env;
			JNIResult res = myVM.GetEnv(out env, JNI.JNI_VERSION_1_4);
			Console.WriteLine(res);
			
			Registry.Initialize();
			Console.WriteLine(java.lang.Class._class.FullName);
			
			Registry.RegisterType(typeof(java.lang.reflect.Method), true, env);
			                      
			var clazz = java.lang.Class._class;
			Console.WriteLine(clazz.getCanonicalName());
			foreach(var m in java.lang.Class._class.getDeclaredMethods())
			{
				Console.WriteLine(m.getName());
			}
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
