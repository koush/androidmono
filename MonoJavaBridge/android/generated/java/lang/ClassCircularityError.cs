namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ClassCircularityError : java.lang.LinkageError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ClassCircularityError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public ClassCircularityError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ClassCircularityError._m0.native == global::System.IntPtr.Zero)
				global::java.lang.ClassCircularityError._m0 = @__env.GetMethodIDNoThrow(global::java.lang.ClassCircularityError.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ClassCircularityError.staticClass, global::java.lang.ClassCircularityError._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public ClassCircularityError(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ClassCircularityError._m1.native == global::System.IntPtr.Zero)
				global::java.lang.ClassCircularityError._m1 = @__env.GetMethodIDNoThrow(global::java.lang.ClassCircularityError.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ClassCircularityError.staticClass, global::java.lang.ClassCircularityError._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ClassCircularityError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.ClassCircularityError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ClassCircularityError"));
		}
	}
}
