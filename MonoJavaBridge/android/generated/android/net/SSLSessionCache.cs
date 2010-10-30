namespace android.net
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class SSLSessionCache : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SSLSessionCache(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SSLSessionCache7766;
		public SSLSessionCache(java.io.File arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.SSLSessionCache._SSLSessionCache7766.native == global::System.IntPtr.Zero)
				global::android.net.SSLSessionCache._SSLSessionCache7766 = @__env.GetMethodIDNoThrow(global::android.net.SSLSessionCache.staticClass, "<init>", "(Ljava/io/File;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.SSLSessionCache.staticClass, global::android.net.SSLSessionCache._SSLSessionCache7766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SSLSessionCache7767;
		public SSLSessionCache(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.SSLSessionCache._SSLSessionCache7767.native == global::System.IntPtr.Zero)
				global::android.net.SSLSessionCache._SSLSessionCache7767 = @__env.GetMethodIDNoThrow(global::android.net.SSLSessionCache.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.SSLSessionCache.staticClass, global::android.net.SSLSessionCache._SSLSessionCache7767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static SSLSessionCache()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.SSLSessionCache.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/SSLSessionCache"));
		}
		internal static void InitJNI()
		{
		}
	}
}
