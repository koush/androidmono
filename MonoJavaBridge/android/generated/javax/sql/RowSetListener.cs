namespace javax.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.sql.RowSetListener_))]
	public partial interface RowSetListener : java.util.EventListener
	{
		void rowSetChanged(javax.sql.RowSetEvent arg0);
		void rowChanged(javax.sql.RowSetEvent arg0);
		void cursorMoved(javax.sql.RowSetEvent arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.sql.RowSetListener))]
	internal sealed partial class RowSetListener_ : java.lang.Object, RowSetListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal RowSetListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void javax.sql.RowSetListener.rowSetChanged(javax.sql.RowSetEvent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetListener_.staticClass, "rowSetChanged", "(Ljavax/sql/RowSetEvent;)V", ref global::javax.sql.RowSetListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void javax.sql.RowSetListener.rowChanged(javax.sql.RowSetEvent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetListener_.staticClass, "rowChanged", "(Ljavax/sql/RowSetEvent;)V", ref global::javax.sql.RowSetListener_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void javax.sql.RowSetListener.cursorMoved(javax.sql.RowSetEvent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetListener_.staticClass, "cursorMoved", "(Ljavax/sql/RowSetEvent;)V", ref global::javax.sql.RowSetListener_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static RowSetListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.sql.RowSetListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/sql/RowSetListener"));
		}
	}
}
