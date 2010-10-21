namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.SQLData_))]
	public interface SQLData  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String getSQLTypeName();
		void readSQL(java.sql.SQLInput arg0, java.lang.String arg1);
		void writeSQL(java.sql.SQLOutput arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.sql.SQLData))]
	public sealed partial class SQLData_ : java.lang.Object, SQLData
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SQLData_()
		{
			InitJNI();
		}
		internal SQLData_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getSQLTypeName24848;
		 global::java.lang.String java.sql.SQLData.getSQLTypeName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLData_._getSQLTypeName24848)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.SQLData_.staticClass, global::java.sql.SQLData_._getSQLTypeName24848)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readSQL24849;
		 void java.sql.SQLData.readSQL(java.sql.SQLInput arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLData_._readSQL24849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLData_.staticClass, global::java.sql.SQLData_._readSQL24849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeSQL24850;
		 void java.sql.SQLData.writeSQL(java.sql.SQLOutput arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLData_._writeSQL24850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLData_.staticClass, global::java.sql.SQLData_._writeSQL24850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.SQLData_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/SQLData"));
			global::java.sql.SQLData_._getSQLTypeName24848 = @__env.GetMethodIDNoThrow(global::java.sql.SQLData_.staticClass, "getSQLTypeName", "()Ljava/lang/String;");
			global::java.sql.SQLData_._readSQL24849 = @__env.GetMethodIDNoThrow(global::java.sql.SQLData_.staticClass, "readSQL", "(Ljava/sql/SQLInput;Ljava/lang/String;)V");
			global::java.sql.SQLData_._writeSQL24850 = @__env.GetMethodIDNoThrow(global::java.sql.SQLData_.staticClass, "writeSQL", "(Ljava/sql/SQLOutput;)V");
		}
	}
}
