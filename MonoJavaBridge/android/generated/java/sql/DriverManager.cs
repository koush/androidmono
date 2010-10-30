namespace java.sql
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DriverManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DriverManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _println24626;
		public static void println(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.DriverManager._println24626.native == global::System.IntPtr.Zero)
				global::java.sql.DriverManager._println24626 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "println", "(Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._println24626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getConnection24627;
		public static global::java.sql.Connection getConnection(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.DriverManager._getConnection24627.native == global::System.IntPtr.Zero)
				global::java.sql.DriverManager._getConnection24627 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "getConnection", "(Ljava/lang/String;)Ljava/sql/Connection;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallStaticObjectMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._getConnection24627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Connection;
		}
		internal static global::MonoJavaBridge.MethodId _getConnection24628;
		public static global::java.sql.Connection getConnection(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.DriverManager._getConnection24628.native == global::System.IntPtr.Zero)
				global::java.sql.DriverManager._getConnection24628 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "getConnection", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/Connection;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallStaticObjectMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._getConnection24628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.Connection;
		}
		internal static global::MonoJavaBridge.MethodId _getConnection24629;
		public static global::java.sql.Connection getConnection(java.lang.String arg0, java.util.Properties arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.DriverManager._getConnection24629.native == global::System.IntPtr.Zero)
				global::java.sql.DriverManager._getConnection24629 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "getConnection", "(Ljava/lang/String;Ljava/util/Properties;)Ljava/sql/Connection;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallStaticObjectMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._getConnection24629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Connection;
		}
		public static global::java.io.PrintWriter LogWriter
		{
			get
			{
				return getLogWriter();
			}
			set
			{
				setLogWriter(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLogWriter24630;
		public static global::java.io.PrintWriter getLogWriter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.DriverManager._getLogWriter24630.native == global::System.IntPtr.Zero)
				global::java.sql.DriverManager._getLogWriter24630 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "getLogWriter", "()Ljava/io/PrintWriter;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._getLogWriter24630)) as java.io.PrintWriter;
		}
		internal static global::MonoJavaBridge.MethodId _setLogWriter24631;
		public static void setLogWriter(java.io.PrintWriter arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.DriverManager._setLogWriter24631.native == global::System.IntPtr.Zero)
				global::java.sql.DriverManager._setLogWriter24631 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "setLogWriter", "(Ljava/io/PrintWriter;)V");
			@__env.CallStaticVoidMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._setLogWriter24631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDriver24632;
		public static global::java.sql.Driver getDriver(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.DriverManager._getDriver24632.native == global::System.IntPtr.Zero)
				global::java.sql.DriverManager._getDriver24632 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "getDriver", "(Ljava/lang/String;)Ljava/sql/Driver;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Driver>(@__env.CallStaticObjectMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._getDriver24632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Driver;
		}
		internal static global::MonoJavaBridge.MethodId _registerDriver24633;
		public static void registerDriver(java.sql.Driver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.DriverManager._registerDriver24633.native == global::System.IntPtr.Zero)
				global::java.sql.DriverManager._registerDriver24633 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "registerDriver", "(Ljava/sql/Driver;)V");
			@__env.CallStaticVoidMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._registerDriver24633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deregisterDriver24634;
		public static void deregisterDriver(java.sql.Driver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.DriverManager._deregisterDriver24634.native == global::System.IntPtr.Zero)
				global::java.sql.DriverManager._deregisterDriver24634 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "deregisterDriver", "(Ljava/sql/Driver;)V");
			@__env.CallStaticVoidMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._deregisterDriver24634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.util.Enumeration Drivers
		{
			get
			{
				return getDrivers();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDrivers24635;
		public static global::java.util.Enumeration getDrivers()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.DriverManager._getDrivers24635.native == global::System.IntPtr.Zero)
				global::java.sql.DriverManager._getDrivers24635 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "getDrivers", "()Ljava/util/Enumeration;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallStaticObjectMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._getDrivers24635)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _setLoginTimeout24636;
		public static void setLoginTimeout(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.DriverManager._setLoginTimeout24636.native == global::System.IntPtr.Zero)
				global::java.sql.DriverManager._setLoginTimeout24636 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "setLoginTimeout", "(I)V");
			@__env.CallStaticVoidMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._setLoginTimeout24636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int LoginTimeout
		{
			get
			{
				return getLoginTimeout();
			}
			set
			{
				setLoginTimeout(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLoginTimeout24637;
		public static int getLoginTimeout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.DriverManager._getLoginTimeout24637.native == global::System.IntPtr.Zero)
				global::java.sql.DriverManager._getLoginTimeout24637 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "getLoginTimeout", "()I");
			return @__env.CallStaticIntMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._getLoginTimeout24637);
		}
		internal static global::MonoJavaBridge.MethodId _setLogStream24638;
		public static void setLogStream(java.io.PrintStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.DriverManager._setLogStream24638.native == global::System.IntPtr.Zero)
				global::java.sql.DriverManager._setLogStream24638 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "setLogStream", "(Ljava/io/PrintStream;)V");
			@__env.CallStaticVoidMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._setLogStream24638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.io.PrintStream LogStream
		{
			get
			{
				return getLogStream();
			}
			set
			{
				setLogStream(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLogStream24639;
		public static global::java.io.PrintStream getLogStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.DriverManager._getLogStream24639.native == global::System.IntPtr.Zero)
				global::java.sql.DriverManager._getLogStream24639 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "getLogStream", "()Ljava/io/PrintStream;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._getLogStream24639)) as java.io.PrintStream;
		}
		static DriverManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.DriverManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/DriverManager"));
		}
		internal static void InitJNI()
		{
		}
	}
}
