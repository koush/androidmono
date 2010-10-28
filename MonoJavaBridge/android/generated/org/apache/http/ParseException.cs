namespace org.apache.http
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ParseException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ParseException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ParseException31741;
		public ParseException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.ParseException.staticClass, global::org.apache.http.ParseException._ParseException31741);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ParseException31742;
		public ParseException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.ParseException.staticClass, global::org.apache.http.ParseException._ParseException31742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ParseException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.ParseException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/ParseException"));
			global::org.apache.http.ParseException._ParseException31741 = @__env.GetMethodIDNoThrow(global::org.apache.http.ParseException.staticClass, "<init>", "()V");
			global::org.apache.http.ParseException._ParseException31742 = @__env.GetMethodIDNoThrow(global::org.apache.http.ParseException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
