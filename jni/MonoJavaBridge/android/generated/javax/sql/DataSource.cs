namespace javax.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.sql.DataSource_))]
	public partial interface DataSource  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.sql.Connection getConnection();
		global::java.sql.Connection getConnection(java.lang.String arg0, java.lang.String arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.sql.DataSource))]
	internal sealed partial class DataSource_ : java.lang.Object, DataSource
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DataSource_()
		{
			InitJNI();
		}
		internal DataSource_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getConnection30284;
		global::java.sql.Connection javax.sql.DataSource.getConnection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.DataSource_._getConnection30284)) as java.sql.Connection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.DataSource_.staticClass, global::javax.sql.DataSource_._getConnection30284)) as java.sql.Connection;
		}
		internal static global::MonoJavaBridge.MethodId _getConnection30285;
		global::java.sql.Connection javax.sql.DataSource.getConnection(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.DataSource_._getConnection30285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Connection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.DataSource_.staticClass, global::javax.sql.DataSource_._getConnection30285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Connection;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.sql.DataSource_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/sql/DataSource"));
			global::javax.sql.DataSource_._getConnection30284 = @__env.GetMethodIDNoThrow(global::javax.sql.DataSource_.staticClass, "getConnection", "()Ljava/sql/Connection;");
			global::javax.sql.DataSource_._getConnection30285 = @__env.GetMethodIDNoThrow(global::javax.sql.DataSource_.staticClass, "getConnection", "(Ljava/lang/String;Ljava/lang/String;)Ljava/sql/Connection;");
		}
	}
}
