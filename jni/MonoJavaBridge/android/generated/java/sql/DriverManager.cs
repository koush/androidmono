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
		internal static global::MonoJavaBridge.MethodId _println18832;
		public static void println(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._println18832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getConnection18833;
		public static global::java.sql.Connection getConnection(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallStaticObjectMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._getConnection18833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Connection;
		}
		internal static global::MonoJavaBridge.MethodId _getConnection18834;
		public static global::java.sql.Connection getConnection(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallStaticObjectMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._getConnection18834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.Connection;
		}
		internal static global::MonoJavaBridge.MethodId _getConnection18835;
		public static global::java.sql.Connection getConnection(java.lang.String arg0, java.util.Properties arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallStaticObjectMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._getConnection18835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Connection;
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
		internal static global::MonoJavaBridge.MethodId _getLogWriter18836;
		public static global::java.io.PrintWriter getLogWriter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._getLogWriter18836)) as java.io.PrintWriter;
		}
		internal static global::MonoJavaBridge.MethodId _setLogWriter18837;
		public static void setLogWriter(java.io.PrintWriter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._setLogWriter18837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDriver18838;
		public static global::java.sql.Driver getDriver(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Driver>(@__env.CallStaticObjectMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._getDriver18838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Driver;
		}
		internal static global::MonoJavaBridge.MethodId _registerDriver18839;
		public static void registerDriver(java.sql.Driver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._registerDriver18839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deregisterDriver18840;
		public static void deregisterDriver(java.sql.Driver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._deregisterDriver18840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.util.Enumeration Drivers
		{
			get
			{
				return getDrivers();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDrivers18841;
		public static global::java.util.Enumeration getDrivers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallStaticObjectMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._getDrivers18841)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _setLoginTimeout18842;
		public static void setLoginTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._setLoginTimeout18842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getLoginTimeout18843;
		public static int getLoginTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._getLoginTimeout18843);
		}
		internal static global::MonoJavaBridge.MethodId _setLogStream18844;
		public static void setLogStream(java.io.PrintStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._setLogStream18844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getLogStream18845;
		public static global::java.io.PrintStream getLogStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._getLogStream18845)) as java.io.PrintStream;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.DriverManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/DriverManager"));
			global::java.sql.DriverManager._println18832 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "println", "(Ljava/lang/String;)V");
			global::java.sql.DriverManager._getConnection18833 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "getConnection", "(Ljava/lang/String;)Ljava/sql/Connection;");
			global::java.sql.DriverManager._getConnection18834 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "getConnection", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/Connection;");
			global::java.sql.DriverManager._getConnection18835 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "getConnection", "(Ljava/lang/String;Ljava/util/Properties;)Ljava/sql/Connection;");
			global::java.sql.DriverManager._getLogWriter18836 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "getLogWriter", "()Ljava/io/PrintWriter;");
			global::java.sql.DriverManager._setLogWriter18837 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "setLogWriter", "(Ljava/io/PrintWriter;)V");
			global::java.sql.DriverManager._getDriver18838 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "getDriver", "(Ljava/lang/String;)Ljava/sql/Driver;");
			global::java.sql.DriverManager._registerDriver18839 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "registerDriver", "(Ljava/sql/Driver;)V");
			global::java.sql.DriverManager._deregisterDriver18840 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "deregisterDriver", "(Ljava/sql/Driver;)V");
			global::java.sql.DriverManager._getDrivers18841 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "getDrivers", "()Ljava/util/Enumeration;");
			global::java.sql.DriverManager._setLoginTimeout18842 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "setLoginTimeout", "(I)V");
			global::java.sql.DriverManager._getLoginTimeout18843 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "getLoginTimeout", "()I");
			global::java.sql.DriverManager._setLogStream18844 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "setLogStream", "(Ljava/io/PrintStream;)V");
			global::java.sql.DriverManager._getLogStream18845 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "getLogStream", "()Ljava/io/PrintStream;");
		}
	}
}
