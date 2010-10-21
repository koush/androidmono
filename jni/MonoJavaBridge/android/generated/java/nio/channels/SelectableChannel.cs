namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.SelectableChannel_))]
	public abstract partial class SelectableChannel : java.nio.channels.spi.AbstractInterruptibleChannel, Channel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SelectableChannel()
		{
			InitJNI();
		}
		protected SelectableChannel(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _register22437;
		public abstract global::java.nio.channels.SelectionKey register(java.nio.channels.Selector arg0, int arg1, java.lang.Object arg2);
		internal static global::MonoJavaBridge.MethodId _register22438;
		public virtual global::java.nio.channels.SelectionKey register(java.nio.channels.Selector arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel._register22438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.channels.SelectionKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel.staticClass, global::java.nio.channels.SelectableChannel._register22438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.channels.SelectionKey;
		}
		internal static global::MonoJavaBridge.MethodId _provider22439;
		public abstract global::java.nio.channels.spi.SelectorProvider provider();
		internal static global::MonoJavaBridge.MethodId _isRegistered22440;
		public abstract bool isRegistered();
		internal static global::MonoJavaBridge.MethodId _isBlocking22441;
		public abstract bool isBlocking();
		internal static global::MonoJavaBridge.MethodId _keyFor22442;
		public abstract global::java.nio.channels.SelectionKey keyFor(java.nio.channels.Selector arg0);
		internal static global::MonoJavaBridge.MethodId _validOps22443;
		public abstract int validOps();
		internal static global::MonoJavaBridge.MethodId _blockingLock22444;
		public abstract global::java.lang.Object blockingLock();
		internal static global::MonoJavaBridge.MethodId _configureBlocking22445;
		public abstract global::java.nio.channels.SelectableChannel configureBlocking(bool arg0);
		internal static global::MonoJavaBridge.MethodId _SelectableChannel22446;
		protected SelectableChannel()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.SelectableChannel.staticClass, global::java.nio.channels.SelectableChannel._SelectableChannel22446);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.SelectableChannel.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/SelectableChannel"));
			global::java.nio.channels.SelectableChannel._register22437 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel.staticClass, "register", "(Ljava/nio/channels/Selector;ILjava/lang/Object;)Ljava/nio/channels/SelectionKey;");
			global::java.nio.channels.SelectableChannel._register22438 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel.staticClass, "register", "(Ljava/nio/channels/Selector;I)Ljava/nio/channels/SelectionKey;");
			global::java.nio.channels.SelectableChannel._provider22439 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel.staticClass, "provider", "()Ljava/nio/channels/spi/SelectorProvider;");
			global::java.nio.channels.SelectableChannel._isRegistered22440 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel.staticClass, "isRegistered", "()Z");
			global::java.nio.channels.SelectableChannel._isBlocking22441 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel.staticClass, "isBlocking", "()Z");
			global::java.nio.channels.SelectableChannel._keyFor22442 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel.staticClass, "keyFor", "(Ljava/nio/channels/Selector;)Ljava/nio/channels/SelectionKey;");
			global::java.nio.channels.SelectableChannel._validOps22443 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel.staticClass, "validOps", "()I");
			global::java.nio.channels.SelectableChannel._blockingLock22444 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel.staticClass, "blockingLock", "()Ljava/lang/Object;");
			global::java.nio.channels.SelectableChannel._configureBlocking22445 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel.staticClass, "configureBlocking", "(Z)Ljava/nio/channels/SelectableChannel;");
			global::java.nio.channels.SelectableChannel._SelectableChannel22446 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.SelectableChannel))]
	public sealed partial class SelectableChannel_ : java.nio.channels.SelectableChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SelectableChannel_()
		{
			InitJNI();
		}
		internal SelectableChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _register22447;
		public override global::java.nio.channels.SelectionKey register(java.nio.channels.Selector arg0, int arg1, java.lang.Object arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_._register22447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.channels.SelectionKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_.staticClass, global::java.nio.channels.SelectableChannel_._register22447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.channels.SelectionKey;
		}
		internal static global::MonoJavaBridge.MethodId _provider22448;
		public override global::java.nio.channels.spi.SelectorProvider provider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_._provider22448)) as java.nio.channels.spi.SelectorProvider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_.staticClass, global::java.nio.channels.SelectableChannel_._provider22448)) as java.nio.channels.spi.SelectorProvider;
		}
		internal static global::MonoJavaBridge.MethodId _isRegistered22449;
		public override bool isRegistered() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_._isRegistered22449);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_.staticClass, global::java.nio.channels.SelectableChannel_._isRegistered22449);
		}
		internal static global::MonoJavaBridge.MethodId _isBlocking22450;
		public override bool isBlocking() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_._isBlocking22450);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_.staticClass, global::java.nio.channels.SelectableChannel_._isBlocking22450);
		}
		internal static global::MonoJavaBridge.MethodId _keyFor22451;
		public override global::java.nio.channels.SelectionKey keyFor(java.nio.channels.Selector arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_._keyFor22451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.SelectionKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_.staticClass, global::java.nio.channels.SelectableChannel_._keyFor22451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.SelectionKey;
		}
		internal static global::MonoJavaBridge.MethodId _validOps22452;
		public override int validOps() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_._validOps22452);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_.staticClass, global::java.nio.channels.SelectableChannel_._validOps22452);
		}
		internal static global::MonoJavaBridge.MethodId _blockingLock22453;
		public override global::java.lang.Object blockingLock() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_._blockingLock22453)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_.staticClass, global::java.nio.channels.SelectableChannel_._blockingLock22453)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _configureBlocking22454;
		public override global::java.nio.channels.SelectableChannel configureBlocking(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_._configureBlocking22454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.SelectableChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_.staticClass, global::java.nio.channels.SelectableChannel_._configureBlocking22454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.SelectableChannel;
		}
		internal static global::MonoJavaBridge.MethodId _implCloseChannel22455;
		protected override void implCloseChannel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_._implCloseChannel22455);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_.staticClass, global::java.nio.channels.SelectableChannel_._implCloseChannel22455);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.SelectableChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/SelectableChannel"));
			global::java.nio.channels.SelectableChannel_._register22447 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel_.staticClass, "register", "(Ljava/nio/channels/Selector;ILjava/lang/Object;)Ljava/nio/channels/SelectionKey;");
			global::java.nio.channels.SelectableChannel_._provider22448 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel_.staticClass, "provider", "()Ljava/nio/channels/spi/SelectorProvider;");
			global::java.nio.channels.SelectableChannel_._isRegistered22449 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel_.staticClass, "isRegistered", "()Z");
			global::java.nio.channels.SelectableChannel_._isBlocking22450 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel_.staticClass, "isBlocking", "()Z");
			global::java.nio.channels.SelectableChannel_._keyFor22451 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel_.staticClass, "keyFor", "(Ljava/nio/channels/Selector;)Ljava/nio/channels/SelectionKey;");
			global::java.nio.channels.SelectableChannel_._validOps22452 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel_.staticClass, "validOps", "()I");
			global::java.nio.channels.SelectableChannel_._blockingLock22453 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel_.staticClass, "blockingLock", "()Ljava/lang/Object;");
			global::java.nio.channels.SelectableChannel_._configureBlocking22454 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel_.staticClass, "configureBlocking", "(Z)Ljava/nio/channels/SelectableChannel;");
			global::java.nio.channels.SelectableChannel_._implCloseChannel22455 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel_.staticClass, "implCloseChannel", "()V");
		}
	}
}
