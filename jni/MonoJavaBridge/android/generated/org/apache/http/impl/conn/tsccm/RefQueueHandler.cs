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
		static RefQueueHandler_()
		{
			InitJNI();
		}
		internal RefQueueHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _handleReference33153;
		void org.apache.http.impl.conn.tsccm.RefQueueHandler.handleReference(java.lang.@ref.Reference arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.RefQueueHandler_._handleReference33153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.RefQueueHandler_.staticClass, global::org.apache.http.impl.conn.tsccm.RefQueueHandler_._handleReference33153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.tsccm.RefQueueHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/tsccm/RefQueueHandler"));
			global::org.apache.http.impl.conn.tsccm.RefQueueHandler_._handleReference33153 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.RefQueueHandler_.staticClass, "handleReference", "(Ljava/lang/ref/Reference;)V");
		}
	}
}
