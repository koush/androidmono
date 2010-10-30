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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.ReadableByteChannel_._read22546.native == global::System.IntPtr.Zero)
				global::java.nio.channels.ReadableByteChannel_._read22546 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ReadableByteChannel_.staticClass, "read", "(Ljava/nio/ByteBuffer;)I");
			return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.ReadableByteChannel_._read22546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close22547;
		void java.nio.channels.Channel.close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.ReadableByteChannel_._close22547.native == global::System.IntPtr.Zero)
				global::java.nio.channels.ReadableByteChannel_._close22547 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ReadableByteChannel_.staticClass, "close", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.ReadableByteChannel_._close22547);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen22548;
		bool java.nio.channels.Channel.isOpen()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.ReadableByteChannel_._isOpen22548.native == global::System.IntPtr.Zero)
				global::java.nio.channels.ReadableByteChannel_._isOpen22548 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ReadableByteChannel_.staticClass, "isOpen", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.ReadableByteChannel_._isOpen22548);
		}
		internal static global::MonoJavaBridge.MethodId _close22549;
		void java.io.Closeable.close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.ReadableByteChannel_._close22549.native == global::System.IntPtr.Zero)
				global::java.nio.channels.ReadableByteChannel_._close22549 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ReadableByteChannel_.staticClass, "close", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.ReadableByteChannel_._close22549);
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
