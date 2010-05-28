namespace java.nio.channels.spi 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class AbstractSelectableChannel : java.nio.channels.SelectableChannel
	{ 
		internal new static global::java.lang.Class staticClass; 
		static AbstractSelectableChannel() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.nio.channels.spi.AbstractSelectableChannel), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected AbstractSelectableChannel(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _register12304; 
		public sealed override global::java.nio.channels.SelectionKey register(java.nio.channels.Selector arg0, int arg1, java.lang.Object arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.spi.AbstractSelectableChannel)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.SelectionKey>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.channels.spi.AbstractSelectableChannel._register12304, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.SelectionKey>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, global::java.nio.channels.spi.AbstractSelectableChannel._register12304, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _provider12305; 
		public sealed override global::java.nio.channels.spi.SelectorProvider provider() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.spi.AbstractSelectableChannel)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.spi.SelectorProvider>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.channels.spi.AbstractSelectableChannel._provider12305)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.spi.SelectorProvider>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, global::java.nio.channels.spi.AbstractSelectableChannel._provider12305)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isRegistered12306; 
		public sealed override bool isRegistered() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.spi.AbstractSelectableChannel)) 
				return @__env.CallBooleanMethod(this, global::java.nio.channels.spi.AbstractSelectableChannel._isRegistered12306); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, global::java.nio.channels.spi.AbstractSelectableChannel._isRegistered12306); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isBlocking12307; 
		public sealed override bool isBlocking() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.spi.AbstractSelectableChannel)) 
				return @__env.CallBooleanMethod(this, global::java.nio.channels.spi.AbstractSelectableChannel._isBlocking12307); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, global::java.nio.channels.spi.AbstractSelectableChannel._isBlocking12307); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _implCloseChannel12308; 
		protected sealed override void implCloseChannel() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.spi.AbstractSelectableChannel)) 
				@__env.CallVoidMethod(this, global::java.nio.channels.spi.AbstractSelectableChannel._implCloseChannel12308); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, global::java.nio.channels.spi.AbstractSelectableChannel._implCloseChannel12308); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _keyFor12309; 
		public sealed override global::java.nio.channels.SelectionKey keyFor(java.nio.channels.Selector arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.spi.AbstractSelectableChannel)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.SelectionKey>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.channels.spi.AbstractSelectableChannel._keyFor12309, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.SelectionKey>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, global::java.nio.channels.spi.AbstractSelectableChannel._keyFor12309, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _implCloseSelectableChannel12310; 
		protected abstract void implCloseSelectableChannel(); 
		internal static global::net.sf.jni4net.jni.MethodId _blockingLock12311; 
		public sealed override global::java.lang.Object blockingLock() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.spi.AbstractSelectableChannel)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.channels.spi.AbstractSelectableChannel._blockingLock12311)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, global::java.nio.channels.spi.AbstractSelectableChannel._blockingLock12311)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _configureBlocking12312; 
		public sealed override global::java.nio.channels.SelectableChannel configureBlocking(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.spi.AbstractSelectableChannel)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.SelectableChannel>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.channels.spi.AbstractSelectableChannel._configureBlocking12312, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.SelectableChannel>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, global::java.nio.channels.spi.AbstractSelectableChannel._configureBlocking12312, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _implConfigureBlocking12313; 
		protected abstract void implConfigureBlocking(bool arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _AbstractSelectableChannel12314; 
		protected AbstractSelectableChannel(java.nio.channels.spi.SelectorProvider arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.nio.channels.spi.AbstractSelectableChannel.staticClass, global::java.nio.channels.spi.AbstractSelectableChannel._AbstractSelectableChannel12314, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.nio.channels.spi.AbstractSelectableChannel.staticClass = @__class; 
			global::java.nio.channels.spi.AbstractSelectableChannel._register12304 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "register", "(Ljava/nio/channels/Selector;ILjava/lang/Object;)Ljava/nio/channels/SelectionKey;"); 
			global::java.nio.channels.spi.AbstractSelectableChannel._provider12305 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "provider", "()Ljava/nio/channels/spi/SelectorProvider;"); 
			global::java.nio.channels.spi.AbstractSelectableChannel._isRegistered12306 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "isRegistered", "()Z"); 
			global::java.nio.channels.spi.AbstractSelectableChannel._isBlocking12307 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "isBlocking", "()Z"); 
			global::java.nio.channels.spi.AbstractSelectableChannel._implCloseChannel12308 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "implCloseChannel", "()V"); 
			global::java.nio.channels.spi.AbstractSelectableChannel._keyFor12309 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "keyFor", "(Ljava/nio/channels/Selector;)Ljava/nio/channels/SelectionKey;"); 
			global::java.nio.channels.spi.AbstractSelectableChannel._implCloseSelectableChannel12310 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "implCloseSelectableChannel", "()V"); 
			global::java.nio.channels.spi.AbstractSelectableChannel._blockingLock12311 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "blockingLock", "()Ljava/lang/Object;"); 
			global::java.nio.channels.spi.AbstractSelectableChannel._configureBlocking12312 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "configureBlocking", "(Z)Ljava/nio/channels/SelectableChannel;"); 
			global::java.nio.channels.spi.AbstractSelectableChannel._implConfigureBlocking12313 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "implConfigureBlocking", "(Z)V"); 
			global::java.nio.channels.spi.AbstractSelectableChannel._AbstractSelectableChannel12314 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V"); 
		} 
	} 
} 
