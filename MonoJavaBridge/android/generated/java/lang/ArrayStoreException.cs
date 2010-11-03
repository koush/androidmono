namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ArrayStoreException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ArrayStoreException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public ArrayStoreException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ArrayStoreException._m0.native == global::System.IntPtr.Zero)
				global::java.lang.ArrayStoreException._m0 = @__env.GetMethodIDNoThrow(global::java.lang.ArrayStoreException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ArrayStoreException.staticClass, global::java.lang.ArrayStoreException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public ArrayStoreException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ArrayStoreException._m1.native == global::System.IntPtr.Zero)
				global::java.lang.ArrayStoreException._m1 = @__env.GetMethodIDNoThrow(global::java.lang.ArrayStoreException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ArrayStoreException.staticClass, global::java.lang.ArrayStoreException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ArrayStoreException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.ArrayStoreException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ArrayStoreException"));
		}
	}
}
