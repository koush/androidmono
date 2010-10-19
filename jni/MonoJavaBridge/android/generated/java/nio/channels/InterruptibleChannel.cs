namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.nio.channels.InterruptibleChannel_))]
	public interface InterruptibleChannel : Channel
	{
		void close();
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
		internal static global::MonoJavaBridge.MethodId _close16797;
		 void java.nio.channels.InterruptibleChannel.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.InterruptibleChannel_._close16797);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.InterruptibleChannel_.staticClass, global::java.nio.channels.InterruptibleChannel_._close16797);
		}
		internal static global::MonoJavaBridge.MethodId _close16798;
		 void java.nio.channels.Channel.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.InterruptibleChannel_._close16798);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.InterruptibleChannel_.staticClass, global::java.nio.channels.InterruptibleChannel_._close16798);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen16799;
		 bool java.nio.channels.Channel.isOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.InterruptibleChannel_._isOpen16799);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.InterruptibleChannel_.staticClass, global::java.nio.channels.InterruptibleChannel_._isOpen16799);
		}
		internal static global::MonoJavaBridge.MethodId _close16800;
		 void java.io.Closeable.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.InterruptibleChannel_._close16800);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.InterruptibleChannel_.staticClass, global::java.nio.channels.InterruptibleChannel_._close16800);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.InterruptibleChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/InterruptibleChannel"));
			global::java.nio.channels.InterruptibleChannel_._close16797 = @__env.GetMethodIDNoThrow(global::java.nio.channels.InterruptibleChannel_.staticClass, "close", "()V");
			global::java.nio.channels.InterruptibleChannel_._close16798 = @__env.GetMethodIDNoThrow(global::java.nio.channels.InterruptibleChannel_.staticClass, "close", "()V");
			global::java.nio.channels.InterruptibleChannel_._isOpen16799 = @__env.GetMethodIDNoThrow(global::java.nio.channels.InterruptibleChannel_.staticClass, "isOpen", "()Z");
			global::java.nio.channels.InterruptibleChannel_._close16800 = @__env.GetMethodIDNoThrow(global::java.nio.channels.InterruptibleChannel_.staticClass, "close", "()V");
		}
	}
}
