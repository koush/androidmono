namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.nio.channels.ScatteringByteChannel_))]
	public partial interface ScatteringByteChannel : ReadableByteChannel
	{
		long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		long read(java.nio.ByteBuffer[] arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.ScatteringByteChannel))]
	internal sealed partial class ScatteringByteChannel_ : java.lang.Object, ScatteringByteChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ScatteringByteChannel_()
		{
			InitJNI();
		}
		internal ScatteringByteChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _read22549;
		long java.nio.channels.ScatteringByteChannel.read(java.nio.ByteBuffer[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.ScatteringByteChannel_._read22549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.ScatteringByteChannel_.staticClass, global::java.nio.channels.ScatteringByteChannel_._read22549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read22550;
		long java.nio.channels.ScatteringByteChannel.read(java.nio.ByteBuffer[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.ScatteringByteChannel_._read22550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.ScatteringByteChannel_.staticClass, global::java.nio.channels.ScatteringByteChannel_._read22550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read22551;
		int java.nio.channels.ReadableByteChannel.read(java.nio.ByteBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.ScatteringByteChannel_._read22551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.ScatteringByteChannel_.staticClass, global::java.nio.channels.ScatteringByteChannel_._read22551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close22552;
		void java.nio.channels.Channel.close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.ScatteringByteChannel_._close22552);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.ScatteringByteChannel_.staticClass, global::java.nio.channels.ScatteringByteChannel_._close22552);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen22553;
		bool java.nio.channels.Channel.isOpen()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.ScatteringByteChannel_._isOpen22553);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.ScatteringByteChannel_.staticClass, global::java.nio.channels.ScatteringByteChannel_._isOpen22553);
		}
		internal static global::MonoJavaBridge.MethodId _close22554;
		void java.io.Closeable.close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.ScatteringByteChannel_._close22554);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.ScatteringByteChannel_.staticClass, global::java.nio.channels.ScatteringByteChannel_._close22554);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.ScatteringByteChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/ScatteringByteChannel"));
			global::java.nio.channels.ScatteringByteChannel_._read22549 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ScatteringByteChannel_.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.ScatteringByteChannel_._read22550 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ScatteringByteChannel_.staticClass, "read", "([Ljava/nio/ByteBuffer;)J");
			global::java.nio.channels.ScatteringByteChannel_._read22551 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ScatteringByteChannel_.staticClass, "read", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.ScatteringByteChannel_._close22552 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ScatteringByteChannel_.staticClass, "close", "()V");
			global::java.nio.channels.ScatteringByteChannel_._isOpen22553 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ScatteringByteChannel_.staticClass, "isOpen", "()Z");
			global::java.nio.channels.ScatteringByteChannel_._close22554 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ScatteringByteChannel_.staticClass, "close", "()V");
		}
	}
}
