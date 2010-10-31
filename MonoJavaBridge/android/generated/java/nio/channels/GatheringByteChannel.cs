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
		private static global::MonoJavaBridge.MethodId _m0;
		long java.nio.channels.GatheringByteChannel.write(java.nio.ByteBuffer[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.channels.GatheringByteChannel_.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J", ref global::java.nio.channels.GatheringByteChannel_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		long java.nio.channels.GatheringByteChannel.write(java.nio.ByteBuffer[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.channels.GatheringByteChannel_.staticClass, "write", "([Ljava/nio/ByteBuffer;)J", ref global::java.nio.channels.GatheringByteChannel_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		int java.nio.channels.WritableByteChannel.write(java.nio.ByteBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.GatheringByteChannel_.staticClass, "write", "(Ljava/nio/ByteBuffer;)I", ref global::java.nio.channels.GatheringByteChannel_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void java.nio.channels.Channel.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.GatheringByteChannel_.staticClass, "close", "()V", ref global::java.nio.channels.GatheringByteChannel_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		bool java.nio.channels.Channel.isOpen()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.GatheringByteChannel_.staticClass, "isOpen", "()Z", ref global::java.nio.channels.GatheringByteChannel_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		void java.io.Closeable.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.GatheringByteChannel_.staticClass, "close", "()V", ref global::java.nio.channels.GatheringByteChannel_._m5);
		}
		static GatheringByteChannel_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.GatheringByteChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/GatheringByteChannel"));
		}
	}
}
