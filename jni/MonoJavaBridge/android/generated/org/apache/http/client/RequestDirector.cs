namespace org.apache.http.client
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.client.RequestDirector_))]
	public partial interface RequestDirector  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.apache.http.HttpResponse execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.protocol.HttpContext arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.client.RequestDirector))]
	internal sealed partial class RequestDirector_ : java.lang.Object, RequestDirector
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RequestDirector_()
		{
			InitJNI();
		}
		internal RequestDirector_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _execute31900;
		global::org.apache.http.HttpResponse org.apache.http.client.RequestDirector.execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.protocol.HttpContext arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.RequestDirector_._execute31900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.HttpResponse;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.client.RequestDirector_.staticClass, global::org.apache.http.client.RequestDirector_._execute31900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.HttpResponse;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.RequestDirector_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/RequestDirector"));
			global::org.apache.http.client.RequestDirector_._execute31900 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.RequestDirector_.staticClass, "execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/HttpResponse;");
		}
	}
}
