namespace java.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.net.SocketAddress_))]
	public abstract partial class SocketAddress : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SocketAddress(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public SocketAddress() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.SocketAddress._m0.native == global::System.IntPtr.Zero)
				global::java.net.SocketAddress._m0 = @__env.GetMethodIDNoThrow(global::java.net.SocketAddress.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.SocketAddress.staticClass, global::java.net.SocketAddress._m0);
			Init(@__env, handle);
		}
		static SocketAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.SocketAddress.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/SocketAddress"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.SocketAddress))]
	internal sealed partial class SocketAddress_ : java.net.SocketAddress
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SocketAddress_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static SocketAddress_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.SocketAddress_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/SocketAddress"));
		}
		internal static void InitJNI()
		{
		}
	}
}
