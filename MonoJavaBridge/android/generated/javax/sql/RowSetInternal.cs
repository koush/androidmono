namespace javax.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.sql.RowSetInternal_))]
	public partial interface RowSetInternal  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object[] getParams();
		global::java.sql.Connection getConnection();
		global::java.sql.ResultSet getOriginal();
		void setMetaData(javax.sql.RowSetMetaData arg0);
		global::java.sql.ResultSet getOriginalRow();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.sql.RowSetInternal))]
	internal sealed partial class RowSetInternal_ : java.lang.Object, RowSetInternal
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal RowSetInternal_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getParams30575;
		global::java.lang.Object[] javax.sql.RowSetInternal.getParams()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.sql.RowSetInternal_._getParams30575.native == global::System.IntPtr.Zero)
				global::javax.sql.RowSetInternal_._getParams30575 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetInternal_.staticClass, "getParams", "()[Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSetInternal_._getParams30575)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _getConnection30576;
		global::java.sql.Connection javax.sql.RowSetInternal.getConnection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.sql.RowSetInternal_._getConnection30576.native == global::System.IntPtr.Zero)
				global::javax.sql.RowSetInternal_._getConnection30576 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetInternal_.staticClass, "getConnection", "()Ljava/sql/Connection;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSetInternal_._getConnection30576)) as java.sql.Connection;
		}
		internal static global::MonoJavaBridge.MethodId _getOriginal30577;
		global::java.sql.ResultSet javax.sql.RowSetInternal.getOriginal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.sql.RowSetInternal_._getOriginal30577.native == global::System.IntPtr.Zero)
				global::javax.sql.RowSetInternal_._getOriginal30577 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetInternal_.staticClass, "getOriginal", "()Ljava/sql/ResultSet;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSetInternal_._getOriginal30577)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _setMetaData30578;
		void javax.sql.RowSetInternal.setMetaData(javax.sql.RowSetMetaData arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.sql.RowSetInternal_._setMetaData30578.native == global::System.IntPtr.Zero)
				global::javax.sql.RowSetInternal_._setMetaData30578 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetInternal_.staticClass, "setMetaData", "(Ljavax/sql/RowSetMetaData;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetInternal_._setMetaData30578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOriginalRow30579;
		global::java.sql.ResultSet javax.sql.RowSetInternal.getOriginalRow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.sql.RowSetInternal_._getOriginalRow30579.native == global::System.IntPtr.Zero)
				global::javax.sql.RowSetInternal_._getOriginalRow30579 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetInternal_.staticClass, "getOriginalRow", "()Ljava/sql/ResultSet;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSetInternal_._getOriginalRow30579)) as java.sql.ResultSet;
		}
		static RowSetInternal_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.sql.RowSetInternal_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/sql/RowSetInternal"));
		}
		internal static void InitJNI()
		{
		}
	}
}
