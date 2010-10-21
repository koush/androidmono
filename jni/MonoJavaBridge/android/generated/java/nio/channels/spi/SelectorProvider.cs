namespace java.nio.channels.spi
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.spi.SelectorProvider_))]
	public abstract partial class SelectorProvider : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SelectorProvider()
		{
			InitJNI();
		}
		protected SelectorProvider(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _inheritedChannel22589;
		public virtual global::java.nio.channels.Channel inheritedChannel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.nio.channels.Channel>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.spi.SelectorProvider._inheritedChannel22589)) as java.nio.channels.Channel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.nio.channels.Channel>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.spi.SelectorProvider.staticClass, global::java.nio.channels.spi.SelectorProvider._inheritedChannel22589)) as java.nio.channels.Channel;
		}
		internal static global::MonoJavaBridge.MethodId _provider22590;
		public static global::java.nio.channels.spi.SelectorProvider provider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.spi.SelectorProvider.staticClass, global::java.nio.channels.spi.SelectorProvider._provider22590)) as java.nio.channels.spi.SelectorProvider;
		}
		internal static global::MonoJavaBridge.MethodId _openDatagramChannel22591;
		public abstract global::java.nio.channels.DatagramChannel openDatagramChannel();
		internal static global::MonoJavaBridge.MethodId _openServerSocketChannel22592;
		public abstract global::java.nio.channels.ServerSocketChannel openServerSocketChannel();
		internal static global::MonoJavaBridge.MethodId _openSocketChannel22593;
		public abstract global::java.nio.channels.SocketChannel openSocketChannel();
		internal static global::MonoJavaBridge.MethodId _openSelector22594;
		public abstract global::java.nio.channels.spi.AbstractSelector openSelector();
		internal static global::MonoJavaBridge.MethodId _openPipe22595;
		public abstract global::java.nio.channels.Pipe openPipe();
		internal static global::MonoJavaBridge.MethodId _SelectorProvider22596;
		protected SelectorProvider()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.spi.SelectorProvider.staticClass, global::java.nio.channels.spi.SelectorProvider._SelectorProvider22596);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.spi.SelectorProvider.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/spi/SelectorProvider"));
			global::java.nio.channels.spi.SelectorProvider._inheritedChannel22589 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.SelectorProvider.staticClass, "inheritedChannel", "()Ljava/nio/channels/Channel;");
			global::java.nio.channels.spi.SelectorProvider._provider22590 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.spi.SelectorProvider.staticClass, "provider", "()Ljava/nio/channels/spi/SelectorProvider;");
			global::java.nio.channels.spi.SelectorProvider._openDatagramChannel22591 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.SelectorProvider.staticClass, "openDatagramChannel", "()Ljava/nio/channels/DatagramChannel;");
			global::java.nio.channels.spi.SelectorProvider._openServerSocketChannel22592 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.SelectorProvider.staticClass, "openServerSocketChannel", "()Ljava/nio/channels/ServerSocketChannel;");
			global::java.nio.channels.spi.SelectorProvider._openSocketChannel22593 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.SelectorProvider.staticClass, "openSocketChannel", "()Ljava/nio/channels/SocketChannel;");
			global::java.nio.channels.spi.SelectorProvider._openSelector22594 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.SelectorProvider.staticClass, "openSelector", "()Ljava/nio/channels/spi/AbstractSelector;");
			global::java.nio.channels.spi.SelectorProvider._openPipe22595 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.SelectorProvider.staticClass, "openPipe", "()Ljava/nio/channels/Pipe;");
			global::java.nio.channels.spi.SelectorProvider._SelectorProvider22596 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.SelectorProvider.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.spi.SelectorProvider))]
	public sealed partial class SelectorProvider_ : java.nio.channels.spi.SelectorProvider
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SelectorProvider_()
		{
			InitJNI();
		}
		internal SelectorProvider_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _openDatagramChannel22597;
		public override global::java.nio.channels.DatagramChannel openDatagramChannel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.spi.SelectorProvider_._openDatagramChannel22597)) as java.nio.channels.DatagramChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.spi.SelectorProvider_.staticClass, global::java.nio.channels.spi.SelectorProvider_._openDatagramChannel22597)) as java.nio.channels.DatagramChannel;
		}
		internal static global::MonoJavaBridge.MethodId _openServerSocketChannel22598;
		public override global::java.nio.channels.ServerSocketChannel openServerSocketChannel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.spi.SelectorProvider_._openServerSocketChannel22598)) as java.nio.channels.ServerSocketChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.spi.SelectorProvider_.staticClass, global::java.nio.channels.spi.SelectorProvider_._openServerSocketChannel22598)) as java.nio.channels.ServerSocketChannel;
		}
		internal static global::MonoJavaBridge.MethodId _openSocketChannel22599;
		public override global::java.nio.channels.SocketChannel openSocketChannel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.spi.SelectorProvider_._openSocketChannel22599)) as java.nio.channels.SocketChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.spi.SelectorProvider_.staticClass, global::java.nio.channels.spi.SelectorProvider_._openSocketChannel22599)) as java.nio.channels.SocketChannel;
		}
		internal static global::MonoJavaBridge.MethodId _openSelector22600;
		public override global::java.nio.channels.spi.AbstractSelector openSelector() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.spi.SelectorProvider_._openSelector22600)) as java.nio.channels.spi.AbstractSelector;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.spi.SelectorProvider_.staticClass, global::java.nio.channels.spi.SelectorProvider_._openSelector22600)) as java.nio.channels.spi.AbstractSelector;
		}
		internal static global::MonoJavaBridge.MethodId _openPipe22601;
		public override global::java.nio.channels.Pipe openPipe() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.spi.SelectorProvider_._openPipe22601)) as java.nio.channels.Pipe;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.spi.SelectorProvider_.staticClass, global::java.nio.channels.spi.SelectorProvider_._openPipe22601)) as java.nio.channels.Pipe;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.spi.SelectorProvider_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/spi/SelectorProvider"));
			global::java.nio.channels.spi.SelectorProvider_._openDatagramChannel22597 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.SelectorProvider_.staticClass, "openDatagramChannel", "()Ljava/nio/channels/DatagramChannel;");
			global::java.nio.channels.spi.SelectorProvider_._openServerSocketChannel22598 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.SelectorProvider_.staticClass, "openServerSocketChannel", "()Ljava/nio/channels/ServerSocketChannel;");
			global::java.nio.channels.spi.SelectorProvider_._openSocketChannel22599 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.SelectorProvider_.staticClass, "openSocketChannel", "()Ljava/nio/channels/SocketChannel;");
			global::java.nio.channels.spi.SelectorProvider_._openSelector22600 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.SelectorProvider_.staticClass, "openSelector", "()Ljava/nio/channels/spi/AbstractSelector;");
			global::java.nio.channels.spi.SelectorProvider_._openPipe22601 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.SelectorProvider_.staticClass, "openPipe", "()Ljava/nio/channels/Pipe;");
		}
	}
}
