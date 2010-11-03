namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ArrayIndexOutOfBoundsException : java.lang.IndexOutOfBoundsException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ArrayIndexOutOfBoundsException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public ArrayIndexOutOfBoundsException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ArrayIndexOutOfBoundsException._m0.native == global::System.IntPtr.Zero)
				global::java.lang.ArrayIndexOutOfBoundsException._m0 = @__env.GetMethodIDNoThrow(global::java.lang.ArrayIndexOutOfBoundsException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ArrayIndexOutOfBoundsException.staticClass, global::java.lang.ArrayIndexOutOfBoundsException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public ArrayIndexOutOfBoundsException(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ArrayIndexOutOfBoundsException._m1.native == global::System.IntPtr.Zero)
				global::java.lang.ArrayIndexOutOfBoundsException._m1 = @__env.GetMethodIDNoThrow(global::java.lang.ArrayIndexOutOfBoundsException.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ArrayIndexOutOfBoundsException.staticClass, global::java.lang.ArrayIndexOutOfBoundsException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public ArrayIndexOutOfBoundsException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ArrayIndexOutOfBoundsException._m2.native == global::System.IntPtr.Zero)
				global::java.lang.ArrayIndexOutOfBoundsException._m2 = @__env.GetMethodIDNoThrow(global::java.lang.ArrayIndexOutOfBoundsException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ArrayIndexOutOfBoundsException.staticClass, global::java.lang.ArrayIndexOutOfBoundsException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ArrayIndexOutOfBoundsException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.ArrayIndexOutOfBoundsException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ArrayIndexOutOfBoundsException"));
		}
	}
}
