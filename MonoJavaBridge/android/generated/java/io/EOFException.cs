namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EOFException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EOFException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public EOFException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.EOFException._m0.native == global::System.IntPtr.Zero)
				global::java.io.EOFException._m0 = @__env.GetMethodIDNoThrow(global::java.io.EOFException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.EOFException.staticClass, global::java.io.EOFException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public EOFException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.EOFException._m1.native == global::System.IntPtr.Zero)
				global::java.io.EOFException._m1 = @__env.GetMethodIDNoThrow(global::java.io.EOFException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.EOFException.staticClass, global::java.io.EOFException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static EOFException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.EOFException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/EOFException"));
		}
	}
}
