namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.nio.channels.GatheringByteChannel_))]
	public partial interface GatheringByteChannel : WritableByteChannel
	{
		long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		long write(java.nio.ByteBuffer[] arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.GatheringByteChannel))]
	public sealed partial class GatheringByteChannel_ : java.lang.Object, GatheringByteChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GatheringByteChannel_()
		{
			InitJNI();
		}
		internal GatheringByteChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write22383;
		 long java.nio.channels.GatheringByteChannel.write(java.nio.ByteBuffer[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.GatheringByteChannel_._write22383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.GatheringByteChannel_.staticClass, global::java.nio.channels.GatheringByteChannel_._write22383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write22384;
		 long java.nio.channels.GatheringByteChannel.write(java.nio.ByteBuffer[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.GatheringByteChannel_._write22384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.GatheringByteChannel_.staticClass, global::java.nio.channels.GatheringByteChannel_._write22384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write22385;
		 int java.nio.channels.WritableByteChannel.write(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.GatheringByteChannel_._write22385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.GatheringByteChannel_.staticClass, global::java.nio.channels.GatheringByteChannel_._write22385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close22386;
		 void java.nio.channels.Channel.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.GatheringByteChannel_._close22386);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.GatheringByteChannel_.staticClass, global::java.nio.channels.GatheringByteChannel_._close22386);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen22387;
		 bool java.nio.channels.Channel.isOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.GatheringByteChannel_._isOpen22387);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.GatheringByteChannel_.staticClass, global::java.nio.channels.GatheringByteChannel_._isOpen22387);
		}
		internal static global::MonoJavaBridge.MethodId _close22388;
		 void java.io.Closeable.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.GatheringByteChannel_._close22388);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.GatheringByteChannel_.staticClass, global::java.nio.channels.GatheringByteChannel_._close22388);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.GatheringByteChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/GatheringByteChannel"));
			global::java.nio.channels.GatheringByteChannel_._write22383 = @__env.GetMethodIDNoThrow(global::java.nio.channels.GatheringByteChannel_.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.GatheringByteChannel_._write22384 = @__env.GetMethodIDNoThrow(global::java.nio.channels.GatheringByteChannel_.staticClass, "write", "([Ljava/nio/ByteBuffer;)J");
			global::java.nio.channels.GatheringByteChannel_._write22385 = @__env.GetMethodIDNoThrow(global::java.nio.channels.GatheringByteChannel_.staticClass, "write", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.GatheringByteChannel_._close22386 = @__env.GetMethodIDNoThrow(global::java.nio.channels.GatheringByteChannel_.staticClass, "close", "()V");
			global::java.nio.channels.GatheringByteChannel_._isOpen22387 = @__env.GetMethodIDNoThrow(global::java.nio.channels.GatheringByteChannel_.staticClass, "isOpen", "()Z");
			global::java.nio.channels.GatheringByteChannel_._close22388 = @__env.GetMethodIDNoThrow(global::java.nio.channels.GatheringByteChannel_.staticClass, "close", "()V");
		}
	}
}
