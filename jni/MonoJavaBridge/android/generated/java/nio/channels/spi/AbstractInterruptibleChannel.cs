namespace java.nio.channels.spi
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.spi.AbstractInterruptibleChannel_))]
	public abstract partial class AbstractInterruptibleChannel : java.lang.Object, Channel, InterruptibleChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractInterruptibleChannel()
		{
			InitJNI();
		}
		protected AbstractInterruptibleChannel(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close22661;
		public virtual void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractInterruptibleChannel._close22661);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, global::java.nio.channels.spi.AbstractInterruptibleChannel._close22661);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen22662;
		public virtual bool isOpen()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractInterruptibleChannel._isOpen22662);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, global::java.nio.channels.spi.AbstractInterruptibleChannel._isOpen22662);
		}
		internal static global::MonoJavaBridge.MethodId _end22663;
		protected virtual void end(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractInterruptibleChannel._end22663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, global::java.nio.channels.spi.AbstractInterruptibleChannel._end22663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _implCloseChannel22664;
		protected abstract void implCloseChannel();
		internal static global::MonoJavaBridge.MethodId _begin22665;
		protected virtual void begin()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractInterruptibleChannel._begin22665);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, global::java.nio.channels.spi.AbstractInterruptibleChannel._begin22665);
		}
		internal static global::MonoJavaBridge.MethodId _AbstractInterruptibleChannel22666;
		protected AbstractInterruptibleChannel() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, global::java.nio.channels.spi.AbstractInterruptibleChannel._AbstractInterruptibleChannel22666);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/spi/AbstractInterruptibleChannel"));
			global::java.nio.channels.spi.AbstractInterruptibleChannel._close22661 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, "close", "()V");
			global::java.nio.channels.spi.AbstractInterruptibleChannel._isOpen22662 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, "isOpen", "()Z");
			global::java.nio.channels.spi.AbstractInterruptibleChannel._end22663 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, "end", "(Z)V");
			global::java.nio.channels.spi.AbstractInterruptibleChannel._implCloseChannel22664 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, "implCloseChannel", "()V");
			global::java.nio.channels.spi.AbstractInterruptibleChannel._begin22665 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, "begin", "()V");
			global::java.nio.channels.spi.AbstractInterruptibleChannel._AbstractInterruptibleChannel22666 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.spi.AbstractInterruptibleChannel))]
	internal sealed partial class AbstractInterruptibleChannel_ : java.nio.channels.spi.AbstractInterruptibleChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractInterruptibleChannel_()
		{
			InitJNI();
		}
		internal AbstractInterruptibleChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _implCloseChannel22667;
		protected override void implCloseChannel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractInterruptibleChannel_._implCloseChannel22667);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractInterruptibleChannel_.staticClass, global::java.nio.channels.spi.AbstractInterruptibleChannel_._implCloseChannel22667);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.spi.AbstractInterruptibleChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/spi/AbstractInterruptibleChannel"));
			global::java.nio.channels.spi.AbstractInterruptibleChannel_._implCloseChannel22667 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractInterruptibleChannel_.staticClass, "implCloseChannel", "()V");
		}
	}
}
