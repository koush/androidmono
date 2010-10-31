namespace org.apache.http.client
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.client.UserTokenHandler_))]
	public partial interface UserTokenHandler  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object getUserToken(org.apache.http.protocol.HttpContext arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.client.UserTokenHandler))]
	internal sealed partial class UserTokenHandler_ : java.lang.Object, UserTokenHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal UserTokenHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.Object org.apache.http.client.UserTokenHandler.getUserToken(org.apache.http.protocol.HttpContext arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.client.UserTokenHandler_.staticClass, "getUserToken", "(Lorg/apache/http/protocol/HttpContext;)Ljava/lang/Object;", ref global::org.apache.http.client.UserTokenHandler_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		static UserTokenHandler_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.UserTokenHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/UserTokenHandler"));
		}
	}
}
