namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NotActiveException : java.io.ObjectStreamException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NotActiveException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public NotActiveException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.NotActiveException._m0.native == global::System.IntPtr.Zero)
				global::java.io.NotActiveException._m0 = @__env.GetMethodIDNoThrow(global::java.io.NotActiveException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.NotActiveException.staticClass, global::java.io.NotActiveException._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public NotActiveException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.NotActiveException._m1.native == global::System.IntPtr.Zero)
				global::java.io.NotActiveException._m1 = @__env.GetMethodIDNoThrow(global::java.io.NotActiveException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.NotActiveException.staticClass, global::java.io.NotActiveException._m1);
			Init(@__env, handle);
		}
		static NotActiveException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.NotActiveException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/NotActiveException"));
		}
	}
}
