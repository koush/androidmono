namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ProviderException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ProviderException()
		{
			InitJNI();
		}
		protected ProviderException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ProviderException23291;
		public ProviderException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.ProviderException.staticClass, global::java.security.ProviderException._ProviderException23291);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ProviderException23292;
		public ProviderException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.ProviderException.staticClass, global::java.security.ProviderException._ProviderException23292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ProviderException23293;
		public ProviderException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.ProviderException.staticClass, global::java.security.ProviderException._ProviderException23293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ProviderException23294;
		public ProviderException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.ProviderException.staticClass, global::java.security.ProviderException._ProviderException23294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.ProviderException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/ProviderException"));
			global::java.security.ProviderException._ProviderException23291 = @__env.GetMethodIDNoThrow(global::java.security.ProviderException.staticClass, "<init>", "()V");
			global::java.security.ProviderException._ProviderException23292 = @__env.GetMethodIDNoThrow(global::java.security.ProviderException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.security.ProviderException._ProviderException23293 = @__env.GetMethodIDNoThrow(global::java.security.ProviderException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.security.ProviderException._ProviderException23294 = @__env.GetMethodIDNoThrow(global::java.security.ProviderException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
