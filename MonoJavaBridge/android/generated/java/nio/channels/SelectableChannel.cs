namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.SelectableChannel_))]
	public abstract partial class SelectableChannel : java.nio.channels.spi.AbstractInterruptibleChannel, Channel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SelectableChannel(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract global::java.nio.channels.SelectionKey register(java.nio.channels.Selector arg0, int arg1, java.lang.Object arg2);
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.nio.channels.SelectionKey register(java.nio.channels.Selector arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.SelectableChannel.staticClass, "register", "(Ljava/nio/channels/Selector;I)Ljava/nio/channels/SelectionKey;", ref global::java.nio.channels.SelectableChannel._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.nio.channels.SelectionKey;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract global::java.nio.channels.spi.SelectorProvider provider();
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract bool isRegistered();
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract bool isBlocking();
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract global::java.nio.channels.SelectionKey keyFor(java.nio.channels.Selector arg0);
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract int validOps();
		private static global::MonoJavaBridge.MethodId _m7;
		public abstract global::java.lang.Object blockingLock();
		private static global::MonoJavaBridge.MethodId _m8;
		public abstract global::java.nio.channels.SelectableChannel configureBlocking(bool arg0);
		private static global::MonoJavaBridge.MethodId _m9;
		protected SelectableChannel() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.SelectableChannel._m9.native == global::System.IntPtr.Zero)
				global::java.nio.channels.SelectableChannel._m9 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectableChannel.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.SelectableChannel.staticClass, global::java.nio.channels.SelectableChannel._m9);
			Init(@__env, handle);
		}
		static SelectableChannel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.SelectableChannel.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/SelectableChannel"));
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
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.nio.channels.SelectionKey register(java.nio.channels.Selector arg0, int arg1, java.lang.Object arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.SelectableChannel_.staticClass, "register", "(Ljava/nio/channels/Selector;ILjava/lang/Object;)Ljava/nio/channels/SelectionKey;", ref global::java.nio.channels.SelectableChannel_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.nio.channels.SelectionKey;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.nio.channels.spi.SelectorProvider provider()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.SelectableChannel_.staticClass, "provider", "()Ljava/nio/channels/spi/SelectorProvider;", ref global::java.nio.channels.SelectableChannel_._m1) as java.nio.channels.spi.SelectorProvider;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool isRegistered()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.SelectableChannel_.staticClass, "isRegistered", "()Z", ref global::java.nio.channels.SelectableChannel_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool isBlocking()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.SelectableChannel_.staticClass, "isBlocking", "()Z", ref global::java.nio.channels.SelectableChannel_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::java.nio.channels.SelectionKey keyFor(java.nio.channels.Selector arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.SelectableChannel_.staticClass, "keyFor", "(Ljava/nio/channels/Selector;)Ljava/nio/channels/SelectionKey;", ref global::java.nio.channels.SelectableChannel_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.channels.SelectionKey;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override int validOps()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.SelectableChannel_.staticClass, "validOps", "()I", ref global::java.nio.channels.SelectableChannel_._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::java.lang.Object blockingLock()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.SelectableChannel_.staticClass, "blockingLock", "()Ljava/lang/Object;", ref global::java.nio.channels.SelectableChannel_._m6) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override global::java.nio.channels.SelectableChannel configureBlocking(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.SelectableChannel_.staticClass, "configureBlocking", "(Z)Ljava/nio/channels/SelectableChannel;", ref global::java.nio.channels.SelectableChannel_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.channels.SelectableChannel;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected override void implCloseChannel()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.SelectableChannel_.staticClass, "implCloseChannel", "()V", ref global::java.nio.channels.SelectableChannel_._m8);
		}
		static SelectableChannel_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.SelectableChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/SelectableChannel"));
		}
		internal static void InitJNI()
		{
		}
	}
}
