namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.nio.channels.Channel_))]
	public interface Channel : java.io.Closeable
	{
		new void close();
		bool isOpen();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.Channel))]
	public sealed partial class Channel_ : java.lang.Object, Channel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Channel_()
		{
			InitJNI();
		}
		internal Channel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close14384;
		 void java.nio.channels.Channel.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.Channel_._close14384);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.Channel_.staticClass, global::java.nio.channels.Channel_._close14384);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen14385;
		 bool java.nio.channels.Channel.isOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.Channel_._isOpen14385);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.Channel_.staticClass, global::java.nio.channels.Channel_._isOpen14385);
		}
		internal static global::MonoJavaBridge.MethodId _close14386;
		 void java.io.Closeable.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.Channel_._close14386);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.Channel_.staticClass, global::java.nio.channels.Channel_._close14386);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.Channel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Channel"));
			global::java.nio.channels.Channel_._close14384 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Channel_.staticClass, "close", "()V");
			global::java.nio.channels.Channel_._isOpen14385 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Channel_.staticClass, "isOpen", "()Z");
			global::java.nio.channels.Channel_._close14386 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Channel_.staticClass, "close", "()V");
		}
	}
}
