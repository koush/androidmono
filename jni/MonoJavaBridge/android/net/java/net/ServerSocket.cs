namespace java.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ServerSocket : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static ServerSocket() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.net.ServerSocket), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.net.ServerSocket(@__env); 
			} 
		} 
		protected ServerSocket(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString10966; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ServerSocket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString10966)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.ServerSocket.staticClass, _toString10966)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close10967; 
		public virtual void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ServerSocket)) 
				@__env.CallVoidMethod(this, _close10967); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.ServerSocket.staticClass, _close10967); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _accept10968; 
		public virtual java.net.Socket accept() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ServerSocket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallObjectMethodPtr(this, _accept10968)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.ServerSocket.staticClass, _accept10968)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChannel10969; 
		public virtual java.nio.channels.ServerSocketChannel getChannel() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ServerSocket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.ServerSocketChannel>(@__env, @__env.CallObjectMethodPtr(this, _getChannel10969)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.ServerSocketChannel>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.ServerSocket.staticClass, _getChannel10969)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isClosed10970; 
		public virtual bool isClosed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ServerSocket)) 
				return @__env.CallBooleanMethod(this, _isClosed10970); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.ServerSocket.staticClass, _isClosed10970); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bind10971; 
		public virtual void bind(java.net.SocketAddress arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ServerSocket)) 
				@__env.CallVoidMethod(this, _bind10971, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.ServerSocket.staticClass, _bind10971, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bind10972; 
		public virtual void bind(java.net.SocketAddress arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ServerSocket)) 
				@__env.CallVoidMethod(this, _bind10972, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.ServerSocket.staticClass, _bind10972, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocalSocketAddress10973; 
		public virtual java.net.SocketAddress getLocalSocketAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ServerSocket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.SocketAddress>(@__env, @__env.CallObjectMethodPtr(this, _getLocalSocketAddress10973)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.SocketAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.ServerSocket.staticClass, _getLocalSocketAddress10973)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setReceiveBufferSize10974; 
		public virtual void setReceiveBufferSize(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ServerSocket)) 
				@__env.CallVoidMethod(this, _setReceiveBufferSize10974, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.ServerSocket.staticClass, _setReceiveBufferSize10974, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getReceiveBufferSize10975; 
		public virtual int getReceiveBufferSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ServerSocket)) 
				return @__env.CallIntMethod(this, _getReceiveBufferSize10975); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.ServerSocket.staticClass, _getReceiveBufferSize10975); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSoTimeout10976; 
		public virtual void setSoTimeout(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ServerSocket)) 
				@__env.CallVoidMethod(this, _setSoTimeout10976, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.ServerSocket.staticClass, _setSoTimeout10976, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSoTimeout10977; 
		public virtual int getSoTimeout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ServerSocket)) 
				return @__env.CallIntMethod(this, _getSoTimeout10977); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.ServerSocket.staticClass, _getSoTimeout10977); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isBound10978; 
		public virtual bool isBound() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ServerSocket)) 
				return @__env.CallBooleanMethod(this, _isBound10978); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.ServerSocket.staticClass, _isBound10978); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInetAddress10979; 
		public virtual java.net.InetAddress getInetAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ServerSocket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallObjectMethodPtr(this, _getInetAddress10979)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.ServerSocket.staticClass, _getInetAddress10979)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocalPort10980; 
		public virtual int getLocalPort() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ServerSocket)) 
				return @__env.CallIntMethod(this, _getLocalPort10980); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.ServerSocket.staticClass, _getLocalPort10980); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setReuseAddress10981; 
		public virtual void setReuseAddress(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ServerSocket)) 
				@__env.CallVoidMethod(this, _setReuseAddress10981, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.ServerSocket.staticClass, _setReuseAddress10981, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getReuseAddress10982; 
		public virtual bool getReuseAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ServerSocket)) 
				return @__env.CallBooleanMethod(this, _getReuseAddress10982); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.ServerSocket.staticClass, _getReuseAddress10982); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPerformancePreferences10983; 
		public virtual void setPerformancePreferences(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ServerSocket)) 
				@__env.CallVoidMethod(this, _setPerformancePreferences10983, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.ServerSocket.staticClass, _setPerformancePreferences10983, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _implAccept10984; 
		protected virtual void implAccept(java.net.Socket arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ServerSocket)) 
				@__env.CallVoidMethod(this, _implAccept10984, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.ServerSocket.staticClass, _implAccept10984, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSocketFactory10985; 
		public static void setSocketFactory(java.net.SocketImplFactory arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(java.net.ServerSocket.staticClass, _setSocketFactory10985, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ServerSocket10986; 
		public ServerSocket()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.ServerSocket.staticClass, _ServerSocket10986, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ServerSocket10987; 
		public ServerSocket(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.ServerSocket.staticClass, _ServerSocket10987, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ServerSocket10988; 
		public ServerSocket(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.ServerSocket.staticClass, _ServerSocket10988, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ServerSocket10989; 
		public ServerSocket(int arg0, int arg1, java.net.InetAddress arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.ServerSocket.staticClass, _ServerSocket10989, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.net.ServerSocket.staticClass = @__class; 
			global::java.net.ServerSocket._toString10966 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.net.ServerSocket._close10967 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "close", "()V"); 
			global::java.net.ServerSocket._accept10968 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "accept", "()Ljava/net/Socket;"); 
			global::java.net.ServerSocket._getChannel10969 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "getChannel", "()Ljava/nio/channels/ServerSocketChannel;"); 
			global::java.net.ServerSocket._isClosed10970 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "isClosed", "()Z"); 
			global::java.net.ServerSocket._bind10971 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "bind", "(Ljava/net/SocketAddress;)V"); 
			global::java.net.ServerSocket._bind10972 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "bind", "(Ljava/net/SocketAddress;I)V"); 
			global::java.net.ServerSocket._getLocalSocketAddress10973 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "getLocalSocketAddress", "()Ljava/net/SocketAddress;"); 
			global::java.net.ServerSocket._setReceiveBufferSize10974 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "setReceiveBufferSize", "(I)V"); 
			global::java.net.ServerSocket._getReceiveBufferSize10975 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "getReceiveBufferSize", "()I"); 
			global::java.net.ServerSocket._setSoTimeout10976 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "setSoTimeout", "(I)V"); 
			global::java.net.ServerSocket._getSoTimeout10977 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "getSoTimeout", "()I"); 
			global::java.net.ServerSocket._isBound10978 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "isBound", "()Z"); 
			global::java.net.ServerSocket._getInetAddress10979 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "getInetAddress", "()Ljava/net/InetAddress;"); 
			global::java.net.ServerSocket._getLocalPort10980 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "getLocalPort", "()I"); 
			global::java.net.ServerSocket._setReuseAddress10981 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "setReuseAddress", "(Z)V"); 
			global::java.net.ServerSocket._getReuseAddress10982 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "getReuseAddress", "()Z"); 
			global::java.net.ServerSocket._setPerformancePreferences10983 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "setPerformancePreferences", "(III)V"); 
			global::java.net.ServerSocket._implAccept10984 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "implAccept", "(Ljava/net/Socket;)V"); 
			global::java.net.ServerSocket._setSocketFactory10985 = @__env.GetStaticMethodID(global::java.net.ServerSocket.staticClass, "setSocketFactory", "(Ljava/net/SocketImplFactory;)V"); 
			global::java.net.ServerSocket._ServerSocket10986 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "<init>", "()V"); 
			global::java.net.ServerSocket._ServerSocket10987 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "<init>", "(I)V"); 
			global::java.net.ServerSocket._ServerSocket10988 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "<init>", "(II)V"); 
			global::java.net.ServerSocket._ServerSocket10989 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "<init>", "(IILjava/net/InetAddress;)V"); 
		} 
	} 
} 
