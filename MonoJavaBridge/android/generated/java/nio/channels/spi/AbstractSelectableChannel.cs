namespace java.nio.channels.spi
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.spi.AbstractSelectableChannel_))]
	public abstract partial class AbstractSelectableChannel : java.nio.channels.SelectableChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractSelectableChannel(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override global::java.nio.channels.SelectionKey register(java.nio.channels.Selector arg0, int arg1, java.lang.Object arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "register", "(Ljava/nio/channels/Selector;ILjava/lang/Object;)Ljava/nio/channels/SelectionKey;", ref global::java.nio.channels.spi.AbstractSelectableChannel._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.nio.channels.SelectionKey;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override global::java.nio.channels.spi.SelectorProvider provider()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "provider", "()Ljava/nio/channels/spi/SelectorProvider;", ref global::java.nio.channels.spi.AbstractSelectableChannel._m1) as java.nio.channels.spi.SelectorProvider;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override bool isRegistered()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "isRegistered", "()Z", ref global::java.nio.channels.spi.AbstractSelectableChannel._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public sealed override bool isBlocking()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "isBlocking", "()Z", ref global::java.nio.channels.spi.AbstractSelectableChannel._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected sealed override void implCloseChannel()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "implCloseChannel", "()V", ref global::java.nio.channels.spi.AbstractSelectableChannel._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public sealed override global::java.nio.channels.SelectionKey keyFor(java.nio.channels.Selector arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "keyFor", "(Ljava/nio/channels/Selector;)Ljava/nio/channels/SelectionKey;", ref global::java.nio.channels.spi.AbstractSelectableChannel._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.channels.SelectionKey;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected abstract void implCloseSelectableChannel();
		private static global::MonoJavaBridge.MethodId _m7;
		public sealed override global::java.lang.Object blockingLock()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "blockingLock", "()Ljava/lang/Object;", ref global::java.nio.channels.spi.AbstractSelectableChannel._m7) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public sealed override global::java.nio.channels.SelectableChannel configureBlocking(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "configureBlocking", "(Z)Ljava/nio/channels/SelectableChannel;", ref global::java.nio.channels.spi.AbstractSelectableChannel._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.channels.SelectableChannel;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected abstract void implConfigureBlocking(bool arg0);
		private static global::MonoJavaBridge.MethodId _m10;
		protected AbstractSelectableChannel(java.nio.channels.spi.SelectorProvider arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.spi.AbstractSelectableChannel._m10.native == global::System.IntPtr.Zero)
				global::java.nio.channels.spi.AbstractSelectableChannel._m10 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.spi.AbstractSelectableChannel.staticClass, global::java.nio.channels.spi.AbstractSelectableChannel._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static AbstractSelectableChannel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.spi.AbstractSelectableChannel.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/spi/AbstractSelectableChannel"));
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
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void implCloseSelectableChannel()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.spi.AbstractSelectableChannel_.staticClass, "implCloseSelectableChannel", "()V", ref global::java.nio.channels.spi.AbstractSelectableChannel_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void implConfigureBlocking(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.spi.AbstractSelectableChannel_.staticClass, "implConfigureBlocking", "(Z)V", ref global::java.nio.channels.spi.AbstractSelectableChannel_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int validOps()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.spi.AbstractSelectableChannel_.staticClass, "validOps", "()I", ref global::java.nio.channels.spi.AbstractSelectableChannel_._m2);
		}
		static AbstractSelectableChannel_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.spi.AbstractSelectableChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/spi/AbstractSelectableChannel"));
		}
		internal static void InitJNI()
		{
		}
	}
}
