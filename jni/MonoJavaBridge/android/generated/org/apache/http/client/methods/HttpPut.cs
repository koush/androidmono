namespace org.apache.http.client.methods
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpPut : org.apache.http.client.methods.HttpEntityEnclosingRequestBase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpPut()
		{
			InitJNI();
		}
		protected HttpPut(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Method
		{
			get
			{
				return getMethod();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMethod31940;
		public override global::java.lang.String getMethod() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpPut._getMethod31940)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpPut.staticClass, global::org.apache.http.client.methods.HttpPut._getMethod31940)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _HttpPut31941;
		public HttpPut()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpPut.staticClass, global::org.apache.http.client.methods.HttpPut._HttpPut31941);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpPut31942;
		public HttpPut(java.net.URI arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpPut.staticClass, global::org.apache.http.client.methods.HttpPut._HttpPut31942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpPut31943;
		public HttpPut(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpPut.staticClass, global::org.apache.http.client.methods.HttpPut._HttpPut31943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static global::java.lang.String METHOD_NAME
		{
			get
			{
				return "PUT";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.methods.HttpPut.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/methods/HttpPut"));
			global::org.apache.http.client.methods.HttpPut._getMethod31940 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpPut.staticClass, "getMethod", "()Ljava/lang/String;");
			global::org.apache.http.client.methods.HttpPut._HttpPut31941 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpPut.staticClass, "<init>", "()V");
			global::org.apache.http.client.methods.HttpPut._HttpPut31942 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpPut.staticClass, "<init>", "(Ljava/net/URI;)V");
			global::org.apache.http.client.methods.HttpPut._HttpPut31943 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpPut.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
