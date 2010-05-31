namespace android.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class LocalSocket : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static LocalSocket() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.net.LocalSocket), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _toString4643; 
		public override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.LocalSocket._toString4643)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._toString4643)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close4644; 
		public virtual void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.net.LocalSocket._close4644); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._close4644); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInputStream4645; 
		public virtual global::java.io.InputStream getInputStream() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.LocalSocket._getInputStream4645)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getInputStream4645)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _connect4646; 
		public virtual void connect(android.net.LocalSocketAddress arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.net.LocalSocket._connect4646, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._connect4646, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _connect4647; 
		public virtual void connect(android.net.LocalSocketAddress arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.net.LocalSocket._connect4647, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._connect4647, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isClosed4648; 
		public virtual bool isClosed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.net.LocalSocket._isClosed4648); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._isClosed4648); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOutputStream4649; 
		public virtual global::java.io.OutputStream getOutputStream() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.OutputStream>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.LocalSocket._getOutputStream4649)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.OutputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getOutputStream4649)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFileDescriptor4650; 
		public virtual global::java.io.FileDescriptor getFileDescriptor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.LocalSocket._getFileDescriptor4650)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getFileDescriptor4650)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bind4651; 
		public virtual void bind(android.net.LocalSocketAddress arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.net.LocalSocket._bind4651, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._bind4651, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isConnected4652; 
		public virtual bool isConnected() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.net.LocalSocket._isConnected4652); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._isConnected4652); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocalSocketAddress4653; 
		public virtual global::android.net.LocalSocketAddress getLocalSocketAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.LocalSocketAddress>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.LocalSocket._getLocalSocketAddress4653)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.LocalSocketAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getLocalSocketAddress4653)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _shutdownInput4654; 
		public virtual void shutdownInput() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.net.LocalSocket._shutdownInput4654); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._shutdownInput4654); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _shutdownOutput4655; 
		public virtual void shutdownOutput() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.net.LocalSocket._shutdownOutput4655); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._shutdownOutput4655); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setReceiveBufferSize4656; 
		public virtual void setReceiveBufferSize(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.net.LocalSocket._setReceiveBufferSize4656, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._setReceiveBufferSize4656, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getReceiveBufferSize4657; 
		public virtual int getReceiveBufferSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.net.LocalSocket._getReceiveBufferSize4657); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getReceiveBufferSize4657); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSoTimeout4658; 
		public virtual void setSoTimeout(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.net.LocalSocket._setSoTimeout4658, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._setSoTimeout4658, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSoTimeout4659; 
		public virtual int getSoTimeout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.net.LocalSocket._getSoTimeout4659); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getSoTimeout4659); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSendBufferSize4660; 
		public virtual void setSendBufferSize(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.net.LocalSocket._setSendBufferSize4660, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._setSendBufferSize4660, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSendBufferSize4661; 
		public virtual int getSendBufferSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.net.LocalSocket._getSendBufferSize4661); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getSendBufferSize4661); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRemoteSocketAddress4662; 
		public virtual global::android.net.LocalSocketAddress getRemoteSocketAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.LocalSocketAddress>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.LocalSocket._getRemoteSocketAddress4662)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.LocalSocketAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getRemoteSocketAddress4662)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isBound4663; 
		public virtual bool isBound() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.net.LocalSocket._isBound4663); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._isBound4663); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isOutputShutdown4664; 
		public virtual bool isOutputShutdown() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.net.LocalSocket._isOutputShutdown4664); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._isOutputShutdown4664); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isInputShutdown4665; 
		public virtual bool isInputShutdown() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.net.LocalSocket._isInputShutdown4665); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._isInputShutdown4665); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFileDescriptorsForSend4666; 
		public virtual void setFileDescriptorsForSend(java.io.FileDescriptor[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.net.LocalSocket._setFileDescriptorsForSend4666, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._setFileDescriptorsForSend4666, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAncillaryFileDescriptors4667; 
		public virtual global::java.io.FileDescriptor[] getAncillaryFileDescriptors() 
		{ 
			if (!IsClrObject) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.net.LocalSocket._getAncillaryFileDescriptors4667)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getAncillaryFileDescriptors4667)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPeerCredentials4668; 
		public virtual global::android.net.Credentials getPeerCredentials() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Credentials>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.LocalSocket._getPeerCredentials4668)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Credentials>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getPeerCredentials4668)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LocalSocket4669; 
		public LocalSocket()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.net.LocalSocket.staticClass, global::android.net.LocalSocket._LocalSocket4669, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.net.LocalSocket.staticClass = @__class; 
			global::android.net.LocalSocket._toString4643 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.net.LocalSocket._close4644 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "close", "()V"); 
			global::android.net.LocalSocket._getInputStream4645 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "getInputStream", "()Ljava/io/InputStream;"); 
			global::android.net.LocalSocket._connect4646 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "connect", "(Landroid/net/LocalSocketAddress;I)V"); 
			global::android.net.LocalSocket._connect4647 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "connect", "(Landroid/net/LocalSocketAddress;)V"); 
			global::android.net.LocalSocket._isClosed4648 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "isClosed", "()Z"); 
			global::android.net.LocalSocket._getOutputStream4649 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "getOutputStream", "()Ljava/io/OutputStream;"); 
			global::android.net.LocalSocket._getFileDescriptor4650 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "getFileDescriptor", "()Ljava/io/FileDescriptor;"); 
			global::android.net.LocalSocket._bind4651 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "bind", "(Landroid/net/LocalSocketAddress;)V"); 
			global::android.net.LocalSocket._isConnected4652 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "isConnected", "()Z"); 
			global::android.net.LocalSocket._getLocalSocketAddress4653 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "getLocalSocketAddress", "()Landroid/net/LocalSocketAddress;"); 
			global::android.net.LocalSocket._shutdownInput4654 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "shutdownInput", "()V"); 
			global::android.net.LocalSocket._shutdownOutput4655 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "shutdownOutput", "()V"); 
			global::android.net.LocalSocket._setReceiveBufferSize4656 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "setReceiveBufferSize", "(I)V"); 
			global::android.net.LocalSocket._getReceiveBufferSize4657 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "getReceiveBufferSize", "()I"); 
			global::android.net.LocalSocket._setSoTimeout4658 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "setSoTimeout", "(I)V"); 
			global::android.net.LocalSocket._getSoTimeout4659 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "getSoTimeout", "()I"); 
			global::android.net.LocalSocket._setSendBufferSize4660 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "setSendBufferSize", "(I)V"); 
			global::android.net.LocalSocket._getSendBufferSize4661 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "getSendBufferSize", "()I"); 
			global::android.net.LocalSocket._getRemoteSocketAddress4662 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "getRemoteSocketAddress", "()Landroid/net/LocalSocketAddress;"); 
			global::android.net.LocalSocket._isBound4663 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "isBound", "()Z"); 
			global::android.net.LocalSocket._isOutputShutdown4664 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "isOutputShutdown", "()Z"); 
			global::android.net.LocalSocket._isInputShutdown4665 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "isInputShutdown", "()Z"); 
			global::android.net.LocalSocket._setFileDescriptorsForSend4666 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "setFileDescriptorsForSend", "([Ljava/io/FileDescriptor;)V"); 
			global::android.net.LocalSocket._getAncillaryFileDescriptors4667 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "getAncillaryFileDescriptors", "()[Ljava/io/FileDescriptor;"); 
			global::android.net.LocalSocket._getPeerCredentials4668 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "getPeerCredentials", "()Landroid/net/Credentials;"); 
			global::android.net.LocalSocket._LocalSocket4669 = @__env.GetMethodID(global::android.net.LocalSocket.staticClass, "<init>", "()V"); 
		} 
	} 
} 
