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
		private static global::MonoJavaBridge.MethodId _m0;
		int java.nio.channels.ReadableByteChannel.read(java.nio.ByteBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.ReadableByteChannel_.staticClass, "read", "(Ljava/nio/ByteBuffer;)I", ref global::java.nio.channels.ReadableByteChannel_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void java.nio.channels.Channel.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.ReadableByteChannel_.staticClass, "close", "()V", ref global::java.nio.channels.ReadableByteChannel_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		bool java.nio.channels.Channel.isOpen()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.ReadableByteChannel_.staticClass, "isOpen", "()Z", ref global::java.nio.channels.ReadableByteChannel_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void java.io.Closeable.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.ReadableByteChannel_.staticClass, "close", "()V", ref global::java.nio.channels.ReadableByteChannel_._m3);
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
