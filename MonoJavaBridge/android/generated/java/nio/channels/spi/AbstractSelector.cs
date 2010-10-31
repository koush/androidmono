namespace java.nio.channels.spi
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.spi.AbstractSelector_))]
	public abstract partial class AbstractSelector : java.nio.channels.Selector
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractSelector(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected abstract global::java.nio.channels.SelectionKey register(java.nio.channels.spi.AbstractSelectableChannel arg0, int arg1, java.lang.Object arg2);
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override global::java.nio.channels.spi.SelectorProvider provider()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.spi.AbstractSelector.staticClass, "provider", "()Ljava/nio/channels/spi/SelectorProvider;", ref global::java.nio.channels.spi.AbstractSelector._m1) as java.nio.channels.spi.SelectorProvider;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.spi.AbstractSelector.staticClass, "close", "()V", ref global::java.nio.channels.spi.AbstractSelector._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public sealed override bool isOpen()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.spi.AbstractSelector.staticClass, "isOpen", "()Z", ref global::java.nio.channels.spi.AbstractSelector._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected virtual void end()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.spi.AbstractSelector.staticClass, "end", "()V", ref global::java.nio.channels.spi.AbstractSelector._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected virtual void begin()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.spi.AbstractSelector.staticClass, "begin", "()V", ref global::java.nio.channels.spi.AbstractSelector._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected virtual global::java.util.Set cancelledKeys()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.nio.channels.spi.AbstractSelector.staticClass, "cancelledKeys", "()Ljava/util/Set;", ref global::java.nio.channels.spi.AbstractSelector._m6) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected abstract void implCloseSelector();
		private static global::MonoJavaBridge.MethodId _m8;
		protected virtual void deregister(java.nio.channels.spi.AbstractSelectionKey arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.spi.AbstractSelector.staticClass, "deregister", "(Ljava/nio/channels/spi/AbstractSelectionKey;)V", ref global::java.nio.channels.spi.AbstractSelector._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected AbstractSelector(java.nio.channels.spi.SelectorProvider arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.spi.AbstractSelector._m9.native == global::System.IntPtr.Zero)
				global::java.nio.channels.spi.AbstractSelector._m9 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelector.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.spi.AbstractSelector.staticClass, global::java.nio.channels.spi.AbstractSelector._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static AbstractSelector()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.spi.AbstractSelector.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/spi/AbstractSelector"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.spi.AbstractSelector))]
	internal sealed partial class AbstractSelector_ : java.nio.channels.spi.AbstractSelector
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractSelector_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override global::java.nio.channels.SelectionKey register(java.nio.channels.spi.AbstractSelectableChannel arg0, int arg1, java.lang.Object arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.spi.AbstractSelector_.staticClass, "register", "(Ljava/nio/channels/spi/AbstractSelectableChannel;ILjava/lang/Object;)Ljava/nio/channels/SelectionKey;", ref global::java.nio.channels.spi.AbstractSelector_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.nio.channels.SelectionKey;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void implCloseSelector()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.spi.AbstractSelector_.staticClass, "implCloseSelector", "()V", ref global::java.nio.channels.spi.AbstractSelector_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.util.Set keys()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.nio.channels.spi.AbstractSelector_.staticClass, "keys", "()Ljava/util/Set;", ref global::java.nio.channels.spi.AbstractSelector_._m2) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int select(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.spi.AbstractSelector_.staticClass, "select", "(J)I", ref global::java.nio.channels.spi.AbstractSelector_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int select()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.spi.AbstractSelector_.staticClass, "select", "()I", ref global::java.nio.channels.spi.AbstractSelector_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::java.util.Set selectedKeys()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.nio.channels.spi.AbstractSelector_.staticClass, "selectedKeys", "()Ljava/util/Set;", ref global::java.nio.channels.spi.AbstractSelector_._m5) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override int selectNow()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.spi.AbstractSelector_.staticClass, "selectNow", "()I", ref global::java.nio.channels.spi.AbstractSelector_._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override global::java.nio.channels.Selector wakeup()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.spi.AbstractSelector_.staticClass, "wakeup", "()Ljava/nio/channels/Selector;", ref global::java.nio.channels.spi.AbstractSelector_._m7) as java.nio.channels.Selector;
		}
		static AbstractSelector_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.spi.AbstractSelector_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/spi/AbstractSelector"));
		}
	}
}
