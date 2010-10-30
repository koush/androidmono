namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.Driver_))]
	public partial interface Driver  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.sql.Connection connect(java.lang.String arg0, java.util.Properties arg1);
		bool acceptsURL(java.lang.String arg0);
		global::java.sql.DriverPropertyInfo[] getPropertyInfo(java.lang.String arg0, java.util.Properties arg1);
		int getMajorVersion();
		int getMinorVersion();
		bool jdbcCompliant();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.sql.Driver))]
	internal sealed partial class Driver_ : java.lang.Object, Driver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Driver_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _connect24620;
		global::java.sql.Connection java.sql.Driver.connect(java.lang.String arg0, java.util.Properties arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Connection>(this, global::java.sql.Driver_.staticClass, "connect", "(Ljava/lang/String;Ljava/util/Properties;)Ljava/sql/Connection;", ref global::java.sql.Driver_._connect24620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.sql.Connection;
		}
		internal static global::MonoJavaBridge.MethodId _acceptsURL24621;
		bool java.sql.Driver.acceptsURL(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.Driver_.staticClass, "acceptsURL", "(Ljava/lang/String;)Z", ref global::java.sql.Driver_._acceptsURL24621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPropertyInfo24622;
		global::java.sql.DriverPropertyInfo[] java.sql.Driver.getPropertyInfo(java.lang.String arg0, java.util.Properties arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.sql.DriverPropertyInfo>(this, global::java.sql.Driver_.staticClass, "getPropertyInfo", "(Ljava/lang/String;Ljava/util/Properties;)[Ljava/sql/DriverPropertyInfo;", ref global::java.sql.Driver_._getPropertyInfo24622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.sql.DriverPropertyInfo[];
		}
		internal static global::MonoJavaBridge.MethodId _getMajorVersion24623;
		int java.sql.Driver.getMajorVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.Driver_.staticClass, "getMajorVersion", "()I", ref global::java.sql.Driver_._getMajorVersion24623);
		}
		internal static global::MonoJavaBridge.MethodId _getMinorVersion24624;
		int java.sql.Driver.getMinorVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.Driver_.staticClass, "getMinorVersion", "()I", ref global::java.sql.Driver_._getMinorVersion24624);
		}
		internal static global::MonoJavaBridge.MethodId _jdbcCompliant24625;
		bool java.sql.Driver.jdbcCompliant()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.Driver_.staticClass, "jdbcCompliant", "()Z", ref global::java.sql.Driver_._jdbcCompliant24625);
		}
		static Driver_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.Driver_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/Driver"));
		}
		internal static void InitJNI()
		{
		}
	}
}
