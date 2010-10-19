namespace android.net
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Proxy : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Proxy()
		{
			InitJNI();
		}
		internal Proxy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getPort5235;
		public static int getPort(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.net.Proxy.staticClass, global::android.net.Proxy._getPort5235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int DefaultPort
		{
			get
			{
				return getDefaultPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultPort5236;
		public static int getDefaultPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.net.Proxy.staticClass, global::android.net.Proxy._getDefaultPort5236);
		}
		internal static global::MonoJavaBridge.MethodId _getHost5237;
		public static global::java.lang.String getHost(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.Proxy.staticClass, global::android.net.Proxy._getHost5237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		public static global::java.lang.String DefaultHost
		{
			get
			{
				return getDefaultHost();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultHost5238;
		public static global::java.lang.String getDefaultHost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.Proxy.staticClass, global::android.net.Proxy._getDefaultHost5238)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _Proxy5239;
		public Proxy()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.Proxy.staticClass, global::android.net.Proxy._Proxy5239);
			Init(@__env, handle);
		}
		public static global::java.lang.String PROXY_CHANGE_ACTION
		{
			get
			{
				return "android.intent.action.PROXY_CHANGE";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.Proxy.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/Proxy"));
			global::android.net.Proxy._getPort5235 = @__env.GetStaticMethodIDNoThrow(global::android.net.Proxy.staticClass, "getPort", "(Landroid/content/Context;)I");
			global::android.net.Proxy._getDefaultPort5236 = @__env.GetStaticMethodIDNoThrow(global::android.net.Proxy.staticClass, "getDefaultPort", "()I");
			global::android.net.Proxy._getHost5237 = @__env.GetStaticMethodIDNoThrow(global::android.net.Proxy.staticClass, "getHost", "(Landroid/content/Context;)Ljava/lang/String;");
			global::android.net.Proxy._getDefaultHost5238 = @__env.GetStaticMethodIDNoThrow(global::android.net.Proxy.staticClass, "getDefaultHost", "()Ljava/lang/String;");
			global::android.net.Proxy._Proxy5239 = @__env.GetMethodIDNoThrow(global::android.net.Proxy.staticClass, "<init>", "()V");
		}
	}
}
