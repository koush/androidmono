namespace javax.sql
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RowSetEvent : java.util.EventObject
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RowSetEvent(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _RowSetEvent30574;
		public RowSetEvent(javax.sql.RowSet arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.sql.RowSetEvent.staticClass, global::javax.sql.RowSetEvent._RowSetEvent30574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static RowSetEvent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.sql.RowSetEvent.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/sql/RowSetEvent"));
			global::javax.sql.RowSetEvent._RowSetEvent30574 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetEvent.staticClass, "<init>", "(Ljavax/sql/RowSet;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
