namespace java.nio.channels 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class SelectableChannel : java.nio.channels.spi.AbstractInterruptibleChannel, Channel
	{ 
		internal new static global::java.lang.Class staticClass; 
		static SelectableChannel() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.nio.channels.SelectableChannel), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected SelectableChannel(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _register11379; 
		public abstract java.nio.channels.SelectionKey register(java.nio.channels.Selector arg0, int arg1, java.lang.Object arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _register11380; 
		public virtual java.nio.channels.SelectionKey register(java.nio.channels.Selector arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.SelectableChannel)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.SelectionKey>(@__env, @__env.CallObjectMethodPtr(this, _register11380, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.SelectionKey>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.channels.SelectableChannel.staticClass, _register11380, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _provider11381; 
		public abstract java.nio.channels.spi.SelectorProvider provider(); 
		internal static global::net.sf.jni4net.jni.MethodId _isRegistered11382; 
		public abstract bool isRegistered(); 
		internal static global::net.sf.jni4net.jni.MethodId _isBlocking11383; 
		public abstract bool isBlocking(); 
		internal static global::net.sf.jni4net.jni.MethodId _keyFor11384; 
		public abstract java.nio.channels.SelectionKey keyFor(java.nio.channels.Selector arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _validOps11385; 
		public abstract int validOps(); 
		internal static global::net.sf.jni4net.jni.MethodId _blockingLock11386; 
		public abstract java.lang.Object blockingLock(); 
		internal static global::net.sf.jni4net.jni.MethodId _configureBlocking11387; 
		public abstract java.nio.channels.SelectableChannel configureBlocking(bool arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _SelectableChannel11388; 
		protected SelectableChannel()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.nio.channels.SelectableChannel.staticClass, _SelectableChannel11388, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.nio.channels.SelectableChannel.staticClass = @__class; 
			global::java.nio.channels.SelectableChannel._register11379 = @__env.GetMethodID(global::java.nio.channels.SelectableChannel.staticClass, "register", "(Ljava/nio/channels/Selector;ILjava/lang/Object;)Ljava/nio/channels/SelectionKey;"); 
			global::java.nio.channels.SelectableChannel._register11380 = @__env.GetMethodID(global::java.nio.channels.SelectableChannel.staticClass, "register", "(Ljava/nio/channels/Selector;I)Ljava/nio/channels/SelectionKey;"); 
			global::java.nio.channels.SelectableChannel._provider11381 = @__env.GetMethodID(global::java.nio.channels.SelectableChannel.staticClass, "provider", "()Ljava/nio/channels/spi/SelectorProvider;"); 
			global::java.nio.channels.SelectableChannel._isRegistered11382 = @__env.GetMethodID(global::java.nio.channels.SelectableChannel.staticClass, "isRegistered", "()Z"); 
			global::java.nio.channels.SelectableChannel._isBlocking11383 = @__env.GetMethodID(global::java.nio.channels.SelectableChannel.staticClass, "isBlocking", "()Z"); 
			global::java.nio.channels.SelectableChannel._keyFor11384 = @__env.GetMethodID(global::java.nio.channels.SelectableChannel.staticClass, "keyFor", "(Ljava/nio/channels/Selector;)Ljava/nio/channels/SelectionKey;"); 
			global::java.nio.channels.SelectableChannel._validOps11385 = @__env.GetMethodID(global::java.nio.channels.SelectableChannel.staticClass, "validOps", "()I"); 
			global::java.nio.channels.SelectableChannel._blockingLock11386 = @__env.GetMethodID(global::java.nio.channels.SelectableChannel.staticClass, "blockingLock", "()Ljava/lang/Object;"); 
			global::java.nio.channels.SelectableChannel._configureBlocking11387 = @__env.GetMethodID(global::java.nio.channels.SelectableChannel.staticClass, "configureBlocking", "(Z)Ljava/nio/channels/SelectableChannel;"); 
			global::java.nio.channels.SelectableChannel._SelectableChannel11388 = @__env.GetMethodID(global::java.nio.channels.SelectableChannel.staticClass, "<init>", "()V"); 
		} 
	} 
} 
