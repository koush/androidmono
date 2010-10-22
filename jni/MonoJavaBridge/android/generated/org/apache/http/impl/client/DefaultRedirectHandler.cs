namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DefaultRedirectHandler : java.lang.Object, org.apache.http.client.RedirectHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DefaultRedirectHandler()
		{
			InitJNI();
		}
		protected DefaultRedirectHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isRedirectRequested32792;
		public virtual bool isRedirectRequested(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultRedirectHandler._isRedirectRequested32792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultRedirectHandler.staticClass, global::org.apache.http.impl.client.DefaultRedirectHandler._isRedirectRequested32792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLocationURI32793;
		public virtual global::java.net.URI getLocationURI(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URI>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultRedirectHandler._getLocationURI32793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.URI;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URI>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultRedirectHandler.staticClass, global::org.apache.http.impl.client.DefaultRedirectHandler._getLocationURI32793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _DefaultRedirectHandler32794;
		public DefaultRedirectHandler()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.DefaultRedirectHandler.staticClass, global::org.apache.http.impl.client.DefaultRedirectHandler._DefaultRedirectHandler32794);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.DefaultRedirectHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/DefaultRedirectHandler"));
			global::org.apache.http.impl.client.DefaultRedirectHandler._isRedirectRequested32792 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultRedirectHandler.staticClass, "isRedirectRequested", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Z");
			global::org.apache.http.impl.client.DefaultRedirectHandler._getLocationURI32793 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultRedirectHandler.staticClass, "getLocationURI", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Ljava/net/URI;");
			global::org.apache.http.impl.client.DefaultRedirectHandler._DefaultRedirectHandler32794 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultRedirectHandler.staticClass, "<init>", "()V");
		}
	}
}
