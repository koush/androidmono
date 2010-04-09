using System;
using System.Runtime.InteropServices;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace MonoJavaBridge
{
	public class JavaBridge
	{
		static IntPtr myVM;
		static JavaBridge()
		{
		}
		
		static void Initialize(IntPtr vm)
		{
			Console.WriteLine("Mono initialized.");
			myVM = vm;
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
