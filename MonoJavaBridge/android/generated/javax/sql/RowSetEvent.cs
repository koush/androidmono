namespace javax.sql
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RowSetEvent : java.util.EventObject
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RowSetEvent(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public RowSetEvent(javax.sql.RowSet arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.sql.RowSetEvent._m0.native == global::System.IntPtr.Zero)
				global::javax.sql.RowSetEvent._m0 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetEvent.staticClass, "<init>", "(Ljavax/sql/RowSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.sql.RowSetEvent.staticClass, global::javax.sql.RowSetEvent._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static RowSetEvent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.sql.RowSetEvent.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/sql/RowSetEvent"));
		}
		internal static void InitJNI()
		{
		}
	}
}
