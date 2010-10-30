namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.nio.channels.GatheringByteChannel_))]
	public partial interface GatheringByteChannel : WritableByteChannel
	{
		long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		long write(java.nio.ByteBuffer[] arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.GatheringByteChannel))]
	internal sealed partial class GatheringByteChannel_ : java.lang.Object, GatheringByteChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal GatheringByteChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write22502;
		long java.nio.channels.GatheringByteChannel.write(java.nio.ByteBuffer[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.GatheringByteChannel_._write22502.native == global::System.IntPtr.Zero)
				global::java.nio.channels.GatheringByteChannel_._write22502 = @__env.GetMethodIDNoThrow(global::java.nio.channels.GatheringByteChannel_.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J");
			return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.GatheringByteChannel_._write22502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write22503;
		long java.nio.channels.GatheringByteChannel.write(java.nio.ByteBuffer[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.GatheringByteChannel_._write22503.native == global::System.IntPtr.Zero)
				global::java.nio.channels.GatheringByteChannel_._write22503 = @__env.GetMethodIDNoThrow(global::java.nio.channels.GatheringByteChannel_.staticClass, "write", "([Ljava/nio/ByteBuffer;)J");
			return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.GatheringByteChannel_._write22503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write22504;
		int java.nio.channels.WritableByteChannel.write(java.nio.ByteBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.GatheringByteChannel_._write22504.native == global::System.IntPtr.Zero)
				global::java.nio.channels.GatheringByteChannel_._write22504 = @__env.GetMethodIDNoThrow(global::java.nio.channels.GatheringByteChannel_.staticClass, "write", "(Ljava/nio/ByteBuffer;)I");
			return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.GatheringByteChannel_._write22504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close22505;
		void java.nio.channels.Channel.close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.GatheringByteChannel_._close22505.native == global::System.IntPtr.Zero)
				global::java.nio.channels.GatheringByteChannel_._close22505 = @__env.GetMethodIDNoThrow(global::java.nio.channels.GatheringByteChannel_.staticClass, "close", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.GatheringByteChannel_._close22505);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen22506;
		bool java.nio.channels.Channel.isOpen()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.GatheringByteChannel_._isOpen22506.native == global::System.IntPtr.Zero)
				global::java.nio.channels.GatheringByteChannel_._isOpen22506 = @__env.GetMethodIDNoThrow(global::java.nio.channels.GatheringByteChannel_.staticClass, "isOpen", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.GatheringByteChannel_._isOpen22506);
		}
		internal static global::MonoJavaBridge.MethodId _close22507;
		void java.io.Closeable.close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.GatheringByteChannel_._close22507.native == global::System.IntPtr.Zero)
				global::java.nio.channels.GatheringByteChannel_._close22507 = @__env.GetMethodIDNoThrow(global::java.nio.channels.GatheringByteChannel_.staticClass, "close", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.GatheringByteChannel_._close22507);
		}
		static GatheringByteChannel_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.GatheringByteChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/GatheringByteChannel"));
		}
		internal static void InitJNI()
		{
		}
	}
}
