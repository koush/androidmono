namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ProtocolException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ProtocolException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ProtocolException21657;
		public ProtocolException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ProtocolException._ProtocolException21657.native == global::System.IntPtr.Zero)
				global::java.net.ProtocolException._ProtocolException21657 = @__env.GetMethodIDNoThrow(global::java.net.ProtocolException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.ProtocolException.staticClass, global::java.net.ProtocolException._ProtocolException21657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ProtocolException21658;
		public ProtocolException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ProtocolException._ProtocolException21658.native == global::System.IntPtr.Zero)
				global::java.net.ProtocolException._ProtocolException21658 = @__env.GetMethodIDNoThrow(global::java.net.ProtocolException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.ProtocolException.staticClass, global::java.net.ProtocolException._ProtocolException21658);
			Init(@__env, handle);
		}
		static ProtocolException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.ProtocolException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/ProtocolException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
