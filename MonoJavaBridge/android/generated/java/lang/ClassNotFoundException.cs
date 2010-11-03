namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ClassNotFoundException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ClassNotFoundException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.Throwable Cause
		{
			get
			{
				return getCause();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.Throwable getCause()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.ClassNotFoundException.staticClass, "getCause", "()Ljava/lang/Throwable;", ref global::java.lang.ClassNotFoundException._m0) as java.lang.Throwable;
		}
		public new global::java.lang.Throwable Exception
		{
			get
			{
				return getException();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Throwable getException()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.ClassNotFoundException.staticClass, "getException", "()Ljava/lang/Throwable;", ref global::java.lang.ClassNotFoundException._m1) as java.lang.Throwable;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public ClassNotFoundException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ClassNotFoundException._m2.native == global::System.IntPtr.Zero)
				global::java.lang.ClassNotFoundException._m2 = @__env.GetMethodIDNoThrow(global::java.lang.ClassNotFoundException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ClassNotFoundException.staticClass, global::java.lang.ClassNotFoundException._m2);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public ClassNotFoundException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ClassNotFoundException._m3.native == global::System.IntPtr.Zero)
				global::java.lang.ClassNotFoundException._m3 = @__env.GetMethodIDNoThrow(global::java.lang.ClassNotFoundException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ClassNotFoundException.staticClass, global::java.lang.ClassNotFoundException._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public ClassNotFoundException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ClassNotFoundException._m4.native == global::System.IntPtr.Zero)
				global::java.lang.ClassNotFoundException._m4 = @__env.GetMethodIDNoThrow(global::java.lang.ClassNotFoundException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ClassNotFoundException.staticClass, global::java.lang.ClassNotFoundException._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ClassNotFoundException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.ClassNotFoundException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ClassNotFoundException"));
		}
	}
}
