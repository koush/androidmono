namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.Selector_))]
	public abstract partial class Selector : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Selector(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract global::java.nio.channels.spi.SelectorProvider provider();
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract global::java.util.Set keys();
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract void close();
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::java.nio.channels.Selector open()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.Selector._m3.native == global::System.IntPtr.Zero)
				global::java.nio.channels.Selector._m3 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.Selector.staticClass, "open", "()Ljava/nio/channels/Selector;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.Selector.staticClass, global::java.nio.channels.Selector._m3)) as java.nio.channels.Selector;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract bool isOpen();
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract int select(long arg0);
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract int select();
		private static global::MonoJavaBridge.MethodId _m7;
		public abstract global::java.util.Set selectedKeys();
		private static global::MonoJavaBridge.MethodId _m8;
		public abstract int selectNow();
		private static global::MonoJavaBridge.MethodId _m9;
		public abstract global::java.nio.channels.Selector wakeup();
		private static global::MonoJavaBridge.MethodId _m10;
		protected Selector() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.Selector._m10.native == global::System.IntPtr.Zero)
				global::java.nio.channels.Selector._m10 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.Selector.staticClass, global::java.nio.channels.Selector._m10);
			Init(@__env, handle);
		}
		static Selector()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.Selector.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Selector"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.Selector))]
	internal sealed partial class Selector_ : java.nio.channels.Selector
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Selector_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.nio.channels.spi.SelectorProvider provider()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.Selector_.staticClass, "provider", "()Ljava/nio/channels/spi/SelectorProvider;", ref global::java.nio.channels.Selector_._m0) as java.nio.channels.spi.SelectorProvider;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.util.Set keys()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.nio.channels.Selector_.staticClass, "keys", "()Ljava/util/Set;", ref global::java.nio.channels.Selector_._m1) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.Selector_.staticClass, "close", "()V", ref global::java.nio.channels.Selector_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool isOpen()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.Selector_.staticClass, "isOpen", "()Z", ref global::java.nio.channels.Selector_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int select(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.Selector_.staticClass, "select", "(J)I", ref global::java.nio.channels.Selector_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override int select()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.Selector_.staticClass, "select", "()I", ref global::java.nio.channels.Selector_._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::java.util.Set selectedKeys()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.nio.channels.Selector_.staticClass, "selectedKeys", "()Ljava/util/Set;", ref global::java.nio.channels.Selector_._m6) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override int selectNow()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.Selector_.staticClass, "selectNow", "()I", ref global::java.nio.channels.Selector_._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override global::java.nio.channels.Selector wakeup()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.Selector_.staticClass, "wakeup", "()Ljava/nio/channels/Selector;", ref global::java.nio.channels.Selector_._m8) as java.nio.channels.Selector;
		}
		static Selector_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.Selector_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Selector"));
		}
	}
}
