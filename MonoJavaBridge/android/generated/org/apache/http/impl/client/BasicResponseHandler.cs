namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicResponseHandler : java.lang.Object, org.apache.http.client.ResponseHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicResponseHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.Object handleResponse(org.apache.http.HttpResponse arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.client.BasicResponseHandler.staticClass, "handleResponse", "(Lorg/apache/http/HttpResponse;)Ljava/lang/Object;", ref global::org.apache.http.impl.client.BasicResponseHandler._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public BasicResponseHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.BasicResponseHandler._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.BasicResponseHandler._m1 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.BasicResponseHandler.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.BasicResponseHandler.staticClass, global::org.apache.http.impl.client.BasicResponseHandler._m1);
			Init(@__env, handle);
		}
		static BasicResponseHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.BasicResponseHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/BasicResponseHandler"));
		}
	}
}
