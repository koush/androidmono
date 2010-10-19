namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class PluginData : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PluginData()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getInputStream10893;
		public global::java.io.InputStream getInputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.PluginData._getInputStream10893)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.PluginData.staticClass, global::android.webkit.PluginData._getInputStream10893)) as java.io.InputStream;
		}
		public new long ContentLength
		{
			get
			{
				return getContentLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentLength10894;
		public long getContentLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.webkit.PluginData._getContentLength10894);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.webkit.PluginData.staticClass, global::android.webkit.PluginData._getContentLength10894);
		}
		public new global::java.util.Map Headers
		{
			get
			{
				return getHeaders();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHeaders10895;
		public global::java.util.Map getHeaders() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.PluginData._getHeaders10895)) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.PluginData.staticClass, global::android.webkit.PluginData._getHeaders10895)) as java.util.Map;
		}
		public new int StatusCode
		{
			get
			{
				return getStatusCode();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStatusCode10896;
		public int getStatusCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.PluginData._getStatusCode10896);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.PluginData.staticClass, global::android.webkit.PluginData._getStatusCode10896);
		}
		internal static global::MonoJavaBridge.MethodId _PluginData10897;
		public PluginData(java.io.InputStream arg0, long arg1, java.util.Map arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.PluginData.staticClass, global::android.webkit.PluginData._PluginData10897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.PluginData.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/PluginData"));
			global::android.webkit.PluginData._getInputStream10893 = @__env.GetMethodIDNoThrow(global::android.webkit.PluginData.staticClass, "getInputStream", "()Ljava/io/InputStream;");
			global::android.webkit.PluginData._getContentLength10894 = @__env.GetMethodIDNoThrow(global::android.webkit.PluginData.staticClass, "getContentLength", "()J");
			global::android.webkit.PluginData._getHeaders10895 = @__env.GetMethodIDNoThrow(global::android.webkit.PluginData.staticClass, "getHeaders", "()Ljava/util/Map;");
			global::android.webkit.PluginData._getStatusCode10896 = @__env.GetMethodIDNoThrow(global::android.webkit.PluginData.staticClass, "getStatusCode", "()I");
			global::android.webkit.PluginData._PluginData10897 = @__env.GetMethodIDNoThrow(global::android.webkit.PluginData.staticClass, "<init>", "(Ljava/io/InputStream;JLjava/util/Map;I)V");
		}
	}
}
