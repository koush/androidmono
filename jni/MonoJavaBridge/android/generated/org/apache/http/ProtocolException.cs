namespace org.apache.http
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ProtocolException : org.apache.http.HttpException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ProtocolException()
		{
			InitJNI();
		}
		protected ProtocolException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ProtocolException31742;
		public ProtocolException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.ProtocolException.staticClass, global::org.apache.http.ProtocolException._ProtocolException31742);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ProtocolException31743;
		public ProtocolException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.ProtocolException.staticClass, global::org.apache.http.ProtocolException._ProtocolException31743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ProtocolException31744;
		public ProtocolException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.ProtocolException.staticClass, global::org.apache.http.ProtocolException._ProtocolException31744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.ProtocolException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/ProtocolException"));
			global::org.apache.http.ProtocolException._ProtocolException31742 = @__env.GetMethodIDNoThrow(global::org.apache.http.ProtocolException.staticClass, "<init>", "()V");
			global::org.apache.http.ProtocolException._ProtocolException31743 = @__env.GetMethodIDNoThrow(global::org.apache.http.ProtocolException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::org.apache.http.ProtocolException._ProtocolException31744 = @__env.GetMethodIDNoThrow(global::org.apache.http.ProtocolException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
		}
	}
}
