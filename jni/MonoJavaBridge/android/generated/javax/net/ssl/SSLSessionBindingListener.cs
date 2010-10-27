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
		static SSLSessionBindingListener_()
		{
			InitJNI();
		}
		internal SSLSessionBindingListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _valueBound30060;
		void javax.net.ssl.SSLSessionBindingListener.valueBound(javax.net.ssl.SSLSessionBindingEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionBindingListener_._valueBound30060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionBindingListener_.staticClass, global::javax.net.ssl.SSLSessionBindingListener_._valueBound30060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueUnbound30061;
		void javax.net.ssl.SSLSessionBindingListener.valueUnbound(javax.net.ssl.SSLSessionBindingEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionBindingListener_._valueUnbound30061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionBindingListener_.staticClass, global::javax.net.ssl.SSLSessionBindingListener_._valueUnbound30061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLSessionBindingListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLSessionBindingListener"));
			global::javax.net.ssl.SSLSessionBindingListener_._valueBound30060 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSessionBindingListener_.staticClass, "valueBound", "(Ljavax/net/ssl/SSLSessionBindingEvent;)V");
			global::javax.net.ssl.SSLSessionBindingListener_._valueUnbound30061 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSessionBindingListener_.staticClass, "valueUnbound", "(Ljavax/net/ssl/SSLSessionBindingEvent;)V");
		}
	}
}
