namespace javax.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.sql.RowSetWriter_))]
	public partial interface RowSetWriter  : global::MonoJavaBridge.IJavaObject 
	{
		bool writeData(javax.sql.RowSetInternal arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.sql.RowSetWriter))]
	internal sealed partial class RowSetWriter_ : java.lang.Object, RowSetWriter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal RowSetWriter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeData30622;
		bool javax.sql.RowSetWriter.writeData(javax.sql.RowSetInternal arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSetWriter_._writeData30622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static RowSetWriter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.sql.RowSetWriter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/sql/RowSetWriter"));
			global::javax.sql.RowSetWriter_._writeData30622 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetWriter_.staticClass, "writeData", "(Ljavax/sql/RowSetInternal;)Z");
		}
		internal static void InitJNI()
		{
		}
	}
}
