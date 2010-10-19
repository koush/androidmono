namespace org.apache.http.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RedirectException : org.apache.http.ProtocolException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RedirectException()
		{
			InitJNI();
		}
		protected RedirectException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _RedirectException25232;
		public RedirectException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.RedirectException.staticClass, global::org.apache.http.client.RedirectException._RedirectException25232);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RedirectException25233;
		public RedirectException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.RedirectException.staticClass, global::org.apache.http.client.RedirectException._RedirectException25233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RedirectException25234;
		public RedirectException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.RedirectException.staticClass, global::org.apache.http.client.RedirectException._RedirectException25234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.RedirectException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/RedirectException"));
			global::org.apache.http.client.RedirectException._RedirectException25232 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.RedirectException.staticClass, "<init>", "()V");
			global::org.apache.http.client.RedirectException._RedirectException25233 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.RedirectException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::org.apache.http.client.RedirectException._RedirectException25234 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.RedirectException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
		}
	}
}
