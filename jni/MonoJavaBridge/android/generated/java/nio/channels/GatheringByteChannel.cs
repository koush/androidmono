namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.nio.channels.GatheringByteChannel_))]
	public interface GatheringByteChannel : WritableByteChannel
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
		internal static global::MonoJavaBridge.MethodId _write14467;
		 long java.nio.channels.GatheringByteChannel.write(java.nio.ByteBuffer[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.GatheringByteChannel_._write14467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.GatheringByteChannel_.staticClass, global::java.nio.channels.GatheringByteChannel_._write14467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write14468;
		 long java.nio.channels.GatheringByteChannel.write(java.nio.ByteBuffer[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.GatheringByteChannel_._write14468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.GatheringByteChannel_.staticClass, global::java.nio.channels.GatheringByteChannel_._write14468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write14469;
		 int java.nio.channels.WritableByteChannel.write(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.GatheringByteChannel_._write14469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.GatheringByteChannel_.staticClass, global::java.nio.channels.GatheringByteChannel_._write14469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close14470;
		 void java.nio.channels.Channel.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.GatheringByteChannel_._close14470);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.GatheringByteChannel_.staticClass, global::java.nio.channels.GatheringByteChannel_._close14470);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen14471;
		 bool java.nio.channels.Channel.isOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.GatheringByteChannel_._isOpen14471);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.GatheringByteChannel_.staticClass, global::java.nio.channels.GatheringByteChannel_._isOpen14471);
		}
		internal static global::MonoJavaBridge.MethodId _close14472;
		 void java.io.Closeable.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.GatheringByteChannel_._close14472);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.GatheringByteChannel_.staticClass, global::java.nio.channels.GatheringByteChannel_._close14472);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.GatheringByteChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/GatheringByteChannel"));
			global::java.nio.channels.GatheringByteChannel_._write14467 = @__env.GetMethodIDNoThrow(global::java.nio.channels.GatheringByteChannel_.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.GatheringByteChannel_._write14468 = @__env.GetMethodIDNoThrow(global::java.nio.channels.GatheringByteChannel_.staticClass, "write", "([Ljava/nio/ByteBuffer;)J");
			global::java.nio.channels.GatheringByteChannel_._write14469 = @__env.GetMethodIDNoThrow(global::java.nio.channels.GatheringByteChannel_.staticClass, "write", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.GatheringByteChannel_._close14470 = @__env.GetMethodIDNoThrow(global::java.nio.channels.GatheringByteChannel_.staticClass, "close", "()V");
			global::java.nio.channels.GatheringByteChannel_._isOpen14471 = @__env.GetMethodIDNoThrow(global::java.nio.channels.GatheringByteChannel_.staticClass, "isOpen", "()Z");
			global::java.nio.channels.GatheringByteChannel_._close14472 = @__env.GetMethodIDNoThrow(global::java.nio.channels.GatheringByteChannel_.staticClass, "close", "()V");
		}
	}
}
