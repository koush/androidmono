namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ProtocolException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ProtocolException()
		{
			InitJNI();
		}
		protected ProtocolException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ProtocolException15958;
		public ProtocolException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.ProtocolException.staticClass, global::java.net.ProtocolException._ProtocolException15958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ProtocolException15959;
		public ProtocolException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.ProtocolException.staticClass, global::java.net.ProtocolException._ProtocolException15959);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.ProtocolException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/ProtocolException"));
			global::java.net.ProtocolException._ProtocolException15958 = @__env.GetMethodIDNoThrow(global::java.net.ProtocolException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.net.ProtocolException._ProtocolException15959 = @__env.GetMethodIDNoThrow(global::java.net.ProtocolException.staticClass, "<init>", "()V");
		}
	}
}
