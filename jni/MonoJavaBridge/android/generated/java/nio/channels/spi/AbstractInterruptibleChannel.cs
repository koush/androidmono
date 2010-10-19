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
		internal static global::MonoJavaBridge.MethodId _close16944;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractInterruptibleChannel._close16944);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, global::java.nio.channels.spi.AbstractInterruptibleChannel._close16944);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen16945;
		public virtual bool isOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractInterruptibleChannel._isOpen16945);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, global::java.nio.channels.spi.AbstractInterruptibleChannel._isOpen16945);
		}
		internal static global::MonoJavaBridge.MethodId _end16946;
		protected virtual void end(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractInterruptibleChannel._end16946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, global::java.nio.channels.spi.AbstractInterruptibleChannel._end16946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _implCloseChannel16947;
		protected abstract void implCloseChannel();
		internal static global::MonoJavaBridge.MethodId _begin16948;
		protected virtual void begin() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractInterruptibleChannel._begin16948);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, global::java.nio.channels.spi.AbstractInterruptibleChannel._begin16948);
		}
		internal static global::MonoJavaBridge.MethodId _AbstractInterruptibleChannel16949;
		protected AbstractInterruptibleChannel()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, global::java.nio.channels.spi.AbstractInterruptibleChannel._AbstractInterruptibleChannel16949);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/spi/AbstractInterruptibleChannel"));
			global::java.nio.channels.spi.AbstractInterruptibleChannel._close16944 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, "close", "()V");
			global::java.nio.channels.spi.AbstractInterruptibleChannel._isOpen16945 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, "isOpen", "()Z");
			global::java.nio.channels.spi.AbstractInterruptibleChannel._end16946 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, "end", "(Z)V");
			global::java.nio.channels.spi.AbstractInterruptibleChannel._implCloseChannel16947 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, "implCloseChannel", "()V");
			global::java.nio.channels.spi.AbstractInterruptibleChannel._begin16948 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, "begin", "()V");
			global::java.nio.channels.spi.AbstractInterruptibleChannel._AbstractInterruptibleChannel16949 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.spi.AbstractInterruptibleChannel))]
	public sealed partial class AbstractInterruptibleChannel_ : java.nio.channels.spi.AbstractInterruptibleChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractInterruptibleChannel_()
		{
			InitJNI();
		}
		internal AbstractInterruptibleChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _implCloseChannel16950;
		protected override void implCloseChannel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractInterruptibleChannel_._implCloseChannel16950);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractInterruptibleChannel_.staticClass, global::java.nio.channels.spi.AbstractInterruptibleChannel_._implCloseChannel16950);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.spi.AbstractInterruptibleChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/spi/AbstractInterruptibleChannel"));
			global::java.nio.channels.spi.AbstractInterruptibleChannel_._implCloseChannel16950 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractInterruptibleChannel_.staticClass, "implCloseChannel", "()V");
		}
	}
}
