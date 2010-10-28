namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.Selector_))]
	public abstract partial class Selector : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Selector()
		{
			InitJNI();
		}
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
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.Selector.staticClass, global::java.nio.channels.Selector._Selector22610);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.Selector.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Selector"));
			global::java.nio.channels.Selector._provider22600 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector.staticClass, "provider", "()Ljava/nio/channels/spi/SelectorProvider;");
			global::java.nio.channels.Selector._keys22601 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector.staticClass, "keys", "()Ljava/util/Set;");
			global::java.nio.channels.Selector._close22602 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector.staticClass, "close", "()V");
			global::java.nio.channels.Selector._open22603 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.Selector.staticClass, "open", "()Ljava/nio/channels/Selector;");
			global::java.nio.channels.Selector._isOpen22604 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector.staticClass, "isOpen", "()Z");
			global::java.nio.channels.Selector._select22605 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector.staticClass, "select", "(J)I");
			global::java.nio.channels.Selector._select22606 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector.staticClass, "select", "()I");
			global::java.nio.channels.Selector._selectedKeys22607 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector.staticClass, "selectedKeys", "()Ljava/util/Set;");
			global::java.nio.channels.Selector._selectNow22608 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector.staticClass, "selectNow", "()I");
			global::java.nio.channels.Selector._wakeup22609 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector.staticClass, "wakeup", "()Ljava/nio/channels/Selector;");
			global::java.nio.channels.Selector._Selector22610 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.Selector))]
	internal sealed partial class Selector_ : java.nio.channels.Selector
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Selector_()
		{
			InitJNI();
		}
		internal Selector_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _provider22611;
		public override global::java.nio.channels.spi.SelectorProvider provider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.Selector_._provider22611)) as java.nio.channels.spi.SelectorProvider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.Selector_.staticClass, global::java.nio.channels.Selector_._provider22611)) as java.nio.channels.spi.SelectorProvider;
		}
		internal static global::MonoJavaBridge.MethodId _keys22612;
		public override global::java.util.Set keys()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.Selector_._keys22612)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.Selector_.staticClass, global::java.nio.channels.Selector_._keys22612)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _close22613;
		public override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.Selector_._close22613);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.Selector_.staticClass, global::java.nio.channels.Selector_._close22613);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen22614;
		public override bool isOpen()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.Selector_._isOpen22614);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.Selector_.staticClass, global::java.nio.channels.Selector_._isOpen22614);
		}
		internal static global::MonoJavaBridge.MethodId _select22615;
		public override int select(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.Selector_._select22615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.Selector_.staticClass, global::java.nio.channels.Selector_._select22615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _select22616;
		public override int select()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.Selector_._select22616);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.Selector_.staticClass, global::java.nio.channels.Selector_._select22616);
		}
		internal static global::MonoJavaBridge.MethodId _selectedKeys22617;
		public override global::java.util.Set selectedKeys()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.Selector_._selectedKeys22617)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.Selector_.staticClass, global::java.nio.channels.Selector_._selectedKeys22617)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _selectNow22618;
		public override int selectNow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.Selector_._selectNow22618);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.Selector_.staticClass, global::java.nio.channels.Selector_._selectNow22618);
		}
		internal static global::MonoJavaBridge.MethodId _wakeup22619;
		public override global::java.nio.channels.Selector wakeup()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.Selector_._wakeup22619)) as java.nio.channels.Selector;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.Selector_.staticClass, global::java.nio.channels.Selector_._wakeup22619)) as java.nio.channels.Selector;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.Selector_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Selector"));
			global::java.nio.channels.Selector_._provider22611 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector_.staticClass, "provider", "()Ljava/nio/channels/spi/SelectorProvider;");
			global::java.nio.channels.Selector_._keys22612 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector_.staticClass, "keys", "()Ljava/util/Set;");
			global::java.nio.channels.Selector_._close22613 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector_.staticClass, "close", "()V");
			global::java.nio.channels.Selector_._isOpen22614 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector_.staticClass, "isOpen", "()Z");
			global::java.nio.channels.Selector_._select22615 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector_.staticClass, "select", "(J)I");
			global::java.nio.channels.Selector_._select22616 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector_.staticClass, "select", "()I");
			global::java.nio.channels.Selector_._selectedKeys22617 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector_.staticClass, "selectedKeys", "()Ljava/util/Set;");
			global::java.nio.channels.Selector_._selectNow22618 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector_.staticClass, "selectNow", "()I");
			global::java.nio.channels.Selector_._wakeup22619 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector_.staticClass, "wakeup", "()Ljava/nio/channels/Selector;");
		}
	}
}
