namespace java.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.net.CookieHandler_))]
	public abstract partial class CookieHandler : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CookieHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract global::java.util.Map get(java.net.URI arg0, java.util.Map arg1);
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract void put(java.net.URI arg0, java.util.Map arg1);
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.net.CookieHandler getDefault()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.CookieHandler._m2.native == global::System.IntPtr.Zero)
				global::java.net.CookieHandler._m2 = @__env.GetStaticMethodIDNoThrow(global::java.net.CookieHandler.staticClass, "getDefault", "()Ljava/net/CookieHandler;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.CookieHandler.staticClass, global::java.net.CookieHandler._m2)) as java.net.CookieHandler;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static void setDefault(java.net.CookieHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.CookieHandler._m3.native == global::System.IntPtr.Zero)
				global::java.net.CookieHandler._m3 = @__env.GetStaticMethodIDNoThrow(global::java.net.CookieHandler.staticClass, "setDefault", "(Ljava/net/CookieHandler;)V");
			@__env.CallStaticVoidMethod(java.net.CookieHandler.staticClass, global::java.net.CookieHandler._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public CookieHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.CookieHandler._m4.native == global::System.IntPtr.Zero)
				global::java.net.CookieHandler._m4 = @__env.GetMethodIDNoThrow(global::java.net.CookieHandler.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.CookieHandler.staticClass, global::java.net.CookieHandler._m4);
			Init(@__env, handle);
		}
		static CookieHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.CookieHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/CookieHandler"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.CookieHandler))]
	internal sealed partial class CookieHandler_ : java.net.CookieHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CookieHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.util.Map get(java.net.URI arg0, java.util.Map arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map>(this, global::java.net.CookieHandler_.staticClass, "get", "(Ljava/net/URI;Ljava/util/Map;)Ljava/util/Map;", ref global::java.net.CookieHandler_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.Map;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void put(java.net.URI arg0, java.util.Map arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.CookieHandler_.staticClass, "put", "(Ljava/net/URI;Ljava/util/Map;)V", ref global::java.net.CookieHandler_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static CookieHandler_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.CookieHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/CookieHandler"));
		}
	}
}
