namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.SelectableChannel_))]
	public abstract partial class SelectableChannel : java.nio.channels.spi.AbstractInterruptibleChannel, Channel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SelectableChannel(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _register22556;
		public abstract global::java.nio.channels.SelectionKey register(java.nio.channels.Selector arg0, int arg1, java.lang.Object arg2);
		internal static global::MonoJavaBridge.MethodId _register22557;
		public virtual global::java.nio.channels.SelectionKey register(java.nio.channels.Selector arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.SelectableChannel.staticClass, global::java.nio.channels.SelectableChannel._register22557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.channels.SelectionKey;
		}
		internal static global::MonoJavaBridge.MethodId _provider22558;
		public abstract global::java.nio.channels.spi.SelectorProvider provider();
		internal static global::MonoJavaBridge.MethodId _isRegistered22559;
		public abstract bool isRegistered();
		internal static global::MonoJavaBridge.MethodId _isBlocking22560;
		public abstract bool isBlocking();
		internal static global::MonoJavaBridge.MethodId _keyFor22561;
		public abstract global::java.nio.channels.SelectionKey keyFor(java.nio.channels.Selector arg0);
		internal static global::MonoJavaBridge.MethodId _validOps22562;
		public abstract int validOps();
		internal static global::MonoJavaBridge.MethodId _blockingLock22563;
		public abstract global::java.lang.Object blockingLock();
		internal static global::MonoJavaBridge.MethodId _configureBlocking22564;
		public abstract global::java.nio.channels.SelectableChannel configureBlocking(bool arg0);
		internal static global::MonoJavaBridge.MethodId _SelectableChannel22565;
		protected SelectableChannel() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.SelectableChannel.staticClass, global::java.nio.channels.SelectableChannel._SelectableChannel22565);
			Init(@__env, handle);
		}
		static SelectableChannel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.SelectableChannel.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/SelectableChannel"));
			global::java.nio.channels.SelectableChannel._register22556 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel.staticClass, "register", "(Ljava/nio/channels/Selector;ILjava/lang/Object;)Ljava/nio/channels/SelectionKey;");
			global::java.nio.channels.SelectableChannel._register22557 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel.staticClass, "register", "(Ljava/nio/channels/Selector;I)Ljava/nio/channels/SelectionKey;");
			global::java.nio.channels.SelectableChannel._provider22558 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel.staticClass, "provider", "()Ljava/nio/channels/spi/SelectorProvider;");
			global::java.nio.channels.SelectableChannel._isRegistered22559 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel.staticClass, "isRegistered", "()Z");
			global::java.nio.channels.SelectableChannel._isBlocking22560 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel.staticClass, "isBlocking", "()Z");
			global::java.nio.channels.SelectableChannel._keyFor22561 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel.staticClass, "keyFor", "(Ljava/nio/channels/Selector;)Ljava/nio/channels/SelectionKey;");
			global::java.nio.channels.SelectableChannel._validOps22562 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel.staticClass, "validOps", "()I");
			global::java.nio.channels.SelectableChannel._blockingLock22563 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel.staticClass, "blockingLock", "()Ljava/lang/Object;");
			global::java.nio.channels.SelectableChannel._configureBlocking22564 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel.staticClass, "configureBlocking", "(Z)Ljava/nio/channels/SelectableChannel;");
			global::java.nio.channels.SelectableChannel._SelectableChannel22565 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.SelectableChannel))]
	internal sealed partial class SelectableChannel_ : java.nio.channels.SelectableChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SelectableChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _register22566;
		public override global::java.nio.channels.SelectionKey register(java.nio.channels.Selector arg0, int arg1, java.lang.Object arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_._register22566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.channels.SelectionKey;
		}
		internal static global::MonoJavaBridge.MethodId _provider22567;
		public override global::java.nio.channels.spi.SelectorProvider provider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_._provider22567)) as java.nio.channels.spi.SelectorProvider;
		}
		internal static global::MonoJavaBridge.MethodId _isRegistered22568;
		public override bool isRegistered()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_._isRegistered22568);
		}
		internal static global::MonoJavaBridge.MethodId _isBlocking22569;
		public override bool isBlocking()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_._isBlocking22569);
		}
		internal static global::MonoJavaBridge.MethodId _keyFor22570;
		public override global::java.nio.channels.SelectionKey keyFor(java.nio.channels.Selector arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_._keyFor22570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.SelectionKey;
		}
		internal static global::MonoJavaBridge.MethodId _validOps22571;
		public override int validOps()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_._validOps22571);
		}
		internal static global::MonoJavaBridge.MethodId _blockingLock22572;
		public override global::java.lang.Object blockingLock()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_._blockingLock22572)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _configureBlocking22573;
		public override global::java.nio.channels.SelectableChannel configureBlocking(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_._configureBlocking22573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.SelectableChannel;
		}
		internal static global::MonoJavaBridge.MethodId _implCloseChannel22574;
		protected override void implCloseChannel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_._implCloseChannel22574);
		}
		static SelectableChannel_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.SelectableChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/SelectableChannel"));
			global::java.nio.channels.SelectableChannel_._register22566 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel_.staticClass, "register", "(Ljava/nio/channels/Selector;ILjava/lang/Object;)Ljava/nio/channels/SelectionKey;");
			global::java.nio.channels.SelectableChannel_._provider22567 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel_.staticClass, "provider", "()Ljava/nio/channels/spi/SelectorProvider;");
			global::java.nio.channels.SelectableChannel_._isRegistered22568 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel_.staticClass, "isRegistered", "()Z");
			global::java.nio.channels.SelectableChannel_._isBlocking22569 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel_.staticClass, "isBlocking", "()Z");
			global::java.nio.channels.SelectableChannel_._keyFor22570 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel_.staticClass, "keyFor", "(Ljava/nio/channels/Selector;)Ljava/nio/channels/SelectionKey;");
			global::java.nio.channels.SelectableChannel_._validOps22571 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel_.staticClass, "validOps", "()I");
			global::java.nio.channels.SelectableChannel_._blockingLock22572 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel_.staticClass, "blockingLock", "()Ljava/lang/Object;");
			global::java.nio.channels.SelectableChannel_._configureBlocking22573 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel_.staticClass, "configureBlocking", "(Z)Ljava/nio/channels/SelectableChannel;");
			global::java.nio.channels.SelectableChannel_._implCloseChannel22574 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel_.staticClass, "implCloseChannel", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
