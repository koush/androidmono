namespace java.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class SocketImpl : java.lang.Object, SocketOptions
	{ 
		internal static global::java.lang.Class staticClass; 
		static SocketImpl() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.net.SocketImpl), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected SocketImpl(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOption11870; 
		public abstract global::java.lang.Object getOption(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setOption11871; 
		public abstract void setOption(int arg0, java.lang.Object arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _toString11872; 
		public override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.SocketImpl._toString11872)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.SocketImpl.staticClass, global::java.net.SocketImpl._toString11872)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close11873; 
		protected abstract void close(); 
		internal static global::net.sf.jni4net.jni.MethodId _accept11874; 
		protected abstract void accept(java.net.SocketImpl arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _available11875; 
		protected abstract int available(); 
		internal static global::net.sf.jni4net.jni.MethodId _getPort11876; 
		protected virtual int getPort() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.net.SocketImpl._getPort11876); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.net.SocketImpl.staticClass, global::java.net.SocketImpl._getPort11876); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _create11877; 
		protected abstract void create(bool arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getInputStream11878; 
		protected abstract global::java.io.InputStream getInputStream(); 
		internal static global::net.sf.jni4net.jni.MethodId _connect11879; 
		protected abstract void connect(java.net.SocketAddress arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _connect11880; 
		protected abstract void connect(java.lang.String arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _connect11881; 
		protected abstract void connect(java.net.InetAddress arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _getOutputStream11882; 
		protected abstract global::java.io.OutputStream getOutputStream(); 
		internal static global::net.sf.jni4net.jni.MethodId _getFileDescriptor11883; 
		protected virtual global::java.io.FileDescriptor getFileDescriptor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.SocketImpl._getFileDescriptor11883)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.SocketImpl.staticClass, global::java.net.SocketImpl._getFileDescriptor11883)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _listen11884; 
		protected abstract void listen(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _bind11885; 
		protected abstract void bind(java.net.InetAddress arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _shutdownInput11886; 
		protected virtual void shutdownInput() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.net.SocketImpl._shutdownInput11886); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.net.SocketImpl.staticClass, global::java.net.SocketImpl._shutdownInput11886); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _shutdownOutput11887; 
		protected virtual void shutdownOutput() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.net.SocketImpl._shutdownOutput11887); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.net.SocketImpl.staticClass, global::java.net.SocketImpl._shutdownOutput11887); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInetAddress11888; 
		protected virtual global::java.net.InetAddress getInetAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.SocketImpl._getInetAddress11888)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.SocketImpl.staticClass, global::java.net.SocketImpl._getInetAddress11888)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocalPort11889; 
		protected virtual int getLocalPort() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.net.SocketImpl._getLocalPort11889); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.net.SocketImpl.staticClass, global::java.net.SocketImpl._getLocalPort11889); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendUrgentData11890; 
		protected abstract void sendUrgentData(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setPerformancePreferences11891; 
		protected virtual void setPerformancePreferences(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.net.SocketImpl._setPerformancePreferences11891, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.net.SocketImpl.staticClass, global::java.net.SocketImpl._setPerformancePreferences11891, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _supportsUrgentData11892; 
		protected virtual bool supportsUrgentData() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::java.net.SocketImpl._supportsUrgentData11892); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.net.SocketImpl.staticClass, global::java.net.SocketImpl._supportsUrgentData11892); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SocketImpl11893; 
		public SocketImpl()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.SocketImpl.staticClass, global::java.net.SocketImpl._SocketImpl11893, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.net.SocketImpl.staticClass = @__class; 
			global::java.net.SocketImpl._getOption11870 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "getOption", "(I)Ljava/lang/Object;"); 
			global::java.net.SocketImpl._setOption11871 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "setOption", "(ILjava/lang/Object;)V"); 
			global::java.net.SocketImpl._toString11872 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.net.SocketImpl._close11873 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "close", "()V"); 
			global::java.net.SocketImpl._accept11874 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "accept", "(Ljava/net/SocketImpl;)V"); 
			global::java.net.SocketImpl._available11875 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "available", "()I"); 
			global::java.net.SocketImpl._getPort11876 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "getPort", "()I"); 
			global::java.net.SocketImpl._create11877 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "create", "(Z)V"); 
			global::java.net.SocketImpl._getInputStream11878 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "getInputStream", "()Ljava/io/InputStream;"); 
			global::java.net.SocketImpl._connect11879 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "connect", "(Ljava/net/SocketAddress;I)V"); 
			global::java.net.SocketImpl._connect11880 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "connect", "(Ljava/lang/String;I)V"); 
			global::java.net.SocketImpl._connect11881 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "connect", "(Ljava/net/InetAddress;I)V"); 
			global::java.net.SocketImpl._getOutputStream11882 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "getOutputStream", "()Ljava/io/OutputStream;"); 
			global::java.net.SocketImpl._getFileDescriptor11883 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "getFileDescriptor", "()Ljava/io/FileDescriptor;"); 
			global::java.net.SocketImpl._listen11884 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "listen", "(I)V"); 
			global::java.net.SocketImpl._bind11885 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "bind", "(Ljava/net/InetAddress;I)V"); 
			global::java.net.SocketImpl._shutdownInput11886 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "shutdownInput", "()V"); 
			global::java.net.SocketImpl._shutdownOutput11887 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "shutdownOutput", "()V"); 
			global::java.net.SocketImpl._getInetAddress11888 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "getInetAddress", "()Ljava/net/InetAddress;"); 
			global::java.net.SocketImpl._getLocalPort11889 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "getLocalPort", "()I"); 
			global::java.net.SocketImpl._sendUrgentData11890 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "sendUrgentData", "(I)V"); 
			global::java.net.SocketImpl._setPerformancePreferences11891 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "setPerformancePreferences", "(III)V"); 
			global::java.net.SocketImpl._supportsUrgentData11892 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "supportsUrgentData", "()Z"); 
			global::java.net.SocketImpl._SocketImpl11893 = @__env.GetMethodID(global::java.net.SocketImpl.staticClass, "<init>", "()V"); 
		} 
	} 
} 
