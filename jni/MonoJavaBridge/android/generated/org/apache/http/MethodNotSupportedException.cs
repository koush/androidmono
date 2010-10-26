namespace org.apache.http
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MethodNotSupportedException : org.apache.http.HttpException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MethodNotSupportedException()
		{
			InitJNI();
		}
		protected MethodNotSupportedException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _MethodNotSupportedException31735;
		public MethodNotSupportedException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.MethodNotSupportedException.staticClass, global::org.apache.http.MethodNotSupportedException._MethodNotSupportedException31735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MethodNotSupportedException31736;
		public MethodNotSupportedException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.MethodNotSupportedException.staticClass, global::org.apache.http.MethodNotSupportedException._MethodNotSupportedException31736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.MethodNotSupportedException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/MethodNotSupportedException"));
			global::org.apache.http.MethodNotSupportedException._MethodNotSupportedException31735 = @__env.GetMethodIDNoThrow(global::org.apache.http.MethodNotSupportedException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::org.apache.http.MethodNotSupportedException._MethodNotSupportedException31736 = @__env.GetMethodIDNoThrow(global::org.apache.http.MethodNotSupportedException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
		}
	}
}
