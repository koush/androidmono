namespace java.nio.channels.spi 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class SelectorProvider : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static SelectorProvider() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.nio.channels.spi.SelectorProvider), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected SelectorProvider(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inheritedChannel11464; 
		public virtual java.nio.channels.Channel inheritedChannel() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.spi.SelectorProvider)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.nio.channels.Channel>(@__env, @__env.CallObjectMethodPtr(this, _inheritedChannel11464)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.nio.channels.Channel>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.channels.spi.SelectorProvider.staticClass, _inheritedChannel11464)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _provider11465; 
		public static java.nio.channels.spi.SelectorProvider provider() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.spi.SelectorProvider>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.channels.spi.SelectorProvider.staticClass, _provider11465)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _openDatagramChannel11466; 
		public abstract java.nio.channels.DatagramChannel openDatagramChannel(); 
		internal static global::net.sf.jni4net.jni.MethodId _openServerSocketChannel11467; 
		public abstract java.nio.channels.ServerSocketChannel openServerSocketChannel(); 
		internal static global::net.sf.jni4net.jni.MethodId _openSocketChannel11468; 
		public abstract java.nio.channels.SocketChannel openSocketChannel(); 
		internal static global::net.sf.jni4net.jni.MethodId _openSelector11469; 
		public abstract java.nio.channels.spi.AbstractSelector openSelector(); 
		internal static global::net.sf.jni4net.jni.MethodId _openPipe11470; 
		public abstract java.nio.channels.Pipe openPipe(); 
		internal static global::net.sf.jni4net.jni.MethodId _SelectorProvider11471; 
		protected SelectorProvider()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.nio.channels.spi.SelectorProvider.staticClass, _SelectorProvider11471, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.nio.channels.spi.SelectorProvider.staticClass = @__class; 
			global::java.nio.channels.spi.SelectorProvider._inheritedChannel11464 = @__env.GetMethodID(global::java.nio.channels.spi.SelectorProvider.staticClass, "inheritedChannel", "()Ljava/nio/channels/Channel;"); 
			global::java.nio.channels.spi.SelectorProvider._provider11465 = @__env.GetStaticMethodID(global::java.nio.channels.spi.SelectorProvider.staticClass, "provider", "()Ljava/nio/channels/spi/SelectorProvider;"); 
			global::java.nio.channels.spi.SelectorProvider._openDatagramChannel11466 = @__env.GetMethodID(global::java.nio.channels.spi.SelectorProvider.staticClass, "openDatagramChannel", "()Ljava/nio/channels/DatagramChannel;"); 
			global::java.nio.channels.spi.SelectorProvider._openServerSocketChannel11467 = @__env.GetMethodID(global::java.nio.channels.spi.SelectorProvider.staticClass, "openServerSocketChannel", "()Ljava/nio/channels/ServerSocketChannel;"); 
			global::java.nio.channels.spi.SelectorProvider._openSocketChannel11468 = @__env.GetMethodID(global::java.nio.channels.spi.SelectorProvider.staticClass, "openSocketChannel", "()Ljava/nio/channels/SocketChannel;"); 
			global::java.nio.channels.spi.SelectorProvider._openSelector11469 = @__env.GetMethodID(global::java.nio.channels.spi.SelectorProvider.staticClass, "openSelector", "()Ljava/nio/channels/spi/AbstractSelector;"); 
			global::java.nio.channels.spi.SelectorProvider._openPipe11470 = @__env.GetMethodID(global::java.nio.channels.spi.SelectorProvider.staticClass, "openPipe", "()Ljava/nio/channels/Pipe;"); 
			global::java.nio.channels.spi.SelectorProvider._SelectorProvider11471 = @__env.GetMethodID(global::java.nio.channels.spi.SelectorProvider.staticClass, "<init>", "()V"); 
		} 
	} 
} 
