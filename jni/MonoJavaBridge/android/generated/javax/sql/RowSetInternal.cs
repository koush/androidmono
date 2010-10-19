namespace javax.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.sql.RowSetInternal_))]
	public interface RowSetInternal  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object[] getParams();
		global::java.sql.Connection getConnection();
		global::java.sql.ResultSet getOriginal();
		void setMetaData(javax.sql.RowSetMetaData arg0);
		global::java.sql.ResultSet getOriginalRow();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.sql.RowSetInternal))]
	public sealed partial class RowSetInternal_ : java.lang.Object, RowSetInternal
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RowSetInternal_()
		{
			InitJNI();
		}
		internal RowSetInternal_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getParams24022;
		 global::java.lang.Object[] javax.sql.RowSetInternal.getParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSetInternal_._getParams24022)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSetInternal_.staticClass, global::javax.sql.RowSetInternal_._getParams24022)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _getConnection24023;
		 global::java.sql.Connection javax.sql.RowSetInternal.getConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSetInternal_._getConnection24023)) as java.sql.Connection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSetInternal_.staticClass, global::javax.sql.RowSetInternal_._getConnection24023)) as java.sql.Connection;
		}
		internal static global::MonoJavaBridge.MethodId _getOriginal24024;
		 global::java.sql.ResultSet javax.sql.RowSetInternal.getOriginal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSetInternal_._getOriginal24024)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSetInternal_.staticClass, global::javax.sql.RowSetInternal_._getOriginal24024)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _setMetaData24025;
		 void javax.sql.RowSetInternal.setMetaData(javax.sql.RowSetMetaData arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetInternal_._setMetaData24025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetInternal_.staticClass, global::javax.sql.RowSetInternal_._setMetaData24025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOriginalRow24026;
		 global::java.sql.ResultSet javax.sql.RowSetInternal.getOriginalRow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSetInternal_._getOriginalRow24026)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSetInternal_.staticClass, global::javax.sql.RowSetInternal_._getOriginalRow24026)) as java.sql.ResultSet;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.sql.RowSetInternal_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/sql/RowSetInternal"));
			global::javax.sql.RowSetInternal_._getParams24022 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetInternal_.staticClass, "getParams", "()[Ljava/lang/Object;");
			global::javax.sql.RowSetInternal_._getConnection24023 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetInternal_.staticClass, "getConnection", "()Ljava/sql/Connection;");
			global::javax.sql.RowSetInternal_._getOriginal24024 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetInternal_.staticClass, "getOriginal", "()Ljava/sql/ResultSet;");
			global::javax.sql.RowSetInternal_._setMetaData24025 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetInternal_.staticClass, "setMetaData", "(Ljavax/sql/RowSetMetaData;)V");
			global::javax.sql.RowSetInternal_._getOriginalRow24026 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetInternal_.staticClass, "getOriginalRow", "()Ljava/sql/ResultSet;");
		}
	}
}
