namespace org.apache.http
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnsupportedHttpVersionException : org.apache.http.ProtocolException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected UnsupportedHttpVersionException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _UnsupportedHttpVersionException31771;
		public UnsupportedHttpVersionException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.UnsupportedHttpVersionException._UnsupportedHttpVersionException31771.native == global::System.IntPtr.Zero)
				global::org.apache.http.UnsupportedHttpVersionException._UnsupportedHttpVersionException31771 = @__env.GetMethodIDNoThrow(global::org.apache.http.UnsupportedHttpVersionException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.UnsupportedHttpVersionException.staticClass, global::org.apache.http.UnsupportedHttpVersionException._UnsupportedHttpVersionException31771);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _UnsupportedHttpVersionException31772;
		public UnsupportedHttpVersionException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.UnsupportedHttpVersionException._UnsupportedHttpVersionException31772.native == global::System.IntPtr.Zero)
				global::org.apache.http.UnsupportedHttpVersionException._UnsupportedHttpVersionException31772 = @__env.GetMethodIDNoThrow(global::org.apache.http.UnsupportedHttpVersionException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.UnsupportedHttpVersionException.staticClass, global::org.apache.http.UnsupportedHttpVersionException._UnsupportedHttpVersionException31772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static UnsupportedHttpVersionException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.UnsupportedHttpVersionException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/UnsupportedHttpVersionException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
