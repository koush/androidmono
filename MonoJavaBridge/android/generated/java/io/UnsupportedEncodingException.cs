namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnsupportedEncodingException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected UnsupportedEncodingException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _UnsupportedEncodingException19633;
		public UnsupportedEncodingException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.UnsupportedEncodingException._UnsupportedEncodingException19633.native == global::System.IntPtr.Zero)
				global::java.io.UnsupportedEncodingException._UnsupportedEncodingException19633 = @__env.GetMethodIDNoThrow(global::java.io.UnsupportedEncodingException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.UnsupportedEncodingException.staticClass, global::java.io.UnsupportedEncodingException._UnsupportedEncodingException19633);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _UnsupportedEncodingException19634;
		public UnsupportedEncodingException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.UnsupportedEncodingException._UnsupportedEncodingException19634.native == global::System.IntPtr.Zero)
				global::java.io.UnsupportedEncodingException._UnsupportedEncodingException19634 = @__env.GetMethodIDNoThrow(global::java.io.UnsupportedEncodingException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.UnsupportedEncodingException.staticClass, global::java.io.UnsupportedEncodingException._UnsupportedEncodingException19634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static UnsupportedEncodingException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.UnsupportedEncodingException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/UnsupportedEncodingException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
