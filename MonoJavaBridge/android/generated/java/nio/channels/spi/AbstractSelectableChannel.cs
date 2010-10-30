namespace java.nio.channels.spi
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.spi.AbstractSelectableChannel_))]
	public abstract partial class AbstractSelectableChannel : java.nio.channels.SelectableChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractSelectableChannel(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _register22668;
		public sealed override global::java.nio.channels.SelectionKey register(java.nio.channels.Selector arg0, int arg1, java.lang.Object arg2)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, global::java.nio.channels.spi.AbstractSelectableChannel._register22668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.channels.SelectionKey;
		}
		internal static global::MonoJavaBridge.MethodId _provider22669;
		public sealed override global::java.nio.channels.spi.SelectorProvider provider()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, global::java.nio.channels.spi.AbstractSelectableChannel._provider22669)) as java.nio.channels.spi.SelectorProvider;
		}
		internal static global::MonoJavaBridge.MethodId _isRegistered22670;
		public sealed override bool isRegistered()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, global::java.nio.channels.spi.AbstractSelectableChannel._isRegistered22670);
		}
		internal static global::MonoJavaBridge.MethodId _isBlocking22671;
		public sealed override bool isBlocking()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, global::java.nio.channels.spi.AbstractSelectableChannel._isBlocking22671);
		}
		internal static global::MonoJavaBridge.MethodId _implCloseChannel22672;
		protected sealed override void implCloseChannel()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, global::java.nio.channels.spi.AbstractSelectableChannel._implCloseChannel22672);
		}
		internal static global::MonoJavaBridge.MethodId _keyFor22673;
		public sealed override global::java.nio.channels.SelectionKey keyFor(java.nio.channels.Selector arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, global::java.nio.channels.spi.AbstractSelectableChannel._keyFor22673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.SelectionKey;
		}
		internal static global::MonoJavaBridge.MethodId _implCloseSelectableChannel22674;
		protected abstract void implCloseSelectableChannel();
		internal static global::MonoJavaBridge.MethodId _blockingLock22675;
		public sealed override global::java.lang.Object blockingLock()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, global::java.nio.channels.spi.AbstractSelectableChannel._blockingLock22675)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _configureBlocking22676;
		public sealed override global::java.nio.channels.SelectableChannel configureBlocking(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, global::java.nio.channels.spi.AbstractSelectableChannel._configureBlocking22676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.SelectableChannel;
		}
		internal static global::MonoJavaBridge.MethodId _implConfigureBlocking22677;
		protected abstract void implConfigureBlocking(bool arg0);
		internal static global::MonoJavaBridge.MethodId _AbstractSelectableChannel22678;
		protected AbstractSelectableChannel(java.nio.channels.spi.SelectorProvider arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.spi.AbstractSelectableChannel.staticClass, global::java.nio.channels.spi.AbstractSelectableChannel._AbstractSelectableChannel22678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static AbstractSelectableChannel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.spi.AbstractSelectableChannel.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/spi/AbstractSelectableChannel"));
			global::java.nio.channels.spi.AbstractSelectableChannel._register22668 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "register", "(Ljava/nio/channels/Selector;ILjava/lang/Object;)Ljava/nio/channels/SelectionKey;");
			global::java.nio.channels.spi.AbstractSelectableChannel._provider22669 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "provider", "()Ljava/nio/channels/spi/SelectorProvider;");
			global::java.nio.channels.spi.AbstractSelectableChannel._isRegistered22670 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "isRegistered", "()Z");
			global::java.nio.channels.spi.AbstractSelectableChannel._isBlocking22671 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "isBlocking", "()Z");
			global::java.nio.channels.spi.AbstractSelectableChannel._implCloseChannel22672 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "implCloseChannel", "()V");
			global::java.nio.channels.spi.AbstractSelectableChannel._keyFor22673 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "keyFor", "(Ljava/nio/channels/Selector;)Ljava/nio/channels/SelectionKey;");
			global::java.nio.channels.spi.AbstractSelectableChannel._implCloseSelectableChannel22674 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "implCloseSelectableChannel", "()V");
			global::java.nio.channels.spi.AbstractSelectableChannel._blockingLock22675 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "blockingLock", "()Ljava/lang/Object;");
			global::java.nio.channels.spi.AbstractSelectableChannel._configureBlocking22676 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "configureBlocking", "(Z)Ljava/nio/channels/SelectableChannel;");
			global::java.nio.channels.spi.AbstractSelectableChannel._implConfigureBlocking22677 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "implConfigureBlocking", "(Z)V");
			global::java.nio.channels.spi.AbstractSelectableChannel._AbstractSelectableChannel22678 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.spi.AbstractSelectableChannel))]
	internal sealed partial class AbstractSelectableChannel_ : java.nio.channels.spi.AbstractSelectableChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractSelectableChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _implCloseSelectableChannel22679;
		protected override void implCloseSelectableChannel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelectableChannel_._implCloseSelectableChannel22679);
		}
		internal static global::MonoJavaBridge.MethodId _implConfigureBlocking22680;
		protected override void implConfigureBlocking(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelectableChannel_._implConfigureBlocking22680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _validOps22681;
		public override int validOps()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelectableChannel_._validOps22681);
		}
		static AbstractSelectableChannel_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.spi.AbstractSelectableChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/spi/AbstractSelectableChannel"));
			global::java.nio.channels.spi.AbstractSelectableChannel_._implCloseSelectableChannel22679 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelectableChannel_.staticClass, "implCloseSelectableChannel", "()V");
			global::java.nio.channels.spi.AbstractSelectableChannel_._implConfigureBlocking22680 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelectableChannel_.staticClass, "implConfigureBlocking", "(Z)V");
			global::java.nio.channels.spi.AbstractSelectableChannel_._validOps22681 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelectableChannel_.staticClass, "validOps", "()I");
		}
		internal static void InitJNI()
		{
		}
	}
}
