namespace org.apache.http.client
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.client.RedirectHandler_))]
	public partial interface RedirectHandler  : global::MonoJavaBridge.IJavaObject 
	{
		bool isRedirectRequested(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1);
		global::java.net.URI getLocationURI(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.client.RedirectHandler))]
	internal sealed partial class RedirectHandler_ : java.lang.Object, RedirectHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal RedirectHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isRedirectRequested31899;
		bool org.apache.http.client.RedirectHandler.isRedirectRequested(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.client.RedirectHandler_._isRedirectRequested31899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLocationURI31900;
		global::java.net.URI org.apache.http.client.RedirectHandler.getLocationURI(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URI>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.RedirectHandler_._getLocationURI31900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.URI;
		}
		static RedirectHandler_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.RedirectHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/RedirectHandler"));
			global::org.apache.http.client.RedirectHandler_._isRedirectRequested31899 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.RedirectHandler_.staticClass, "isRedirectRequested", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Z");
			global::org.apache.http.client.RedirectHandler_._getLocationURI31900 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.RedirectHandler_.staticClass, "getLocationURI", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Ljava/net/URI;");
		}
		internal static void InitJNI()
		{
		}
	}
}
