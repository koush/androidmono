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
		internal static global::MonoJavaBridge.MethodId _register22555;
		public abstract global::java.nio.channels.SelectionKey register(java.nio.channels.Selector arg0, int arg1, java.lang.Object arg2);
		internal static global::MonoJavaBridge.MethodId _register22556;
		public virtual global::java.nio.channels.SelectionKey register(java.nio.channels.Selector arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel._register22556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.channels.SelectionKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel.staticClass, global::java.nio.channels.SelectableChannel._register22556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.channels.SelectionKey;
		}
		internal static global::MonoJavaBridge.MethodId _provider22557;
		public abstract global::java.nio.channels.spi.SelectorProvider provider();
		internal static global::MonoJavaBridge.MethodId _isRegistered22558;
		public abstract bool isRegistered();
		internal static global::MonoJavaBridge.MethodId _isBlocking22559;
		public abstract bool isBlocking();
		internal static global::MonoJavaBridge.MethodId _keyFor22560;
		public abstract global::java.nio.channels.SelectionKey keyFor(java.nio.channels.Selector arg0);
		internal static global::MonoJavaBridge.MethodId _validOps22561;
		public abstract int validOps();
		internal static global::MonoJavaBridge.MethodId _blockingLock22562;
		public abstract global::java.lang.Object blockingLock();
		internal static global::MonoJavaBridge.MethodId _configureBlocking22563;
		public abstract global::java.nio.channels.SelectableChannel configureBlocking(bool arg0);
		internal static global::MonoJavaBridge.MethodId _SelectableChannel22564;
		protected SelectableChannel()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.SelectableChannel.staticClass, global::java.nio.channels.SelectableChannel._SelectableChannel22564);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.SelectableChannel.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/SelectableChannel"));
			global::java.nio.channels.SelectableChannel._register22555 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel.staticClass, "register", "(Ljava/nio/channels/Selector;ILjava/lang/Object;)Ljava/nio/channels/SelectionKey;");
			global::java.nio.channels.SelectableChannel._register22556 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel.staticClass, "register", "(Ljava/nio/channels/Selector;I)Ljava/nio/channels/SelectionKey;");
			global::java.nio.channels.SelectableChannel._provider22557 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel.staticClass, "provider", "()Ljava/nio/channels/spi/SelectorProvider;");
			global::java.nio.channels.SelectableChannel._isRegistered22558 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel.staticClass, "isRegistered", "()Z");
			global::java.nio.channels.SelectableChannel._isBlocking22559 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel.staticClass, "isBlocking", "()Z");
			global::java.nio.channels.SelectableChannel._keyFor22560 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel.staticClass, "keyFor", "(Ljava/nio/channels/Selector;)Ljava/nio/channels/SelectionKey;");
			global::java.nio.channels.SelectableChannel._validOps22561 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel.staticClass, "validOps", "()I");
			global::java.nio.channels.SelectableChannel._blockingLock22562 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel.staticClass, "blockingLock", "()Ljava/lang/Object;");
			global::java.nio.channels.SelectableChannel._configureBlocking22563 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel.staticClass, "configureBlocking", "(Z)Ljava/nio/channels/SelectableChannel;");
			global::java.nio.channels.SelectableChannel._SelectableChannel22564 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.SelectableChannel))]
	internal sealed partial class SelectableChannel_ : java.nio.channels.SelectableChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SelectableChannel_()
		{
			InitJNI();
		}
		internal SelectableChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _register22565;
		public override global::java.nio.channels.SelectionKey register(java.nio.channels.Selector arg0, int arg1, java.lang.Object arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_._register22565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.channels.SelectionKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_.staticClass, global::java.nio.channels.SelectableChannel_._register22565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.channels.SelectionKey;
		}
		internal static global::MonoJavaBridge.MethodId _provider22566;
		public override global::java.nio.channels.spi.SelectorProvider provider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_._provider22566)) as java.nio.channels.spi.SelectorProvider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_.staticClass, global::java.nio.channels.SelectableChannel_._provider22566)) as java.nio.channels.spi.SelectorProvider;
		}
		internal static global::MonoJavaBridge.MethodId _isRegistered22567;
		public override bool isRegistered() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_._isRegistered22567);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_.staticClass, global::java.nio.channels.SelectableChannel_._isRegistered22567);
		}
		internal static global::MonoJavaBridge.MethodId _isBlocking22568;
		public override bool isBlocking() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_._isBlocking22568);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_.staticClass, global::java.nio.channels.SelectableChannel_._isBlocking22568);
		}
		internal static global::MonoJavaBridge.MethodId _keyFor22569;
		public override global::java.nio.channels.SelectionKey keyFor(java.nio.channels.Selector arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_._keyFor22569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.SelectionKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_.staticClass, global::java.nio.channels.SelectableChannel_._keyFor22569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.SelectionKey;
		}
		internal static global::MonoJavaBridge.MethodId _validOps22570;
		public override int validOps() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_._validOps22570);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_.staticClass, global::java.nio.channels.SelectableChannel_._validOps22570);
		}
		internal static global::MonoJavaBridge.MethodId _blockingLock22571;
		public override global::java.lang.Object blockingLock() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_._blockingLock22571)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_.staticClass, global::java.nio.channels.SelectableChannel_._blockingLock22571)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _configureBlocking22572;
		public override global::java.nio.channels.SelectableChannel configureBlocking(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_._configureBlocking22572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.SelectableChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_.staticClass, global::java.nio.channels.SelectableChannel_._configureBlocking22572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.SelectableChannel;
		}
		internal static global::MonoJavaBridge.MethodId _implCloseChannel22573;
		protected override void implCloseChannel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_._implCloseChannel22573);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.SelectableChannel_.staticClass, global::java.nio.channels.SelectableChannel_._implCloseChannel22573);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.SelectableChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/SelectableChannel"));
			global::java.nio.channels.SelectableChannel_._register22565 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel_.staticClass, "register", "(Ljava/nio/channels/Selector;ILjava/lang/Object;)Ljava/nio/channels/SelectionKey;");
			global::java.nio.channels.SelectableChannel_._provider22566 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel_.staticClass, "provider", "()Ljava/nio/channels/spi/SelectorProvider;");
			global::java.nio.channels.SelectableChannel_._isRegistered22567 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel_.staticClass, "isRegistered", "()Z");
			global::java.nio.channels.SelectableChannel_._isBlocking22568 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel_.staticClass, "isBlocking", "()Z");
			global::java.nio.channels.SelectableChannel_._keyFor22569 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel_.staticClass, "keyFor", "(Ljava/nio/channels/Selector;)Ljava/nio/channels/SelectionKey;");
			global::java.nio.channels.SelectableChannel_._validOps22570 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel_.staticClass, "validOps", "()I");
			global::java.nio.channels.SelectableChannel_._blockingLock22571 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel_.staticClass, "blockingLock", "()Ljava/lang/Object;");
			global::java.nio.channels.SelectableChannel_._configureBlocking22572 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel_.staticClass, "configureBlocking", "(Z)Ljava/nio/channels/SelectableChannel;");
			global::java.nio.channels.SelectableChannel_._implCloseChannel22573 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel_.staticClass, "implCloseChannel", "()V");
		}
	}
}
