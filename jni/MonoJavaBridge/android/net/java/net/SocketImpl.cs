namespace java.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class SocketImpl : java.lang.Object, SocketOptions
	{ 
		internal static global::java.lang.Class staticClass; 
		static SocketImpl() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.net.SocketImpl), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected SocketImpl(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOption11042; 
		public abstract java.lang.Object getOption(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setOption11043; 
		public abstract void setOption(int arg0, java.lang.Object arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _toString11044; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.SocketImpl)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString11044)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.SocketImpl.staticClass, _toString11044)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close11045; 
		protected abstract void close(); 
		internal static global::net.sf.jni4net.jni.MethodId _accept11046; 
		protected abstract void accept(java.net.SocketImpl arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _available11047; 
		protected abstract int available(); 
		internal static global::net.sf.jni4net.jni.MethodId _getPort11048; 
		protected virtual int getPort() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.SocketImpl)) 
				return @__env.CallIntMethod(this, _getPort11048); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.SocketImpl.staticClass, _getPort11048); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _create11049; 
		protected abstract void create(bool arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getInputStream11050; 
		protected abstract java.io.InputStream getInputStream(); 
		internal static global::net.sf.jni4net.jni.MethodId _connect11051; 
		protected abstract void connect(java.net.SocketAddress arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _connect11052; 
		protected abstract void connect(java.lang.String arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _connect11053; 
		protected abstract void connect(java.net.InetAddress arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _getOutputStream11054; 
		protected abstract java.io.OutputStream getOutputStream(); 
		internal static global::net.sf.jni4net.jni.MethodId _getFileDescriptor11055; 
		protected virtual java.io.FileDescriptor getFileDescriptor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.SocketImpl)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, _getFileDescriptor11055)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.SocketImpl.staticClass, _getFileDescriptor11055)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _listen11056; 
		protected abstract void listen(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _bind11057; 
		protected abstract void bind(java.net.InetAddress arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _shutdownInput11058; 
		protected virtual void shutdownInput() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.SocketImpl)) 
				@__env.CallVoidMethod(this, _shutdownInput11058); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.SocketImpl.staticClass, _shutdownInput11058); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _shutdownOutput11059; 
		protected virtual void shutdownOutput() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.SocketImpl)) 
				@__env.CallVoidMethod(this, _shutdownOutput11059); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.SocketImpl.staticClass, _shutdownOutput11059); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInetAddress11060; 
		protected virtual java.net.InetAddress getInetAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.SocketImpl)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallObjectMethodPtr(this, _getInetAddress11060)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.SocketImpl.staticClass, _getInetAddress11060)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocalPort11061; 
		protected virtual int getLocalPort() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.SocketImpl)) 
				return @__env.CallIntMethod(this, _getLocalPort11061); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.SocketImpl.staticClass, _getLocalPort11061); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendUrgentData11062; 
		protected abstract void sendUrgentData(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setPerformancePreferences11063; 
		protected virtual void setPerformancePreferences(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.SocketImpl)) 
				@__env.CallVoidMethod(this, _setPerformancePreferences11063, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.SocketImpl.staticClass, _setPerformancePreferences11063, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _supportsUrgentData11064; 
		protected virtual bool supportsUrgentData() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.SocketImpl)) 
				return @__env.CallBooleanMethod(this, _supportsUrgentData11064); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.SocketImpl.staticClass, _supportsUrgentData11064); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SocketImpl11065; 
		public SocketImpl()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.SocketImpl.staticClass, _SocketImpl11065, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.net.SocketImpl.staticClass = @__class; 
			global::java.net.SocketImpl._getOption11042 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "getOption", "(I)Ljava/lang/Object;"); 
			global::java.net.SocketImpl._setOption11043 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "setOption", "(ILjava/lang/Object;)V"); 
			global::java.net.SocketImpl._toString11044 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.net.SocketImpl._close11045 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "close", "()V"); 
			global::java.net.SocketImpl._accept11046 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "accept", "(Ljava/net/SocketImpl;)V"); 
			global::java.net.SocketImpl._available11047 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "available", "()I"); 
			global::java.net.SocketImpl._getPort11048 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "getPort", "()I"); 
			global::java.net.SocketImpl._create11049 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "create", "(Z)V"); 
			global::java.net.SocketImpl._getInputStream11050 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "getInputStream", "()Ljava/io/InputStream;"); 
			global::java.net.SocketImpl._connect11051 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "connect", "(Ljava/net/SocketAddress;I)V"); 
			global::java.net.SocketImpl._connect11052 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "connect", "(Ljava/lang/String;I)V"); 
			global::java.net.SocketImpl._connect11053 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "connect", "(Ljava/net/InetAddress;I)V"); 
			global::java.net.SocketImpl._getOutputStream11054 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "getOutputStream", "()Ljava/io/OutputStream;"); 
			global::java.net.SocketImpl._getFileDescriptor11055 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "getFileDescriptor", "()Ljava/io/FileDescriptor;"); 
			global::java.net.SocketImpl._listen11056 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "listen", "(I)V"); 
			global::java.net.SocketImpl._bind11057 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "bind", "(Ljava/net/InetAddress;I)V"); 
			global::java.net.SocketImpl._shutdownInput11058 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "shutdownInput", "()V"); 
			global::java.net.SocketImpl._shutdownOutput11059 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "shutdownOutput", "()V"); 
			global::java.net.SocketImpl._getInetAddress11060 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "getInetAddress", "()Ljava/net/InetAddress;"); 
			global::java.net.SocketImpl._getLocalPort11061 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "getLocalPort", "()I"); 
			global::java.net.SocketImpl._sendUrgentData11062 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "sendUrgentData", "(I)V"); 
			global::java.net.SocketImpl._setPerformancePreferences11063 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "setPerformancePreferences", "(III)V"); 
			global::java.net.SocketImpl._supportsUrgentData11064 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "supportsUrgentData", "()Z"); 
			global::java.net.SocketImpl._SocketImpl11065 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "<init>", "()V"); 
		} 
	} 
} 
