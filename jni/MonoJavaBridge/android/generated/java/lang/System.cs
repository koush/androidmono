namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class System : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal System(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _exit20784;
		public static void exit(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._exit20784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _runFinalizersOnExit20785;
		public static void runFinalizersOnExit(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._runFinalizersOnExit20785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setProperty20786;
		public static global::java.lang.String setProperty(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._setProperty20786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getProperty20787;
		public static global::java.lang.String getProperty(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._getProperty20787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getProperty20788;
		public static global::java.lang.String getProperty(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._getProperty20788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _identityHashCode20789;
		public static int identityHashCode(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.System.staticClass, global::java.lang.System._identityHashCode20789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _currentTimeMillis20790;
		public static long currentTimeMillis()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.System.staticClass, global::java.lang.System._currentTimeMillis20790);
		}
		internal static global::MonoJavaBridge.MethodId _nanoTime20791;
		public static long nanoTime()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.System.staticClass, global::java.lang.System._nanoTime20791);
		}
		internal static global::MonoJavaBridge.MethodId _arraycopy20792;
		public static void arraycopy(java.lang.Object arg0, int arg1, java.lang.Object arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._arraycopy20792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
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
		internal static global::MonoJavaBridge.MethodId _getSecurityManager20793;
		public static global::java.lang.SecurityManager getSecurityManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._getSecurityManager20793)) as java.lang.SecurityManager;
		}
		internal static global::MonoJavaBridge.MethodId _loadLibrary20794;
		public static void loadLibrary(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._loadLibrary20794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _mapLibraryName20795;
		public static global::java.lang.String mapLibraryName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._mapLibraryName20795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _load20796;
		public static void load(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._load20796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.io.InputStream In
		{
			set
			{
				setIn(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setIn20797;
		public static void setIn(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._setIn20797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.io.PrintStream Out
		{
			set
			{
				setOut(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setOut20798;
		public static void setOut(java.io.PrintStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._setOut20798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.io.PrintStream Err
		{
			set
			{
				setErr(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setErr20799;
		public static void setErr(java.io.PrintStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._setErr20799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _inheritedChannel20800;
		public static global::java.nio.channels.Channel inheritedChannel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.nio.channels.Channel>(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._inheritedChannel20800)) as java.nio.channels.Channel;
		}
		internal static global::MonoJavaBridge.MethodId _setSecurityManager20801;
		public static void setSecurityManager(java.lang.SecurityManager arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._setSecurityManager20801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getProperties20802;
		public static global::java.util.Properties getProperties()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._getProperties20802)) as java.util.Properties;
		}
		internal static global::MonoJavaBridge.MethodId _setProperties20803;
		public static void setProperties(java.util.Properties arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._setProperties20803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearProperty20804;
		public static global::java.lang.String clearProperty(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._clearProperty20804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getenv20805;
		public static global::java.lang.String getenv(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._getenv20805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		public static global::java.util.Map env
		{
			get
			{
				return getenv();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getenv20806;
		public static global::java.util.Map getenv()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._getenv20806)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _gc20807;
		public static void gc()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._gc20807);
		}
		internal static global::MonoJavaBridge.MethodId _runFinalization20808;
		public static void runFinalization()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._runFinalization20808);
		}
		internal static global::MonoJavaBridge.FieldId _in20809;
		public static global::java.io.InputStream @in
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.lang.System.staticClass, _in20809)) as java.io.InputStream;
			}
		}
		internal static global::MonoJavaBridge.FieldId _out20810;
		public static global::java.io.PrintStream @out
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.lang.System.staticClass, _out20810)) as java.io.PrintStream;
			}
		}
		internal static global::MonoJavaBridge.FieldId _err20811;
		public static global::java.io.PrintStream err
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.lang.System.staticClass, _err20811)) as java.io.PrintStream;
			}
		}
		static System()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.System.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/System"));
			global::java.lang.System._exit20784 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "exit", "(I)V");
			global::java.lang.System._runFinalizersOnExit20785 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "runFinalizersOnExit", "(Z)V");
			global::java.lang.System._setProperty20786 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::java.lang.System._getProperty20787 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "getProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::java.lang.System._getProperty20788 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.lang.System._identityHashCode20789 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "identityHashCode", "(Ljava/lang/Object;)I");
			global::java.lang.System._currentTimeMillis20790 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "currentTimeMillis", "()J");
			global::java.lang.System._nanoTime20791 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "nanoTime", "()J");
			global::java.lang.System._arraycopy20792 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "arraycopy", "(Ljava/lang/Object;ILjava/lang/Object;II)V");
			global::java.lang.System._getSecurityManager20793 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "getSecurityManager", "()Ljava/lang/SecurityManager;");
			global::java.lang.System._loadLibrary20794 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "loadLibrary", "(Ljava/lang/String;)V");
			global::java.lang.System._mapLibraryName20795 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "mapLibraryName", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.lang.System._load20796 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "load", "(Ljava/lang/String;)V");
			global::java.lang.System._setIn20797 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "setIn", "(Ljava/io/InputStream;)V");
			global::java.lang.System._setOut20798 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "setOut", "(Ljava/io/PrintStream;)V");
			global::java.lang.System._setErr20799 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "setErr", "(Ljava/io/PrintStream;)V");
			global::java.lang.System._inheritedChannel20800 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "inheritedChannel", "()Ljava/nio/channels/Channel;");
			global::java.lang.System._setSecurityManager20801 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "setSecurityManager", "(Ljava/lang/SecurityManager;)V");
			global::java.lang.System._getProperties20802 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "getProperties", "()Ljava/util/Properties;");
			global::java.lang.System._setProperties20803 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "setProperties", "(Ljava/util/Properties;)V");
			global::java.lang.System._clearProperty20804 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "clearProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.lang.System._getenv20805 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "getenv", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.lang.System._getenv20806 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "getenv", "()Ljava/util/Map;");
			global::java.lang.System._gc20807 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "gc", "()V");
			global::java.lang.System._runFinalization20808 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "runFinalization", "()V");
			global::java.lang.System._in20809 = @__env.GetStaticFieldIDNoThrow(global::java.lang.System.staticClass, "@in", "Ljava/io/InputStream;");
			global::java.lang.System._out20810 = @__env.GetStaticFieldIDNoThrow(global::java.lang.System.staticClass, "@out", "Ljava/io/PrintStream;");
			global::java.lang.System._err20811 = @__env.GetStaticFieldIDNoThrow(global::java.lang.System.staticClass, "err", "Ljava/io/PrintStream;");
		}
		internal static void InitJNI()
		{
		}
	}
}
