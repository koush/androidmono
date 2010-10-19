namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DigestException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DigestException()
		{
			InitJNI();
		}
		protected DigestException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _DigestException17217;
		public DigestException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.DigestException.staticClass, global::java.security.DigestException._DigestException17217);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DigestException17218;
		public DigestException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.DigestException.staticClass, global::java.security.DigestException._DigestException17218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DigestException17219;
		public DigestException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.DigestException.staticClass, global::java.security.DigestException._DigestException17219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DigestException17220;
		public DigestException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.DigestException.staticClass, global::java.security.DigestException._DigestException17220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.DigestException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/DigestException"));
			global::java.security.DigestException._DigestException17217 = @__env.GetMethodIDNoThrow(global::java.security.DigestException.staticClass, "<init>", "()V");
			global::java.security.DigestException._DigestException17218 = @__env.GetMethodIDNoThrow(global::java.security.DigestException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.security.DigestException._DigestException17219 = @__env.GetMethodIDNoThrow(global::java.security.DigestException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.security.DigestException._DigestException17220 = @__env.GetMethodIDNoThrow(global::java.security.DigestException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
