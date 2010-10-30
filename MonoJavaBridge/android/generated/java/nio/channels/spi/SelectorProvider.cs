namespace java.nio.channels.spi
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.spi.SelectorProvider_))]
	public abstract partial class SelectorProvider : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SelectorProvider(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _inheritedChannel22708;
		public virtual global::java.nio.channels.Channel inheritedChannel()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.nio.channels.Channel>(this, global::java.nio.channels.spi.SelectorProvider.staticClass, "inheritedChannel", "()Ljava/nio/channels/Channel;", ref global::java.nio.channels.spi.SelectorProvider._inheritedChannel22708) as java.nio.channels.Channel;
		}
		internal static global::MonoJavaBridge.MethodId _provider22709;
		public static global::java.nio.channels.spi.SelectorProvider provider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.spi.SelectorProvider._provider22709.native == global::System.IntPtr.Zero)
				global::java.nio.channels.spi.SelectorProvider._provider22709 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.spi.SelectorProvider.staticClass, "provider", "()Ljava/nio/channels/spi/SelectorProvider;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.spi.SelectorProvider.staticClass, global::java.nio.channels.spi.SelectorProvider._provider22709)) as java.nio.channels.spi.SelectorProvider;
		}
		internal static global::MonoJavaBridge.MethodId _openDatagramChannel22710;
		public abstract global::java.nio.channels.DatagramChannel openDatagramChannel();
		internal static global::MonoJavaBridge.MethodId _openServerSocketChannel22711;
		public abstract global::java.nio.channels.ServerSocketChannel openServerSocketChannel();
		internal static global::MonoJavaBridge.MethodId _openSocketChannel22712;
		public abstract global::java.nio.channels.SocketChannel openSocketChannel();
		internal static global::MonoJavaBridge.MethodId _openSelector22713;
		public abstract global::java.nio.channels.spi.AbstractSelector openSelector();
		internal static global::MonoJavaBridge.MethodId _openPipe22714;
		public abstract global::java.nio.channels.Pipe openPipe();
		internal static global::MonoJavaBridge.MethodId _SelectorProvider22715;
		protected SelectorProvider() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.spi.SelectorProvider._SelectorProvider22715.native == global::System.IntPtr.Zero)
				global::java.nio.channels.spi.SelectorProvider._SelectorProvider22715 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.SelectorProvider.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.spi.SelectorProvider.staticClass, global::java.nio.channels.spi.SelectorProvider._SelectorProvider22715);
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
		internal static global::MonoJavaBridge.MethodId _openDatagramChannel22716;
		public override global::java.nio.channels.DatagramChannel openDatagramChannel()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.spi.SelectorProvider_.staticClass, "openDatagramChannel", "()Ljava/nio/channels/DatagramChannel;", ref global::java.nio.channels.spi.SelectorProvider_._openDatagramChannel22716) as java.nio.channels.DatagramChannel;
		}
		internal static global::MonoJavaBridge.MethodId _openServerSocketChannel22717;
		public override global::java.nio.channels.ServerSocketChannel openServerSocketChannel()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.spi.SelectorProvider_.staticClass, "openServerSocketChannel", "()Ljava/nio/channels/ServerSocketChannel;", ref global::java.nio.channels.spi.SelectorProvider_._openServerSocketChannel22717) as java.nio.channels.ServerSocketChannel;
		}
		internal static global::MonoJavaBridge.MethodId _openSocketChannel22718;
		public override global::java.nio.channels.SocketChannel openSocketChannel()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.spi.SelectorProvider_.staticClass, "openSocketChannel", "()Ljava/nio/channels/SocketChannel;", ref global::java.nio.channels.spi.SelectorProvider_._openSocketChannel22718) as java.nio.channels.SocketChannel;
		}
		internal static global::MonoJavaBridge.MethodId _openSelector22719;
		public override global::java.nio.channels.spi.AbstractSelector openSelector()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.spi.SelectorProvider_.staticClass, "openSelector", "()Ljava/nio/channels/spi/AbstractSelector;", ref global::java.nio.channels.spi.SelectorProvider_._openSelector22719) as java.nio.channels.spi.AbstractSelector;
		}
		internal static global::MonoJavaBridge.MethodId _openPipe22720;
		public override global::java.nio.channels.Pipe openPipe()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.spi.SelectorProvider_.staticClass, "openPipe", "()Ljava/nio/channels/Pipe;", ref global::java.nio.channels.spi.SelectorProvider_._openPipe22720) as java.nio.channels.Pipe;
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
