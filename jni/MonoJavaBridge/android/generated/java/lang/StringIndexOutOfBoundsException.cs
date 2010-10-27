namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StringIndexOutOfBoundsException : java.lang.IndexOutOfBoundsException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static StringIndexOutOfBoundsException()
		{
			InitJNI();
		}
		protected StringIndexOutOfBoundsException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _StringIndexOutOfBoundsException20775;
		public StringIndexOutOfBoundsException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringIndexOutOfBoundsException.staticClass, global::java.lang.StringIndexOutOfBoundsException._StringIndexOutOfBoundsException20775);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringIndexOutOfBoundsException20776;
		public StringIndexOutOfBoundsException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringIndexOutOfBoundsException.staticClass, global::java.lang.StringIndexOutOfBoundsException._StringIndexOutOfBoundsException20776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringIndexOutOfBoundsException20777;
		public StringIndexOutOfBoundsException(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StringIndexOutOfBoundsException.staticClass, global::java.lang.StringIndexOutOfBoundsException._StringIndexOutOfBoundsException20777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.StringIndexOutOfBoundsException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/StringIndexOutOfBoundsException"));
			global::java.lang.StringIndexOutOfBoundsException._StringIndexOutOfBoundsException20775 = @__env.GetMethodIDNoThrow(global::java.lang.StringIndexOutOfBoundsException.staticClass, "<init>", "()V");
			global::java.lang.StringIndexOutOfBoundsException._StringIndexOutOfBoundsException20776 = @__env.GetMethodIDNoThrow(global::java.lang.StringIndexOutOfBoundsException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.StringIndexOutOfBoundsException._StringIndexOutOfBoundsException20777 = @__env.GetMethodIDNoThrow(global::java.lang.StringIndexOutOfBoundsException.staticClass, "<init>", "(I)V");
		}
	}
}
