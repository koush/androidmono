namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnsupportedOperationException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected UnsupportedOperationException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public UnsupportedOperationException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.UnsupportedOperationException._m0.native == global::System.IntPtr.Zero)
				global::java.lang.UnsupportedOperationException._m0 = @__env.GetMethodIDNoThrow(global::java.lang.UnsupportedOperationException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.UnsupportedOperationException.staticClass, global::java.lang.UnsupportedOperationException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public UnsupportedOperationException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.UnsupportedOperationException._m1.native == global::System.IntPtr.Zero)
				global::java.lang.UnsupportedOperationException._m1 = @__env.GetMethodIDNoThrow(global::java.lang.UnsupportedOperationException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.UnsupportedOperationException.staticClass, global::java.lang.UnsupportedOperationException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public UnsupportedOperationException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.UnsupportedOperationException._m2.native == global::System.IntPtr.Zero)
				global::java.lang.UnsupportedOperationException._m2 = @__env.GetMethodIDNoThrow(global::java.lang.UnsupportedOperationException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.UnsupportedOperationException.staticClass, global::java.lang.UnsupportedOperationException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public UnsupportedOperationException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.UnsupportedOperationException._m3.native == global::System.IntPtr.Zero)
				global::java.lang.UnsupportedOperationException._m3 = @__env.GetMethodIDNoThrow(global::java.lang.UnsupportedOperationException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.UnsupportedOperationException.staticClass, global::java.lang.UnsupportedOperationException._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static UnsupportedOperationException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.UnsupportedOperationException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/UnsupportedOperationException"));
		}
	}
}
