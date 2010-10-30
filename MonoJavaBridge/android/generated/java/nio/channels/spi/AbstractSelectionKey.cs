namespace java.nio.channels.spi
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.spi.AbstractSelectionKey_))]
	public abstract partial class AbstractSelectionKey : java.nio.channels.SelectionKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractSelectionKey(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool isValid()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.spi.AbstractSelectionKey.staticClass, "isValid", "()Z", ref global::java.nio.channels.spi.AbstractSelectionKey._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override void cancel()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.spi.AbstractSelectionKey.staticClass, "cancel", "()V", ref global::java.nio.channels.spi.AbstractSelectionKey._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected AbstractSelectionKey() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.spi.AbstractSelectionKey._m2.native == global::System.IntPtr.Zero)
				global::java.nio.channels.spi.AbstractSelectionKey._m2 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelectionKey.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.spi.AbstractSelectionKey.staticClass, global::java.nio.channels.spi.AbstractSelectionKey._m2);
			Init(@__env, handle);
		}
		static AbstractSelectionKey()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.spi.AbstractSelectionKey.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/spi/AbstractSelectionKey"));
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
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.nio.channels.SelectableChannel channel()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.spi.AbstractSelectionKey_.staticClass, "channel", "()Ljava/nio/channels/SelectableChannel;", ref global::java.nio.channels.spi.AbstractSelectionKey_._m0) as java.nio.channels.SelectableChannel;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.nio.channels.Selector selector()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.spi.AbstractSelectionKey_.staticClass, "selector", "()Ljava/nio/channels/Selector;", ref global::java.nio.channels.spi.AbstractSelectionKey_._m1) as java.nio.channels.Selector;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int interestOps()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.spi.AbstractSelectionKey_.staticClass, "interestOps", "()I", ref global::java.nio.channels.spi.AbstractSelectionKey_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.nio.channels.SelectionKey interestOps(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.spi.AbstractSelectionKey_.staticClass, "interestOps", "(I)Ljava/nio/channels/SelectionKey;", ref global::java.nio.channels.spi.AbstractSelectionKey_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.channels.SelectionKey;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int readyOps()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.spi.AbstractSelectionKey_.staticClass, "readyOps", "()I", ref global::java.nio.channels.spi.AbstractSelectionKey_._m4);
		}
		static AbstractSelectionKey_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.spi.AbstractSelectionKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/spi/AbstractSelectionKey"));
		}
		internal static void InitJNI()
		{
		}
	}
}
