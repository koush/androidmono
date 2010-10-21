namespace org.apache.http.impl.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnsupportedDigestAlgorithmException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static UnsupportedDigestAlgorithmException()
		{
			InitJNI();
		}
		protected UnsupportedDigestAlgorithmException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _UnsupportedDigestAlgorithmException32640;
		public UnsupportedDigestAlgorithmException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.auth.UnsupportedDigestAlgorithmException.staticClass, global::org.apache.http.impl.auth.UnsupportedDigestAlgorithmException._UnsupportedDigestAlgorithmException32640);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _UnsupportedDigestAlgorithmException32641;
		public UnsupportedDigestAlgorithmException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.auth.UnsupportedDigestAlgorithmException.staticClass, global::org.apache.http.impl.auth.UnsupportedDigestAlgorithmException._UnsupportedDigestAlgorithmException32641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _UnsupportedDigestAlgorithmException32642;
		public UnsupportedDigestAlgorithmException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.auth.UnsupportedDigestAlgorithmException.staticClass, global::org.apache.http.impl.auth.UnsupportedDigestAlgorithmException._UnsupportedDigestAlgorithmException32642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.auth.UnsupportedDigestAlgorithmException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/auth/UnsupportedDigestAlgorithmException"));
			global::org.apache.http.impl.auth.UnsupportedDigestAlgorithmException._UnsupportedDigestAlgorithmException32640 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.UnsupportedDigestAlgorithmException.staticClass, "<init>", "()V");
			global::org.apache.http.impl.auth.UnsupportedDigestAlgorithmException._UnsupportedDigestAlgorithmException32641 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.UnsupportedDigestAlgorithmException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::org.apache.http.impl.auth.UnsupportedDigestAlgorithmException._UnsupportedDigestAlgorithmException32642 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.UnsupportedDigestAlgorithmException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
		}
	}
}
