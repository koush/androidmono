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
		internal static global::net.sf.jni4net.jni.MethodId _register12318;
		protected abstract global::java.nio.channels.SelectionKey register(java.nio.channels.spi.AbstractSelectableChannel arg0, int arg1, java.lang.Object arg2);
		internal static global::net.sf.jni4net.jni.MethodId _provider12319;
		public sealed override global::java.nio.channels.spi.SelectorProvider provider() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.spi.SelectorProvider>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.channels.spi.AbstractSelector._provider12319));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.spi.SelectorProvider>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.channels.spi.AbstractSelector.staticClass, global::java.nio.channels.spi.AbstractSelector._provider12319));
		}
		internal static global::net.sf.jni4net.jni.MethodId _close12320;
		public sealed override void close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.nio.channels.spi.AbstractSelector._close12320);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.nio.channels.spi.AbstractSelector.staticClass, global::java.nio.channels.spi.AbstractSelector._close12320);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isOpen12321;
		public sealed override bool isOpen() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.nio.channels.spi.AbstractSelector._isOpen12321);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.channels.spi.AbstractSelector.staticClass, global::java.nio.channels.spi.AbstractSelector._isOpen12321);
		}
		internal static global::net.sf.jni4net.jni.MethodId _end12322;
		protected virtual void end() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.nio.channels.spi.AbstractSelector._end12322);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.nio.channels.spi.AbstractSelector.staticClass, global::java.nio.channels.spi.AbstractSelector._end12322);
		}
		internal static global::net.sf.jni4net.jni.MethodId _begin12323;
		protected virtual void begin() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.nio.channels.spi.AbstractSelector._begin12323);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.nio.channels.spi.AbstractSelector.staticClass, global::java.nio.channels.spi.AbstractSelector._begin12323);
		}
		internal static global::net.sf.jni4net.jni.MethodId _cancelledKeys12324;
		protected virtual global::java.util.Set cancelledKeys() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.channels.spi.AbstractSelector._cancelledKeys12324));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.channels.spi.AbstractSelector.staticClass, global::java.nio.channels.spi.AbstractSelector._cancelledKeys12324));
		}
		internal static global::net.sf.jni4net.jni.MethodId _implCloseSelector12325;
		protected abstract void implCloseSelector();
		internal static global::net.sf.jni4net.jni.MethodId _deregister12326;
		protected virtual void deregister(java.nio.channels.spi.AbstractSelectionKey arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.nio.channels.spi.AbstractSelector._deregister12326, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.nio.channels.spi.AbstractSelector.staticClass, global::java.nio.channels.spi.AbstractSelector._deregister12326, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AbstractSelector12327;
		protected AbstractSelector(java.nio.channels.spi.SelectorProvider arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.nio.channels.spi.AbstractSelector.staticClass, global::java.nio.channels.spi.AbstractSelector._AbstractSelector12327, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.nio.channels.spi.AbstractSelector.staticClass = @__class;
			global::java.nio.channels.spi.AbstractSelector._register12318 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelector.staticClass, "register", "(Ljava/nio/channels/spi/AbstractSelectableChannel;ILjava/lang/Object;)Ljava/nio/channels/SelectionKey;");
			global::java.nio.channels.spi.AbstractSelector._provider12319 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelector.staticClass, "provider", "()Ljava/nio/channels/spi/SelectorProvider;");
			global::java.nio.channels.spi.AbstractSelector._close12320 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelector.staticClass, "close", "()V");
			global::java.nio.channels.spi.AbstractSelector._isOpen12321 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelector.staticClass, "isOpen", "()Z");
			global::java.nio.channels.spi.AbstractSelector._end12322 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelector.staticClass, "end", "()V");
			global::java.nio.channels.spi.AbstractSelector._begin12323 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelector.staticClass, "begin", "()V");
			global::java.nio.channels.spi.AbstractSelector._cancelledKeys12324 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelector.staticClass, "cancelledKeys", "()Ljava/util/Set;");
			global::java.nio.channels.spi.AbstractSelector._implCloseSelector12325 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelector.staticClass, "implCloseSelector", "()V");
			global::java.nio.channels.spi.AbstractSelector._deregister12326 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelector.staticClass, "deregister", "(Ljava/nio/channels/spi/AbstractSelectionKey;)V");
			global::java.nio.channels.spi.AbstractSelector._AbstractSelector12327 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelector.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V");
		}
	}
}
