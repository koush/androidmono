namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SSLException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SSLException()
		{
			InitJNI();
		}
		protected SSLException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SSLException23437;
		public SSLException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLException.staticClass, global::javax.net.ssl.SSLException._SSLException23437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SSLException23438;
		public SSLException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLException.staticClass, global::javax.net.ssl.SSLException._SSLException23438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SSLException23439;
		public SSLException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLException.staticClass, global::javax.net.ssl.SSLException._SSLException23439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLException"));
			global::javax.net.ssl.SSLException._SSLException23437 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::javax.net.ssl.SSLException._SSLException23438 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::javax.net.ssl.SSLException._SSLException23439 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
