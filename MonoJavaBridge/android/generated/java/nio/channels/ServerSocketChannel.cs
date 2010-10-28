namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.ServerSocketChannel_))]
	public abstract partial class ServerSocketChannel : java.nio.channels.spi.AbstractSelectableChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ServerSocketChannel(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _accept22620;
		public abstract global::java.nio.channels.SocketChannel accept();
		internal static global::MonoJavaBridge.MethodId _open22621;
		public static global::java.nio.channels.ServerSocketChannel open()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.ServerSocketChannel.staticClass, global::java.nio.channels.ServerSocketChannel._open22621)) as java.nio.channels.ServerSocketChannel;
		}
		internal static global::MonoJavaBridge.MethodId _socket22622;
		public abstract global::java.net.ServerSocket socket();
		internal static global::MonoJavaBridge.MethodId _validOps22623;
		public sealed override int validOps()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.ServerSocketChannel._validOps22623);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.ServerSocketChannel.staticClass, global::java.nio.channels.ServerSocketChannel._validOps22623);
		}
		internal static global::MonoJavaBridge.MethodId _ServerSocketChannel22624;
		protected ServerSocketChannel(java.nio.channels.spi.SelectorProvider arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.ServerSocketChannel.staticClass, global::java.nio.channels.ServerSocketChannel._ServerSocketChannel22624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ServerSocketChannel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.ServerSocketChannel.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/ServerSocketChannel"));
			global::java.nio.channels.ServerSocketChannel._accept22620 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ServerSocketChannel.staticClass, "accept", "()Ljava/nio/channels/SocketChannel;");
			global::java.nio.channels.ServerSocketChannel._open22621 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.ServerSocketChannel.staticClass, "open", "()Ljava/nio/channels/ServerSocketChannel;");
			global::java.nio.channels.ServerSocketChannel._socket22622 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ServerSocketChannel.staticClass, "socket", "()Ljava/net/ServerSocket;");
			global::java.nio.channels.ServerSocketChannel._validOps22623 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ServerSocketChannel.staticClass, "validOps", "()I");
			global::java.nio.channels.ServerSocketChannel._ServerSocketChannel22624 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ServerSocketChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.ServerSocketChannel))]
	internal sealed partial class ServerSocketChannel_ : java.nio.channels.ServerSocketChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ServerSocketChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _accept22625;
		public override global::java.nio.channels.SocketChannel accept()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.ServerSocketChannel_._accept22625)) as java.nio.channels.SocketChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.ServerSocketChannel_.staticClass, global::java.nio.channels.ServerSocketChannel_._accept22625)) as java.nio.channels.SocketChannel;
		}
		internal static global::MonoJavaBridge.MethodId _socket22626;
		public override global::java.net.ServerSocket socket()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.ServerSocketChannel_._socket22626)) as java.net.ServerSocket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.ServerSocketChannel_.staticClass, global::java.nio.channels.ServerSocketChannel_._socket22626)) as java.net.ServerSocket;
		}
		internal static global::MonoJavaBridge.MethodId _implCloseSelectableChannel22627;
		protected override void implCloseSelectableChannel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.ServerSocketChannel_._implCloseSelectableChannel22627);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.ServerSocketChannel_.staticClass, global::java.nio.channels.ServerSocketChannel_._implCloseSelectableChannel22627);
		}
		internal static global::MonoJavaBridge.MethodId _implConfigureBlocking22628;
		protected override void implConfigureBlocking(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.ServerSocketChannel_._implConfigureBlocking22628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.ServerSocketChannel_.staticClass, global::java.nio.channels.ServerSocketChannel_._implConfigureBlocking22628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static ServerSocketChannel_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.ServerSocketChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/ServerSocketChannel"));
			global::java.nio.channels.ServerSocketChannel_._accept22625 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ServerSocketChannel_.staticClass, "accept", "()Ljava/nio/channels/SocketChannel;");
			global::java.nio.channels.ServerSocketChannel_._socket22626 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ServerSocketChannel_.staticClass, "socket", "()Ljava/net/ServerSocket;");
			global::java.nio.channels.ServerSocketChannel_._implCloseSelectableChannel22627 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ServerSocketChannel_.staticClass, "implCloseSelectableChannel", "()V");
			global::java.nio.channels.ServerSocketChannel_._implConfigureBlocking22628 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ServerSocketChannel_.staticClass, "implConfigureBlocking", "(Z)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
