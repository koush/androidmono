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
		internal static global::MonoJavaBridge.MethodId _exit15146;
		public static void exit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._exit15146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _runFinalizersOnExit15147;
		public static void runFinalizersOnExit(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._runFinalizersOnExit15147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setProperty15148;
		public static global::java.lang.String setProperty(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._setProperty15148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getProperty15149;
		public static global::java.lang.String getProperty(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._getProperty15149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getProperty15150;
		public static global::java.lang.String getProperty(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._getProperty15150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _identityHashCode15151;
		public static int identityHashCode(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.System.staticClass, global::java.lang.System._identityHashCode15151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _currentTimeMillis15152;
		public static long currentTimeMillis() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.System.staticClass, global::java.lang.System._currentTimeMillis15152);
		}
		internal static global::MonoJavaBridge.MethodId _nanoTime15153;
		public static long nanoTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.System.staticClass, global::java.lang.System._nanoTime15153);
		}
		internal static global::MonoJavaBridge.MethodId _arraycopy15154;
		public static void arraycopy(java.lang.Object arg0, int arg1, java.lang.Object arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._arraycopy15154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
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
		internal static global::MonoJavaBridge.MethodId _getSecurityManager15155;
		public static global::java.lang.SecurityManager getSecurityManager() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._getSecurityManager15155)) as java.lang.SecurityManager;
		}
		internal static global::MonoJavaBridge.MethodId _loadLibrary15156;
		public static void loadLibrary(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._loadLibrary15156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _mapLibraryName15157;
		public static global::java.lang.String mapLibraryName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._mapLibraryName15157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _load15158;
		public static void load(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._load15158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIn15159;
		public static void setIn(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._setIn15159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOut15160;
		public static void setOut(java.io.PrintStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._setOut15160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setErr15161;
		public static void setErr(java.io.PrintStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._setErr15161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _inheritedChannel15162;
		public static global::java.nio.channels.Channel inheritedChannel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.nio.channels.Channel>(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._inheritedChannel15162)) as java.nio.channels.Channel;
		}
		internal static global::MonoJavaBridge.MethodId _setSecurityManager15163;
		public static void setSecurityManager(java.lang.SecurityManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._setSecurityManager15163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getProperties15164;
		public static global::java.util.Properties getProperties() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._getProperties15164)) as java.util.Properties;
		}
		internal static global::MonoJavaBridge.MethodId _setProperties15165;
		public static void setProperties(java.util.Properties arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._setProperties15165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearProperty15166;
		public static global::java.lang.String clearProperty(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._clearProperty15166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getenv15167;
		public static global::java.lang.String getenv(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._getenv15167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		public static global::java.util.Map env
		{
			get
			{
				return getenv();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getenv15168;
		public static global::java.util.Map getenv() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._getenv15168)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _gc15169;
		public static void gc() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._gc15169);
		}
		internal static global::MonoJavaBridge.MethodId _runFinalization15170;
		public static void runFinalization() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._runFinalization15170);
		}
		internal static global::MonoJavaBridge.FieldId _in15171;
		public static global::java.io.InputStream @in
		{
			get
			{
				return default(global::java.io.InputStream);
			}
		}
		internal static global::MonoJavaBridge.FieldId _out15172;
		public static global::java.io.PrintStream @out
		{
			get
			{
				return default(global::java.io.PrintStream);
			}
		}
		internal static global::MonoJavaBridge.FieldId _err15173;
		public static global::java.io.PrintStream err
		{
			get
			{
				return default(global::java.io.PrintStream);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.System.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/System"));
			global::java.lang.System._exit15146 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "exit", "(I)V");
			global::java.lang.System._runFinalizersOnExit15147 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "runFinalizersOnExit", "(Z)V");
			global::java.lang.System._setProperty15148 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::java.lang.System._getProperty15149 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "getProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::java.lang.System._getProperty15150 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.lang.System._identityHashCode15151 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "identityHashCode", "(Ljava/lang/Object;)I");
			global::java.lang.System._currentTimeMillis15152 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "currentTimeMillis", "()J");
			global::java.lang.System._nanoTime15153 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "nanoTime", "()J");
			global::java.lang.System._arraycopy15154 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "arraycopy", "(Ljava/lang/Object;ILjava/lang/Object;II)V");
			global::java.lang.System._getSecurityManager15155 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "getSecurityManager", "()Ljava/lang/SecurityManager;");
			global::java.lang.System._loadLibrary15156 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "loadLibrary", "(Ljava/lang/String;)V");
			global::java.lang.System._mapLibraryName15157 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "mapLibraryName", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.lang.System._load15158 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "load", "(Ljava/lang/String;)V");
			global::java.lang.System._setIn15159 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "setIn", "(Ljava/io/InputStream;)V");
			global::java.lang.System._setOut15160 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "setOut", "(Ljava/io/PrintStream;)V");
			global::java.lang.System._setErr15161 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "setErr", "(Ljava/io/PrintStream;)V");
			global::java.lang.System._inheritedChannel15162 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "inheritedChannel", "()Ljava/nio/channels/Channel;");
			global::java.lang.System._setSecurityManager15163 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "setSecurityManager", "(Ljava/lang/SecurityManager;)V");
			global::java.lang.System._getProperties15164 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "getProperties", "()Ljava/util/Properties;");
			global::java.lang.System._setProperties15165 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "setProperties", "(Ljava/util/Properties;)V");
			global::java.lang.System._clearProperty15166 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "clearProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.lang.System._getenv15167 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "getenv", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.lang.System._getenv15168 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "getenv", "()Ljava/util/Map;");
			global::java.lang.System._gc15169 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "gc", "()V");
			global::java.lang.System._runFinalization15170 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "runFinalization", "()V");
		}
	}
}
