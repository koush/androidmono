namespace java.nio.channels.spi
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class SelectorProvider : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static SelectorProvider()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.nio.channels.spi.SelectorProvider), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected SelectorProvider(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _inheritedChannel13057;
		public virtual global::java.nio.channels.Channel inheritedChannel() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.nio.channels.Channel>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.channels.spi.SelectorProvider._inheritedChannel13057));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.nio.channels.Channel>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.channels.spi.SelectorProvider.staticClass, global::java.nio.channels.spi.SelectorProvider._inheritedChannel13057));
		}
		internal static global::net.sf.jni4net.jni.MethodId _provider13058;
		public static global::java.nio.channels.spi.SelectorProvider provider() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.spi.SelectorProvider>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.channels.spi.SelectorProvider.staticClass, global::java.nio.channels.spi.SelectorProvider._provider13058));
		}
		internal static global::net.sf.jni4net.jni.MethodId _openDatagramChannel13059;
		public abstract global::java.nio.channels.DatagramChannel openDatagramChannel();
		internal static global::net.sf.jni4net.jni.MethodId _openServerSocketChannel13060;
		public abstract global::java.nio.channels.ServerSocketChannel openServerSocketChannel();
		internal static global::net.sf.jni4net.jni.MethodId _openSocketChannel13061;
		public abstract global::java.nio.channels.SocketChannel openSocketChannel();
		internal static global::net.sf.jni4net.jni.MethodId _openSelector13062;
		public abstract global::java.nio.channels.spi.AbstractSelector openSelector();
		internal static global::net.sf.jni4net.jni.MethodId _openPipe13063;
		public abstract global::java.nio.channels.Pipe openPipe();
		internal static global::net.sf.jni4net.jni.MethodId _SelectorProvider13064;
		protected SelectorProvider()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.nio.channels.spi.SelectorProvider.staticClass, global::java.nio.channels.spi.SelectorProvider._SelectorProvider13064, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.nio.channels.spi.SelectorProvider.staticClass = @__class;
			global::java.nio.channels.spi.SelectorProvider._inheritedChannel13057 = @__env.GetMethodID(global::java.nio.channels.spi.SelectorProvider.staticClass, "inheritedChannel", "()Ljava/nio/channels/Channel;");
			global::java.nio.channels.spi.SelectorProvider._provider13058 = @__env.GetStaticMethodID(global::java.nio.channels.spi.SelectorProvider.staticClass, "provider", "()Ljava/nio/channels/spi/SelectorProvider;");
			global::java.nio.channels.spi.SelectorProvider._openDatagramChannel13059 = @__env.GetMethodID(global::java.nio.channels.spi.SelectorProvider.staticClass, "openDatagramChannel", "()Ljava/nio/channels/DatagramChannel;");
			global::java.nio.channels.spi.SelectorProvider._openServerSocketChannel13060 = @__env.GetMethodID(global::java.nio.channels.spi.SelectorProvider.staticClass, "openServerSocketChannel", "()Ljava/nio/channels/ServerSocketChannel;");
			global::java.nio.channels.spi.SelectorProvider._openSocketChannel13061 = @__env.GetMethodID(global::java.nio.channels.spi.SelectorProvider.staticClass, "openSocketChannel", "()Ljava/nio/channels/SocketChannel;");
			global::java.nio.channels.spi.SelectorProvider._openSelector13062 = @__env.GetMethodID(global::java.nio.channels.spi.SelectorProvider.staticClass, "openSelector", "()Ljava/nio/channels/spi/AbstractSelector;");
			global::java.nio.channels.spi.SelectorProvider._openPipe13063 = @__env.GetMethodID(global::java.nio.channels.spi.SelectorProvider.staticClass, "openPipe", "()Ljava/nio/channels/Pipe;");
			global::java.nio.channels.spi.SelectorProvider._SelectorProvider13064 = @__env.GetMethodID(global::java.nio.channels.spi.SelectorProvider.staticClass, "<init>", "()V");
		}
	}
}
