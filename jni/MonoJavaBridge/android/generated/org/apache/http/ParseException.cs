namespace org.apache.http
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ParseException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ParseException()
		{
			InitJNI();
		}
		protected ParseException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ParseException25083;
		public ParseException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.ParseException.staticClass, global::org.apache.http.ParseException._ParseException25083);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ParseException25084;
		public ParseException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.ParseException.staticClass, global::org.apache.http.ParseException._ParseException25084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.ParseException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/ParseException"));
			global::org.apache.http.ParseException._ParseException25083 = @__env.GetMethodIDNoThrow(global::org.apache.http.ParseException.staticClass, "<init>", "()V");
			global::org.apache.http.ParseException._ParseException25084 = @__env.GetMethodIDNoThrow(global::org.apache.http.ParseException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
