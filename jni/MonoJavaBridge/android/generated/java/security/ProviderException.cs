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
		internal static global::MonoJavaBridge.MethodId _ProviderException23172;
		public ProviderException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.ProviderException.staticClass, global::java.security.ProviderException._ProviderException23172);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ProviderException23173;
		public ProviderException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.ProviderException.staticClass, global::java.security.ProviderException._ProviderException23173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ProviderException23174;
		public ProviderException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.ProviderException.staticClass, global::java.security.ProviderException._ProviderException23174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ProviderException23175;
		public ProviderException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.ProviderException.staticClass, global::java.security.ProviderException._ProviderException23175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.ProviderException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/ProviderException"));
			global::java.security.ProviderException._ProviderException23172 = @__env.GetMethodIDNoThrow(global::java.security.ProviderException.staticClass, "<init>", "()V");
			global::java.security.ProviderException._ProviderException23173 = @__env.GetMethodIDNoThrow(global::java.security.ProviderException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.security.ProviderException._ProviderException23174 = @__env.GetMethodIDNoThrow(global::java.security.ProviderException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.security.ProviderException._ProviderException23175 = @__env.GetMethodIDNoThrow(global::java.security.ProviderException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
