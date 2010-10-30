namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.nio.channels.InterruptibleChannel_))]
	public partial interface InterruptibleChannel : Channel
	{
		void close();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.InterruptibleChannel))]
	internal sealed partial class InterruptibleChannel_ : java.lang.Object, InterruptibleChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal InterruptibleChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close22510;
		void java.nio.channels.InterruptibleChannel.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.InterruptibleChannel_.staticClass, "close", "()V", ref global::java.nio.channels.InterruptibleChannel_._close22510);
		}
		internal static global::MonoJavaBridge.MethodId _close22511;
		void java.nio.channels.Channel.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.InterruptibleChannel_.staticClass, "close", "()V", ref global::java.nio.channels.InterruptibleChannel_._close22511);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen22512;
		bool java.nio.channels.Channel.isOpen()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.InterruptibleChannel_.staticClass, "isOpen", "()Z", ref global::java.nio.channels.InterruptibleChannel_._isOpen22512);
		}
		internal static global::MonoJavaBridge.MethodId _close22513;
		void java.io.Closeable.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.InterruptibleChannel_.staticClass, "close", "()V", ref global::java.nio.channels.InterruptibleChannel_._close22513);
		}
		static InterruptibleChannel_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.InterruptibleChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/InterruptibleChannel"));
		}
		internal static void InitJNI()
		{
		}
	}
}
