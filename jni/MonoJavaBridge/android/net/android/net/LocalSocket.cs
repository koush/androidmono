namespace android.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class LocalSocket : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static LocalSocket() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.net.LocalSocket), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.net.LocalSocket(@__env); 
			} 
		} 
		protected LocalSocket(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString4395; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.LocalSocket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString4395)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.LocalSocket.staticClass, _toString4395)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close4396; 
		public virtual void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.LocalSocket)) 
				@__env.CallVoidMethod(this, _close4396); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.net.LocalSocket.staticClass, _close4396); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInputStream4397; 
		public virtual java.io.InputStream getInputStream() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.LocalSocket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallObjectMethodPtr(this, _getInputStream4397)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.LocalSocket.staticClass, _getInputStream4397)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _connect4398; 
		public virtual void connect(android.net.LocalSocketAddress arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.LocalSocket)) 
				@__env.CallVoidMethod(this, _connect4398, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.net.LocalSocket.staticClass, _connect4398, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _connect4399; 
		public virtual void connect(android.net.LocalSocketAddress arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.LocalSocket)) 
				@__env.CallVoidMethod(this, _connect4399, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.net.LocalSocket.staticClass, _connect4399, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isClosed4400; 
		public virtual bool isClosed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.LocalSocket)) 
				return @__env.CallBooleanMethod(this, _isClosed4400); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.net.LocalSocket.staticClass, _isClosed4400); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOutputStream4401; 
		public virtual java.io.OutputStream getOutputStream() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.LocalSocket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.OutputStream>(@__env, @__env.CallObjectMethodPtr(this, _getOutputStream4401)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.OutputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.LocalSocket.staticClass, _getOutputStream4401)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFileDescriptor4402; 
		public virtual java.io.FileDescriptor getFileDescriptor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.LocalSocket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, _getFileDescriptor4402)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.LocalSocket.staticClass, _getFileDescriptor4402)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bind4403; 
		public virtual void bind(android.net.LocalSocketAddress arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.LocalSocket)) 
				@__env.CallVoidMethod(this, _bind4403, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.net.LocalSocket.staticClass, _bind4403, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isConnected4404; 
		public virtual bool isConnected() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.LocalSocket)) 
				return @__env.CallBooleanMethod(this, _isConnected4404); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.net.LocalSocket.staticClass, _isConnected4404); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocalSocketAddress4405; 
		public virtual android.net.LocalSocketAddress getLocalSocketAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.LocalSocket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.LocalSocketAddress>(@__env, @__env.CallObjectMethodPtr(this, _getLocalSocketAddress4405)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.LocalSocketAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.LocalSocket.staticClass, _getLocalSocketAddress4405)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _shutdownInput4406; 
		public virtual void shutdownInput() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.LocalSocket)) 
				@__env.CallVoidMethod(this, _shutdownInput4406); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.net.LocalSocket.staticClass, _shutdownInput4406); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _shutdownOutput4407; 
		public virtual void shutdownOutput() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.LocalSocket)) 
				@__env.CallVoidMethod(this, _shutdownOutput4407); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.net.LocalSocket.staticClass, _shutdownOutput4407); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setReceiveBufferSize4408; 
		public virtual void setReceiveBufferSize(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.LocalSocket)) 
				@__env.CallVoidMethod(this, _setReceiveBufferSize4408, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.net.LocalSocket.staticClass, _setReceiveBufferSize4408, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getReceiveBufferSize4409; 
		public virtual int getReceiveBufferSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.LocalSocket)) 
				return @__env.CallIntMethod(this, _getReceiveBufferSize4409); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.net.LocalSocket.staticClass, _getReceiveBufferSize4409); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSoTimeout4410; 
		public virtual void setSoTimeout(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.LocalSocket)) 
				@__env.CallVoidMethod(this, _setSoTimeout4410, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.net.LocalSocket.staticClass, _setSoTimeout4410, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSoTimeout4411; 
		public virtual int getSoTimeout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.LocalSocket)) 
				return @__env.CallIntMethod(this, _getSoTimeout4411); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.net.LocalSocket.staticClass, _getSoTimeout4411); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSendBufferSize4412; 
		public virtual void setSendBufferSize(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.LocalSocket)) 
				@__env.CallVoidMethod(this, _setSendBufferSize4412, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.net.LocalSocket.staticClass, _setSendBufferSize4412, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSendBufferSize4413; 
		public virtual int getSendBufferSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.LocalSocket)) 
				return @__env.CallIntMethod(this, _getSendBufferSize4413); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.net.LocalSocket.staticClass, _getSendBufferSize4413); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRemoteSocketAddress4414; 
		public virtual android.net.LocalSocketAddress getRemoteSocketAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.LocalSocket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.LocalSocketAddress>(@__env, @__env.CallObjectMethodPtr(this, _getRemoteSocketAddress4414)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.LocalSocketAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.LocalSocket.staticClass, _getRemoteSocketAddress4414)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isBound4415; 
		public virtual bool isBound() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.LocalSocket)) 
				return @__env.CallBooleanMethod(this, _isBound4415); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.net.LocalSocket.staticClass, _isBound4415); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isOutputShutdown4416; 
		public virtual bool isOutputShutdown() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.LocalSocket)) 
				return @__env.CallBooleanMethod(this, _isOutputShutdown4416); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.net.LocalSocket.staticClass, _isOutputShutdown4416); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isInputShutdown4417; 
		public virtual bool isInputShutdown() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.LocalSocket)) 
				return @__env.CallBooleanMethod(this, _isInputShutdown4417); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.net.LocalSocket.staticClass, _isInputShutdown4417); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFileDescriptorsForSend4418; 
		public virtual void setFileDescriptorsForSend(java.io.FileDescriptor[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.LocalSocket)) 
				@__env.CallVoidMethod(this, _setFileDescriptorsForSend4418, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.net.LocalSocket.staticClass, _setFileDescriptorsForSend4418, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAncillaryFileDescriptors4419; 
		public virtual java.io.FileDescriptor[] getAncillaryFileDescriptors() 
		{ 
			if (GetType() == typeof(android.net.LocalSocket)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getAncillaryFileDescriptors4419)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.LocalSocket.staticClass, _getAncillaryFileDescriptors4419)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPeerCredentials4420; 
		public virtual android.net.Credentials getPeerCredentials() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.LocalSocket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Credentials>(@__env, @__env.CallObjectMethodPtr(this, _getPeerCredentials4420)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Credentials>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.LocalSocket.staticClass, _getPeerCredentials4420)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LocalSocket4421; 
		public LocalSocket()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.net.LocalSocket.staticClass, _LocalSocket4421, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.net.LocalSocket.staticClass = @__class; 
			global::android.net.LocalSocket._toString4395 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.net.LocalSocket._close4396 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "close", "()V"); 
			global::android.net.LocalSocket._getInputStream4397 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "getInputStream", "()Ljava/io/InputStream;"); 
			global::android.net.LocalSocket._connect4398 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "connect", "(Landroid/net/LocalSocketAddress;I)V"); 
			global::android.net.LocalSocket._connect4399 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "connect", "(Landroid/net/LocalSocketAddress;)V"); 
			global::android.net.LocalSocket._isClosed4400 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "isClosed", "()Z"); 
			global::android.net.LocalSocket._getOutputStream4401 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "getOutputStream", "()Ljava/io/OutputStream;"); 
			global::android.net.LocalSocket._getFileDescriptor4402 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "getFileDescriptor", "()Ljava/io/FileDescriptor;"); 
			global::android.net.LocalSocket._bind4403 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "bind", "(Landroid/net/LocalSocketAddress;)V"); 
			global::android.net.LocalSocket._isConnected4404 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "isConnected", "()Z"); 
			global::android.net.LocalSocket._getLocalSocketAddress4405 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "getLocalSocketAddress", "()Landroid/net/LocalSocketAddress;"); 
			global::android.net.LocalSocket._shutdownInput4406 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "shutdownInput", "()V"); 
			global::android.net.LocalSocket._shutdownOutput4407 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "shutdownOutput", "()V"); 
			global::android.net.LocalSocket._setReceiveBufferSize4408 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "setReceiveBufferSize", "(I)V"); 
			global::android.net.LocalSocket._getReceiveBufferSize4409 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "getReceiveBufferSize", "()I"); 
			global::android.net.LocalSocket._setSoTimeout4410 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "setSoTimeout", "(I)V"); 
			global::android.net.LocalSocket._getSoTimeout4411 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "getSoTimeout", "()I"); 
			global::android.net.LocalSocket._setSendBufferSize4412 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "setSendBufferSize", "(I)V"); 
			global::android.net.LocalSocket._getSendBufferSize4413 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "getSendBufferSize", "()I"); 
			global::android.net.LocalSocket._getRemoteSocketAddress4414 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "getRemoteSocketAddress", "()Landroid/net/LocalSocketAddress;"); 
			global::android.net.LocalSocket._isBound4415 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "isBound", "()Z"); 
			global::android.net.LocalSocket._isOutputShutdown4416 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "isOutputShutdown", "()Z"); 
			global::android.net.LocalSocket._isInputShutdown4417 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "isInputShutdown", "()Z"); 
			global::android.net.LocalSocket._setFileDescriptorsForSend4418 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "setFileDescriptorsForSend", "([Ljava/io/FileDescriptor;)V"); 
			global::android.net.LocalSocket._getAncillaryFileDescriptors4419 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "getAncillaryFileDescriptors", "()[Ljava/io/FileDescriptor;"); 
			global::android.net.LocalSocket._getPeerCredentials4420 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "getPeerCredentials", "()Landroid/net/Credentials;"); 
			global::android.net.LocalSocket._LocalSocket4421 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "<init>", "()V"); 
		} 
	} 
} 
