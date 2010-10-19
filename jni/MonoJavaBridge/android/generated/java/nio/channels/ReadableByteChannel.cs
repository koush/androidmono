namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.nio.channels.ReadableByteChannel_))]
	public interface ReadableByteChannel : Channel
	{
		int read(java.nio.ByteBuffer arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.ReadableByteChannel))]
	public sealed partial class ReadableByteChannel_ : java.lang.Object, ReadableByteChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ReadableByteChannel_()
		{
			InitJNI();
		}
		internal ReadableByteChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _read16833;
		 int java.nio.channels.ReadableByteChannel.read(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.ReadableByteChannel_._read16833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.ReadableByteChannel_.staticClass, global::java.nio.channels.ReadableByteChannel_._read16833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close16834;
		 void java.nio.channels.Channel.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.ReadableByteChannel_._close16834);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.ReadableByteChannel_.staticClass, global::java.nio.channels.ReadableByteChannel_._close16834);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen16835;
		 bool java.nio.channels.Channel.isOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.ReadableByteChannel_._isOpen16835);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.ReadableByteChannel_.staticClass, global::java.nio.channels.ReadableByteChannel_._isOpen16835);
		}
		internal static global::MonoJavaBridge.MethodId _close16836;
		 void java.io.Closeable.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.ReadableByteChannel_._close16836);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.ReadableByteChannel_.staticClass, global::java.nio.channels.ReadableByteChannel_._close16836);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.ReadableByteChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/ReadableByteChannel"));
			global::java.nio.channels.ReadableByteChannel_._read16833 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ReadableByteChannel_.staticClass, "read", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.ReadableByteChannel_._close16834 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ReadableByteChannel_.staticClass, "close", "()V");
			global::java.nio.channels.ReadableByteChannel_._isOpen16835 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ReadableByteChannel_.staticClass, "isOpen", "()Z");
			global::java.nio.channels.ReadableByteChannel_._close16836 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ReadableByteChannel_.staticClass, "close", "()V");
		}
	}
}
