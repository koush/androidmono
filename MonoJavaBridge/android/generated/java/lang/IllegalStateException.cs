namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IllegalStateException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IllegalStateException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _IllegalStateException20179;
		public IllegalStateException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.IllegalStateException._IllegalStateException20179.native == global::System.IntPtr.Zero)
				global::java.lang.IllegalStateException._IllegalStateException20179 = @__env.GetMethodIDNoThrow(global::java.lang.IllegalStateException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IllegalStateException.staticClass, global::java.lang.IllegalStateException._IllegalStateException20179);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IllegalStateException20180;
		public IllegalStateException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.IllegalStateException._IllegalStateException20180.native == global::System.IntPtr.Zero)
				global::java.lang.IllegalStateException._IllegalStateException20180 = @__env.GetMethodIDNoThrow(global::java.lang.IllegalStateException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IllegalStateException.staticClass, global::java.lang.IllegalStateException._IllegalStateException20180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IllegalStateException20181;
		public IllegalStateException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.IllegalStateException._IllegalStateException20181.native == global::System.IntPtr.Zero)
				global::java.lang.IllegalStateException._IllegalStateException20181 = @__env.GetMethodIDNoThrow(global::java.lang.IllegalStateException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IllegalStateException.staticClass, global::java.lang.IllegalStateException._IllegalStateException20181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IllegalStateException20182;
		public IllegalStateException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.IllegalStateException._IllegalStateException20182.native == global::System.IntPtr.Zero)
				global::java.lang.IllegalStateException._IllegalStateException20182 = @__env.GetMethodIDNoThrow(global::java.lang.IllegalStateException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IllegalStateException.staticClass, global::java.lang.IllegalStateException._IllegalStateException20182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static IllegalStateException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.IllegalStateException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/IllegalStateException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
