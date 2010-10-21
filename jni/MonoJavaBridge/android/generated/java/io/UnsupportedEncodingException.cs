namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnsupportedEncodingException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static UnsupportedEncodingException()
		{
			InitJNI();
		}
		protected UnsupportedEncodingException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _UnsupportedEncodingException19515;
		public UnsupportedEncodingException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.UnsupportedEncodingException.staticClass, global::java.io.UnsupportedEncodingException._UnsupportedEncodingException19515);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _UnsupportedEncodingException19516;
		public UnsupportedEncodingException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.UnsupportedEncodingException.staticClass, global::java.io.UnsupportedEncodingException._UnsupportedEncodingException19516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.UnsupportedEncodingException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/UnsupportedEncodingException"));
			global::java.io.UnsupportedEncodingException._UnsupportedEncodingException19515 = @__env.GetMethodIDNoThrow(global::java.io.UnsupportedEncodingException.staticClass, "<init>", "()V");
			global::java.io.UnsupportedEncodingException._UnsupportedEncodingException19516 = @__env.GetMethodIDNoThrow(global::java.io.UnsupportedEncodingException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
