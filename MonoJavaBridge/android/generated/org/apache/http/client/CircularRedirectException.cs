namespace org.apache.http.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CircularRedirectException : org.apache.http.client.RedirectException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CircularRedirectException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _CircularRedirectException31867;
		public CircularRedirectException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.CircularRedirectException._CircularRedirectException31867.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.CircularRedirectException._CircularRedirectException31867 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.CircularRedirectException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.CircularRedirectException.staticClass, global::org.apache.http.client.CircularRedirectException._CircularRedirectException31867);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CircularRedirectException31868;
		public CircularRedirectException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.CircularRedirectException._CircularRedirectException31868.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.CircularRedirectException._CircularRedirectException31868 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.CircularRedirectException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.CircularRedirectException.staticClass, global::org.apache.http.client.CircularRedirectException._CircularRedirectException31868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CircularRedirectException31869;
		public CircularRedirectException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.CircularRedirectException._CircularRedirectException31869.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.CircularRedirectException._CircularRedirectException31869 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.CircularRedirectException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.CircularRedirectException.staticClass, global::org.apache.http.client.CircularRedirectException._CircularRedirectException31869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static CircularRedirectException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.CircularRedirectException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/CircularRedirectException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
