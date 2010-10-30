namespace org.apache.http
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ParseException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ParseException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public ParseException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.ParseException._m0.native == global::System.IntPtr.Zero)
				global::org.apache.http.ParseException._m0 = @__env.GetMethodIDNoThrow(global::org.apache.http.ParseException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.ParseException.staticClass, global::org.apache.http.ParseException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public ParseException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.ParseException._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.ParseException._m1 = @__env.GetMethodIDNoThrow(global::org.apache.http.ParseException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.ParseException.staticClass, global::org.apache.http.ParseException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ParseException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.ParseException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/ParseException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
