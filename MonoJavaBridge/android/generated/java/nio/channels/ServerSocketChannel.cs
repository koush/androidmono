namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.ServerSocketChannel_))]
	public abstract partial class ServerSocketChannel : java.nio.channels.spi.AbstractSelectableChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ServerSocketChannel(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract global::java.nio.channels.SocketChannel accept();
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.nio.channels.ServerSocketChannel open()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.ServerSocketChannel._m1.native == global::System.IntPtr.Zero)
				global::java.nio.channels.ServerSocketChannel._m1 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.ServerSocketChannel.staticClass, "open", "()Ljava/nio/channels/ServerSocketChannel;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.ServerSocketChannel.staticClass, global::java.nio.channels.ServerSocketChannel._m1)) as java.nio.channels.ServerSocketChannel;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract global::java.net.ServerSocket socket();
		private static global::MonoJavaBridge.MethodId _m3;
		public sealed override int validOps()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.ServerSocketChannel.staticClass, "validOps", "()I", ref global::java.nio.channels.ServerSocketChannel._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected ServerSocketChannel(java.nio.channels.spi.SelectorProvider arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.ServerSocketChannel._m4.native == global::System.IntPtr.Zero)
				global::java.nio.channels.ServerSocketChannel._m4 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ServerSocketChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.ServerSocketChannel.staticClass, global::java.nio.channels.ServerSocketChannel._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ServerSocketChannel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.ServerSocketChannel.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/ServerSocketChannel"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.ServerSocketChannel))]
	internal sealed partial class ServerSocketChannel_ : java.nio.channels.ServerSocketChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ServerSocketChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.nio.channels.SocketChannel accept()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.ServerSocketChannel_.staticClass, "accept", "()Ljava/nio/channels/SocketChannel;", ref global::java.nio.channels.ServerSocketChannel_._m0) as java.nio.channels.SocketChannel;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.net.ServerSocket socket()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.ServerSocketChannel_.staticClass, "socket", "()Ljava/net/ServerSocket;", ref global::java.nio.channels.ServerSocketChannel_._m1) as java.net.ServerSocket;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override void implCloseSelectableChannel()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.ServerSocketChannel_.staticClass, "implCloseSelectableChannel", "()V", ref global::java.nio.channels.ServerSocketChannel_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override void implConfigureBlocking(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.ServerSocketChannel_.staticClass, "implConfigureBlocking", "(Z)V", ref global::java.nio.channels.ServerSocketChannel_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static ServerSocketChannel_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.ServerSocketChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/ServerSocketChannel"));
		}
	}
}
