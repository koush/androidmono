namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicCommentHandler : org.apache.http.impl.cookie.AbstractCookieAttributeHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BasicCommentHandler()
		{
			InitJNI();
		}
		protected BasicCommentHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse33251;
		public override void parse(org.apache.http.cookie.SetCookie arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicCommentHandler._parse33251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicCommentHandler.staticClass, global::org.apache.http.impl.cookie.BasicCommentHandler._parse33251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _BasicCommentHandler33252;
		public BasicCommentHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.BasicCommentHandler.staticClass, global::org.apache.http.impl.cookie.BasicCommentHandler._BasicCommentHandler33252);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.BasicCommentHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/BasicCommentHandler"));
			global::org.apache.http.impl.cookie.BasicCommentHandler._parse33251 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicCommentHandler.staticClass, "parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V");
			global::org.apache.http.impl.cookie.BasicCommentHandler._BasicCommentHandler33252 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicCommentHandler.staticClass, "<init>", "()V");
		}
	}
}
