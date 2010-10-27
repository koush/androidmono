namespace java.nio.channels.spi
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.spi.AbstractSelector_))]
	public abstract partial class AbstractSelector : java.nio.channels.Selector
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractSelector()
		{
			InitJNI();
		}
		protected AbstractSelector(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _register22689;
		protected abstract global::java.nio.channels.SelectionKey register(java.nio.channels.spi.AbstractSelectableChannel arg0, int arg1, java.lang.Object arg2);
		internal static global::MonoJavaBridge.MethodId _provider22690;
		public sealed override global::java.nio.channels.spi.SelectorProvider provider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelector._provider22690)) as java.nio.channels.spi.SelectorProvider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelector.staticClass, global::java.nio.channels.spi.AbstractSelector._provider22690)) as java.nio.channels.spi.SelectorProvider;
		}
		internal static global::MonoJavaBridge.MethodId _close22691;
		public sealed override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelector._close22691);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelector.staticClass, global::java.nio.channels.spi.AbstractSelector._close22691);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen22692;
		public sealed override bool isOpen()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelector._isOpen22692);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelector.staticClass, global::java.nio.channels.spi.AbstractSelector._isOpen22692);
		}
		internal static global::MonoJavaBridge.MethodId _end22693;
		protected virtual void end()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelector._end22693);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelector.staticClass, global::java.nio.channels.spi.AbstractSelector._end22693);
		}
		internal static global::MonoJavaBridge.MethodId _begin22694;
		protected virtual void begin()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelector._begin22694);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelector.staticClass, global::java.nio.channels.spi.AbstractSelector._begin22694);
		}
		internal static global::MonoJavaBridge.MethodId _cancelledKeys22695;
		protected virtual global::java.util.Set cancelledKeys()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelector._cancelledKeys22695)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelector.staticClass, global::java.nio.channels.spi.AbstractSelector._cancelledKeys22695)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _implCloseSelector22696;
		protected abstract void implCloseSelector();
		internal static global::MonoJavaBridge.MethodId _deregister22697;
		protected virtual void deregister(java.nio.channels.spi.AbstractSelectionKey arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelector._deregister22697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelector.staticClass, global::java.nio.channels.spi.AbstractSelector._deregister22697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AbstractSelector22698;
		protected AbstractSelector(java.nio.channels.spi.SelectorProvider arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.spi.AbstractSelector.staticClass, global::java.nio.channels.spi.AbstractSelector._AbstractSelector22698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.spi.AbstractSelector.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/spi/AbstractSelector"));
			global::java.nio.channels.spi.AbstractSelector._register22689 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelector.staticClass, "register", "(Ljava/nio/channels/spi/AbstractSelectableChannel;ILjava/lang/Object;)Ljava/nio/channels/SelectionKey;");
			global::java.nio.channels.spi.AbstractSelector._provider22690 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelector.staticClass, "provider", "()Ljava/nio/channels/spi/SelectorProvider;");
			global::java.nio.channels.spi.AbstractSelector._close22691 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelector.staticClass, "close", "()V");
			global::java.nio.channels.spi.AbstractSelector._isOpen22692 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelector.staticClass, "isOpen", "()Z");
			global::java.nio.channels.spi.AbstractSelector._end22693 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelector.staticClass, "end", "()V");
			global::java.nio.channels.spi.AbstractSelector._begin22694 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelector.staticClass, "begin", "()V");
			global::java.nio.channels.spi.AbstractSelector._cancelledKeys22695 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelector.staticClass, "cancelledKeys", "()Ljava/util/Set;");
			global::java.nio.channels.spi.AbstractSelector._implCloseSelector22696 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelector.staticClass, "implCloseSelector", "()V");
			global::java.nio.channels.spi.AbstractSelector._deregister22697 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelector.staticClass, "deregister", "(Ljava/nio/channels/spi/AbstractSelectionKey;)V");
			global::java.nio.channels.spi.AbstractSelector._AbstractSelector22698 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelector.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.spi.AbstractSelector))]
	internal sealed partial class AbstractSelector_ : java.nio.channels.spi.AbstractSelector
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractSelector_()
		{
			InitJNI();
		}
		internal AbstractSelector_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _register22699;
		protected override global::java.nio.channels.SelectionKey register(java.nio.channels.spi.AbstractSelectableChannel arg0, int arg1, java.lang.Object arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelector_._register22699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.channels.SelectionKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelector_.staticClass, global::java.nio.channels.spi.AbstractSelector_._register22699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.channels.SelectionKey;
		}
		internal static global::MonoJavaBridge.MethodId _implCloseSelector22700;
		protected override void implCloseSelector()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelector_._implCloseSelector22700);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelector_.staticClass, global::java.nio.channels.spi.AbstractSelector_._implCloseSelector22700);
		}
		internal static global::MonoJavaBridge.MethodId _keys22701;
		public override global::java.util.Set keys()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelector_._keys22701)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelector_.staticClass, global::java.nio.channels.spi.AbstractSelector_._keys22701)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _select22702;
		public override int select(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelector_._select22702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelector_.staticClass, global::java.nio.channels.spi.AbstractSelector_._select22702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _select22703;
		public override int select()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelector_._select22703);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelector_.staticClass, global::java.nio.channels.spi.AbstractSelector_._select22703);
		}
		internal static global::MonoJavaBridge.MethodId _selectedKeys22704;
		public override global::java.util.Set selectedKeys()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelector_._selectedKeys22704)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelector_.staticClass, global::java.nio.channels.spi.AbstractSelector_._selectedKeys22704)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _selectNow22705;
		public override int selectNow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelector_._selectNow22705);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelector_.staticClass, global::java.nio.channels.spi.AbstractSelector_._selectNow22705);
		}
		internal static global::MonoJavaBridge.MethodId _wakeup22706;
		public override global::java.nio.channels.Selector wakeup()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelector_._wakeup22706)) as java.nio.channels.Selector;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.spi.AbstractSelector_.staticClass, global::java.nio.channels.spi.AbstractSelector_._wakeup22706)) as java.nio.channels.Selector;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.spi.AbstractSelector_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/spi/AbstractSelector"));
			global::java.nio.channels.spi.AbstractSelector_._register22699 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelector_.staticClass, "register", "(Ljava/nio/channels/spi/AbstractSelectableChannel;ILjava/lang/Object;)Ljava/nio/channels/SelectionKey;");
			global::java.nio.channels.spi.AbstractSelector_._implCloseSelector22700 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelector_.staticClass, "implCloseSelector", "()V");
			global::java.nio.channels.spi.AbstractSelector_._keys22701 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelector_.staticClass, "keys", "()Ljava/util/Set;");
			global::java.nio.channels.spi.AbstractSelector_._select22702 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelector_.staticClass, "select", "(J)I");
			global::java.nio.channels.spi.AbstractSelector_._select22703 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelector_.staticClass, "select", "()I");
			global::java.nio.channels.spi.AbstractSelector_._selectedKeys22704 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelector_.staticClass, "selectedKeys", "()Ljava/util/Set;");
			global::java.nio.channels.spi.AbstractSelector_._selectNow22705 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelector_.staticClass, "selectNow", "()I");
			global::java.nio.channels.spi.AbstractSelector_._wakeup22706 = @__env.GetMethodIDNoThrow(global::java.nio.channels.spi.AbstractSelector_.staticClass, "wakeup", "()Ljava/nio/channels/Selector;");
		}
	}
}
