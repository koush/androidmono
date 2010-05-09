using System;
using System.Runtime.InteropServices;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

using net.sf.jni4net;
using net.sf.jni4net.jni;
using net.sf.jni4net.utils;

using System.IO;
using System.Text;

using System.Collections.Generic;

namespace com.koushikdutta.monojavabridge.test
{
	public class BridgeTest
	{
	}
}

namespace MonoJavaBridge
{
	public class LogWriter : TextWriter
	{
		public override Encoding Encoding {
			get {
				return Encoding.ASCII;
			}
		}

		StringBuilder buffer = new StringBuilder();
		public override void Write (char value)
		{
			if (value == '\n')
			{
				JavaBridge.Log(buffer.ToString());
				buffer = new StringBuilder();
			}
			else
			{
				buffer.Append(value);
			}
		}
	}
	
	public class JavaBridge
	{
		public static void Log(string format, params object[] args)
		{
			string s = String.Format(format, args);
			IntPtr p = Marshal.StringToHGlobalAnsi(s);
			log(p);
			Marshal.FreeHGlobal(p);
		}
		
		static JavaVM myVM;
		static JavaBridge()
		{
		}
		
		static JNIEnv GetEnv() 
		{
			return JNIEnv.GetEnvForVm(myVM);
		}
		
		static void Initialize(IntPtr vm)
		{
			Log("Setting logwriter");
			Console.SetOut(new LogWriter());
			Console.WriteLine("Testing logwriter");
				
			Log("Mono initialized.");
				
			myVM = new JavaVM(vm);
			Log("Setting JVM");
			Bridge.SetJVM(myVM);
            Bridge.Setup.VeryVerbose = Bridge.Setup.Verbose = true;
			var env = JNIEnv.GetEnvForVm(myVM);
			Registry.Initialize();
			Registry.RegisterType(typeof(java.lang.reflect.Method), true, env);
		}
		
		static List<string> myAssemblies = new List<string>();

		static void LoadAssembly(IntPtr assemblyNamePtr)
		{
			String assemblyName = GetEnv().ConvertToString(assemblyNamePtr);
			Console.WriteLine("Loading Assembly: {0}", assemblyName);
			var assembly = Assembly.LoadFile(assemblyName);
			if (assembly != null)
				myAssemblies.Add(assembly.FullName);
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		extern static void log(IntPtr p);

		[MethodImpl(MethodImplOptions.InternalCall)]
		extern static object mono_pointer_to_object(IntPtr ptr);
		
		[MethodImpl(MethodImplOptions.InternalCall)]
		extern static IntPtr mono_object_to_pointer(Object o);
		
		public static void Prelink(Type type)
		{
			Log("Prelinking: {0}", type);
		}

		public static void Prelink(IntPtr className)
		{
			JNIEnv env = JNIEnv.GetEnvForVm(myVM);
			string classNameString = env.ConvertToString(className);
			Log("Linking: {0}", classNameString);
			var clazz = env.FindClass(classNameString.Replace('.', '/'));
			Type type = null;
			foreach (string assembly in myAssemblies)
			{
				type = Type.GetType(classNameString + "," + assembly);
				if (type != null)
					break;
			}
			if (clazz == null)
				Console.WriteLine("Could not find java class.");
			else
				Console.WriteLine("Found java class: {0}", clazz);
			if (type == null)
				Console.WriteLine("Could not find clr type.");
			else
				Console.WriteLine("Found clr type: {0}", type);
            
            android.util.Log.i("HelloMono", "Hello from Mono Interop!");
            //int i = android.widget.LinearLayout.VERTICAL;
			
			//env.RegisterNatives(clazz, JNINativeMethod
			
			//env.RegisterNatives(
			
			//Log("Finding foo");
			//var method = clazz.getMethod("foo", null);
			//Log("Invoking foo");
			//method.invoke(null, null);

			//Log("Getting declared methods");
			//java.lang.Class._class.getDeclaredMethods();

			/*
			JniLocalHandle handle = new JniLocalHandle();
			handle.handle = className;
			
			*/
			//Log("Prelinking!");
		}
	}
}
