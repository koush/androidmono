namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AssertionError : java.lang.Error
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AssertionError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public AssertionError(double arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.AssertionError._m0.native == global::System.IntPtr.Zero)
				global::java.lang.AssertionError._m0 = @__env.GetMethodIDNoThrow(global::java.lang.AssertionError.staticClass, "<init>", "(D)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.AssertionError.staticClass, global::java.lang.AssertionError._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public AssertionError(java.lang.Object arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.AssertionError._m1.native == global::System.IntPtr.Zero)
				global::java.lang.AssertionError._m1 = @__env.GetMethodIDNoThrow(global::java.lang.AssertionError.staticClass, "<init>", "(Ljava/lang/Object;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.AssertionError.staticClass, global::java.lang.AssertionError._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public AssertionError(bool arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.AssertionError._m2.native == global::System.IntPtr.Zero)
				global::java.lang.AssertionError._m2 = @__env.GetMethodIDNoThrow(global::java.lang.AssertionError.staticClass, "<init>", "(Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.AssertionError.staticClass, global::java.lang.AssertionError._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public AssertionError(char arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.AssertionError._m3.native == global::System.IntPtr.Zero)
				global::java.lang.AssertionError._m3 = @__env.GetMethodIDNoThrow(global::java.lang.AssertionError.staticClass, "<init>", "(C)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.AssertionError.staticClass, global::java.lang.AssertionError._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public AssertionError(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.AssertionError._m4.native == global::System.IntPtr.Zero)
				global::java.lang.AssertionError._m4 = @__env.GetMethodIDNoThrow(global::java.lang.AssertionError.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.AssertionError.staticClass, global::java.lang.AssertionError._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public AssertionError(long arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.AssertionError._m5.native == global::System.IntPtr.Zero)
				global::java.lang.AssertionError._m5 = @__env.GetMethodIDNoThrow(global::java.lang.AssertionError.staticClass, "<init>", "(J)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.AssertionError.staticClass, global::java.lang.AssertionError._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public AssertionError(float arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.AssertionError._m6.native == global::System.IntPtr.Zero)
				global::java.lang.AssertionError._m6 = @__env.GetMethodIDNoThrow(global::java.lang.AssertionError.staticClass, "<init>", "(F)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.AssertionError.staticClass, global::java.lang.AssertionError._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public AssertionError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.AssertionError._m7.native == global::System.IntPtr.Zero)
				global::java.lang.AssertionError._m7 = @__env.GetMethodIDNoThrow(global::java.lang.AssertionError.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.AssertionError.staticClass, global::java.lang.AssertionError._m7);
			Init(@__env, handle);
		}
		static AssertionError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.AssertionError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/AssertionError"));
		}
	}
}
