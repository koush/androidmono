namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LinkageError : java.lang.Error
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LinkageError()
		{
			InitJNI();
		}
		protected LinkageError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _LinkageError20123;
		public LinkageError()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.LinkageError.staticClass, global::java.lang.LinkageError._LinkageError20123);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LinkageError20124;
		public LinkageError(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.LinkageError.staticClass, global::java.lang.LinkageError._LinkageError20124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.LinkageError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/LinkageError"));
			global::java.lang.LinkageError._LinkageError20123 = @__env.GetMethodIDNoThrow(global::java.lang.LinkageError.staticClass, "<init>", "()V");
			global::java.lang.LinkageError._LinkageError20124 = @__env.GetMethodIDNoThrow(global::java.lang.LinkageError.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
