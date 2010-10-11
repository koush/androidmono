namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.nio.channels.InterruptibleChannel_))]
	public interface InterruptibleChannel : Channel
	{
		new void close();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.InterruptibleChannel))]
	public sealed partial class InterruptibleChannel_ : java.lang.Object, InterruptibleChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InterruptibleChannel_()
		{
			InitJNI();
		}
		internal InterruptibleChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close14473;
		 void java.nio.channels.InterruptibleChannel.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.InterruptibleChannel_._close14473);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.InterruptibleChannel_.staticClass, global::java.nio.channels.InterruptibleChannel_._close14473);
		}
		internal static global::MonoJavaBridge.MethodId _close14474;
		 void java.nio.channels.Channel.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.InterruptibleChannel_._close14474);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.InterruptibleChannel_.staticClass, global::java.nio.channels.InterruptibleChannel_._close14474);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen14475;
		 bool java.nio.channels.Channel.isOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.InterruptibleChannel_._isOpen14475);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.InterruptibleChannel_.staticClass, global::java.nio.channels.InterruptibleChannel_._isOpen14475);
		}
		internal static global::MonoJavaBridge.MethodId _close14476;
		 void java.io.Closeable.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.InterruptibleChannel_._close14476);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.InterruptibleChannel_.staticClass, global::java.nio.channels.InterruptibleChannel_._close14476);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.InterruptibleChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/InterruptibleChannel"));
			global::java.nio.channels.InterruptibleChannel_._close14473 = @__env.GetMethodIDNoThrow(global::java.nio.channels.InterruptibleChannel_.staticClass, "close", "()V");
			global::java.nio.channels.InterruptibleChannel_._close14474 = @__env.GetMethodIDNoThrow(global::java.nio.channels.InterruptibleChannel_.staticClass, "close", "()V");
			global::java.nio.channels.InterruptibleChannel_._isOpen14475 = @__env.GetMethodIDNoThrow(global::java.nio.channels.InterruptibleChannel_.staticClass, "isOpen", "()Z");
			global::java.nio.channels.InterruptibleChannel_._close14476 = @__env.GetMethodIDNoThrow(global::java.nio.channels.InterruptibleChannel_.staticClass, "close", "()V");
		}
	}
}
