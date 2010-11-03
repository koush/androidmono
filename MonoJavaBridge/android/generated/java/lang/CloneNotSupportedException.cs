namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CloneNotSupportedException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CloneNotSupportedException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public CloneNotSupportedException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.CloneNotSupportedException._m0.native == global::System.IntPtr.Zero)
				global::java.lang.CloneNotSupportedException._m0 = @__env.GetMethodIDNoThrow(global::java.lang.CloneNotSupportedException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.CloneNotSupportedException.staticClass, global::java.lang.CloneNotSupportedException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public CloneNotSupportedException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.CloneNotSupportedException._m1.native == global::System.IntPtr.Zero)
				global::java.lang.CloneNotSupportedException._m1 = @__env.GetMethodIDNoThrow(global::java.lang.CloneNotSupportedException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.CloneNotSupportedException.staticClass, global::java.lang.CloneNotSupportedException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static CloneNotSupportedException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.CloneNotSupportedException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/CloneNotSupportedException"));
		}
	}
}
