namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SSLSessionBindingEvent : java.util.EventObject
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SSLSessionBindingEvent(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLSessionBindingEvent.staticClass, "getName", "()Ljava/lang/String;", ref global::javax.net.ssl.SSLSessionBindingEvent._m0) as java.lang.String;
		}
		public new global::javax.net.ssl.SSLSession Session
		{
			get
			{
				return getSession();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::javax.net.ssl.SSLSession getSession()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.net.ssl.SSLSession>(this, global::javax.net.ssl.SSLSessionBindingEvent.staticClass, "getSession", "()Ljavax/net/ssl/SSLSession;", ref global::javax.net.ssl.SSLSessionBindingEvent._m1) as javax.net.ssl.SSLSession;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public SSLSessionBindingEvent(javax.net.ssl.SSLSession arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLSessionBindingEvent._m2.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLSessionBindingEvent._m2 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSessionBindingEvent.staticClass, "<init>", "(Ljavax/net/ssl/SSLSession;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLSessionBindingEvent.staticClass, global::javax.net.ssl.SSLSessionBindingEvent._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static SSLSessionBindingEvent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLSessionBindingEvent.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLSessionBindingEvent"));
		}
	}
}
