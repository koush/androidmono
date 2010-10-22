namespace android.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LocalSocket : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LocalSocket()
		{
			InitJNI();
		}
		protected LocalSocket(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString7626;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.LocalSocket._toString7626)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._toString7626)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _close7627;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.LocalSocket._close7627);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._close7627);
		}
		public new global::java.io.InputStream InputStream
		{
			get
			{
				return getInputStream();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputStream7628;
		public virtual global::java.io.InputStream getInputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.LocalSocket._getInputStream7628)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getInputStream7628)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _connect7629;
		public virtual void connect(android.net.LocalSocketAddress arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.LocalSocket._connect7629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._connect7629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _connect7630;
		public virtual void connect(android.net.LocalSocketAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.LocalSocket._connect7630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._connect7630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isClosed7631;
		public virtual bool isClosed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.LocalSocket._isClosed7631);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._isClosed7631);
		}
		public new global::java.io.OutputStream OutputStream
		{
			get
			{
				return getOutputStream();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOutputStream7632;
		public virtual global::java.io.OutputStream getOutputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.LocalSocket._getOutputStream7632)) as java.io.OutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getOutputStream7632)) as java.io.OutputStream;
		}
		public new global::java.io.FileDescriptor FileDescriptor
		{
			get
			{
				return getFileDescriptor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFileDescriptor7633;
		public virtual global::java.io.FileDescriptor getFileDescriptor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.io.FileDescriptor>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.LocalSocket._getFileDescriptor7633)) as java.io.FileDescriptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.io.FileDescriptor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getFileDescriptor7633)) as java.io.FileDescriptor;
		}
		internal static global::MonoJavaBridge.MethodId _bind7634;
		public virtual void bind(android.net.LocalSocketAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.LocalSocket._bind7634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._bind7634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isConnected7635;
		public virtual bool isConnected() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.LocalSocket._isConnected7635);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._isConnected7635);
		}
		public new global::android.net.LocalSocketAddress LocalSocketAddress
		{
			get
			{
				return getLocalSocketAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalSocketAddress7636;
		public virtual global::android.net.LocalSocketAddress getLocalSocketAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.LocalSocket._getLocalSocketAddress7636)) as android.net.LocalSocketAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getLocalSocketAddress7636)) as android.net.LocalSocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _shutdownInput7637;
		public virtual void shutdownInput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.LocalSocket._shutdownInput7637);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._shutdownInput7637);
		}
		internal static global::MonoJavaBridge.MethodId _shutdownOutput7638;
		public virtual void shutdownOutput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.LocalSocket._shutdownOutput7638);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._shutdownOutput7638);
		}
		internal static global::MonoJavaBridge.MethodId _setReceiveBufferSize7639;
		public virtual void setReceiveBufferSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.LocalSocket._setReceiveBufferSize7639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._setReceiveBufferSize7639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ReceiveBufferSize
		{
			get
			{
				return getReceiveBufferSize();
			}
			set
			{
				setReceiveBufferSize(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReceiveBufferSize7640;
		public virtual int getReceiveBufferSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.LocalSocket._getReceiveBufferSize7640);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getReceiveBufferSize7640);
		}
		internal static global::MonoJavaBridge.MethodId _setSoTimeout7641;
		public virtual void setSoTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.LocalSocket._setSoTimeout7641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._setSoTimeout7641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int SoTimeout
		{
			get
			{
				return getSoTimeout();
			}
			set
			{
				setSoTimeout(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSoTimeout7642;
		public virtual int getSoTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.LocalSocket._getSoTimeout7642);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getSoTimeout7642);
		}
		internal static global::MonoJavaBridge.MethodId _setSendBufferSize7643;
		public virtual void setSendBufferSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.LocalSocket._setSendBufferSize7643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._setSendBufferSize7643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int SendBufferSize
		{
			get
			{
				return getSendBufferSize();
			}
			set
			{
				setSendBufferSize(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSendBufferSize7644;
		public virtual int getSendBufferSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.LocalSocket._getSendBufferSize7644);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getSendBufferSize7644);
		}
		public new global::android.net.LocalSocketAddress RemoteSocketAddress
		{
			get
			{
				return getRemoteSocketAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRemoteSocketAddress7645;
		public virtual global::android.net.LocalSocketAddress getRemoteSocketAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.LocalSocket._getRemoteSocketAddress7645)) as android.net.LocalSocketAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getRemoteSocketAddress7645)) as android.net.LocalSocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _isBound7646;
		public virtual bool isBound() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.LocalSocket._isBound7646);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._isBound7646);
		}
		internal static global::MonoJavaBridge.MethodId _isOutputShutdown7647;
		public virtual bool isOutputShutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.LocalSocket._isOutputShutdown7647);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._isOutputShutdown7647);
		}
		internal static global::MonoJavaBridge.MethodId _isInputShutdown7648;
		public virtual bool isInputShutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.LocalSocket._isInputShutdown7648);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._isInputShutdown7648);
		}
		internal static global::MonoJavaBridge.MethodId _setFileDescriptorsForSend7649;
		public virtual void setFileDescriptorsForSend(java.io.FileDescriptor[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.LocalSocket._setFileDescriptorsForSend7649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._setFileDescriptorsForSend7649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.io.FileDescriptor[] AncillaryFileDescriptors
		{
			get
			{
				return getAncillaryFileDescriptors();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAncillaryFileDescriptors7650;
		public virtual global::java.io.FileDescriptor[] getAncillaryFileDescriptors() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.FileDescriptor>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.LocalSocket._getAncillaryFileDescriptors7650)) as java.io.FileDescriptor[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.FileDescriptor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getAncillaryFileDescriptors7650)) as java.io.FileDescriptor[];
		}
		public new global::android.net.Credentials PeerCredentials
		{
			get
			{
				return getPeerCredentials();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPeerCredentials7651;
		public virtual global::android.net.Credentials getPeerCredentials() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.LocalSocket._getPeerCredentials7651)) as android.net.Credentials;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getPeerCredentials7651)) as android.net.Credentials;
		}
		internal static global::MonoJavaBridge.MethodId _LocalSocket7652;
		public LocalSocket()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.LocalSocket.staticClass, global::android.net.LocalSocket._LocalSocket7652);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.LocalSocket.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/LocalSocket"));
			global::android.net.LocalSocket._toString7626 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "toString", "()Ljava/lang/String;");
			global::android.net.LocalSocket._close7627 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "close", "()V");
			global::android.net.LocalSocket._getInputStream7628 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "getInputStream", "()Ljava/io/InputStream;");
			global::android.net.LocalSocket._connect7629 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "connect", "(Landroid/net/LocalSocketAddress;I)V");
			global::android.net.LocalSocket._connect7630 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "connect", "(Landroid/net/LocalSocketAddress;)V");
			global::android.net.LocalSocket._isClosed7631 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "isClosed", "()Z");
			global::android.net.LocalSocket._getOutputStream7632 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "getOutputStream", "()Ljava/io/OutputStream;");
			global::android.net.LocalSocket._getFileDescriptor7633 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "getFileDescriptor", "()Ljava/io/FileDescriptor;");
			global::android.net.LocalSocket._bind7634 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "bind", "(Landroid/net/LocalSocketAddress;)V");
			global::android.net.LocalSocket._isConnected7635 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "isConnected", "()Z");
			global::android.net.LocalSocket._getLocalSocketAddress7636 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "getLocalSocketAddress", "()Landroid/net/LocalSocketAddress;");
			global::android.net.LocalSocket._shutdownInput7637 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "shutdownInput", "()V");
			global::android.net.LocalSocket._shutdownOutput7638 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "shutdownOutput", "()V");
			global::android.net.LocalSocket._setReceiveBufferSize7639 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "setReceiveBufferSize", "(I)V");
			global::android.net.LocalSocket._getReceiveBufferSize7640 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "getReceiveBufferSize", "()I");
			global::android.net.LocalSocket._setSoTimeout7641 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "setSoTimeout", "(I)V");
			global::android.net.LocalSocket._getSoTimeout7642 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "getSoTimeout", "()I");
			global::android.net.LocalSocket._setSendBufferSize7643 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "setSendBufferSize", "(I)V");
			global::android.net.LocalSocket._getSendBufferSize7644 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "getSendBufferSize", "()I");
			global::android.net.LocalSocket._getRemoteSocketAddress7645 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "getRemoteSocketAddress", "()Landroid/net/LocalSocketAddress;");
			global::android.net.LocalSocket._isBound7646 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "isBound", "()Z");
			global::android.net.LocalSocket._isOutputShutdown7647 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "isOutputShutdown", "()Z");
			global::android.net.LocalSocket._isInputShutdown7648 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "isInputShutdown", "()Z");
			global::android.net.LocalSocket._setFileDescriptorsForSend7649 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "setFileDescriptorsForSend", "([Ljava/io/FileDescriptor;)V");
			global::android.net.LocalSocket._getAncillaryFileDescriptors7650 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "getAncillaryFileDescriptors", "()[Ljava/io/FileDescriptor;");
			global::android.net.LocalSocket._getPeerCredentials7651 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "getPeerCredentials", "()Landroid/net/Credentials;");
			global::android.net.LocalSocket._LocalSocket7652 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "<init>", "()V");
		}
	}
}
