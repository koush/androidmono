namespace org.apache.http.client.methods
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpDelete : org.apache.http.client.methods.HttpRequestBase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HttpDelete(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Method
		{
			get
			{
				return getMethod();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMethod31909;
		public override global::java.lang.String getMethod()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.client.methods.HttpDelete.staticClass, global::org.apache.http.client.methods.HttpDelete._getMethod31909)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _HttpDelete31910;
		public HttpDelete() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpDelete.staticClass, global::org.apache.http.client.methods.HttpDelete._HttpDelete31910);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpDelete31911;
		public HttpDelete(java.net.URI arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpDelete.staticClass, global::org.apache.http.client.methods.HttpDelete._HttpDelete31911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpDelete31912;
		public HttpDelete(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpDelete.staticClass, global::org.apache.http.client.methods.HttpDelete._HttpDelete31912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static global::java.lang.String METHOD_NAME
		{
			get
			{
				return "DELETE";
			}
		}
		static HttpDelete()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.methods.HttpDelete.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/methods/HttpDelete"));
			global::org.apache.http.client.methods.HttpDelete._getMethod31909 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpDelete.staticClass, "getMethod", "()Ljava/lang/String;");
			global::org.apache.http.client.methods.HttpDelete._HttpDelete31910 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpDelete.staticClass, "<init>", "()V");
			global::org.apache.http.client.methods.HttpDelete._HttpDelete31911 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpDelete.staticClass, "<init>", "(Ljava/net/URI;)V");
			global::org.apache.http.client.methods.HttpDelete._HttpDelete31912 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpDelete.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
