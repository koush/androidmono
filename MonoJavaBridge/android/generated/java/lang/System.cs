namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class System : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal System(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static void exit(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.System._m0.native == global::System.IntPtr.Zero)
				global::java.lang.System._m0 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "exit", "(I)V");
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static void runFinalizersOnExit(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.System._m1.native == global::System.IntPtr.Zero)
				global::java.lang.System._m1 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "runFinalizersOnExit", "(Z)V");
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.lang.String setProperty(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.System._m2.native == global::System.IntPtr.Zero)
				global::java.lang.System._m2 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::java.lang.String getProperty(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.System._m3.native == global::System.IntPtr.Zero)
				global::java.lang.System._m3 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "getProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static global::java.lang.String getProperty(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.System._m4.native == global::System.IntPtr.Zero)
				global::java.lang.System._m4 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static int identityHashCode(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.System._m5.native == global::System.IntPtr.Zero)
				global::java.lang.System._m5 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "identityHashCode", "(Ljava/lang/Object;)I");
			return @__env.CallStaticIntMethod(java.lang.System.staticClass, global::java.lang.System._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static long currentTimeMillis()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.System._m6.native == global::System.IntPtr.Zero)
				global::java.lang.System._m6 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "currentTimeMillis", "()J");
			return @__env.CallStaticLongMethod(java.lang.System.staticClass, global::java.lang.System._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static long nanoTime()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.System._m7.native == global::System.IntPtr.Zero)
				global::java.lang.System._m7 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "nanoTime", "()J");
			return @__env.CallStaticLongMethod(java.lang.System.staticClass, global::java.lang.System._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static void arraycopy(java.lang.Object arg0, int arg1, java.lang.Object arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.System._m8.native == global::System.IntPtr.Zero)
				global::java.lang.System._m8 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "arraycopy", "(Ljava/lang/Object;ILjava/lang/Object;II)V");
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public static global::java.lang.SecurityManager SecurityManager
		{
			get
			{
				return getSecurityManager();
			}
			set
			{
				setSecurityManager(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static global::java.lang.SecurityManager getSecurityManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.System._m9.native == global::System.IntPtr.Zero)
				global::java.lang.System._m9 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "getSecurityManager", "()Ljava/lang/SecurityManager;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._m9)) as java.lang.SecurityManager;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static void loadLibrary(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.System._m10.native == global::System.IntPtr.Zero)
				global::java.lang.System._m10 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "loadLibrary", "(Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static global::java.lang.String mapLibraryName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.System._m11.native == global::System.IntPtr.Zero)
				global::java.lang.System._m11 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "mapLibraryName", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static void load(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.System._m12.native == global::System.IntPtr.Zero)
				global::java.lang.System._m12 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "load", "(Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.io.InputStream In
		{
			set
			{
				setIn(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static void setIn(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.System._m13.native == global::System.IntPtr.Zero)
				global::java.lang.System._m13 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "setIn", "(Ljava/io/InputStream;)V");
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.io.PrintStream Out
		{
			set
			{
				setOut(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static void setOut(java.io.PrintStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.System._m14.native == global::System.IntPtr.Zero)
				global::java.lang.System._m14 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "setOut", "(Ljava/io/PrintStream;)V");
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.io.PrintStream Err
		{
			set
			{
				setErr(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static void setErr(java.io.PrintStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.System._m15.native == global::System.IntPtr.Zero)
				global::java.lang.System._m15 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "setErr", "(Ljava/io/PrintStream;)V");
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public static global::java.nio.channels.Channel inheritedChannel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.System._m16.native == global::System.IntPtr.Zero)
				global::java.lang.System._m16 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "inheritedChannel", "()Ljava/nio/channels/Channel;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.nio.channels.Channel>(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._m16)) as java.nio.channels.Channel;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public static void setSecurityManager(java.lang.SecurityManager arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.System._m17.native == global::System.IntPtr.Zero)
				global::java.lang.System._m17 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "setSecurityManager", "(Ljava/lang/SecurityManager;)V");
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.util.Properties Properties
		{
			get
			{
				return getProperties();
			}
			set
			{
				setProperties(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public static global::java.util.Properties getProperties()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.System._m18.native == global::System.IntPtr.Zero)
				global::java.lang.System._m18 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "getProperties", "()Ljava/util/Properties;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._m18)) as java.util.Properties;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public static void setProperties(java.util.Properties arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.System._m19.native == global::System.IntPtr.Zero)
				global::java.lang.System._m19 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "setProperties", "(Ljava/util/Properties;)V");
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public static global::java.lang.String clearProperty(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.System._m20.native == global::System.IntPtr.Zero)
				global::java.lang.System._m20 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "clearProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public static global::java.lang.String getenv(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.System._m21.native == global::System.IntPtr.Zero)
				global::java.lang.System._m21 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "getenv", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		public static global::java.util.Map env
		{
			get
			{
				return getenv();
			}
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public static global::java.util.Map getenv()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.System._m22.native == global::System.IntPtr.Zero)
				global::java.lang.System._m22 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "getenv", "()Ljava/util/Map;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._m22)) as java.util.Map;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public static void gc()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.System._m23.native == global::System.IntPtr.Zero)
				global::java.lang.System._m23 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "gc", "()V");
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._m23);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public static void runFinalization()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.System._m24.native == global::System.IntPtr.Zero)
				global::java.lang.System._m24 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "runFinalization", "()V");
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._m24);
		}
		internal static global::MonoJavaBridge.FieldId _in6387;
		public static global::java.io.InputStream @in
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.lang.System.staticClass, _in6387)) as java.io.InputStream;
			}
		}
		internal static global::MonoJavaBridge.FieldId _out6388;
		public static global::java.io.PrintStream @out
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.lang.System.staticClass, _out6388)) as java.io.PrintStream;
			}
		}
		internal static global::MonoJavaBridge.FieldId _err6389;
		public static global::java.io.PrintStream err
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.lang.System.staticClass, _err6389)) as java.io.PrintStream;
			}
		}
		static System()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.System.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/System"));
			global::java.lang.System._in6387 = @__env.GetStaticFieldIDNoThrow(global::java.lang.System.staticClass, "@in", "Ljava/io/InputStream;");
			global::java.lang.System._out6388 = @__env.GetStaticFieldIDNoThrow(global::java.lang.System.staticClass, "@out", "Ljava/io/PrintStream;");
			global::java.lang.System._err6389 = @__env.GetStaticFieldIDNoThrow(global::java.lang.System.staticClass, "err", "Ljava/io/PrintStream;");
		}
	}
}
