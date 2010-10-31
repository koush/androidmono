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
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String getMethod()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.client.methods.HttpOptions.staticClass, "getMethod", "()Ljava/lang/String;", ref global::org.apache.http.client.methods.HttpOptions._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.util.Set getAllowedMethods(org.apache.http.HttpResponse arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::org.apache.http.client.methods.HttpOptions.staticClass, "getAllowedMethods", "(Lorg/apache/http/HttpResponse;)Ljava/util/Set;", ref global::org.apache.http.client.methods.HttpOptions._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public HttpOptions() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.methods.HttpOptions._m2.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.methods.HttpOptions._m2 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpOptions.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpOptions.staticClass, global::org.apache.http.client.methods.HttpOptions._m2);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public HttpOptions(java.net.URI arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.methods.HttpOptions._m3.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.methods.HttpOptions._m3 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpOptions.staticClass, "<init>", "(Ljava/net/URI;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpOptions.staticClass, global::org.apache.http.client.methods.HttpOptions._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public HttpOptions(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.methods.HttpOptions._m4.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.methods.HttpOptions._m4 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpOptions.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpOptions.staticClass, global::org.apache.http.client.methods.HttpOptions._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
	}
}
