namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.net.ssl.HandshakeCompletedListener_))]
	public partial interface HandshakeCompletedListener : java.util.EventListener
	{
		void handshakeCompleted(javax.net.ssl.HandshakeCompletedEvent arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.HandshakeCompletedListener))]
	internal sealed partial class HandshakeCompletedListener_ : java.lang.Object, HandshakeCompletedListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HandshakeCompletedListener_()
		{
			InitJNI();
		}
		internal HandshakeCompletedListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _handshakeCompleted29839;
		void javax.net.ssl.HandshakeCompletedListener.handshakeCompleted(javax.net.ssl.HandshakeCompletedEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.HandshakeCompletedListener_._handshakeCompleted29839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.HandshakeCompletedListener_.staticClass, global::javax.net.ssl.HandshakeCompletedListener_._handshakeCompleted29839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.HandshakeCompletedListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/HandshakeCompletedListener"));
			global::javax.net.ssl.HandshakeCompletedListener_._handshakeCompleted29839 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HandshakeCompletedListener_.staticClass, "handshakeCompleted", "(Ljavax/net/ssl/HandshakeCompletedEvent;)V");
		}
	}
}
