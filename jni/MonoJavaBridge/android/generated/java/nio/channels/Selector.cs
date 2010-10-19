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
		internal static global::MonoJavaBridge.MethodId _provider16883;
		public abstract global::java.nio.channels.spi.SelectorProvider provider();
		internal static global::MonoJavaBridge.MethodId _keys16884;
		public abstract global::java.util.Set keys();
		internal static global::MonoJavaBridge.MethodId _close16885;
		public abstract void close();
		internal static global::MonoJavaBridge.MethodId _open16886;
		public static global::java.nio.channels.Selector open() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.Selector.staticClass, global::java.nio.channels.Selector._open16886)) as java.nio.channels.Selector;
		}
		internal static global::MonoJavaBridge.MethodId _isOpen16887;
		public abstract bool isOpen();
		internal static global::MonoJavaBridge.MethodId _select16888;
		public abstract int select(long arg0);
		internal static global::MonoJavaBridge.MethodId _select16889;
		public abstract int select();
		internal static global::MonoJavaBridge.MethodId _selectedKeys16890;
		public abstract global::java.util.Set selectedKeys();
		internal static global::MonoJavaBridge.MethodId _selectNow16891;
		public abstract int selectNow();
		internal static global::MonoJavaBridge.MethodId _wakeup16892;
		public abstract global::java.nio.channels.Selector wakeup();
		internal static global::MonoJavaBridge.MethodId _Selector16893;
		protected Selector()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.Selector.staticClass, global::java.nio.channels.Selector._Selector16893);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.Selector.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Selector"));
			global::java.nio.channels.Selector._provider16883 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector.staticClass, "provider", "()Ljava/nio/channels/spi/SelectorProvider;");
			global::java.nio.channels.Selector._keys16884 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector.staticClass, "keys", "()Ljava/util/Set;");
			global::java.nio.channels.Selector._close16885 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector.staticClass, "close", "()V");
			global::java.nio.channels.Selector._open16886 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.Selector.staticClass, "open", "()Ljava/nio/channels/Selector;");
			global::java.nio.channels.Selector._isOpen16887 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector.staticClass, "isOpen", "()Z");
			global::java.nio.channels.Selector._select16888 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector.staticClass, "select", "(J)I");
			global::java.nio.channels.Selector._select16889 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector.staticClass, "select", "()I");
			global::java.nio.channels.Selector._selectedKeys16890 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector.staticClass, "selectedKeys", "()Ljava/util/Set;");
			global::java.nio.channels.Selector._selectNow16891 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector.staticClass, "selectNow", "()I");
			global::java.nio.channels.Selector._wakeup16892 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector.staticClass, "wakeup", "()Ljava/nio/channels/Selector;");
			global::java.nio.channels.Selector._Selector16893 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.Selector))]
	public sealed partial class Selector_ : java.nio.channels.Selector
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Selector_()
		{
			InitJNI();
		}
		internal Selector_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _provider16894;
		public override global::java.nio.channels.spi.SelectorProvider provider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.Selector_._provider16894)) as java.nio.channels.spi.SelectorProvider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.Selector_.staticClass, global::java.nio.channels.Selector_._provider16894)) as java.nio.channels.spi.SelectorProvider;
		}
		internal static global::MonoJavaBridge.MethodId _keys16895;
		public override global::java.util.Set keys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.Selector_._keys16895)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.Selector_.staticClass, global::java.nio.channels.Selector_._keys16895)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _close16896;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.Selector_._close16896);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.Selector_.staticClass, global::java.nio.channels.Selector_._close16896);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen16897;
		public override bool isOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.Selector_._isOpen16897);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.Selector_.staticClass, global::java.nio.channels.Selector_._isOpen16897);
		}
		internal static global::MonoJavaBridge.MethodId _select16898;
		public override int select(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.Selector_._select16898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.Selector_.staticClass, global::java.nio.channels.Selector_._select16898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _select16899;
		public override int select() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.Selector_._select16899);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.Selector_.staticClass, global::java.nio.channels.Selector_._select16899);
		}
		internal static global::MonoJavaBridge.MethodId _selectedKeys16900;
		public override global::java.util.Set selectedKeys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.Selector_._selectedKeys16900)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.Selector_.staticClass, global::java.nio.channels.Selector_._selectedKeys16900)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _selectNow16901;
		public override int selectNow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.Selector_._selectNow16901);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.Selector_.staticClass, global::java.nio.channels.Selector_._selectNow16901);
		}
		internal static global::MonoJavaBridge.MethodId _wakeup16902;
		public override global::java.nio.channels.Selector wakeup() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.Selector_._wakeup16902)) as java.nio.channels.Selector;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.Selector_.staticClass, global::java.nio.channels.Selector_._wakeup16902)) as java.nio.channels.Selector;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.Selector_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Selector"));
			global::java.nio.channels.Selector_._provider16894 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector_.staticClass, "provider", "()Ljava/nio/channels/spi/SelectorProvider;");
			global::java.nio.channels.Selector_._keys16895 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector_.staticClass, "keys", "()Ljava/util/Set;");
			global::java.nio.channels.Selector_._close16896 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector_.staticClass, "close", "()V");
			global::java.nio.channels.Selector_._isOpen16897 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector_.staticClass, "isOpen", "()Z");
			global::java.nio.channels.Selector_._select16898 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector_.staticClass, "select", "(J)I");
			global::java.nio.channels.Selector_._select16899 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector_.staticClass, "select", "()I");
			global::java.nio.channels.Selector_._selectedKeys16900 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector_.staticClass, "selectedKeys", "()Ljava/util/Set;");
			global::java.nio.channels.Selector_._selectNow16901 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector_.staticClass, "selectNow", "()I");
			global::java.nio.channels.Selector_._wakeup16902 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector_.staticClass, "wakeup", "()Ljava/nio/channels/Selector;");
		}
	}
}
