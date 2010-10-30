namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.nio.channels.ReadableByteChannel_))]
	public partial interface ReadableByteChannel : Channel
	{
		int read(java.nio.ByteBuffer arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.ReadableByteChannel))]
	internal sealed partial class ReadableByteChannel_ : java.lang.Object, ReadableByteChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ReadableByteChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _read22546;
		int java.nio.channels.ReadableByteChannel.read(java.nio.ByteBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.ReadableByteChannel_.staticClass, "read", "(Ljava/nio/ByteBuffer;)I", ref global::java.nio.channels.ReadableByteChannel_._read22546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close22547;
		void java.nio.channels.Channel.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.ReadableByteChannel_.staticClass, "close", "()V", ref global::java.nio.channels.ReadableByteChannel_._close22547);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen22548;
		bool java.nio.channels.Channel.isOpen()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.ReadableByteChannel_.staticClass, "isOpen", "()Z", ref global::java.nio.channels.ReadableByteChannel_._isOpen22548);
		}
		internal static global::MonoJavaBridge.MethodId _close22549;
		void java.io.Closeable.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.ReadableByteChannel_.staticClass, "close", "()V", ref global::java.nio.channels.ReadableByteChannel_._close22549);
		}
		static ReadableByteChannel_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.ReadableByteChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/ReadableByteChannel"));
		}
		internal static void InitJNI()
		{
		}
	}
}
