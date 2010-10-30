namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DateParseException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DateParseException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _DateParseException33296;
		public DateParseException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.DateParseException._DateParseException33296.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.DateParseException._DateParseException33296 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.DateParseException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.DateParseException.staticClass, global::org.apache.http.impl.cookie.DateParseException._DateParseException33296);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DateParseException33297;
		public DateParseException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.DateParseException._DateParseException33297.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.DateParseException._DateParseException33297 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.DateParseException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.DateParseException.staticClass, global::org.apache.http.impl.cookie.DateParseException._DateParseException33297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static DateParseException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.DateParseException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/DateParseException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
