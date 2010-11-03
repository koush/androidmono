namespace java.sql
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DriverManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DriverManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static void println(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.DriverManager._m0.native == global::System.IntPtr.Zero)
				global::java.sql.DriverManager._m0 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "println", "(Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.sql.Connection getConnection(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.DriverManager._m1.native == global::System.IntPtr.Zero)
				global::java.sql.DriverManager._m1 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "getConnection", "(Ljava/lang/String;)Ljava/sql/Connection;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallStaticObjectMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Connection;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.sql.Connection getConnection(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.DriverManager._m2.native == global::System.IntPtr.Zero)
				global::java.sql.DriverManager._m2 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "getConnection", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/Connection;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallStaticObjectMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.Connection;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::java.sql.Connection getConnection(java.lang.String arg0, java.util.Properties arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.DriverManager._m3.native == global::System.IntPtr.Zero)
				global::java.sql.DriverManager._m3 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "getConnection", "(Ljava/lang/String;Ljava/util/Properties;)Ljava/sql/Connection;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallStaticObjectMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Connection;
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
		private static global::MonoJavaBridge.MethodId _m4;
		public static global::java.io.PrintWriter getLogWriter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.DriverManager._m4.native == global::System.IntPtr.Zero)
				global::java.sql.DriverManager._m4 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "getLogWriter", "()Ljava/io/PrintWriter;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._m4)) as java.io.PrintWriter;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static void setLogWriter(java.io.PrintWriter arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.DriverManager._m5.native == global::System.IntPtr.Zero)
				global::java.sql.DriverManager._m5 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "setLogWriter", "(Ljava/io/PrintWriter;)V");
			@__env.CallStaticVoidMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::java.sql.Driver getDriver(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.DriverManager._m6.native == global::System.IntPtr.Zero)
				global::java.sql.DriverManager._m6 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "getDriver", "(Ljava/lang/String;)Ljava/sql/Driver;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Driver>(@__env.CallStaticObjectMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Driver;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static void registerDriver(java.sql.Driver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.DriverManager._m7.native == global::System.IntPtr.Zero)
				global::java.sql.DriverManager._m7 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "registerDriver", "(Ljava/sql/Driver;)V");
			@__env.CallStaticVoidMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static void deregisterDriver(java.sql.Driver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.DriverManager._m8.native == global::System.IntPtr.Zero)
				global::java.sql.DriverManager._m8 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "deregisterDriver", "(Ljava/sql/Driver;)V");
			@__env.CallStaticVoidMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.util.Enumeration Drivers
		{
			get
			{
				return getDrivers();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static global::java.util.Enumeration getDrivers()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.DriverManager._m9.native == global::System.IntPtr.Zero)
				global::java.sql.DriverManager._m9 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "getDrivers", "()Ljava/util/Enumeration;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallStaticObjectMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._m9)) as java.util.Enumeration;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static void setLoginTimeout(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.DriverManager._m10.native == global::System.IntPtr.Zero)
				global::java.sql.DriverManager._m10 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "setLoginTimeout", "(I)V");
			@__env.CallStaticVoidMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m11;
		public static int getLoginTimeout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.DriverManager._m11.native == global::System.IntPtr.Zero)
				global::java.sql.DriverManager._m11 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "getLoginTimeout", "()I");
			return @__env.CallStaticIntMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static void setLogStream(java.io.PrintStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.DriverManager._m12.native == global::System.IntPtr.Zero)
				global::java.sql.DriverManager._m12 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "setLogStream", "(Ljava/io/PrintStream;)V");
			@__env.CallStaticVoidMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m13;
		public static global::java.io.PrintStream getLogStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.DriverManager._m13.native == global::System.IntPtr.Zero)
				global::java.sql.DriverManager._m13 = @__env.GetStaticMethodIDNoThrow(global::java.sql.DriverManager.staticClass, "getLogStream", "()Ljava/io/PrintStream;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.sql.DriverManager.staticClass, global::java.sql.DriverManager._m13)) as java.io.PrintStream;
		}
		static DriverManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.DriverManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/DriverManager"));
		}
	}
}
