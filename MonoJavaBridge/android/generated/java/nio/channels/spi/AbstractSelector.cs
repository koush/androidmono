namespace java.nio.channels.spi
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.spi.AbstractSelector_))]
	public abstract partial class AbstractSelector : java.nio.channels.Selector
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractSelector(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _register22690;
		protected abstract global::java.nio.channels.SelectionKey register(java.nio.channels.spi.AbstractSelectableChannel arg0, int arg1, java.lang.Object arg2);
		internal static global::MonoJavaBridge.MethodId _provider22691;
		public sealed override global::java.nio.channels.spi.SelectorProvider provider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.spi.AbstractSelector._provider22691.native == global::System.IntPtr.Zero)
				global::java.nio.channels.spi.AbstractSelector._provider22691 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelector.staticClass, "provider", "()Ljava/nio/channels/spi/SelectorProvider;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.spi.AbstractSelector.staticClass, global::java.nio.channels.spi.AbstractSelector._provider22691) as java.nio.channels.spi.SelectorProvider;
		}
		internal static global::MonoJavaBridge.MethodId _close22692;
		public sealed override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.spi.AbstractSelector._close22692.native == global::System.IntPtr.Zero)
				global::java.nio.channels.spi.AbstractSelector._close22692 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelector.staticClass, "close", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.spi.AbstractSelector.staticClass, global::java.nio.channels.spi.AbstractSelector._close22692);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen22693;
		public sealed override bool isOpen()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.spi.AbstractSelector._isOpen22693.native == global::System.IntPtr.Zero)
				global::java.nio.channels.spi.AbstractSelector._isOpen22693 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelector.staticClass, "isOpen", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.spi.AbstractSelector.staticClass, global::java.nio.channels.spi.AbstractSelector._isOpen22693);
		}
		internal static global::MonoJavaBridge.MethodId _end22694;
		protected virtual void end()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.spi.AbstractSelector._end22694.native == global::System.IntPtr.Zero)
				global::java.nio.channels.spi.AbstractSelector._end22694 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelector.staticClass, "end", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.spi.AbstractSelector.staticClass, global::java.nio.channels.spi.AbstractSelector._end22694);
		}
		internal static global::MonoJavaBridge.MethodId _begin22695;
		protected virtual void begin()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.spi.AbstractSelector._begin22695.native == global::System.IntPtr.Zero)
				global::java.nio.channels.spi.AbstractSelector._begin22695 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelector.staticClass, "begin", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.spi.AbstractSelector.staticClass, global::java.nio.channels.spi.AbstractSelector._begin22695);
		}
		internal static global::MonoJavaBridge.MethodId _cancelledKeys22696;
		protected virtual global::java.util.Set cancelledKeys()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.spi.AbstractSelector._cancelledKeys22696.native == global::System.IntPtr.Zero)
				global::java.nio.channels.spi.AbstractSelector._cancelledKeys22696 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelector.staticClass, "cancelledKeys", "()Ljava/util/Set;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.nio.channels.spi.AbstractSelector.staticClass, global::java.nio.channels.spi.AbstractSelector._cancelledKeys22696) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _implCloseSelector22697;
		protected abstract void implCloseSelector();
		internal static global::MonoJavaBridge.MethodId _deregister22698;
		protected virtual void deregister(java.nio.channels.spi.AbstractSelectionKey arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.spi.AbstractSelector._deregister22698.native == global::System.IntPtr.Zero)
				global::java.nio.channels.spi.AbstractSelector._deregister22698 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelector.staticClass, "deregister", "(Ljava/nio/channels/spi/AbstractSelectionKey;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.spi.AbstractSelector.staticClass, global::java.nio.channels.spi.AbstractSelector._deregister22698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AbstractSelector22699;
		protected AbstractSelector(java.nio.channels.spi.SelectorProvider arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.spi.AbstractSelector._AbstractSelector22699.native == global::System.IntPtr.Zero)
				global::java.nio.channels.spi.AbstractSelector._AbstractSelector22699 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelector.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.spi.AbstractSelector.staticClass, global::java.nio.channels.spi.AbstractSelector._AbstractSelector22699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static AbstractSelector()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.spi.AbstractSelector.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/spi/AbstractSelector"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.spi.AbstractSelector))]
	internal sealed partial class AbstractSelector_ : java.nio.channels.spi.AbstractSelector
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractSelector_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _register22700;
		protected override global::java.nio.channels.SelectionKey register(java.nio.channels.spi.AbstractSelectableChannel arg0, int arg1, java.lang.Object arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.spi.AbstractSelector_._register22700.native == global::System.IntPtr.Zero)
				global::java.nio.channels.spi.AbstractSelector_._register22700 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelector_.staticClass, "register", "(Ljava/nio/channels/spi/AbstractSelectableChannel;ILjava/lang/Object;)Ljava/nio/channels/SelectionKey;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelector_._register22700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.channels.SelectionKey;
		}
		internal static global::MonoJavaBridge.MethodId _implCloseSelector22701;
		protected override void implCloseSelector()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.spi.AbstractSelector_._implCloseSelector22701.native == global::System.IntPtr.Zero)
				global::java.nio.channels.spi.AbstractSelector_._implCloseSelector22701 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelector_.staticClass, "implCloseSelector", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelector_._implCloseSelector22701);
		}
		internal static global::MonoJavaBridge.MethodId _keys22702;
		public override global::java.util.Set keys()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.spi.AbstractSelector_._keys22702.native == global::System.IntPtr.Zero)
				global::java.nio.channels.spi.AbstractSelector_._keys22702 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelector_.staticClass, "keys", "()Ljava/util/Set;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelector_._keys22702)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _select22703;
		public override int select(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.spi.AbstractSelector_._select22703.native == global::System.IntPtr.Zero)
				global::java.nio.channels.spi.AbstractSelector_._select22703 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelector_.staticClass, "select", "(J)I");
			return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelector_._select22703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _select22704;
		public override int select()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.spi.AbstractSelector_._select22704.native == global::System.IntPtr.Zero)
				global::java.nio.channels.spi.AbstractSelector_._select22704 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelector_.staticClass, "select", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelector_._select22704);
		}
		internal static global::MonoJavaBridge.MethodId _selectedKeys22705;
		public override global::java.util.Set selectedKeys()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.spi.AbstractSelector_._selectedKeys22705.native == global::System.IntPtr.Zero)
				global::java.nio.channels.spi.AbstractSelector_._selectedKeys22705 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelector_.staticClass, "selectedKeys", "()Ljava/util/Set;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelector_._selectedKeys22705)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _selectNow22706;
		public override int selectNow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.spi.AbstractSelector_._selectNow22706.native == global::System.IntPtr.Zero)
				global::java.nio.channels.spi.AbstractSelector_._selectNow22706 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelector_.staticClass, "selectNow", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelector_._selectNow22706);
		}
		internal static global::MonoJavaBridge.MethodId _wakeup22707;
		public override global::java.nio.channels.Selector wakeup()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.spi.AbstractSelector_._wakeup22707.native == global::System.IntPtr.Zero)
				global::java.nio.channels.spi.AbstractSelector_._wakeup22707 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelector_.staticClass, "wakeup", "()Ljava/nio/channels/Selector;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelector_._wakeup22707)) as java.nio.channels.Selector;
		}
		static AbstractSelector_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.spi.AbstractSelector_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/spi/AbstractSelector"));
		}
		internal static void InitJNI()
		{
		}
	}
}
