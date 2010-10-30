namespace android.net
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Proxy : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Proxy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static int getPort(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.Proxy._m0.native == global::System.IntPtr.Zero)
				global::android.net.Proxy._m0 = @__env.GetStaticMethodIDNoThrow(global::android.net.Proxy.staticClass, "getPort", "(Landroid/content/Context;)I");
			return @__env.CallStaticIntMethod(android.net.Proxy.staticClass, global::android.net.Proxy._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int DefaultPort
		{
			get
			{
				return getDefaultPort();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static int getDefaultPort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.Proxy._m1.native == global::System.IntPtr.Zero)
				global::android.net.Proxy._m1 = @__env.GetStaticMethodIDNoThrow(global::android.net.Proxy.staticClass, "getDefaultPort", "()I");
			return @__env.CallStaticIntMethod(android.net.Proxy.staticClass, global::android.net.Proxy._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.lang.String getHost(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.Proxy._m2.native == global::System.IntPtr.Zero)
				global::android.net.Proxy._m2 = @__env.GetStaticMethodIDNoThrow(global::android.net.Proxy.staticClass, "getHost", "(Landroid/content/Context;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.net.Proxy.staticClass, global::android.net.Proxy._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		public static global::java.lang.String DefaultHost
		{
			get
			{
				return getDefaultHost();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::java.lang.String getDefaultHost()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.Proxy._m3.native == global::System.IntPtr.Zero)
				global::android.net.Proxy._m3 = @__env.GetStaticMethodIDNoThrow(global::android.net.Proxy.staticClass, "getDefaultHost", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.net.Proxy.staticClass, global::android.net.Proxy._m3)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public Proxy() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.Proxy._m4.native == global::System.IntPtr.Zero)
				global::android.net.Proxy._m4 = @__env.GetMethodIDNoThrow(global::android.net.Proxy.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.Proxy.staticClass, global::android.net.Proxy._m4);
			Init(@__env, handle);
		}
		public static global::java.lang.String PROXY_CHANGE_ACTION
		{
			get
			{
				return "android.intent.action.PROXY_CHANGE";
			}
		}
		static Proxy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.Proxy.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/Proxy"));
		}
		internal static void InitJNI()
		{
		}
	}
}
