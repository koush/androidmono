namespace java.sql
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DriverManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DriverManager()
		{
			InitJNI();
		}
		protected DriverManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _println24507;
		public static void println(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._println24507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getConnection24508;
		public static global::java.sql.Connection getConnection(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallStaticObjectMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._getConnection24508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Connection;
		}
		internal static global::MonoJavaBridge.MethodId _getConnection24509;
		public static global::java.sql.Connection getConnection(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallStaticObjectMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._getConnection24509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.Connection;
		}
		internal static global::MonoJavaBridge.MethodId _getConnection24510;
		public static global::java.sql.Connection getConnection(java.lang.String arg0, java.util.Properties arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallStaticObjectMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._getConnection24510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Connection;
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
		internal static global::MonoJavaBridge.MethodId _getLogWriter24511;
		public static global::java.io.PrintWriter getLogWriter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._getLogWriter24511)) as java.io.PrintWriter;
		}
		internal static global::MonoJavaBridge.MethodId _setLogWriter24512;
		public static void setLogWriter(java.io.PrintWriter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._setLogWriter24512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDriver24513;
		public static global::java.sql.Driver getDriver(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Driver>(@__env.CallStaticObjectMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._getDriver24513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Driver;
		}
		internal static global::MonoJavaBridge.MethodId _registerDriver24514;
		public static void registerDriver(java.sql.Driver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._registerDriver24514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deregisterDriver24515;
		public static void deregisterDriver(java.sql.Driver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._deregisterDriver24515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.util.Enumeration Drivers
		{
			get
			{
				return getDrivers();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDrivers24516;
		public static global::java.util.Enumeration getDrivers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallStaticObjectMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._getDrivers24516)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _setLoginTimeout24517;
		public static void setLoginTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._setLoginTimeout24517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getLoginTimeout24518;
		public static int getLoginTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._getLoginTimeout24518);
		}
		internal static global::MonoJavaBridge.MethodId _setLogStream24519;
		public static void setLogStream(java.io.PrintStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._setLogStream24519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getLogStream24520;
		public static global::java.io.PrintStream getLogStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._getLogStream24520)) as java.io.PrintStream;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.DriverManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/DriverManager"));
			global::java.sql.DriverManager._println24507 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "println", "(Ljava/lang/String;)V");
			global::java.sql.DriverManager._getConnection24508 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "getConnection", "(Ljava/lang/String;)Ljava/sql/Connection;");
			global::java.sql.DriverManager._getConnection24509 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "getConnection", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/Connection;");
			global::java.sql.DriverManager._getConnection24510 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "getConnection", "(Ljava/lang/String;Ljava/util/Properties;)Ljava/sql/Connection;");
			global::java.sql.DriverManager._getLogWriter24511 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "getLogWriter", "()Ljava/io/PrintWriter;");
			global::java.sql.DriverManager._setLogWriter24512 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "setLogWriter", "(Ljava/io/PrintWriter;)V");
			global::java.sql.DriverManager._getDriver24513 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "getDriver", "(Ljava/lang/String;)Ljava/sql/Driver;");
			global::java.sql.DriverManager._registerDriver24514 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "registerDriver", "(Ljava/sql/Driver;)V");
			global::java.sql.DriverManager._deregisterDriver24515 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "deregisterDriver", "(Ljava/sql/Driver;)V");
			global::java.sql.DriverManager._getDrivers24516 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "getDrivers", "()Ljava/util/Enumeration;");
			global::java.sql.DriverManager._setLoginTimeout24517 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "setLoginTimeout", "(I)V");
			global::java.sql.DriverManager._getLoginTimeout24518 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "getLoginTimeout", "()I");
			global::java.sql.DriverManager._setLogStream24519 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "setLogStream", "(Ljava/io/PrintStream;)V");
			global::java.sql.DriverManager._getLogStream24520 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "getLogStream", "()Ljava/io/PrintStream;");
		}
	}
}
