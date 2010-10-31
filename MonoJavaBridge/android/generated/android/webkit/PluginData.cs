namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class PluginData : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal PluginData(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.io.InputStream InputStream
		{
			get
			{
				return getInputStream();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public global::java.io.InputStream getInputStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.PluginData.staticClass, "getInputStream", "()Ljava/io/InputStream;", ref global::android.webkit.PluginData._m0) as java.io.InputStream;
		}
		public new long ContentLength
		{
			get
			{
				return getContentLength();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public long getContentLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.webkit.PluginData.staticClass, "getContentLength", "()J", ref global::android.webkit.PluginData._m1);
		}
		public new global::java.util.Map Headers
		{
			get
			{
				return getHeaders();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public global::java.util.Map getHeaders()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map>(this, global::android.webkit.PluginData.staticClass, "getHeaders", "()Ljava/util/Map;", ref global::android.webkit.PluginData._m2) as java.util.Map;
		}
		public new int StatusCode
		{
			get
			{
				return getStatusCode();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public int getStatusCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.PluginData.staticClass, "getStatusCode", "()I", ref global::android.webkit.PluginData._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public PluginData(java.io.InputStream arg0, long arg1, java.util.Map arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.PluginData._m4.native == global::System.IntPtr.Zero)
				global::android.webkit.PluginData._m4 = @__env.GetMethodIDNoThrow(global::android.webkit.PluginData.staticClass, "<init>", "(Ljava/io/InputStream;JLjava/util/Map;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.PluginData.staticClass, global::android.webkit.PluginData._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static PluginData()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.PluginData.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/PluginData"));
		}
	}
}
