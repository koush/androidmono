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
		internal static global::MonoJavaBridge.MethodId _Error14505;
		public Error()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Error.staticClass, global::java.lang.Error._Error14505);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Error14506;
		public Error(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Error.staticClass, global::java.lang.Error._Error14506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Error14507;
		public Error(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Error.staticClass, global::java.lang.Error._Error14507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Error14508;
		public Error(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Error.staticClass, global::java.lang.Error._Error14508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Error.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Error"));
			global::java.lang.Error._Error14505 = @__env.GetMethodIDNoThrow(global::java.lang.Error.staticClass, "<init>", "()V");
			global::java.lang.Error._Error14506 = @__env.GetMethodIDNoThrow(global::java.lang.Error.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.Error._Error14507 = @__env.GetMethodIDNoThrow(global::java.lang.Error.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.lang.Error._Error14508 = @__env.GetMethodIDNoThrow(global::java.lang.Error.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
