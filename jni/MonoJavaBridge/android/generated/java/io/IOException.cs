namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IOException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static IOException()
		{
			InitJNI();
		}
		protected IOException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _IOException13497;
		public IOException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.IOException.staticClass, global::java.io.IOException._IOException13497);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IOException13498;
		public IOException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.IOException.staticClass, global::java.io.IOException._IOException13498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IOException13499;
		public IOException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.IOException.staticClass, global::java.io.IOException._IOException13499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IOException13500;
		public IOException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.IOException.staticClass, global::java.io.IOException._IOException13500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.IOException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/IOException"));
			global::java.io.IOException._IOException13497 = @__env.GetMethodIDNoThrow(global::java.io.IOException.staticClass, "<init>", "()V");
			global::java.io.IOException._IOException13498 = @__env.GetMethodIDNoThrow(global::java.io.IOException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.io.IOException._IOException13499 = @__env.GetMethodIDNoThrow(global::java.io.IOException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.io.IOException._IOException13500 = @__env.GetMethodIDNoThrow(global::java.io.IOException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
