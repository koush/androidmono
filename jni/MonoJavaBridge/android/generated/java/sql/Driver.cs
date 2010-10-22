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
	public sealed partial class Driver_ : java.lang.Object, Driver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Driver_()
		{
			InitJNI();
		}
		internal Driver_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _connect24501;
		 global::java.sql.Connection java.sql.Driver.connect(java.lang.String arg0, java.util.Properties arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Driver_._connect24501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Connection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Driver_.staticClass, global::java.sql.Driver_._connect24501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Connection;
		}
		internal static global::MonoJavaBridge.MethodId _acceptsURL24502;
		 bool java.sql.Driver.acceptsURL(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Driver_._acceptsURL24502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Driver_.staticClass, global::java.sql.Driver_._acceptsURL24502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPropertyInfo24503;
		 global::java.sql.DriverPropertyInfo[] java.sql.Driver.getPropertyInfo(java.lang.String arg0, java.util.Properties arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.sql.DriverPropertyInfo>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Driver_._getPropertyInfo24503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.DriverPropertyInfo[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.sql.DriverPropertyInfo>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Driver_.staticClass, global::java.sql.Driver_._getPropertyInfo24503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.DriverPropertyInfo[];
		}
		internal static global::MonoJavaBridge.MethodId _getMajorVersion24504;
		 int java.sql.Driver.getMajorVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Driver_._getMajorVersion24504);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Driver_.staticClass, global::java.sql.Driver_._getMajorVersion24504);
		}
		internal static global::MonoJavaBridge.MethodId _getMinorVersion24505;
		 int java.sql.Driver.getMinorVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Driver_._getMinorVersion24505);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Driver_.staticClass, global::java.sql.Driver_._getMinorVersion24505);
		}
		internal static global::MonoJavaBridge.MethodId _jdbcCompliant24506;
		 bool java.sql.Driver.jdbcCompliant() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Driver_._jdbcCompliant24506);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Driver_.staticClass, global::java.sql.Driver_._jdbcCompliant24506);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.Driver_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/Driver"));
			global::java.sql.Driver_._connect24501 = @__env.GetMethodIDNoThrow(global::java.sql.Driver_.staticClass, "connect", "(Ljava/lang/String;Ljava/util/Properties;)Ljava/sql/Connection;");
			global::java.sql.Driver_._acceptsURL24502 = @__env.GetMethodIDNoThrow(global::java.sql.Driver_.staticClass, "acceptsURL", "(Ljava/lang/String;)Z");
			global::java.sql.Driver_._getPropertyInfo24503 = @__env.GetMethodIDNoThrow(global::java.sql.Driver_.staticClass, "getPropertyInfo", "(Ljava/lang/String;Ljava/util/Properties;)[Ljava/sql/DriverPropertyInfo;");
			global::java.sql.Driver_._getMajorVersion24504 = @__env.GetMethodIDNoThrow(global::java.sql.Driver_.staticClass, "getMajorVersion", "()I");
			global::java.sql.Driver_._getMinorVersion24505 = @__env.GetMethodIDNoThrow(global::java.sql.Driver_.staticClass, "getMinorVersion", "()I");
			global::java.sql.Driver_._jdbcCompliant24506 = @__env.GetMethodIDNoThrow(global::java.sql.Driver_.staticClass, "jdbcCompliant", "()Z");
		}
	}
}
