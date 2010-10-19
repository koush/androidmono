namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ClassCastException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ClassCastException()
		{
			InitJNI();
		}
		protected ClassCastException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ClassCastException14410;
		public ClassCastException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ClassCastException.staticClass, global::java.lang.ClassCastException._ClassCastException14410);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ClassCastException14411;
		public ClassCastException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ClassCastException.staticClass, global::java.lang.ClassCastException._ClassCastException14411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.ClassCastException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ClassCastException"));
			global::java.lang.ClassCastException._ClassCastException14410 = @__env.GetMethodIDNoThrow(global::java.lang.ClassCastException.staticClass, "<init>", "()V");
			global::java.lang.ClassCastException._ClassCastException14411 = @__env.GetMethodIDNoThrow(global::java.lang.ClassCastException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
