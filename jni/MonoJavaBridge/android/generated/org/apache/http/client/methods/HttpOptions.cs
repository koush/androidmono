namespace org.apache.http.client.methods
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpOptions : org.apache.http.client.methods.HttpRequestBase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpOptions()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getMethod31811;
		public override global::java.lang.String getMethod() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpOptions._getMethod31811)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpOptions.staticClass, global::org.apache.http.client.methods.HttpOptions._getMethod31811)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAllowedMethods31812;
		public virtual global::java.util.Set getAllowedMethods(org.apache.http.HttpResponse arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpOptions._getAllowedMethods31812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpOptions.staticClass, global::org.apache.http.client.methods.HttpOptions._getAllowedMethods31812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _HttpOptions31813;
		public HttpOptions()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpOptions.staticClass, global::org.apache.http.client.methods.HttpOptions._HttpOptions31813);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpOptions31814;
		public HttpOptions(java.net.URI arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpOptions.staticClass, global::org.apache.http.client.methods.HttpOptions._HttpOptions31814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpOptions31815;
		public HttpOptions(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpOptions.staticClass, global::org.apache.http.client.methods.HttpOptions._HttpOptions31815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static global::java.lang.String METHOD_NAME
		{
			get
			{
				return "OPTIONS";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.methods.HttpOptions.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/methods/HttpOptions"));
			global::org.apache.http.client.methods.HttpOptions._getMethod31811 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpOptions.staticClass, "getMethod", "()Ljava/lang/String;");
			global::org.apache.http.client.methods.HttpOptions._getAllowedMethods31812 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpOptions.staticClass, "getAllowedMethods", "(Lorg/apache/http/HttpResponse;)Ljava/util/Set;");
			global::org.apache.http.client.methods.HttpOptions._HttpOptions31813 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpOptions.staticClass, "<init>", "()V");
			global::org.apache.http.client.methods.HttpOptions._HttpOptions31814 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpOptions.staticClass, "<init>", "(Ljava/net/URI;)V");
			global::org.apache.http.client.methods.HttpOptions._HttpOptions31815 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpOptions.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
