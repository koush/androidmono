namespace java.nio.channels.spi 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class AbstractSelectableChannel : java.nio.channels.SelectableChannel
	{ 
		internal new static global::java.lang.Class staticClass; 
		static AbstractSelectableChannel() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.nio.channels.spi.AbstractSelectableChannel), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected AbstractSelectableChannel(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _register11440; 
		public sealed override java.nio.channels.SelectionKey register(java.nio.channels.Selector arg0, int arg1, java.lang.Object arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.spi.AbstractSelectableChannel)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.SelectionKey>(@__env, @__env.CallObjectMethodPtr(this, _register11440, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.SelectionKey>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.channels.spi.AbstractSelectableChannel.staticClass, _register11440, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _provider11441; 
		public sealed override java.nio.channels.spi.SelectorProvider provider() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.spi.AbstractSelectableChannel)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.spi.SelectorProvider>(@__env, @__env.CallObjectMethodPtr(this, _provider11441)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.spi.SelectorProvider>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.channels.spi.AbstractSelectableChannel.staticClass, _provider11441)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isRegistered11442; 
		public sealed override bool isRegistered() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.spi.AbstractSelectableChannel)) 
				return @__env.CallBooleanMethod(this, _isRegistered11442); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.channels.spi.AbstractSelectableChannel.staticClass, _isRegistered11442); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isBlocking11443; 
		public sealed override bool isBlocking() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.spi.AbstractSelectableChannel)) 
				return @__env.CallBooleanMethod(this, _isBlocking11443); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.channels.spi.AbstractSelectableChannel.staticClass, _isBlocking11443); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _implCloseChannel11444; 
		protected sealed override void implCloseChannel() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.spi.AbstractSelectableChannel)) 
				@__env.CallVoidMethod(this, _implCloseChannel11444); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.nio.channels.spi.AbstractSelectableChannel.staticClass, _implCloseChannel11444); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _keyFor11445; 
		public sealed override java.nio.channels.SelectionKey keyFor(java.nio.channels.Selector arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.spi.AbstractSelectableChannel)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.SelectionKey>(@__env, @__env.CallObjectMethodPtr(this, _keyFor11445, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.SelectionKey>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.channels.spi.AbstractSelectableChannel.staticClass, _keyFor11445, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _implCloseSelectableChannel11446; 
		protected abstract void implCloseSelectableChannel(); 
		internal static global::net.sf.jni4net.jni.MethodId _blockingLock11447; 
		public sealed override java.lang.Object blockingLock() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.spi.AbstractSelectableChannel)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _blockingLock11447)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.channels.spi.AbstractSelectableChannel.staticClass, _blockingLock11447)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _configureBlocking11448; 
		public sealed override java.nio.channels.SelectableChannel configureBlocking(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.spi.AbstractSelectableChannel)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.SelectableChannel>(@__env, @__env.CallObjectMethodPtr(this, _configureBlocking11448, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.SelectableChannel>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.channels.spi.AbstractSelectableChannel.staticClass, _configureBlocking11448, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _implConfigureBlocking11449; 
		protected abstract void implConfigureBlocking(bool arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _AbstractSelectableChannel11450; 
		protected AbstractSelectableChannel(java.nio.channels.spi.SelectorProvider arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.nio.channels.spi.AbstractSelectableChannel.staticClass, _AbstractSelectableChannel11450, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.nio.channels.spi.AbstractSelectableChannel.staticClass = @__class; 
			global::java.nio.channels.spi.AbstractSelectableChannel._register11440 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "register", "(Ljava/nio/channels/Selector;ILjava/lang/Object;)Ljava/nio/channels/SelectionKey;"); 
			global::java.nio.channels.spi.AbstractSelectableChannel._provider11441 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "provider", "()Ljava/nio/channels/spi/SelectorProvider;"); 
			global::java.nio.channels.spi.AbstractSelectableChannel._isRegistered11442 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "isRegistered", "()Z"); 
			global::java.nio.channels.spi.AbstractSelectableChannel._isBlocking11443 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "isBlocking", "()Z"); 
			global::java.nio.channels.spi.AbstractSelectableChannel._implCloseChannel11444 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "implCloseChannel", "()V"); 
			global::java.nio.channels.spi.AbstractSelectableChannel._keyFor11445 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "keyFor", "(Ljava/nio/channels/Selector;)Ljava/nio/channels/SelectionKey;"); 
			global::java.nio.channels.spi.AbstractSelectableChannel._implCloseSelectableChannel11446 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "implCloseSelectableChannel", "()V"); 
			global::java.nio.channels.spi.AbstractSelectableChannel._blockingLock11447 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "blockingLock", "()Ljava/lang/Object;"); 
			global::java.nio.channels.spi.AbstractSelectableChannel._configureBlocking11448 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "configureBlocking", "(Z)Ljava/nio/channels/SelectableChannel;"); 
			global::java.nio.channels.spi.AbstractSelectableChannel._implConfigureBlocking11449 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "implConfigureBlocking", "(Z)V"); 
			global::java.nio.channels.spi.AbstractSelectableChannel._AbstractSelectableChannel11450 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelectableChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V"); 
		} 
	} 
} 
