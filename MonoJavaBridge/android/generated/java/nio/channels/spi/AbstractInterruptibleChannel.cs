namespace java.nio.channels.spi
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.spi.AbstractInterruptibleChannel_))]
	public abstract partial class AbstractInterruptibleChannel : java.lang.Object, Channel, InterruptibleChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractInterruptibleChannel(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close22661;
		public virtual void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, "close", "()V", ref global::java.nio.channels.spi.AbstractInterruptibleChannel._close22661);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen22662;
		public virtual bool isOpen()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, "isOpen", "()Z", ref global::java.nio.channels.spi.AbstractInterruptibleChannel._isOpen22662);
		}
		internal static global::MonoJavaBridge.MethodId _end22663;
		protected virtual void end(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, "end", "(Z)V", ref global::java.nio.channels.spi.AbstractInterruptibleChannel._end22663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _implCloseChannel22664;
		protected abstract void implCloseChannel();
		internal static global::MonoJavaBridge.MethodId _begin22665;
		protected virtual void begin()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, "begin", "()V", ref global::java.nio.channels.spi.AbstractInterruptibleChannel._begin22665);
		}
		internal static global::MonoJavaBridge.MethodId _AbstractInterruptibleChannel22666;
		protected AbstractInterruptibleChannel() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.spi.AbstractInterruptibleChannel._AbstractInterruptibleChannel22666.native == global::System.IntPtr.Zero)
				global::java.nio.channels.spi.AbstractInterruptibleChannel._AbstractInterruptibleChannel22666 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, global::java.nio.channels.spi.AbstractInterruptibleChannel._AbstractInterruptibleChannel22666);
			Init(@__env, handle);
		}
		static AbstractInterruptibleChannel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/spi/AbstractInterruptibleChannel"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.spi.AbstractInterruptibleChannel))]
	internal sealed partial class AbstractInterruptibleChannel_ : java.nio.channels.spi.AbstractInterruptibleChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractInterruptibleChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _implCloseChannel22667;
		protected override void implCloseChannel()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.spi.AbstractInterruptibleChannel_.staticClass, "implCloseChannel", "()V", ref global::java.nio.channels.spi.AbstractInterruptibleChannel_._implCloseChannel22667);
		}
		static AbstractInterruptibleChannel_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.spi.AbstractInterruptibleChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/spi/AbstractInterruptibleChannel"));
		}
		internal static void InitJNI()
		{
		}
	}
}
