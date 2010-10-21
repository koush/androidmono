namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DateParseException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DateParseException()
		{
			InitJNI();
		}
		protected DateParseException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _DateParseException33177;
		public DateParseException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.DateParseException.staticClass, global::org.apache.http.impl.cookie.DateParseException._DateParseException33177);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DateParseException33178;
		public DateParseException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.DateParseException.staticClass, global::org.apache.http.impl.cookie.DateParseException._DateParseException33178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.DateParseException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/DateParseException"));
			global::org.apache.http.impl.cookie.DateParseException._DateParseException33177 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.DateParseException.staticClass, "<init>", "()V");
			global::org.apache.http.impl.cookie.DateParseException._DateParseException33178 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.DateParseException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
