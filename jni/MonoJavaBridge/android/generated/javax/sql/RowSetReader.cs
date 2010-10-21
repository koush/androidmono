namespace javax.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.sql.RowSetReader_))]
	public interface RowSetReader  : global::MonoJavaBridge.IJavaObject 
	{
		void readData(javax.sql.RowSetInternal arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.sql.RowSetReader))]
	public sealed partial class RowSetReader_ : java.lang.Object, RowSetReader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RowSetReader_()
		{
			InitJNI();
		}
		internal RowSetReader_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _readData30502;
		 void javax.sql.RowSetReader.readData(javax.sql.RowSetInternal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetReader_._readData30502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetReader_.staticClass, global::javax.sql.RowSetReader_._readData30502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.sql.RowSetReader_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/sql/RowSetReader"));
			global::javax.sql.RowSetReader_._readData30502 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetReader_.staticClass, "readData", "(Ljavax/sql/RowSetInternal;)V");
		}
	}
}
