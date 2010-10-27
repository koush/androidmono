namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.ServerSocketChannel_))]
	public abstract partial class ServerSocketChannel : java.nio.channels.spi.AbstractSelectableChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ServerSocketChannel()
		{
			InitJNI();
		}
		protected ServerSocketChannel(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _accept22619;
		public abstract global::java.nio.channels.SocketChannel accept();
		internal static global::MonoJavaBridge.MethodId _open22620;
		public static global::java.nio.channels.ServerSocketChannel open()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.ServerSocketChannel.staticClass, global::java.nio.channels.ServerSocketChannel._open22620)) as java.nio.channels.ServerSocketChannel;
		}
		internal static global::MonoJavaBridge.MethodId _socket22621;
		public abstract global::java.net.ServerSocket socket();
		internal static global::MonoJavaBridge.MethodId _validOps22622;
		public sealed override int validOps()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.ServerSocketChannel._validOps22622);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.ServerSocketChannel.staticClass, global::java.nio.channels.ServerSocketChannel._validOps22622);
		}
		internal static global::MonoJavaBridge.MethodId _ServerSocketChannel22623;
		protected ServerSocketChannel(java.nio.channels.spi.SelectorProvider arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.ServerSocketChannel.staticClass, global::java.nio.channels.ServerSocketChannel._ServerSocketChannel22623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.ServerSocketChannel.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/ServerSocketChannel"));
			global::java.nio.channels.ServerSocketChannel._accept22619 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ServerSocketChannel.staticClass, "accept", "()Ljava/nio/channels/SocketChannel;");
			global::java.nio.channels.ServerSocketChannel._open22620 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.ServerSocketChannel.staticClass, "open", "()Ljava/nio/channels/ServerSocketChannel;");
			global::java.nio.channels.ServerSocketChannel._socket22621 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ServerSocketChannel.staticClass, "socket", "()Ljava/net/ServerSocket;");
			global::java.nio.channels.ServerSocketChannel._validOps22622 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ServerSocketChannel.staticClass, "validOps", "()I");
			global::java.nio.channels.ServerSocketChannel._ServerSocketChannel22623 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ServerSocketChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.ServerSocketChannel))]
	internal sealed partial class ServerSocketChannel_ : java.nio.channels.ServerSocketChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ServerSocketChannel_()
		{
			InitJNI();
		}
		internal ServerSocketChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _accept22624;
		public override global::java.nio.channels.SocketChannel accept()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.ServerSocketChannel_._accept22624)) as java.nio.channels.SocketChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.ServerSocketChannel_.staticClass, global::java.nio.channels.ServerSocketChannel_._accept22624)) as java.nio.channels.SocketChannel;
		}
		internal static global::MonoJavaBridge.MethodId _socket22625;
		public override global::java.net.ServerSocket socket()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.ServerSocketChannel_._socket22625)) as java.net.ServerSocket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.ServerSocketChannel_.staticClass, global::java.nio.channels.ServerSocketChannel_._socket22625)) as java.net.ServerSocket;
		}
		internal static global::MonoJavaBridge.MethodId _implCloseSelectableChannel22626;
		protected override void implCloseSelectableChannel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.ServerSocketChannel_._implCloseSelectableChannel22626);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.ServerSocketChannel_.staticClass, global::java.nio.channels.ServerSocketChannel_._implCloseSelectableChannel22626);
		}
		internal static global::MonoJavaBridge.MethodId _implConfigureBlocking22627;
		protected override void implConfigureBlocking(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.ServerSocketChannel_._implConfigureBlocking22627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.ServerSocketChannel_.staticClass, global::java.nio.channels.ServerSocketChannel_._implConfigureBlocking22627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.ServerSocketChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/ServerSocketChannel"));
			global::java.nio.channels.ServerSocketChannel_._accept22624 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ServerSocketChannel_.staticClass, "accept", "()Ljava/nio/channels/SocketChannel;");
			global::java.nio.channels.ServerSocketChannel_._socket22625 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ServerSocketChannel_.staticClass, "socket", "()Ljava/net/ServerSocket;");
			global::java.nio.channels.ServerSocketChannel_._implCloseSelectableChannel22626 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ServerSocketChannel_.staticClass, "implCloseSelectableChannel", "()V");
			global::java.nio.channels.ServerSocketChannel_._implConfigureBlocking22627 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ServerSocketChannel_.staticClass, "implConfigureBlocking", "(Z)V");
		}
	}
}
