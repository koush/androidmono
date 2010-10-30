namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.nio.channels.ByteChannel_))]
	public partial interface ByteChannel : ReadableByteChannel, WritableByteChannel
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.ByteChannel))]
	internal sealed partial class ByteChannel_ : java.lang.Object, ByteChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ByteChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		int java.nio.channels.ReadableByteChannel.read(java.nio.ByteBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.ByteChannel_.staticClass, "read", "(Ljava/nio/ByteBuffer;)I", ref global::java.nio.channels.ByteChannel_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void java.nio.channels.Channel.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.ByteChannel_.staticClass, "close", "()V", ref global::java.nio.channels.ByteChannel_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		bool java.nio.channels.Channel.isOpen()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.ByteChannel_.staticClass, "isOpen", "()Z", ref global::java.nio.channels.ByteChannel_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void java.io.Closeable.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.ByteChannel_.staticClass, "close", "()V", ref global::java.nio.channels.ByteChannel_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		int java.nio.channels.WritableByteChannel.write(java.nio.ByteBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.ByteChannel_.staticClass, "write", "(Ljava/nio/ByteBuffer;)I", ref global::java.nio.channels.ByteChannel_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static ByteChannel_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.ByteChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/ByteChannel"));
		}
		internal static void InitJNI()
		{
		}
	}
}
