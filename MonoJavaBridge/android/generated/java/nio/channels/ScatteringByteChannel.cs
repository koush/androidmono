namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.nio.channels.ScatteringByteChannel_))]
	public partial interface ScatteringByteChannel : ReadableByteChannel
	{
		long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		long read(java.nio.ByteBuffer[] arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.ScatteringByteChannel))]
	internal sealed partial class ScatteringByteChannel_ : java.lang.Object, ScatteringByteChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ScatteringByteChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _read22550;
		long java.nio.channels.ScatteringByteChannel.read(java.nio.ByteBuffer[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.channels.ScatteringByteChannel_.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J", ref global::java.nio.channels.ScatteringByteChannel_._read22550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read22551;
		long java.nio.channels.ScatteringByteChannel.read(java.nio.ByteBuffer[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.channels.ScatteringByteChannel_.staticClass, "read", "([Ljava/nio/ByteBuffer;)J", ref global::java.nio.channels.ScatteringByteChannel_._read22551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read22552;
		int java.nio.channels.ReadableByteChannel.read(java.nio.ByteBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.ScatteringByteChannel_.staticClass, "read", "(Ljava/nio/ByteBuffer;)I", ref global::java.nio.channels.ScatteringByteChannel_._read22552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close22553;
		void java.nio.channels.Channel.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.ScatteringByteChannel_.staticClass, "close", "()V", ref global::java.nio.channels.ScatteringByteChannel_._close22553);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen22554;
		bool java.nio.channels.Channel.isOpen()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.ScatteringByteChannel_.staticClass, "isOpen", "()Z", ref global::java.nio.channels.ScatteringByteChannel_._isOpen22554);
		}
		internal static global::MonoJavaBridge.MethodId _close22555;
		void java.io.Closeable.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.ScatteringByteChannel_.staticClass, "close", "()V", ref global::java.nio.channels.ScatteringByteChannel_._close22555);
		}
		static ScatteringByteChannel_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.ScatteringByteChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/ScatteringByteChannel"));
		}
		internal static void InitJNI()
		{
		}
	}
}
