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
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.channels.GatheringByteChannel_.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J", ref global::java.nio.channels.GatheringByteChannel_._write22502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write22503;
		long java.nio.channels.GatheringByteChannel.write(java.nio.ByteBuffer[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.channels.GatheringByteChannel_.staticClass, "write", "([Ljava/nio/ByteBuffer;)J", ref global::java.nio.channels.GatheringByteChannel_._write22503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write22504;
		int java.nio.channels.WritableByteChannel.write(java.nio.ByteBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.GatheringByteChannel_.staticClass, "write", "(Ljava/nio/ByteBuffer;)I", ref global::java.nio.channels.GatheringByteChannel_._write22504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close22505;
		void java.nio.channels.Channel.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.GatheringByteChannel_.staticClass, "close", "()V", ref global::java.nio.channels.GatheringByteChannel_._close22505);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen22506;
		bool java.nio.channels.Channel.isOpen()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.GatheringByteChannel_.staticClass, "isOpen", "()Z", ref global::java.nio.channels.GatheringByteChannel_._isOpen22506);
		}
		internal static global::MonoJavaBridge.MethodId _close22507;
		void java.io.Closeable.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.GatheringByteChannel_.staticClass, "close", "()V", ref global::java.nio.channels.GatheringByteChannel_._close22507);
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
