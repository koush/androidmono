namespace android.net
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Proxy : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Proxy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getPort7747;
		public static int getPort(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.net.Proxy.staticClass, global::android.net.Proxy._getPort7747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int DefaultPort
		{
			get
			{
				return getDefaultPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultPort7748;
		public static int getDefaultPort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.net.Proxy.staticClass, global::android.net.Proxy._getDefaultPort7748);
		}
		internal static global::MonoJavaBridge.MethodId _getHost7749;
		public static global::java.lang.String getHost(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.net.Proxy.staticClass, global::android.net.Proxy._getHost7749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		public static global::java.lang.String DefaultHost
		{
			get
			{
				return getDefaultHost();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultHost7750;
		public static global::java.lang.String getDefaultHost()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.net.Proxy.staticClass, global::android.net.Proxy._getDefaultHost7750)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _Proxy7751;
		public Proxy() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.Proxy.staticClass, global::android.net.Proxy._Proxy7751);
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
			global::android.net.Proxy._getPort7747 = @__env.GetStaticMethodIDNoThrow(global::android.net.Proxy.staticClass, "getPort", "(Landroid/content/Context;)I");
			global::android.net.Proxy._getDefaultPort7748 = @__env.GetStaticMethodIDNoThrow(global::android.net.Proxy.staticClass, "getDefaultPort", "()I");
			global::android.net.Proxy._getHost7749 = @__env.GetStaticMethodIDNoThrow(global::android.net.Proxy.staticClass, "getHost", "(Landroid/content/Context;)Ljava/lang/String;");
			global::android.net.Proxy._getDefaultHost7750 = @__env.GetStaticMethodIDNoThrow(global::android.net.Proxy.staticClass, "getDefaultHost", "()Ljava/lang/String;");
			global::android.net.Proxy._Proxy7751 = @__env.GetMethodIDNoThrow(global::android.net.Proxy.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
