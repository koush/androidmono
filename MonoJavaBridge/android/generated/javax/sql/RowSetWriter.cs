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
		private static global::MonoJavaBridge.MethodId _m0;
		bool javax.sql.RowSetWriter.writeData(javax.sql.RowSetInternal arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.sql.RowSetWriter_.staticClass, "writeData", "(Ljavax/sql/RowSetInternal;)Z", ref global::javax.sql.RowSetWriter_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static RowSetWriter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.sql.RowSetWriter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/sql/RowSetWriter"));
		}
		internal static void InitJNI()
		{
		}
	}
}
