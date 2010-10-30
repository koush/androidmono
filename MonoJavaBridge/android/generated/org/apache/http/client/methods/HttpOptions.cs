namespace org.apache.http.client.methods
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpOptions : org.apache.http.client.methods.HttpRequestBase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HttpOptions(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Method
		{
			get
			{
				return getMethod();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMethod31930;
		public override global::java.lang.String getMethod()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.methods.HttpOptions._getMethod31930.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.methods.HttpOptions._getMethod31930 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpOptions.staticClass, "getMethod", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.client.methods.HttpOptions.staticClass, global::org.apache.http.client.methods.HttpOptions._getMethod31930) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAllowedMethods31931;
		public virtual global::java.util.Set getAllowedMethods(org.apache.http.HttpResponse arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.methods.HttpOptions._getAllowedMethods31931.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.methods.HttpOptions._getAllowedMethods31931 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpOptions.staticClass, "getAllowedMethods", "(Lorg/apache/http/HttpResponse;)Ljava/util/Set;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::org.apache.http.client.methods.HttpOptions.staticClass, global::org.apache.http.client.methods.HttpOptions._getAllowedMethods31931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _HttpOptions31932;
		public HttpOptions() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.methods.HttpOptions._HttpOptions31932.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.methods.HttpOptions._HttpOptions31932 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpOptions.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpOptions.staticClass, global::org.apache.http.client.methods.HttpOptions._HttpOptions31932);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpOptions31933;
		public HttpOptions(java.net.URI arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.methods.HttpOptions._HttpOptions31933.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.methods.HttpOptions._HttpOptions31933 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpOptions.staticClass, "<init>", "(Ljava/net/URI;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpOptions.staticClass, global::org.apache.http.client.methods.HttpOptions._HttpOptions31933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpOptions31934;
		public HttpOptions(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.methods.HttpOptions._HttpOptions31934.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.methods.HttpOptions._HttpOptions31934 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpOptions.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpOptions.staticClass, global::org.apache.http.client.methods.HttpOptions._HttpOptions31934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static global::java.lang.String METHOD_NAME
		{
			get
			{
				return "OPTIONS";
			}
		}
		static HttpOptions()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.methods.HttpOptions.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/methods/HttpOptions"));
		}
		internal static void InitJNI()
		{
		}
	}
}
