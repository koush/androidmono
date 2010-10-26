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
		internal static global::MonoJavaBridge.MethodId _exit20783;
		public static void exit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._exit20783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _runFinalizersOnExit20784;
		public static void runFinalizersOnExit(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._runFinalizersOnExit20784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setProperty20785;
		public static global::java.lang.String setProperty(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._setProperty20785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getProperty20786;
		public static global::java.lang.String getProperty(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._getProperty20786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getProperty20787;
		public static global::java.lang.String getProperty(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._getProperty20787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _identityHashCode20788;
		public static int identityHashCode(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.System.staticClass, global::java.lang.System._identityHashCode20788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _currentTimeMillis20789;
		public static long currentTimeMillis() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.System.staticClass, global::java.lang.System._currentTimeMillis20789);
		}
		internal static global::MonoJavaBridge.MethodId _nanoTime20790;
		public static long nanoTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.System.staticClass, global::java.lang.System._nanoTime20790);
		}
		internal static global::MonoJavaBridge.MethodId _arraycopy20791;
		public static void arraycopy(java.lang.Object arg0, int arg1, java.lang.Object arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._arraycopy20791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
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
		internal static global::MonoJavaBridge.MethodId _getSecurityManager20792;
		public static global::java.lang.SecurityManager getSecurityManager() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._getSecurityManager20792)) as java.lang.SecurityManager;
		}
		internal static global::MonoJavaBridge.MethodId _loadLibrary20793;
		public static void loadLibrary(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._loadLibrary20793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _mapLibraryName20794;
		public static global::java.lang.String mapLibraryName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._mapLibraryName20794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _load20795;
		public static void load(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._load20795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIn20796;
		public static void setIn(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._setIn20796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOut20797;
		public static void setOut(java.io.PrintStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._setOut20797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setErr20798;
		public static void setErr(java.io.PrintStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._setErr20798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _inheritedChannel20799;
		public static global::java.nio.channels.Channel inheritedChannel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.nio.channels.Channel>(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._inheritedChannel20799)) as java.nio.channels.Channel;
		}
		internal static global::MonoJavaBridge.MethodId _setSecurityManager20800;
		public static void setSecurityManager(java.lang.SecurityManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._setSecurityManager20800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getProperties20801;
		public static global::java.util.Properties getProperties() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._getProperties20801)) as java.util.Properties;
		}
		internal static global::MonoJavaBridge.MethodId _setProperties20802;
		public static void setProperties(java.util.Properties arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._setProperties20802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearProperty20803;
		public static global::java.lang.String clearProperty(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._clearProperty20803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getenv20804;
		public static global::java.lang.String getenv(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._getenv20804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		public static global::java.util.Map env
		{
			get
			{
				return getenv();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getenv20805;
		public static global::java.util.Map getenv() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallStaticObjectMethod(java.lang.System.staticClass, global::java.lang.System._getenv20805)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _gc20806;
		public static void gc() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._gc20806);
		}
		internal static global::MonoJavaBridge.MethodId _runFinalization20807;
		public static void runFinalization() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.System.staticClass, global::java.lang.System._runFinalization20807);
		}
		internal static global::MonoJavaBridge.FieldId _in20808;
		public static global::java.io.InputStream @in
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.lang.System.staticClass, _in20808)) as java.io.InputStream;
			}
		}
		internal static global::MonoJavaBridge.FieldId _out20809;
		public static global::java.io.PrintStream @out
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.lang.System.staticClass, _out20809)) as java.io.PrintStream;
			}
		}
		internal static global::MonoJavaBridge.FieldId _err20810;
		public static global::java.io.PrintStream err
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.lang.System.staticClass, _err20810)) as java.io.PrintStream;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.System.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/System"));
			global::java.lang.System._exit20783 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "exit", "(I)V");
			global::java.lang.System._runFinalizersOnExit20784 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "runFinalizersOnExit", "(Z)V");
			global::java.lang.System._setProperty20785 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::java.lang.System._getProperty20786 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "getProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::java.lang.System._getProperty20787 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.lang.System._identityHashCode20788 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "identityHashCode", "(Ljava/lang/Object;)I");
			global::java.lang.System._currentTimeMillis20789 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "currentTimeMillis", "()J");
			global::java.lang.System._nanoTime20790 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "nanoTime", "()J");
			global::java.lang.System._arraycopy20791 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "arraycopy", "(Ljava/lang/Object;ILjava/lang/Object;II)V");
			global::java.lang.System._getSecurityManager20792 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "getSecurityManager", "()Ljava/lang/SecurityManager;");
			global::java.lang.System._loadLibrary20793 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "loadLibrary", "(Ljava/lang/String;)V");
			global::java.lang.System._mapLibraryName20794 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "mapLibraryName", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.lang.System._load20795 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "load", "(Ljava/lang/String;)V");
			global::java.lang.System._setIn20796 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "setIn", "(Ljava/io/InputStream;)V");
			global::java.lang.System._setOut20797 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "setOut", "(Ljava/io/PrintStream;)V");
			global::java.lang.System._setErr20798 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "setErr", "(Ljava/io/PrintStream;)V");
			global::java.lang.System._inheritedChannel20799 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "inheritedChannel", "()Ljava/nio/channels/Channel;");
			global::java.lang.System._setSecurityManager20800 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "setSecurityManager", "(Ljava/lang/SecurityManager;)V");
			global::java.lang.System._getProperties20801 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "getProperties", "()Ljava/util/Properties;");
			global::java.lang.System._setProperties20802 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "setProperties", "(Ljava/util/Properties;)V");
			global::java.lang.System._clearProperty20803 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "clearProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.lang.System._getenv20804 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "getenv", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.lang.System._getenv20805 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "getenv", "()Ljava/util/Map;");
			global::java.lang.System._gc20806 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "gc", "()V");
			global::java.lang.System._runFinalization20807 = @__env.GetStaticMethodIDNoThrow(global::java.lang.System.staticClass, "runFinalization", "()V");
			global::java.lang.System._in20808 = @__env.GetStaticFieldIDNoThrow(global::java.lang.System.staticClass, "@in", "Ljava/io/InputStream;");
			global::java.lang.System._out20809 = @__env.GetStaticFieldIDNoThrow(global::java.lang.System.staticClass, "@out", "Ljava/io/PrintStream;");
			global::java.lang.System._err20810 = @__env.GetStaticFieldIDNoThrow(global::java.lang.System.staticClass, "err", "Ljava/io/PrintStream;");
		}
	}
}
