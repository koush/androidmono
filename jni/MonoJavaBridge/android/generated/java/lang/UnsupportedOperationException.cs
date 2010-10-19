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
		internal static global::MonoJavaBridge.MethodId _UnsupportedOperationException15288;
		public UnsupportedOperationException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.UnsupportedOperationException.staticClass, global::java.lang.UnsupportedOperationException._UnsupportedOperationException15288);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _UnsupportedOperationException15289;
		public UnsupportedOperationException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.UnsupportedOperationException.staticClass, global::java.lang.UnsupportedOperationException._UnsupportedOperationException15289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _UnsupportedOperationException15290;
		public UnsupportedOperationException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.UnsupportedOperationException.staticClass, global::java.lang.UnsupportedOperationException._UnsupportedOperationException15290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _UnsupportedOperationException15291;
		public UnsupportedOperationException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.UnsupportedOperationException.staticClass, global::java.lang.UnsupportedOperationException._UnsupportedOperationException15291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.UnsupportedOperationException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/UnsupportedOperationException"));
			global::java.lang.UnsupportedOperationException._UnsupportedOperationException15288 = @__env.GetMethodIDNoThrow(global::java.lang.UnsupportedOperationException.staticClass, "<init>", "()V");
			global::java.lang.UnsupportedOperationException._UnsupportedOperationException15289 = @__env.GetMethodIDNoThrow(global::java.lang.UnsupportedOperationException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.UnsupportedOperationException._UnsupportedOperationException15290 = @__env.GetMethodIDNoThrow(global::java.lang.UnsupportedOperationException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.lang.UnsupportedOperationException._UnsupportedOperationException15291 = @__env.GetMethodIDNoThrow(global::java.lang.UnsupportedOperationException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
