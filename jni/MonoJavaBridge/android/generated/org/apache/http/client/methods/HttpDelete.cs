namespace org.apache.http.client.methods
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpDelete : org.apache.http.client.methods.HttpRequestBase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpDelete()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getMethod25245;
		public override global::java.lang.String getMethod() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpDelete._getMethod25245)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpDelete.staticClass, global::org.apache.http.client.methods.HttpDelete._getMethod25245)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _HttpDelete25246;
		public HttpDelete()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpDelete.staticClass, global::org.apache.http.client.methods.HttpDelete._HttpDelete25246);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpDelete25247;
		public HttpDelete(java.net.URI arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpDelete.staticClass, global::org.apache.http.client.methods.HttpDelete._HttpDelete25247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpDelete25248;
		public HttpDelete(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpDelete.staticClass, global::org.apache.http.client.methods.HttpDelete._HttpDelete25248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static global::java.lang.String METHOD_NAME
		{
			get
			{
				return "DELETE";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.methods.HttpDelete.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/methods/HttpDelete"));
			global::org.apache.http.client.methods.HttpDelete._getMethod25245 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpDelete.staticClass, "getMethod", "()Ljava/lang/String;");
			global::org.apache.http.client.methods.HttpDelete._HttpDelete25246 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpDelete.staticClass, "<init>", "()V");
			global::org.apache.http.client.methods.HttpDelete._HttpDelete25247 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpDelete.staticClass, "<init>", "(Ljava/net/URI;)V");
			global::org.apache.http.client.methods.HttpDelete._HttpDelete25248 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpDelete.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
