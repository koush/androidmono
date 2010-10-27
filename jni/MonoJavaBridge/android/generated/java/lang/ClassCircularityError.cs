namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ClassCircularityError : java.lang.LinkageError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ClassCircularityError()
		{
			InitJNI();
		}
		protected ClassCircularityError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ClassCircularityError20036;
		public ClassCircularityError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ClassCircularityError.staticClass, global::java.lang.ClassCircularityError._ClassCircularityError20036);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ClassCircularityError20037;
		public ClassCircularityError(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ClassCircularityError.staticClass, global::java.lang.ClassCircularityError._ClassCircularityError20037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.ClassCircularityError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ClassCircularityError"));
			global::java.lang.ClassCircularityError._ClassCircularityError20036 = @__env.GetMethodIDNoThrow(global::java.lang.ClassCircularityError.staticClass, "<init>", "()V");
			global::java.lang.ClassCircularityError._ClassCircularityError20037 = @__env.GetMethodIDNoThrow(global::java.lang.ClassCircularityError.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
