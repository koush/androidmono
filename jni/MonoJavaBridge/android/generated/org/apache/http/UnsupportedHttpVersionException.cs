namespace org.apache.http
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnsupportedHttpVersionException : org.apache.http.ProtocolException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static UnsupportedHttpVersionException()
		{
			InitJNI();
		}
		protected UnsupportedHttpVersionException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _UnsupportedHttpVersionException31770;
		public UnsupportedHttpVersionException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.UnsupportedHttpVersionException.staticClass, global::org.apache.http.UnsupportedHttpVersionException._UnsupportedHttpVersionException31770);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _UnsupportedHttpVersionException31771;
		public UnsupportedHttpVersionException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.UnsupportedHttpVersionException.staticClass, global::org.apache.http.UnsupportedHttpVersionException._UnsupportedHttpVersionException31771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.UnsupportedHttpVersionException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/UnsupportedHttpVersionException"));
			global::org.apache.http.UnsupportedHttpVersionException._UnsupportedHttpVersionException31770 = @__env.GetMethodIDNoThrow(global::org.apache.http.UnsupportedHttpVersionException.staticClass, "<init>", "()V");
			global::org.apache.http.UnsupportedHttpVersionException._UnsupportedHttpVersionException31771 = @__env.GetMethodIDNoThrow(global::org.apache.http.UnsupportedHttpVersionException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
