namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IndexOutOfBoundsException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static IndexOutOfBoundsException()
		{
			InitJNI();
		}
		protected IndexOutOfBoundsException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _IndexOutOfBoundsException12985;
		public IndexOutOfBoundsException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IndexOutOfBoundsException.staticClass, global::java.lang.IndexOutOfBoundsException._IndexOutOfBoundsException12985);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IndexOutOfBoundsException12986;
		public IndexOutOfBoundsException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IndexOutOfBoundsException.staticClass, global::java.lang.IndexOutOfBoundsException._IndexOutOfBoundsException12986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.IndexOutOfBoundsException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/IndexOutOfBoundsException"));
			global::java.lang.IndexOutOfBoundsException._IndexOutOfBoundsException12985 = @__env.GetMethodIDNoThrow(global::java.lang.IndexOutOfBoundsException.staticClass, "<init>", "()V");
			global::java.lang.IndexOutOfBoundsException._IndexOutOfBoundsException12986 = @__env.GetMethodIDNoThrow(global::java.lang.IndexOutOfBoundsException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
