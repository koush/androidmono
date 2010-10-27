namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnsupportedOperationException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static UnsupportedOperationException()
		{
			InitJNI();
		}
		protected UnsupportedOperationException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _UnsupportedOperationException20928;
		public UnsupportedOperationException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.UnsupportedOperationException.staticClass, global::java.lang.UnsupportedOperationException._UnsupportedOperationException20928);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _UnsupportedOperationException20929;
		public UnsupportedOperationException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.UnsupportedOperationException.staticClass, global::java.lang.UnsupportedOperationException._UnsupportedOperationException20929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _UnsupportedOperationException20930;
		public UnsupportedOperationException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.UnsupportedOperationException.staticClass, global::java.lang.UnsupportedOperationException._UnsupportedOperationException20930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _UnsupportedOperationException20931;
		public UnsupportedOperationException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.UnsupportedOperationException.staticClass, global::java.lang.UnsupportedOperationException._UnsupportedOperationException20931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.UnsupportedOperationException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/UnsupportedOperationException"));
			global::java.lang.UnsupportedOperationException._UnsupportedOperationException20928 = @__env.GetMethodIDNoThrow(global::java.lang.UnsupportedOperationException.staticClass, "<init>", "()V");
			global::java.lang.UnsupportedOperationException._UnsupportedOperationException20929 = @__env.GetMethodIDNoThrow(global::java.lang.UnsupportedOperationException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.UnsupportedOperationException._UnsupportedOperationException20930 = @__env.GetMethodIDNoThrow(global::java.lang.UnsupportedOperationException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.lang.UnsupportedOperationException._UnsupportedOperationException20931 = @__env.GetMethodIDNoThrow(global::java.lang.UnsupportedOperationException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
