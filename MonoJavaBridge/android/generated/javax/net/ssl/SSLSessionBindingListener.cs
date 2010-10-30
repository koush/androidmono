namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.net.ssl.SSLSessionBindingListener_))]
	public partial interface SSLSessionBindingListener : java.util.EventListener
	{
		void valueBound(javax.net.ssl.SSLSessionBindingEvent arg0);
		void valueUnbound(javax.net.ssl.SSLSessionBindingEvent arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.SSLSessionBindingListener))]
	internal sealed partial class SSLSessionBindingListener_ : java.lang.Object, SSLSessionBindingListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SSLSessionBindingListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _valueBound30061;
		void javax.net.ssl.SSLSessionBindingListener.valueBound(javax.net.ssl.SSLSessionBindingEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLSessionBindingListener_._valueBound30061.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLSessionBindingListener_._valueBound30061 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSessionBindingListener_.staticClass, "valueBound", "(Ljavax/net/ssl/SSLSessionBindingEvent;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionBindingListener_._valueBound30061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueUnbound30062;
		void javax.net.ssl.SSLSessionBindingListener.valueUnbound(javax.net.ssl.SSLSessionBindingEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLSessionBindingListener_._valueUnbound30062.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLSessionBindingListener_._valueUnbound30062 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSessionBindingListener_.staticClass, "valueUnbound", "(Ljavax/net/ssl/SSLSessionBindingEvent;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionBindingListener_._valueUnbound30062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static SSLSessionBindingListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLSessionBindingListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLSessionBindingListener"));
		}
		internal static void InitJNI()
		{
		}
	}
}
