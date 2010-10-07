namespace java.nio.channels.spi
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class AbstractSelector : java.nio.channels.Selector
	{
		internal new static global::java.lang.Class staticClass;
		static AbstractSelector()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.nio.channels.spi.AbstractSelector), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected AbstractSelector(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _register13047;
		protected abstract global::java.nio.channels.SelectionKey register(java.nio.channels.spi.AbstractSelectableChannel arg0, int arg1, java.lang.Object arg2);
		internal static global::net.sf.jni4net.jni.MethodId _provider13048;
		public sealed override global::java.nio.channels.spi.SelectorProvider provider() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.spi.SelectorProvider>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.channels.spi.AbstractSelector._provider13048));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.spi.SelectorProvider>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.channels.spi.AbstractSelector.staticClass, global::java.nio.channels.spi.AbstractSelector._provider13048));
		}
		internal static global::net.sf.jni4net.jni.MethodId _close13049;
		public sealed override void close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.nio.channels.spi.AbstractSelector._close13049);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.nio.channels.spi.AbstractSelector.staticClass, global::java.nio.channels.spi.AbstractSelector._close13049);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isOpen13050;
		public sealed override bool isOpen() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.nio.channels.spi.AbstractSelector._isOpen13050);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.channels.spi.AbstractSelector.staticClass, global::java.nio.channels.spi.AbstractSelector._isOpen13050);
		}
		internal static global::net.sf.jni4net.jni.MethodId _end13051;
		protected virtual void end() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.nio.channels.spi.AbstractSelector._end13051);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.nio.channels.spi.AbstractSelector.staticClass, global::java.nio.channels.spi.AbstractSelector._end13051);
		}
		internal static global::net.sf.jni4net.jni.MethodId _begin13052;
		protected virtual void begin() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.nio.channels.spi.AbstractSelector._begin13052);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.nio.channels.spi.AbstractSelector.staticClass, global::java.nio.channels.spi.AbstractSelector._begin13052);
		}
		internal static global::net.sf.jni4net.jni.MethodId _cancelledKeys13053;
		protected virtual global::java.util.Set cancelledKeys() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.channels.spi.AbstractSelector._cancelledKeys13053));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.channels.spi.AbstractSelector.staticClass, global::java.nio.channels.spi.AbstractSelector._cancelledKeys13053));
		}
		internal static global::net.sf.jni4net.jni.MethodId _implCloseSelector13054;
		protected abstract void implCloseSelector();
		internal static global::net.sf.jni4net.jni.MethodId _deregister13055;
		protected virtual void deregister(java.nio.channels.spi.AbstractSelectionKey arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.nio.channels.spi.AbstractSelector._deregister13055, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.nio.channels.spi.AbstractSelector.staticClass, global::java.nio.channels.spi.AbstractSelector._deregister13055, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AbstractSelector13056;
		protected AbstractSelector(java.nio.channels.spi.SelectorProvider arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.nio.channels.spi.AbstractSelector.staticClass, global::java.nio.channels.spi.AbstractSelector._AbstractSelector13056, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.nio.channels.spi.AbstractSelector.staticClass = @__class;
			global::java.nio.channels.spi.AbstractSelector._register13047 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelector.staticClass, "register", "(Ljava/nio/channels/spi/AbstractSelectableChannel;ILjava/lang/Object;)Ljava/nio/channels/SelectionKey;");
			global::java.nio.channels.spi.AbstractSelector._provider13048 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelector.staticClass, "provider", "()Ljava/nio/channels/spi/SelectorProvider;");
			global::java.nio.channels.spi.AbstractSelector._close13049 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelector.staticClass, "close", "()V");
			global::java.nio.channels.spi.AbstractSelector._isOpen13050 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelector.staticClass, "isOpen", "()Z");
			global::java.nio.channels.spi.AbstractSelector._end13051 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelector.staticClass, "end", "()V");
			global::java.nio.channels.spi.AbstractSelector._begin13052 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelector.staticClass, "begin", "()V");
			global::java.nio.channels.spi.AbstractSelector._cancelledKeys13053 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelector.staticClass, "cancelledKeys", "()Ljava/util/Set;");
			global::java.nio.channels.spi.AbstractSelector._implCloseSelector13054 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelector.staticClass, "implCloseSelector", "()V");
			global::java.nio.channels.spi.AbstractSelector._deregister13055 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelector.staticClass, "deregister", "(Ljava/nio/channels/spi/AbstractSelectionKey;)V");
			global::java.nio.channels.spi.AbstractSelector._AbstractSelector13056 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelector.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V");
		}
	}
}
