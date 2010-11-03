namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StringIndexOutOfBoundsException : java.lang.IndexOutOfBoundsException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected StringIndexOutOfBoundsException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public StringIndexOutOfBoundsException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.StringIndexOutOfBoundsException._m0.native == global::System.IntPtr.Zero)
				global::java.lang.StringIndexOutOfBoundsException._m0 = @__env.GetMethodIDNoThrow(global::java.lang.StringIndexOutOfBoundsException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringIndexOutOfBoundsException.staticClass, global::java.lang.StringIndexOutOfBoundsException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public StringIndexOutOfBoundsException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.StringIndexOutOfBoundsException._m1.native == global::System.IntPtr.Zero)
				global::java.lang.StringIndexOutOfBoundsException._m1 = @__env.GetMethodIDNoThrow(global::java.lang.StringIndexOutOfBoundsException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringIndexOutOfBoundsException.staticClass, global::java.lang.StringIndexOutOfBoundsException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public StringIndexOutOfBoundsException(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.StringIndexOutOfBoundsException._m2.native == global::System.IntPtr.Zero)
				global::java.lang.StringIndexOutOfBoundsException._m2 = @__env.GetMethodIDNoThrow(global::java.lang.StringIndexOutOfBoundsException.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringIndexOutOfBoundsException.staticClass, global::java.lang.StringIndexOutOfBoundsException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static StringIndexOutOfBoundsException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.StringIndexOutOfBoundsException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/StringIndexOutOfBoundsException"));
		}
	}
}
