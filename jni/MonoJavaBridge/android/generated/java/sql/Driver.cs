namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.Driver_))]
	public interface Driver  : global::MonoJavaBridge.IJavaObject 
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
		internal static global::MonoJavaBridge.MethodId _connect18826;
		 global::java.sql.Connection java.sql.Driver.connect(java.lang.String arg0, java.util.Properties arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Driver_._connect18826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Connection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Driver_.staticClass, global::java.sql.Driver_._connect18826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Connection;
		}
		internal static global::MonoJavaBridge.MethodId _acceptsURL18827;
		 bool java.sql.Driver.acceptsURL(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Driver_._acceptsURL18827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Driver_.staticClass, global::java.sql.Driver_._acceptsURL18827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPropertyInfo18828;
		 global::java.sql.DriverPropertyInfo[] java.sql.Driver.getPropertyInfo(java.lang.String arg0, java.util.Properties arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.sql.DriverPropertyInfo>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Driver_._getPropertyInfo18828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.DriverPropertyInfo[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.sql.DriverPropertyInfo>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Driver_.staticClass, global::java.sql.Driver_._getPropertyInfo18828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.DriverPropertyInfo[];
		}
		internal static global::MonoJavaBridge.MethodId _getMajorVersion18829;
		 int java.sql.Driver.getMajorVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Driver_._getMajorVersion18829);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Driver_.staticClass, global::java.sql.Driver_._getMajorVersion18829);
		}
		internal static global::MonoJavaBridge.MethodId _getMinorVersion18830;
		 int java.sql.Driver.getMinorVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Driver_._getMinorVersion18830);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Driver_.staticClass, global::java.sql.Driver_._getMinorVersion18830);
		}
		internal static global::MonoJavaBridge.MethodId _jdbcCompliant18831;
		 bool java.sql.Driver.jdbcCompliant() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Driver_._jdbcCompliant18831);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Driver_.staticClass, global::java.sql.Driver_._jdbcCompliant18831);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.Driver_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/Driver"));
			global::java.sql.Driver_._connect18826 = @__env.GetMethodIDNoThrow(global::java.sql.Driver_.staticClass, "connect", "(Ljava/lang/String;Ljava/util/Properties;)Ljava/sql/Connection;");
			global::java.sql.Driver_._acceptsURL18827 = @__env.GetMethodIDNoThrow(global::java.sql.Driver_.staticClass, "acceptsURL", "(Ljava/lang/String;)Z");
			global::java.sql.Driver_._getPropertyInfo18828 = @__env.GetMethodIDNoThrow(global::java.sql.Driver_.staticClass, "getPropertyInfo", "(Ljava/lang/String;Ljava/util/Properties;)[Ljava/sql/DriverPropertyInfo;");
			global::java.sql.Driver_._getMajorVersion18829 = @__env.GetMethodIDNoThrow(global::java.sql.Driver_.staticClass, "getMajorVersion", "()I");
			global::java.sql.Driver_._getMinorVersion18830 = @__env.GetMethodIDNoThrow(global::java.sql.Driver_.staticClass, "getMinorVersion", "()I");
			global::java.sql.Driver_._jdbcCompliant18831 = @__env.GetMethodIDNoThrow(global::java.sql.Driver_.staticClass, "jdbcCompliant", "()Z");
		}
	}
}
