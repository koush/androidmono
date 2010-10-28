namespace java.nio.channels.spi
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.spi.AbstractSelectionKey_))]
	public abstract partial class AbstractSelectionKey : java.nio.channels.SelectionKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractSelectionKey(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isValid22682;
		public sealed override bool isValid()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelectionKey._isValid22682);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelectionKey.staticClass, global::java.nio.channels.spi.AbstractSelectionKey._isValid22682);
		}
		internal static global::MonoJavaBridge.MethodId _cancel22683;
		public sealed override void cancel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelectionKey._cancel22683);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelectionKey.staticClass, global::java.nio.channels.spi.AbstractSelectionKey._cancel22683);
		}
		internal static global::MonoJavaBridge.MethodId _AbstractSelectionKey22684;
		protected AbstractSelectionKey() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.spi.AbstractSelectionKey.staticClass, global::java.nio.channels.spi.AbstractSelectionKey._AbstractSelectionKey22684);
			Init(@__env, handle);
		}
		static AbstractSelectionKey()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.spi.AbstractSelectionKey.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/spi/AbstractSelectionKey"));
			global::java.nio.channels.spi.AbstractSelectionKey._isValid22682 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelectionKey.staticClass, "isValid", "()Z");
			global::java.nio.channels.spi.AbstractSelectionKey._cancel22683 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelectionKey.staticClass, "cancel", "()V");
			global::java.nio.channels.spi.AbstractSelectionKey._AbstractSelectionKey22684 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelectionKey.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.spi.AbstractSelectionKey))]
	internal sealed partial class AbstractSelectionKey_ : java.nio.channels.spi.AbstractSelectionKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractSelectionKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _channel22685;
		public override global::java.nio.channels.SelectableChannel channel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelectionKey_._channel22685)) as java.nio.channels.SelectableChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelectionKey_.staticClass, global::java.nio.channels.spi.AbstractSelectionKey_._channel22685)) as java.nio.channels.SelectableChannel;
		}
		internal static global::MonoJavaBridge.MethodId _selector22686;
		public override global::java.nio.channels.Selector selector()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelectionKey_._selector22686)) as java.nio.channels.Selector;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelectionKey_.staticClass, global::java.nio.channels.spi.AbstractSelectionKey_._selector22686)) as java.nio.channels.Selector;
		}
		internal static global::MonoJavaBridge.MethodId _interestOps22687;
		public override int interestOps()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelectionKey_._interestOps22687);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelectionKey_.staticClass, global::java.nio.channels.spi.AbstractSelectionKey_._interestOps22687);
		}
		internal static global::MonoJavaBridge.MethodId _interestOps22688;
		public override global::java.nio.channels.SelectionKey interestOps(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelectionKey_._interestOps22688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.SelectionKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelectionKey_.staticClass, global::java.nio.channels.spi.AbstractSelectionKey_._interestOps22688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.SelectionKey;
		}
		internal static global::MonoJavaBridge.MethodId _readyOps22689;
		public override int readyOps()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelectionKey_._readyOps22689);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelectionKey_.staticClass, global::java.nio.channels.spi.AbstractSelectionKey_._readyOps22689);
		}
		static AbstractSelectionKey_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.spi.AbstractSelectionKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/spi/AbstractSelectionKey"));
			global::java.nio.channels.spi.AbstractSelectionKey_._channel22685 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelectionKey_.staticClass, "channel", "()Ljava/nio/channels/SelectableChannel;");
			global::java.nio.channels.spi.AbstractSelectionKey_._selector22686 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelectionKey_.staticClass, "selector", "()Ljava/nio/channels/Selector;");
			global::java.nio.channels.spi.AbstractSelectionKey_._interestOps22687 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelectionKey_.staticClass, "interestOps", "()I");
			global::java.nio.channels.spi.AbstractSelectionKey_._interestOps22688 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelectionKey_.staticClass, "interestOps", "(I)Ljava/nio/channels/SelectionKey;");
			global::java.nio.channels.spi.AbstractSelectionKey_._readyOps22689 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelectionKey_.staticClass, "readyOps", "()I");
		}
		internal static void InitJNI()
		{
		}
	}
}