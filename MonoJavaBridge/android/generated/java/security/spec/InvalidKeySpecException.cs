namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InvalidKeySpecException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InvalidKeySpecException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _InvalidKeySpecException24024;
		public InvalidKeySpecException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.InvalidKeySpecException._InvalidKeySpecException24024.native == global::System.IntPtr.Zero)
				global::java.security.spec.InvalidKeySpecException._InvalidKeySpecException24024 = @__env.GetMethodIDNoThrow(global::java.security.spec.InvalidKeySpecException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.InvalidKeySpecException.staticClass, global::java.security.spec.InvalidKeySpecException._InvalidKeySpecException24024);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InvalidKeySpecException24025;
		public InvalidKeySpecException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.InvalidKeySpecException._InvalidKeySpecException24025.native == global::System.IntPtr.Zero)
				global::java.security.spec.InvalidKeySpecException._InvalidKeySpecException24025 = @__env.GetMethodIDNoThrow(global::java.security.spec.InvalidKeySpecException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.InvalidKeySpecException.staticClass, global::java.security.spec.InvalidKeySpecException._InvalidKeySpecException24025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InvalidKeySpecException24026;
		public InvalidKeySpecException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.InvalidKeySpecException._InvalidKeySpecException24026.native == global::System.IntPtr.Zero)
				global::java.security.spec.InvalidKeySpecException._InvalidKeySpecException24026 = @__env.GetMethodIDNoThrow(global::java.security.spec.InvalidKeySpecException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.InvalidKeySpecException.staticClass, global::java.security.spec.InvalidKeySpecException._InvalidKeySpecException24026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InvalidKeySpecException24027;
		public InvalidKeySpecException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.InvalidKeySpecException._InvalidKeySpecException24027.native == global::System.IntPtr.Zero)
				global::java.security.spec.InvalidKeySpecException._InvalidKeySpecException24027 = @__env.GetMethodIDNoThrow(global::java.security.spec.InvalidKeySpecException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.InvalidKeySpecException.staticClass, global::java.security.spec.InvalidKeySpecException._InvalidKeySpecException24027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static InvalidKeySpecException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.InvalidKeySpecException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/InvalidKeySpecException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
