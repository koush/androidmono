namespace java.nio.channels.spi
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.spi.SelectorProvider_))]
	public abstract partial class SelectorProvider : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SelectorProvider(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.nio.channels.Channel inheritedChannel()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.nio.channels.Channel>(this, global::java.nio.channels.spi.SelectorProvider.staticClass, "inheritedChannel", "()Ljava/nio/channels/Channel;", ref global::java.nio.channels.spi.SelectorProvider._m0) as java.nio.channels.Channel;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.nio.channels.spi.SelectorProvider provider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.spi.SelectorProvider._m1.native == global::System.IntPtr.Zero)
				global::java.nio.channels.spi.SelectorProvider._m1 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.spi.SelectorProvider.staticClass, "provider", "()Ljava/nio/channels/spi/SelectorProvider;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.spi.SelectorProvider.staticClass, global::java.nio.channels.spi.SelectorProvider._m1)) as java.nio.channels.spi.SelectorProvider;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract global::java.nio.channels.DatagramChannel openDatagramChannel();
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract global::java.nio.channels.ServerSocketChannel openServerSocketChannel();
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract global::java.nio.channels.SocketChannel openSocketChannel();
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract global::java.nio.channels.spi.AbstractSelector openSelector();
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract global::java.nio.channels.Pipe openPipe();
		private static global::MonoJavaBridge.MethodId _m7;
		protected SelectorProvider() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.spi.SelectorProvider._m7.native == global::System.IntPtr.Zero)
				global::java.nio.channels.spi.SelectorProvider._m7 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.SelectorProvider.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.spi.SelectorProvider.staticClass, global::java.nio.channels.spi.SelectorProvider._m7);
			Init(@__env, handle);
		}
		static SelectorProvider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.spi.SelectorProvider.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/spi/SelectorProvider"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.spi.SelectorProvider))]
	internal sealed partial class SelectorProvider_ : java.nio.channels.spi.SelectorProvider
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SelectorProvider_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.nio.channels.DatagramChannel openDatagramChannel()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.spi.SelectorProvider_.staticClass, "openDatagramChannel", "()Ljava/nio/channels/DatagramChannel;", ref global::java.nio.channels.spi.SelectorProvider_._m0) as java.nio.channels.DatagramChannel;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.nio.channels.ServerSocketChannel openServerSocketChannel()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.spi.SelectorProvider_.staticClass, "openServerSocketChannel", "()Ljava/nio/channels/ServerSocketChannel;", ref global::java.nio.channels.spi.SelectorProvider_._m1) as java.nio.channels.ServerSocketChannel;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.nio.channels.SocketChannel openSocketChannel()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.spi.SelectorProvider_.staticClass, "openSocketChannel", "()Ljava/nio/channels/SocketChannel;", ref global::java.nio.channels.spi.SelectorProvider_._m2) as java.nio.channels.SocketChannel;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.nio.channels.spi.AbstractSelector openSelector()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.spi.SelectorProvider_.staticClass, "openSelector", "()Ljava/nio/channels/spi/AbstractSelector;", ref global::java.nio.channels.spi.SelectorProvider_._m3) as java.nio.channels.spi.AbstractSelector;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::java.nio.channels.Pipe openPipe()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.spi.SelectorProvider_.staticClass, "openPipe", "()Ljava/nio/channels/Pipe;", ref global::java.nio.channels.spi.SelectorProvider_._m4) as java.nio.channels.Pipe;
		}
		static SelectorProvider_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.spi.SelectorProvider_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/spi/SelectorProvider"));
		}
		internal static void InitJNI()
		{
		}
	}
}
