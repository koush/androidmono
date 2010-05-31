namespace java.nio.channels
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class ServerSocketChannel : java.nio.channels.spi.AbstractSelectableChannel
	{
		internal new static global::java.lang.Class staticClass;
		static ServerSocketChannel()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.nio.channels.ServerSocketChannel), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected ServerSocketChannel(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _accept12274;
		public abstract global::java.nio.channels.SocketChannel accept();
		internal static global::net.sf.jni4net.jni.MethodId _open12275;
		public static global::java.nio.channels.ServerSocketChannel open() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.ServerSocketChannel>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.channels.ServerSocketChannel.staticClass, global::java.nio.channels.ServerSocketChannel._open12275));
		}
		internal static global::net.sf.jni4net.jni.MethodId _socket12276;
		public abstract global::java.net.ServerSocket socket();
		internal static global::net.sf.jni4net.jni.MethodId _validOps12277;
		public sealed override int validOps() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.channels.ServerSocketChannel._validOps12277);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.channels.ServerSocketChannel.staticClass, global::java.nio.channels.ServerSocketChannel._validOps12277);
		}
		internal static global::net.sf.jni4net.jni.MethodId _ServerSocketChannel12278;
		protected ServerSocketChannel(java.nio.channels.spi.SelectorProvider arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.nio.channels.ServerSocketChannel.staticClass, global::java.nio.channels.ServerSocketChannel._ServerSocketChannel12278, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.nio.channels.ServerSocketChannel.staticClass = @__class;
			global::java.nio.channels.ServerSocketChannel._accept12274 = @__env.GetMethodID(global::java.nio.channels.ServerSocketChannel.staticClass, "accept", "()Ljava/nio/channels/SocketChannel;");
			global::java.nio.channels.ServerSocketChannel._open12275 = @__env.GetStaticMethodID(global::java.nio.channels.ServerSocketChannel.staticClass, "open", "()Ljava/nio/channels/ServerSocketChannel;");
			global::java.nio.channels.ServerSocketChannel._socket12276 = @__env.GetMethodID(global::java.nio.channels.ServerSocketChannel.staticClass, "socket", "()Ljava/net/ServerSocket;");
			global::java.nio.channels.ServerSocketChannel._validOps12277 = @__env.GetMethodID(global::java.nio.channels.ServerSocketChannel.staticClass, "validOps", "()I");
			global::java.nio.channels.ServerSocketChannel._ServerSocketChannel12278 = @__env.GetMethodID(global::java.nio.channels.ServerSocketChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V");
		}
	}
}
