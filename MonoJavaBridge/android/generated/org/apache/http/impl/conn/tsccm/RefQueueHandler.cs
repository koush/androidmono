namespace org.apache.http.impl.conn.tsccm
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.impl.conn.tsccm.RefQueueHandler_))]
	public partial interface RefQueueHandler  : global::MonoJavaBridge.IJavaObject 
	{
		void handleReference(java.lang.@ref.Reference arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.conn.tsccm.RefQueueHandler))]
	internal sealed partial class RefQueueHandler_ : java.lang.Object, RefQueueHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal RefQueueHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void org.apache.http.impl.conn.tsccm.RefQueueHandler.handleReference(java.lang.@ref.Reference arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.RefQueueHandler_.staticClass, "handleReference", "(Ljava/lang/ref/Reference;)V", ref global::org.apache.http.impl.conn.tsccm.RefQueueHandler_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static RefQueueHandler_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.tsccm.RefQueueHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/tsccm/RefQueueHandler"));
		}
	}
}
