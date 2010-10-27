namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicResponseHandler : java.lang.Object, org.apache.http.client.ResponseHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BasicResponseHandler()
		{
			InitJNI();
		}
		protected BasicResponseHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _handleResponse32867;
		public virtual global::java.lang.Object handleResponse(org.apache.http.HttpResponse arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.BasicResponseHandler._handleResponse32867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.BasicResponseHandler.staticClass, global::org.apache.http.impl.client.BasicResponseHandler._handleResponse32867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _BasicResponseHandler32868;
		public BasicResponseHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.BasicResponseHandler.staticClass, global::org.apache.http.impl.client.BasicResponseHandler._BasicResponseHandler32868);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.BasicResponseHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/BasicResponseHandler"));
			global::org.apache.http.impl.client.BasicResponseHandler._handleResponse32867 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.BasicResponseHandler.staticClass, "handleResponse", "(Lorg/apache/http/HttpResponse;)Ljava/lang/Object;");
			global::org.apache.http.impl.client.BasicResponseHandler._BasicResponseHandler32868 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.BasicResponseHandler.staticClass, "<init>", "()V");
		}
	}
}
