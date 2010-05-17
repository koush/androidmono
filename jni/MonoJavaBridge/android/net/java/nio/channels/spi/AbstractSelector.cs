namespace java.nio.channels.spi 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class AbstractSelector : java.nio.channels.Selector
	{ 
		internal new static global::java.lang.Class staticClass; 
		static AbstractSelector() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.nio.channels.spi.AbstractSelector), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected AbstractSelector(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _register11454; 
		protected abstract java.nio.channels.SelectionKey register(java.nio.channels.spi.AbstractSelectableChannel arg0, int arg1, java.lang.Object arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _provider11455; 
		public sealed override java.nio.channels.spi.SelectorProvider provider() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.spi.AbstractSelector)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.spi.SelectorProvider>(@__env, @__env.CallObjectMethodPtr(this, _provider11455)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.spi.SelectorProvider>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.channels.spi.AbstractSelector.staticClass, _provider11455)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close11456; 
		public sealed override void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.spi.AbstractSelector)) 
				@__env.CallVoidMethod(this, _close11456); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.nio.channels.spi.AbstractSelector.staticClass, _close11456); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isOpen11457; 
		public sealed override bool isOpen() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.spi.AbstractSelector)) 
				return @__env.CallBooleanMethod(this, _isOpen11457); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.channels.spi.AbstractSelector.staticClass, _isOpen11457); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _end11458; 
		protected virtual void end() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.spi.AbstractSelector)) 
				@__env.CallVoidMethod(this, _end11458); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.nio.channels.spi.AbstractSelector.staticClass, _end11458); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _begin11459; 
		protected virtual void begin() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.spi.AbstractSelector)) 
				@__env.CallVoidMethod(this, _begin11459); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.nio.channels.spi.AbstractSelector.staticClass, _begin11459); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cancelledKeys11460; 
		protected virtual java.util.Set cancelledKeys() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.spi.AbstractSelector)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, _cancelledKeys11460)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.channels.spi.AbstractSelector.staticClass, _cancelledKeys11460)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _implCloseSelector11461; 
		protected abstract void implCloseSelector(); 
		internal static global::net.sf.jni4net.jni.MethodId _deregister11462; 
		protected virtual void deregister(java.nio.channels.spi.AbstractSelectionKey arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.spi.AbstractSelector)) 
				@__env.CallVoidMethod(this, _deregister11462, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.nio.channels.spi.AbstractSelector.staticClass, _deregister11462, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AbstractSelector11463; 
		protected AbstractSelector(java.nio.channels.spi.SelectorProvider arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.nio.channels.spi.AbstractSelector.staticClass, _AbstractSelector11463, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.nio.channels.spi.AbstractSelector.staticClass = @__class; 
			global::java.nio.channels.spi.AbstractSelector._register11454 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelector.staticClass, "register", "(Ljava/nio/channels/spi/AbstractSelectableChannel;ILjava/lang/Object;)Ljava/nio/channels/SelectionKey;"); 
			global::java.nio.channels.spi.AbstractSelector._provider11455 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelector.staticClass, "provider", "()Ljava/nio/channels/spi/SelectorProvider;"); 
			global::java.nio.channels.spi.AbstractSelector._close11456 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelector.staticClass, "close", "()V"); 
			global::java.nio.channels.spi.AbstractSelector._isOpen11457 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelector.staticClass, "isOpen", "()Z"); 
			global::java.nio.channels.spi.AbstractSelector._end11458 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelector.staticClass, "end", "()V"); 
			global::java.nio.channels.spi.AbstractSelector._begin11459 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelector.staticClass, "begin", "()V"); 
			global::java.nio.channels.spi.AbstractSelector._cancelledKeys11460 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelector.staticClass, "cancelledKeys", "()Ljava/util/Set;"); 
			global::java.nio.channels.spi.AbstractSelector._implCloseSelector11461 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelector.staticClass, "implCloseSelector", "()V"); 
			global::java.nio.channels.spi.AbstractSelector._deregister11462 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelector.staticClass, "deregister", "(Ljava/nio/channels/spi/AbstractSelectionKey;)V"); 
			global::java.nio.channels.spi.AbstractSelector._AbstractSelector11463 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelector.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V"); 
		} 
	} 
} 
