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
		internal static global::MonoJavaBridge.MethodId _inheritedChannel14659;
		public virtual global::java.nio.channels.Channel inheritedChannel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.nio.channels.Channel>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.spi.SelectorProvider._inheritedChannel14659)) as java.nio.channels.Channel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.nio.channels.Channel>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.spi.SelectorProvider.staticClass, global::java.nio.channels.spi.SelectorProvider._inheritedChannel14659)) as java.nio.channels.Channel;
		}
		internal static global::MonoJavaBridge.MethodId _provider14660;
		public static global::java.nio.channels.spi.SelectorProvider provider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.spi.SelectorProvider.staticClass, global::java.nio.channels.spi.SelectorProvider._provider14660)) as java.nio.channels.spi.SelectorProvider;
		}
		internal static global::MonoJavaBridge.MethodId _openDatagramChannel14661;
		public abstract global::java.nio.channels.DatagramChannel openDatagramChannel();
		internal static global::MonoJavaBridge.MethodId _openServerSocketChannel14662;
		public abstract global::java.nio.channels.ServerSocketChannel openServerSocketChannel();
		internal static global::MonoJavaBridge.MethodId _openSocketChannel14663;
		public abstract global::java.nio.channels.SocketChannel openSocketChannel();
		internal static global::MonoJavaBridge.MethodId _openSelector14664;
		public abstract global::java.nio.channels.spi.AbstractSelector openSelector();
		internal static global::MonoJavaBridge.MethodId _openPipe14665;
		public abstract global::java.nio.channels.Pipe openPipe();
		internal static global::MonoJavaBridge.MethodId _SelectorProvider14666;
		protected SelectorProvider()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.spi.SelectorProvider.staticClass, global::java.nio.channels.spi.SelectorProvider._SelectorProvider14666);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.spi.SelectorProvider.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/spi/SelectorProvider"));
			global::java.nio.channels.spi.SelectorProvider._inheritedChannel14659 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.SelectorProvider.staticClass, "inheritedChannel", "()Ljava/nio/channels/Channel;");
			global::java.nio.channels.spi.SelectorProvider._provider14660 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.spi.SelectorProvider.staticClass, "provider", "()Ljava/nio/channels/spi/SelectorProvider;");
			global::java.nio.channels.spi.SelectorProvider._openDatagramChannel14661 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.SelectorProvider.staticClass, "openDatagramChannel", "()Ljava/nio/channels/DatagramChannel;");
			global::java.nio.channels.spi.SelectorProvider._openServerSocketChannel14662 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.SelectorProvider.staticClass, "openServerSocketChannel", "()Ljava/nio/channels/ServerSocketChannel;");
			global::java.nio.channels.spi.SelectorProvider._openSocketChannel14663 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.SelectorProvider.staticClass, "openSocketChannel", "()Ljava/nio/channels/SocketChannel;");
			global::java.nio.channels.spi.SelectorProvider._openSelector14664 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.SelectorProvider.staticClass, "openSelector", "()Ljava/nio/channels/spi/AbstractSelector;");
			global::java.nio.channels.spi.SelectorProvider._openPipe14665 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.SelectorProvider.staticClass, "openPipe", "()Ljava/nio/channels/Pipe;");
			global::java.nio.channels.spi.SelectorProvider._SelectorProvider14666 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.SelectorProvider.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _openDatagramChannel14667;
		public override global::java.nio.channels.DatagramChannel openDatagramChannel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.spi.SelectorProvider_._openDatagramChannel14667)) as java.nio.channels.DatagramChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.spi.SelectorProvider_.staticClass, global::java.nio.channels.spi.SelectorProvider_._openDatagramChannel14667)) as java.nio.channels.DatagramChannel;
		}
		internal static global::MonoJavaBridge.MethodId _openServerSocketChannel14668;
		public override global::java.nio.channels.ServerSocketChannel openServerSocketChannel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.spi.SelectorProvider_._openServerSocketChannel14668)) as java.nio.channels.ServerSocketChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.spi.SelectorProvider_.staticClass, global::java.nio.channels.spi.SelectorProvider_._openServerSocketChannel14668)) as java.nio.channels.ServerSocketChannel;
		}
		internal static global::MonoJavaBridge.MethodId _openSocketChannel14669;
		public override global::java.nio.channels.SocketChannel openSocketChannel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.spi.SelectorProvider_._openSocketChannel14669)) as java.nio.channels.SocketChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.spi.SelectorProvider_.staticClass, global::java.nio.channels.spi.SelectorProvider_._openSocketChannel14669)) as java.nio.channels.SocketChannel;
		}
		internal static global::MonoJavaBridge.MethodId _openSelector14670;
		public override global::java.nio.channels.spi.AbstractSelector openSelector() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.spi.SelectorProvider_._openSelector14670)) as java.nio.channels.spi.AbstractSelector;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.spi.SelectorProvider_.staticClass, global::java.nio.channels.spi.SelectorProvider_._openSelector14670)) as java.nio.channels.spi.AbstractSelector;
		}
		internal static global::MonoJavaBridge.MethodId _openPipe14671;
		public override global::java.nio.channels.Pipe openPipe() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.spi.SelectorProvider_._openPipe14671)) as java.nio.channels.Pipe;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.spi.SelectorProvider_.staticClass, global::java.nio.channels.spi.SelectorProvider_._openPipe14671)) as java.nio.channels.Pipe;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.spi.SelectorProvider_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/spi/SelectorProvider"));
			global::java.nio.channels.spi.SelectorProvider_._openDatagramChannel14667 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.SelectorProvider_.staticClass, "openDatagramChannel", "()Ljava/nio/channels/DatagramChannel;");
			global::java.nio.channels.spi.SelectorProvider_._openServerSocketChannel14668 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.SelectorProvider_.staticClass, "openServerSocketChannel", "()Ljava/nio/channels/ServerSocketChannel;");
			global::java.nio.channels.spi.SelectorProvider_._openSocketChannel14669 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.SelectorProvider_.staticClass, "openSocketChannel", "()Ljava/nio/channels/SocketChannel;");
			global::java.nio.channels.spi.SelectorProvider_._openSelector14670 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.SelectorProvider_.staticClass, "openSelector", "()Ljava/nio/channels/spi/AbstractSelector;");
			global::java.nio.channels.spi.SelectorProvider_._openPipe14671 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.SelectorProvider_.staticClass, "openPipe", "()Ljava/nio/channels/Pipe;");
		}
	}
}
