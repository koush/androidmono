namespace javax.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.sql.RowSetReader_))]
	public partial interface RowSetReader  : global::MonoJavaBridge.IJavaObject 
	{
		void readData(javax.sql.RowSetInternal arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.sql.RowSetReader))]
	internal sealed partial class RowSetReader_ : java.lang.Object, RowSetReader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal RowSetReader_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _readData30621;
		void javax.sql.RowSetReader.readData(javax.sql.RowSetInternal arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetReader_.staticClass, "readData", "(Ljavax/sql/RowSetInternal;)V", ref global::javax.sql.RowSetReader_._readData30621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static RowSetReader_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.sql.RowSetReader_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/sql/RowSetReader"));
		}
		internal static void InitJNI()
		{
		}
	}
}
