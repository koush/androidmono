namespace java.nio.channels 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class ServerSocketChannel : java.nio.channels.spi.AbstractSelectableChannel
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ServerSocketChannel() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.nio.channels.ServerSocketChannel), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected ServerSocketChannel(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _accept11414; 
		public abstract java.nio.channels.SocketChannel accept(); 
		internal static global::net.sf.jni4net.jni.MethodId _open11415; 
		public static java.nio.channels.ServerSocketChannel open() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.ServerSocketChannel>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.channels.ServerSocketChannel.staticClass, _open11415)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _socket11416; 
		public abstract java.net.ServerSocket socket(); 
		internal static global::net.sf.jni4net.jni.MethodId _validOps11417; 
		public sealed override int validOps() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.ServerSocketChannel)) 
				return @__env.CallIntMethod(this, _validOps11417); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.nio.channels.ServerSocketChannel.staticClass, _validOps11417); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ServerSocketChannel11418; 
		protected ServerSocketChannel(java.nio.channels.spi.SelectorProvider arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.nio.channels.ServerSocketChannel.staticClass, _ServerSocketChannel11418, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.nio.channels.ServerSocketChannel.staticClass = @__class; 
			global::java.nio.channels.ServerSocketChannel._accept11414 = @__env.GetMethodID(global::java.nio.channels.ServerSocketChannel.staticClass, "accept", "()Ljava/nio/channels/SocketChannel;"); 
			global::java.nio.channels.ServerSocketChannel._open11415 = @__env.GetStaticMethodID(global::java.nio.channels.ServerSocketChannel.staticClass, "open", "()Ljava/nio/channels/ServerSocketChannel;"); 
			global::java.nio.channels.ServerSocketChannel._socket11416 = @__env.GetMethodID(global::java.nio.channels.ServerSocketChannel.staticClass, "socket", "()Ljava/net/ServerSocket;"); 
			global::java.nio.channels.ServerSocketChannel._validOps11417 = @__env.GetMethodID(global::java.nio.channels.ServerSocketChannel.staticClass, "validOps", "()I"); 
			global::java.nio.channels.ServerSocketChannel._ServerSocketChannel11418 = @__env.GetMethodID(global::java.nio.channels.ServerSocketChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V"); 
		} 
	} 
} 
