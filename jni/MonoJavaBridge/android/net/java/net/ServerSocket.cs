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
		internal static global::net.sf.jni4net.jni.MethodId _toString11794; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ServerSocket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString11794)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.ServerSocket.staticClass, _toString11794)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close11795; 
		public virtual void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ServerSocket)) 
				@__env.CallVoidMethod(this, _close11795); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.ServerSocket.staticClass, _close11795); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _accept11796; 
		public virtual java.net.Socket accept() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ServerSocket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallObjectMethodPtr(this, _accept11796)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.ServerSocket.staticClass, _accept11796)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChannel11797; 
		public virtual java.nio.channels.ServerSocketChannel getChannel() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ServerSocket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.ServerSocketChannel>(@__env, @__env.CallObjectMethodPtr(this, _getChannel11797)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.ServerSocketChannel>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.ServerSocket.staticClass, _getChannel11797)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isClosed11798; 
		public virtual bool isClosed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ServerSocket)) 
				return @__env.CallBooleanMethod(this, _isClosed11798); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.ServerSocket.staticClass, _isClosed11798); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bind11799; 
		public virtual void bind(java.net.SocketAddress arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ServerSocket)) 
				@__env.CallVoidMethod(this, _bind11799, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.ServerSocket.staticClass, _bind11799, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bind11800; 
		public virtual void bind(java.net.SocketAddress arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ServerSocket)) 
				@__env.CallVoidMethod(this, _bind11800, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.ServerSocket.staticClass, _bind11800, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocalSocketAddress11801; 
		public virtual java.net.SocketAddress getLocalSocketAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ServerSocket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.SocketAddress>(@__env, @__env.CallObjectMethodPtr(this, _getLocalSocketAddress11801)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.SocketAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.ServerSocket.staticClass, _getLocalSocketAddress11801)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setReceiveBufferSize11802; 
		public virtual void setReceiveBufferSize(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ServerSocket)) 
				@__env.CallVoidMethod(this, _setReceiveBufferSize11802, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.ServerSocket.staticClass, _setReceiveBufferSize11802, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getReceiveBufferSize11803; 
		public virtual int getReceiveBufferSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ServerSocket)) 
				return @__env.CallIntMethod(this, _getReceiveBufferSize11803); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.ServerSocket.staticClass, _getReceiveBufferSize11803); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSoTimeout11804; 
		public virtual void setSoTimeout(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ServerSocket)) 
				@__env.CallVoidMethod(this, _setSoTimeout11804, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.ServerSocket.staticClass, _setSoTimeout11804, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSoTimeout11805; 
		public virtual int getSoTimeout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ServerSocket)) 
				return @__env.CallIntMethod(this, _getSoTimeout11805); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.ServerSocket.staticClass, _getSoTimeout11805); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isBound11806; 
		public virtual bool isBound() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ServerSocket)) 
				return @__env.CallBooleanMethod(this, _isBound11806); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.ServerSocket.staticClass, _isBound11806); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInetAddress11807; 
		public virtual java.net.InetAddress getInetAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ServerSocket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallObjectMethodPtr(this, _getInetAddress11807)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.ServerSocket.staticClass, _getInetAddress11807)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocalPort11808; 
		public virtual int getLocalPort() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ServerSocket)) 
				return @__env.CallIntMethod(this, _getLocalPort11808); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.ServerSocket.staticClass, _getLocalPort11808); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setReuseAddress11809; 
		public virtual void setReuseAddress(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ServerSocket)) 
				@__env.CallVoidMethod(this, _setReuseAddress11809, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.ServerSocket.staticClass, _setReuseAddress11809, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getReuseAddress11810; 
		public virtual bool getReuseAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ServerSocket)) 
				return @__env.CallBooleanMethod(this, _getReuseAddress11810); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.ServerSocket.staticClass, _getReuseAddress11810); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPerformancePreferences11811; 
		public virtual void setPerformancePreferences(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ServerSocket)) 
				@__env.CallVoidMethod(this, _setPerformancePreferences11811, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.ServerSocket.staticClass, _setPerformancePreferences11811, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _implAccept11812; 
		protected virtual void implAccept(java.net.Socket arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.ServerSocket)) 
				@__env.CallVoidMethod(this, _implAccept11812, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.ServerSocket.staticClass, _implAccept11812, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSocketFactory11813; 
		public static void setSocketFactory(java.net.SocketImplFactory arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(java.net.ServerSocket.staticClass, _setSocketFactory11813, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ServerSocket11814; 
		public ServerSocket()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.ServerSocket.staticClass, _ServerSocket11814, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ServerSocket11815; 
		public ServerSocket(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.ServerSocket.staticClass, _ServerSocket11815, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ServerSocket11816; 
		public ServerSocket(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.ServerSocket.staticClass, _ServerSocket11816, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ServerSocket11817; 
		public ServerSocket(int arg0, int arg1, java.net.InetAddress arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.ServerSocket.staticClass, _ServerSocket11817, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.net.ServerSocket.staticClass = @__class; 
			global::java.net.ServerSocket._toString11794 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.net.ServerSocket._close11795 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "close", "()V"); 
			global::java.net.ServerSocket._accept11796 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "accept", "()Ljava/net/Socket;"); 
			global::java.net.ServerSocket._getChannel11797 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "getChannel", "()Ljava/nio/channels/ServerSocketChannel;"); 
			global::java.net.ServerSocket._isClosed11798 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "isClosed", "()Z"); 
			global::java.net.ServerSocket._bind11799 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "bind", "(Ljava/net/SocketAddress;)V"); 
			global::java.net.ServerSocket._bind11800 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "bind", "(Ljava/net/SocketAddress;I)V"); 
			global::java.net.ServerSocket._getLocalSocketAddress11801 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "getLocalSocketAddress", "()Ljava/net/SocketAddress;"); 
			global::java.net.ServerSocket._setReceiveBufferSize11802 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "setReceiveBufferSize", "(I)V"); 
			global::java.net.ServerSocket._getReceiveBufferSize11803 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "getReceiveBufferSize", "()I"); 
			global::java.net.ServerSocket._setSoTimeout11804 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "setSoTimeout", "(I)V"); 
			global::java.net.ServerSocket._getSoTimeout11805 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "getSoTimeout", "()I"); 
			global::java.net.ServerSocket._isBound11806 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "isBound", "()Z"); 
			global::java.net.ServerSocket._getInetAddress11807 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "getInetAddress", "()Ljava/net/InetAddress;"); 
			global::java.net.ServerSocket._getLocalPort11808 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "getLocalPort", "()I"); 
			global::java.net.ServerSocket._setReuseAddress11809 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "setReuseAddress", "(Z)V"); 
			global::java.net.ServerSocket._getReuseAddress11810 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "getReuseAddress", "()Z"); 
			global::java.net.ServerSocket._setPerformancePreferences11811 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "setPerformancePreferences", "(III)V"); 
			global::java.net.ServerSocket._implAccept11812 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "implAccept", "(Ljava/net/Socket;)V"); 
			global::java.net.ServerSocket._setSocketFactory11813 = @__env.GetStaticMethodID(global::java.net.ServerSocket.staticClass, "setSocketFactory", "(Ljava/net/SocketImplFactory;)V"); 
			global::java.net.ServerSocket._ServerSocket11814 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "<init>", "()V"); 
			global::java.net.ServerSocket._ServerSocket11815 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "<init>", "(I)V"); 
			global::java.net.ServerSocket._ServerSocket11816 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "<init>", "(II)V"); 
			global::java.net.ServerSocket._ServerSocket11817 = @__env.GetMethodID(global::java.net.ServerSocket.staticClass, "<init>", "(IILjava/net/InetAddress;)V"); 
		} 
	} 
} 
