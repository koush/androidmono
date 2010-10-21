namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Error : java.lang.Throwable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Error()
		{
			InitJNI();
		}
		protected Error(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _Error20011;
		public Error()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Error.staticClass, global::java.lang.Error._Error20011);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Error20012;
		public Error(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Error.staticClass, global::java.lang.Error._Error20012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Error20013;
		public Error(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Error.staticClass, global::java.lang.Error._Error20013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Error20014;
		public Error(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Error.staticClass, global::java.lang.Error._Error20014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Error.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Error"));
			global::java.lang.Error._Error20011 = @__env.GetMethodIDNoThrow(global::java.lang.Error.staticClass, "<init>", "()V");
			global::java.lang.Error._Error20012 = @__env.GetMethodIDNoThrow(global::java.lang.Error.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.Error._Error20013 = @__env.GetMethodIDNoThrow(global::java.lang.Error.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.lang.Error._Error20014 = @__env.GetMethodIDNoThrow(global::java.lang.Error.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
