namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.Selector_))]
	public abstract partial class Selector : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Selector(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _provider22600;
		public abstract global::java.nio.channels.spi.SelectorProvider provider();
		internal static global::MonoJavaBridge.MethodId _keys22601;
		public abstract global::java.util.Set keys();
		internal static global::MonoJavaBridge.MethodId _close22602;
		public abstract void close();
		internal static global::MonoJavaBridge.MethodId _open22603;
		public static global::java.nio.channels.Selector open()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.Selector._open22603.native == global::System.IntPtr.Zero)
				global::java.nio.channels.Selector._open22603 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.Selector.staticClass, "open", "()Ljava/nio/channels/Selector;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.Selector.staticClass, global::java.nio.channels.Selector._open22603)) as java.nio.channels.Selector;
		}
		internal static global::MonoJavaBridge.MethodId _isOpen22604;
		public abstract bool isOpen();
		internal static global::MonoJavaBridge.MethodId _select22605;
		public abstract int select(long arg0);
		internal static global::MonoJavaBridge.MethodId _select22606;
		public abstract int select();
		internal static global::MonoJavaBridge.MethodId _selectedKeys22607;
		public abstract global::java.util.Set selectedKeys();
		internal static global::MonoJavaBridge.MethodId _selectNow22608;
		public abstract int selectNow();
		internal static global::MonoJavaBridge.MethodId _wakeup22609;
		public abstract global::java.nio.channels.Selector wakeup();
		internal static global::MonoJavaBridge.MethodId _Selector22610;
		protected Selector() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.Selector._Selector22610.native == global::System.IntPtr.Zero)
				global::java.nio.channels.Selector._Selector22610 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.Selector.staticClass, global::java.nio.channels.Selector._Selector22610);
			Init(@__env, handle);
		}
		static Selector()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.Selector.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Selector"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.Selector))]
	internal sealed partial class Selector_ : java.nio.channels.Selector
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Selector_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _provider22611;
		public override global::java.nio.channels.spi.SelectorProvider provider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.Selector_._provider22611.native == global::System.IntPtr.Zero)
				global::java.nio.channels.Selector_._provider22611 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector_.staticClass, "provider", "()Ljava/nio/channels/spi/SelectorProvider;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.Selector_._provider22611)) as java.nio.channels.spi.SelectorProvider;
		}
		internal static global::MonoJavaBridge.MethodId _keys22612;
		public override global::java.util.Set keys()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.Selector_._keys22612.native == global::System.IntPtr.Zero)
				global::java.nio.channels.Selector_._keys22612 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector_.staticClass, "keys", "()Ljava/util/Set;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.Selector_._keys22612)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _close22613;
		public override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.Selector_._close22613.native == global::System.IntPtr.Zero)
				global::java.nio.channels.Selector_._close22613 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector_.staticClass, "close", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.Selector_._close22613);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen22614;
		public override bool isOpen()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.Selector_._isOpen22614.native == global::System.IntPtr.Zero)
				global::java.nio.channels.Selector_._isOpen22614 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector_.staticClass, "isOpen", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.Selector_._isOpen22614);
		}
		internal static global::MonoJavaBridge.MethodId _select22615;
		public override int select(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.Selector_._select22615.native == global::System.IntPtr.Zero)
				global::java.nio.channels.Selector_._select22615 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector_.staticClass, "select", "(J)I");
			return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.Selector_._select22615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _select22616;
		public override int select()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.Selector_._select22616.native == global::System.IntPtr.Zero)
				global::java.nio.channels.Selector_._select22616 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector_.staticClass, "select", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.Selector_._select22616);
		}
		internal static global::MonoJavaBridge.MethodId _selectedKeys22617;
		public override global::java.util.Set selectedKeys()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.Selector_._selectedKeys22617.native == global::System.IntPtr.Zero)
				global::java.nio.channels.Selector_._selectedKeys22617 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector_.staticClass, "selectedKeys", "()Ljava/util/Set;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.Selector_._selectedKeys22617)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _selectNow22618;
		public override int selectNow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.Selector_._selectNow22618.native == global::System.IntPtr.Zero)
				global::java.nio.channels.Selector_._selectNow22618 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector_.staticClass, "selectNow", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.Selector_._selectNow22618);
		}
		internal static global::MonoJavaBridge.MethodId _wakeup22619;
		public override global::java.nio.channels.Selector wakeup()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.Selector_._wakeup22619.native == global::System.IntPtr.Zero)
				global::java.nio.channels.Selector_._wakeup22619 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector_.staticClass, "wakeup", "()Ljava/nio/channels/Selector;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.Selector_._wakeup22619)) as java.nio.channels.Selector;
		}
		static Selector_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.Selector_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Selector"));
		}
		internal static void InitJNI()
		{
		}
	}
}
