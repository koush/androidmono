namespace java.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.net.SocketAddress_))]
	public abstract partial class SocketAddress : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SocketAddress()
		{
			InitJNI();
		}
		protected SocketAddress(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SocketAddress21654;
		public SocketAddress()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.SocketAddress.staticClass, global::java.net.SocketAddress._SocketAddress21654);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.SocketAddress.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/SocketAddress"));
			global::java.net.SocketAddress._SocketAddress21654 = @__env.GetMethodIDNoThrow(global::java.net.SocketAddress.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.SocketAddress))]
	public sealed partial class SocketAddress_ : java.net.SocketAddress
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SocketAddress_()
		{
			InitJNI();
		}
		internal SocketAddress_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.SocketAddress_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/SocketAddress"));
		}
	}
}
