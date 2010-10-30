namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.nio.channels.Channel_))]
	public partial interface Channel : java.io.Closeable
	{
		void close();
		bool isOpen();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.Channel))]
	internal sealed partial class Channel_ : java.lang.Object, Channel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Channel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close22406;
		void java.nio.channels.Channel.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.Channel_.staticClass, "close", "()V", ref global::java.nio.channels.Channel_._close22406);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen22407;
		bool java.nio.channels.Channel.isOpen()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.Channel_.staticClass, "isOpen", "()Z", ref global::java.nio.channels.Channel_._isOpen22407);
		}
		internal static global::MonoJavaBridge.MethodId _close22408;
		void java.io.Closeable.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.Channel_.staticClass, "close", "()V", ref global::java.nio.channels.Channel_._close22408);
		}
		static Channel_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.Channel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Channel"));
		}
		internal static void InitJNI()
		{
		}
	}
}
