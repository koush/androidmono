namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SecurityException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SecurityException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public SecurityException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.SecurityException._m0.native == global::System.IntPtr.Zero)
				global::java.lang.SecurityException._m0 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.SecurityException.staticClass, global::java.lang.SecurityException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public SecurityException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.SecurityException._m1.native == global::System.IntPtr.Zero)
				global::java.lang.SecurityException._m1 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.SecurityException.staticClass, global::java.lang.SecurityException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public SecurityException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.SecurityException._m2.native == global::System.IntPtr.Zero)
				global::java.lang.SecurityException._m2 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.SecurityException.staticClass, global::java.lang.SecurityException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public SecurityException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.SecurityException._m3.native == global::System.IntPtr.Zero)
				global::java.lang.SecurityException._m3 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.SecurityException.staticClass, global::java.lang.SecurityException._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static SecurityException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.SecurityException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/SecurityException"));
		}
	}
}
