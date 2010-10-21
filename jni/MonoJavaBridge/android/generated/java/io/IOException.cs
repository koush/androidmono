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
		internal static global::MonoJavaBridge.MethodId _IOException18972;
		public IOException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.IOException.staticClass, global::java.io.IOException._IOException18972);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IOException18973;
		public IOException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.IOException.staticClass, global::java.io.IOException._IOException18973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IOException18974;
		public IOException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.IOException.staticClass, global::java.io.IOException._IOException18974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IOException18975;
		public IOException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.IOException.staticClass, global::java.io.IOException._IOException18975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.IOException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/IOException"));
			global::java.io.IOException._IOException18972 = @__env.GetMethodIDNoThrow(global::java.io.IOException.staticClass, "<init>", "()V");
			global::java.io.IOException._IOException18973 = @__env.GetMethodIDNoThrow(global::java.io.IOException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.io.IOException._IOException18974 = @__env.GetMethodIDNoThrow(global::java.io.IOException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.io.IOException._IOException18975 = @__env.GetMethodIDNoThrow(global::java.io.IOException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
