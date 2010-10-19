namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.nio.channels.ByteChannel_))]
	public interface ByteChannel : ReadableByteChannel, WritableByteChannel
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.ByteChannel))]
	public sealed partial class ByteChannel_ : java.lang.Object, ByteChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ByteChannel_()
		{
			InitJNI();
		}
		internal ByteChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _read16687;
		 int java.nio.channels.ReadableByteChannel.read(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.ByteChannel_._read16687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.ByteChannel_.staticClass, global::java.nio.channels.ByteChannel_._read16687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close16688;
		 void java.nio.channels.Channel.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.ByteChannel_._close16688);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.ByteChannel_.staticClass, global::java.nio.channels.ByteChannel_._close16688);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen16689;
		 bool java.nio.channels.Channel.isOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.ByteChannel_._isOpen16689);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.ByteChannel_.staticClass, global::java.nio.channels.ByteChannel_._isOpen16689);
		}
		internal static global::MonoJavaBridge.MethodId _close16690;
		 void java.io.Closeable.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.ByteChannel_._close16690);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.ByteChannel_.staticClass, global::java.nio.channels.ByteChannel_._close16690);
		}
		internal static global::MonoJavaBridge.MethodId _write16691;
		 int java.nio.channels.WritableByteChannel.write(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.ByteChannel_._write16691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.ByteChannel_.staticClass, global::java.nio.channels.ByteChannel_._write16691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.ByteChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/ByteChannel"));
			global::java.nio.channels.ByteChannel_._read16687 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ByteChannel_.staticClass, "read", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.ByteChannel_._close16688 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ByteChannel_.staticClass, "close", "()V");
			global::java.nio.channels.ByteChannel_._isOpen16689 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ByteChannel_.staticClass, "isOpen", "()Z");
			global::java.nio.channels.ByteChannel_._close16690 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ByteChannel_.staticClass, "close", "()V");
			global::java.nio.channels.ByteChannel_._write16691 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ByteChannel_.staticClass, "write", "(Ljava/nio/ByteBuffer;)I");
		}
	}
}
