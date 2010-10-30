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
		private static global::MonoJavaBridge.MethodId _m0;
		void java.nio.channels.InterruptibleChannel.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.InterruptibleChannel_.staticClass, "close", "()V", ref global::java.nio.channels.InterruptibleChannel_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void java.nio.channels.Channel.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.InterruptibleChannel_.staticClass, "close", "()V", ref global::java.nio.channels.InterruptibleChannel_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		bool java.nio.channels.Channel.isOpen()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.InterruptibleChannel_.staticClass, "isOpen", "()Z", ref global::java.nio.channels.InterruptibleChannel_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void java.io.Closeable.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.InterruptibleChannel_.staticClass, "close", "()V", ref global::java.nio.channels.InterruptibleChannel_._m3);
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
