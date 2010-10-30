namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.nio.channels.WritableByteChannel_))]
	public partial interface WritableByteChannel : Channel
	{
		int write(java.nio.ByteBuffer arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.WritableByteChannel))]
	internal sealed partial class WritableByteChannel_ : java.lang.Object, WritableByteChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal WritableByteChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		int java.nio.channels.WritableByteChannel.write(java.nio.ByteBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.WritableByteChannel_.staticClass, "write", "(Ljava/nio/ByteBuffer;)I", ref global::java.nio.channels.WritableByteChannel_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void java.nio.channels.Channel.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.WritableByteChannel_.staticClass, "close", "()V", ref global::java.nio.channels.WritableByteChannel_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		bool java.nio.channels.Channel.isOpen()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.WritableByteChannel_.staticClass, "isOpen", "()Z", ref global::java.nio.channels.WritableByteChannel_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void java.io.Closeable.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.WritableByteChannel_.staticClass, "close", "()V", ref global::java.nio.channels.WritableByteChannel_._m3);
		}
		static WritableByteChannel_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.WritableByteChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/WritableByteChannel"));
		}
		internal static void InitJNI()
		{
		}
	}
}
