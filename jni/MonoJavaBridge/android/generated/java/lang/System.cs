namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class System : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static System()
		{
			InitJNI();
		}
		internal System(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _exit20665;
		public static void exit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._exit20665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _runFinalizersOnExit20666;
		public static void runFinalizersOnExit(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._runFinalizersOnExit20666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setProperty20667;
		public static global::java.lang.String setProperty(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._setProperty20667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getProperty20668;
		public static global::java.lang.String getProperty(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._getProperty20668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getProperty20669;
		public static global::java.lang.String getProperty(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._getProperty20669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _identityHashCode20670;
		public static int identityHashCode(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.System.staticClass, global::java.lang.System._identityHashCode20670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _currentTimeMillis20671;
		public static long currentTimeMillis() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.System.staticClass, global::java.lang.System._currentTimeMillis20671);
		}
		internal static global::MonoJavaBridge.MethodId _nanoTime20672;
		public static long nanoTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.System.staticClass, global::java.lang.System._nanoTime20672);
		}
		internal static global::MonoJavaBridge.MethodId _arraycopy20673;
		public static void arraycopy(java.lang.Object arg0, int arg1, java.lang.Object arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._arraycopy20673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
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
		internal static global::MonoJavaBridge.MethodId _getSecurityManager20674;
		public static global::java.lang.SecurityManager getSecurityManager() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._getSecurityManager20674)) as java.lang.SecurityManager;
		}
		internal static global::MonoJavaBridge.MethodId _loadLibrary20675;
		public static void loadLibrary(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._loadLibrary20675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _mapLibraryName20676;
		public static global::java.lang.String mapLibraryName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._mapLibraryName20676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _load20677;
		public static void load(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._load20677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIn20678;
		public static void setIn(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._setIn20678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOut20679;
		public static void setOut(java.io.PrintStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._setOut20679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setErr20680;
		public static void setErr(java.io.PrintStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._setErr20680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _inheritedChannel20681;
		public static global::java.nio.channels.Channel inheritedChannel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.nio.channels.Channel>(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._inheritedChannel20681)) as java.nio.channels.Channel;
		}
		internal static global::MonoJavaBridge.MethodId _setSecurityManager20682;
		public static void setSecurityManager(java.lang.SecurityManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._setSecurityManager20682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getProperties20683;
		public static global::java.util.Properties getProperties() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._getProperties20683)) as java.util.Properties;
		}
		internal static global::MonoJavaBridge.MethodId _setProperties20684;
		public static void setProperties(java.util.Properties arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._setProperties20684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearProperty20685;
		public static global::java.lang.String clearProperty(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._clearProperty20685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getenv20686;
		public static global::java.lang.String getenv(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._getenv20686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		public static global::java.util.Map env
		{
			get
			{
				return getenv();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getenv20687;
		public static global::java.util.Map getenv() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._getenv20687)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _gc20688;
		public static void gc() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._gc20688);
		}
		internal static global::MonoJavaBridge.MethodId _runFinalization20689;
		public static void runFinalization() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._runFinalization20689);
		}
		internal static global::MonoJavaBridge.FieldId _in20690;
		public static global::java.io.InputStream @in
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.lang.System.staticClass, _in20690)) as java.io.InputStream;
			}
		}
		internal static global::MonoJavaBridge.FieldId _out20691;
		public static global::java.io.PrintStream @out
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.lang.System.staticClass, _out20691)) as java.io.PrintStream;
			}
		}
		internal static global::MonoJavaBridge.FieldId _err20692;
		public static global::java.io.PrintStream err
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.lang.System.staticClass, _err20692)) as java.io.PrintStream;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.System.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/System"));
			global::java.lang.System._exit20665 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "exit", "(I)V");
			global::java.lang.System._runFinalizersOnExit20666 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "runFinalizersOnExit", "(Z)V");
			global::java.lang.System._setProperty20667 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::java.lang.System._getProperty20668 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "getProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::java.lang.System._getProperty20669 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.lang.System._identityHashCode20670 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "identityHashCode", "(Ljava/lang/Object;)I");
			global::java.lang.System._currentTimeMillis20671 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "currentTimeMillis", "()J");
			global::java.lang.System._nanoTime20672 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "nanoTime", "()J");
			global::java.lang.System._arraycopy20673 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "arraycopy", "(Ljava/lang/Object;ILjava/lang/Object;II)V");
			global::java.lang.System._getSecurityManager20674 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "getSecurityManager", "()Ljava/lang/SecurityManager;");
			global::java.lang.System._loadLibrary20675 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "loadLibrary", "(Ljava/lang/String;)V");
			global::java.lang.System._mapLibraryName20676 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "mapLibraryName", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.lang.System._load20677 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "load", "(Ljava/lang/String;)V");
			global::java.lang.System._setIn20678 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "setIn", "(Ljava/io/InputStream;)V");
			global::java.lang.System._setOut20679 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "setOut", "(Ljava/io/PrintStream;)V");
			global::java.lang.System._setErr20680 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "setErr", "(Ljava/io/PrintStream;)V");
			global::java.lang.System._inheritedChannel20681 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "inheritedChannel", "()Ljava/nio/channels/Channel;");
			global::java.lang.System._setSecurityManager20682 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "setSecurityManager", "(Ljava/lang/SecurityManager;)V");
			global::java.lang.System._getProperties20683 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "getProperties", "()Ljava/util/Properties;");
			global::java.lang.System._setProperties20684 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "setProperties", "(Ljava/util/Properties;)V");
			global::java.lang.System._clearProperty20685 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "clearProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.lang.System._getenv20686 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "getenv", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.lang.System._getenv20687 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "getenv", "()Ljava/util/Map;");
			global::java.lang.System._gc20688 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "gc", "()V");
			global::java.lang.System._runFinalization20689 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "runFinalization", "()V");
			global::java.lang.System._in20690 = @__env.GetStaticFieldIDNoThrow(global::java.lang.System.staticClass, "@in", "Ljava/io/InputStream;");
			global::java.lang.System._out20691 = @__env.GetStaticFieldIDNoThrow(global::java.lang.System.staticClass, "@out", "Ljava/io/PrintStream;");
			global::java.lang.System._err20692 = @__env.GetStaticFieldIDNoThrow(global::java.lang.System.staticClass, "err", "Ljava/io/PrintStream;");
		}
	}
}
