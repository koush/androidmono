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
		internal static global::MonoJavaBridge.MethodId _rowSetChanged30580;
		void javax.sql.RowSetListener.rowSetChanged(javax.sql.RowSetEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetListener_._rowSetChanged30580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rowChanged30581;
		void javax.sql.RowSetListener.rowChanged(javax.sql.RowSetEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetListener_._rowChanged30581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cursorMoved30582;
		void javax.sql.RowSetListener.cursorMoved(javax.sql.RowSetEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetListener_._cursorMoved30582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static RowSetListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.sql.RowSetListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/sql/RowSetListener"));
			global::javax.sql.RowSetListener_._rowSetChanged30580 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetListener_.staticClass, "rowSetChanged", "(Ljavax/sql/RowSetEvent;)V");
			global::javax.sql.RowSetListener_._rowChanged30581 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetListener_.staticClass, "rowChanged", "(Ljavax/sql/RowSetEvent;)V");
			global::javax.sql.RowSetListener_._cursorMoved30582 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetListener_.staticClass, "cursorMoved", "(Ljavax/sql/RowSetEvent;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
