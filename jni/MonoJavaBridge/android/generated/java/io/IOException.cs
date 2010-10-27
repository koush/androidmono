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
		internal static global::MonoJavaBridge.MethodId _IOException19090;
		public IOException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.IOException.staticClass, global::java.io.IOException._IOException19090);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IOException19091;
		public IOException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.IOException.staticClass, global::java.io.IOException._IOException19091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IOException19092;
		public IOException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.IOException.staticClass, global::java.io.IOException._IOException19092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IOException19093;
		public IOException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.IOException.staticClass, global::java.io.IOException._IOException19093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.IOException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/IOException"));
			global::java.io.IOException._IOException19090 = @__env.GetMethodIDNoThrow(global::java.io.IOException.staticClass, "<init>", "()V");
			global::java.io.IOException._IOException19091 = @__env.GetMethodIDNoThrow(global::java.io.IOException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.io.IOException._IOException19092 = @__env.GetMethodIDNoThrow(global::java.io.IOException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.io.IOException._IOException19093 = @__env.GetMethodIDNoThrow(global::java.io.IOException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
