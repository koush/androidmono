namespace org.apache.http.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CircularRedirectException : org.apache.http.client.RedirectException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CircularRedirectException()
		{
			InitJNI();
		}
		protected CircularRedirectException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _CircularRedirectException31748;
		public CircularRedirectException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.CircularRedirectException.staticClass, global::org.apache.http.client.CircularRedirectException._CircularRedirectException31748);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CircularRedirectException31749;
		public CircularRedirectException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.CircularRedirectException.staticClass, global::org.apache.http.client.CircularRedirectException._CircularRedirectException31749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CircularRedirectException31750;
		public CircularRedirectException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.CircularRedirectException.staticClass, global::org.apache.http.client.CircularRedirectException._CircularRedirectException31750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.CircularRedirectException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/CircularRedirectException"));
			global::org.apache.http.client.CircularRedirectException._CircularRedirectException31748 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.CircularRedirectException.staticClass, "<init>", "()V");
			global::org.apache.http.client.CircularRedirectException._CircularRedirectException31749 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.CircularRedirectException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::org.apache.http.client.CircularRedirectException._CircularRedirectException31750 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.CircularRedirectException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
		}
	}
}
