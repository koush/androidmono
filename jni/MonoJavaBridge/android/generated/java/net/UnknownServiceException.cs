namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnknownServiceException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static UnknownServiceException()
		{
			InitJNI();
		}
		protected UnknownServiceException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _UnknownServiceException16280;
		public UnknownServiceException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.UnknownServiceException.staticClass, global::java.net.UnknownServiceException._UnknownServiceException16280);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _UnknownServiceException16281;
		public UnknownServiceException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.UnknownServiceException.staticClass, global::java.net.UnknownServiceException._UnknownServiceException16281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.UnknownServiceException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/UnknownServiceException"));
			global::java.net.UnknownServiceException._UnknownServiceException16280 = @__env.GetMethodIDNoThrow(global::java.net.UnknownServiceException.staticClass, "<init>", "()V");
			global::java.net.UnknownServiceException._UnknownServiceException16281 = @__env.GetMethodIDNoThrow(global::java.net.UnknownServiceException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
