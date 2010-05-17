namespace java.nio.channels 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class SelectionKey : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static SelectionKey() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.nio.channels.SelectionKey), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected SelectionKey(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _channel11389; 
		public abstract java.nio.channels.SelectableChannel channel(); 
		internal static global::net.sf.jni4net.jni.MethodId _isValid11390; 
		public abstract bool isValid(); 
		internal static global::net.sf.jni4net.jni.MethodId _cancel11391; 
		public abstract void cancel(); 
		internal static global::net.sf.jni4net.jni.MethodId _selector11392; 
		public abstract java.nio.channels.Selector selector(); 
		internal static global::net.sf.jni4net.jni.MethodId _interestOps11393; 
		public abstract int interestOps(); 
		internal static global::net.sf.jni4net.jni.MethodId _interestOps11394; 
		public abstract java.nio.channels.SelectionKey interestOps(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _attach11395; 
		public virtual java.lang.Object attach(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.SelectionKey)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _attach11395, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.channels.SelectionKey.staticClass, _attach11395, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _attachment11396; 
		public virtual java.lang.Object attachment() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.SelectionKey)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _attachment11396)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.channels.SelectionKey.staticClass, _attachment11396)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readyOps11397; 
		public abstract int readyOps(); 
		internal static global::net.sf.jni4net.jni.MethodId _isReadable11398; 
		public virtual bool isReadable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.SelectionKey)) 
				return @__env.CallBooleanMethod(this, _isReadable11398); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.channels.SelectionKey.staticClass, _isReadable11398); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isWritable11399; 
		public virtual bool isWritable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.SelectionKey)) 
				return @__env.CallBooleanMethod(this, _isWritable11399); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.channels.SelectionKey.staticClass, _isWritable11399); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isConnectable11400; 
		public virtual bool isConnectable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.SelectionKey)) 
				return @__env.CallBooleanMethod(this, _isConnectable11400); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.channels.SelectionKey.staticClass, _isConnectable11400); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAcceptable11401; 
		public virtual bool isAcceptable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.SelectionKey)) 
				return @__env.CallBooleanMethod(this, _isAcceptable11401); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.channels.SelectionKey.staticClass, _isAcceptable11401); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SelectionKey11402; 
		protected SelectionKey()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.nio.channels.SelectionKey.staticClass, _SelectionKey11402, this); 
		} 
		public static int OP_READ
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int OP_WRITE
		{ 
			get 
			{ 
				return 4; 
			} 
		} 
		public static int OP_CONNECT
		{ 
			get 
			{ 
				return 8; 
			} 
		} 
		public static int OP_ACCEPT
		{ 
			get 
			{ 
				return 16; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.nio.channels.SelectionKey.staticClass = @__class; 
			global::java.nio.channels.SelectionKey._channel11389 = @__env.GetMethodID(global::java.nio.channels.SelectionKey.staticClass, "channel", "()Ljava/nio/channels/SelectableChannel;"); 
			global::java.nio.channels.SelectionKey._isValid11390 = @__env.GetMethodID(global::java.nio.channels.SelectionKey.staticClass, "isValid", "()Z"); 
			global::java.nio.channels.SelectionKey._cancel11391 = @__env.GetMethodID(global::java.nio.channels.SelectionKey.staticClass, "cancel", "()V"); 
			global::java.nio.channels.SelectionKey._selector11392 = @__env.GetMethodID(global::java.nio.channels.SelectionKey.staticClass, "selector", "()Ljava/nio/channels/Selector;"); 
			global::java.nio.channels.SelectionKey._interestOps11393 = @__env.GetMethodID(global::java.nio.channels.SelectionKey.staticClass, "interestOps", "()I"); 
			global::java.nio.channels.SelectionKey._interestOps11394 = @__env.GetMethodID(global::java.nio.channels.SelectionKey.staticClass, "interestOps", "(I)Ljava/nio/channels/SelectionKey;"); 
			global::java.nio.channels.SelectionKey._attach11395 = @__env.GetMethodID(global::java.nio.channels.SelectionKey.staticClass, "attach", "(Ljava/lang/Object;)Ljava/lang/Object;"); 
			global::java.nio.channels.SelectionKey._attachment11396 = @__env.GetMethodID(global::java.nio.channels.SelectionKey.staticClass, "attachment", "()Ljava/lang/Object;"); 
			global::java.nio.channels.SelectionKey._readyOps11397 = @__env.GetMethodID(global::java.nio.channels.SelectionKey.staticClass, "readyOps", "()I"); 
			global::java.nio.channels.SelectionKey._isReadable11398 = @__env.GetMethodID(global::java.nio.channels.SelectionKey.staticClass, "isReadable", "()Z"); 
			global::java.nio.channels.SelectionKey._isWritable11399 = @__env.GetMethodID(global::java.nio.channels.SelectionKey.staticClass, "isWritable", "()Z"); 
			global::java.nio.channels.SelectionKey._isConnectable11400 = @__env.GetMethodID(global::java.nio.channels.SelectionKey.staticClass, "isConnectable", "()Z"); 
			global::java.nio.channels.SelectionKey._isAcceptable11401 = @__env.GetMethodID(global::java.nio.channels.SelectionKey.staticClass, "isAcceptable", "()Z"); 
			global::java.nio.channels.SelectionKey._SelectionKey11402 = @__env.GetMethodID(global::java.nio.channels.SelectionKey.staticClass, "<init>", "()V"); 
		} 
	} 
} 
