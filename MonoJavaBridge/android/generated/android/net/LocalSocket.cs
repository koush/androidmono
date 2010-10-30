namespace android.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LocalSocket : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LocalSocket(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString7665;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.LocalSocket.staticClass, "toString", "()Ljava/lang/String;", ref global::android.net.LocalSocket._toString7665) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _close7666;
		public virtual void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.LocalSocket.staticClass, "close", "()V", ref global::android.net.LocalSocket._close7666);
		}
		public new global::java.io.InputStream InputStream
		{
			get
			{
				return getInputStream();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputStream7667;
		public virtual global::java.io.InputStream getInputStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.LocalSocket.staticClass, "getInputStream", "()Ljava/io/InputStream;", ref global::android.net.LocalSocket._getInputStream7667) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _connect7668;
		public virtual void connect(android.net.LocalSocketAddress arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.LocalSocket.staticClass, "connect", "(Landroid/net/LocalSocketAddress;I)V", ref global::android.net.LocalSocket._connect7668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _connect7669;
		public virtual void connect(android.net.LocalSocketAddress arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.LocalSocket.staticClass, "connect", "(Landroid/net/LocalSocketAddress;)V", ref global::android.net.LocalSocket._connect7669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isClosed7670;
		public virtual bool isClosed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.LocalSocket.staticClass, "isClosed", "()Z", ref global::android.net.LocalSocket._isClosed7670);
		}
		public new global::java.io.OutputStream OutputStream
		{
			get
			{
				return getOutputStream();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOutputStream7671;
		public virtual global::java.io.OutputStream getOutputStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.LocalSocket.staticClass, "getOutputStream", "()Ljava/io/OutputStream;", ref global::android.net.LocalSocket._getOutputStream7671) as java.io.OutputStream;
		}
		public new global::java.io.FileDescriptor FileDescriptor
		{
			get
			{
				return getFileDescriptor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFileDescriptor7672;
		public virtual global::java.io.FileDescriptor getFileDescriptor()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.io.FileDescriptor>(this, global::android.net.LocalSocket.staticClass, "getFileDescriptor", "()Ljava/io/FileDescriptor;", ref global::android.net.LocalSocket._getFileDescriptor7672) as java.io.FileDescriptor;
		}
		internal static global::MonoJavaBridge.MethodId _bind7673;
		public virtual void bind(android.net.LocalSocketAddress arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.LocalSocket.staticClass, "bind", "(Landroid/net/LocalSocketAddress;)V", ref global::android.net.LocalSocket._bind7673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isConnected7674;
		public virtual bool isConnected()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.LocalSocket.staticClass, "isConnected", "()Z", ref global::android.net.LocalSocket._isConnected7674);
		}
		public new global::android.net.LocalSocketAddress LocalSocketAddress
		{
			get
			{
				return getLocalSocketAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalSocketAddress7675;
		public virtual global::android.net.LocalSocketAddress getLocalSocketAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.LocalSocket.staticClass, "getLocalSocketAddress", "()Landroid/net/LocalSocketAddress;", ref global::android.net.LocalSocket._getLocalSocketAddress7675) as android.net.LocalSocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _shutdownInput7676;
		public virtual void shutdownInput()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.LocalSocket.staticClass, "shutdownInput", "()V", ref global::android.net.LocalSocket._shutdownInput7676);
		}
		internal static global::MonoJavaBridge.MethodId _shutdownOutput7677;
		public virtual void shutdownOutput()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.LocalSocket.staticClass, "shutdownOutput", "()V", ref global::android.net.LocalSocket._shutdownOutput7677);
		}
		internal static global::MonoJavaBridge.MethodId _setReceiveBufferSize7678;
		public virtual void setReceiveBufferSize(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.LocalSocket.staticClass, "setReceiveBufferSize", "(I)V", ref global::android.net.LocalSocket._setReceiveBufferSize7678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getReceiveBufferSize7679;
		public virtual int getReceiveBufferSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.LocalSocket.staticClass, "getReceiveBufferSize", "()I", ref global::android.net.LocalSocket._getReceiveBufferSize7679);
		}
		internal static global::MonoJavaBridge.MethodId _setSoTimeout7680;
		public virtual void setSoTimeout(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.LocalSocket.staticClass, "setSoTimeout", "(I)V", ref global::android.net.LocalSocket._setSoTimeout7680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSoTimeout7681;
		public virtual int getSoTimeout()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.LocalSocket.staticClass, "getSoTimeout", "()I", ref global::android.net.LocalSocket._getSoTimeout7681);
		}
		internal static global::MonoJavaBridge.MethodId _setSendBufferSize7682;
		public virtual void setSendBufferSize(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.LocalSocket.staticClass, "setSendBufferSize", "(I)V", ref global::android.net.LocalSocket._setSendBufferSize7682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSendBufferSize7683;
		public virtual int getSendBufferSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.LocalSocket.staticClass, "getSendBufferSize", "()I", ref global::android.net.LocalSocket._getSendBufferSize7683);
		}
		public new global::android.net.LocalSocketAddress RemoteSocketAddress
		{
			get
			{
				return getRemoteSocketAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRemoteSocketAddress7684;
		public virtual global::android.net.LocalSocketAddress getRemoteSocketAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.LocalSocket.staticClass, "getRemoteSocketAddress", "()Landroid/net/LocalSocketAddress;", ref global::android.net.LocalSocket._getRemoteSocketAddress7684) as android.net.LocalSocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _isBound7685;
		public virtual bool isBound()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.LocalSocket.staticClass, "isBound", "()Z", ref global::android.net.LocalSocket._isBound7685);
		}
		internal static global::MonoJavaBridge.MethodId _isOutputShutdown7686;
		public virtual bool isOutputShutdown()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.LocalSocket.staticClass, "isOutputShutdown", "()Z", ref global::android.net.LocalSocket._isOutputShutdown7686);
		}
		internal static global::MonoJavaBridge.MethodId _isInputShutdown7687;
		public virtual bool isInputShutdown()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.LocalSocket.staticClass, "isInputShutdown", "()Z", ref global::android.net.LocalSocket._isInputShutdown7687);
		}
		public new global::java.io.FileDescriptor[] FileDescriptorsForSend
		{
			set
			{
				setFileDescriptorsForSend(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setFileDescriptorsForSend7688;
		public virtual void setFileDescriptorsForSend(java.io.FileDescriptor[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.LocalSocket.staticClass, "setFileDescriptorsForSend", "([Ljava/io/FileDescriptor;)V", ref global::android.net.LocalSocket._setFileDescriptorsForSend7688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.io.FileDescriptor[] AncillaryFileDescriptors
		{
			get
			{
				return getAncillaryFileDescriptors();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAncillaryFileDescriptors7689;
		public virtual global::java.io.FileDescriptor[] getAncillaryFileDescriptors()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.io.FileDescriptor>(this, global::android.net.LocalSocket.staticClass, "getAncillaryFileDescriptors", "()[Ljava/io/FileDescriptor;", ref global::android.net.LocalSocket._getAncillaryFileDescriptors7689) as java.io.FileDescriptor[];
		}
		public new global::android.net.Credentials PeerCredentials
		{
			get
			{
				return getPeerCredentials();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPeerCredentials7690;
		public virtual global::android.net.Credentials getPeerCredentials()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.LocalSocket.staticClass, "getPeerCredentials", "()Landroid/net/Credentials;", ref global::android.net.LocalSocket._getPeerCredentials7690) as android.net.Credentials;
		}
		internal static global::MonoJavaBridge.MethodId _LocalSocket7691;
		public LocalSocket() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.LocalSocket._LocalSocket7691.native == global::System.IntPtr.Zero)
				global::android.net.LocalSocket._LocalSocket7691 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.LocalSocket.staticClass, global::android.net.LocalSocket._LocalSocket7691);
			Init(@__env, handle);
		}
		static LocalSocket()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.LocalSocket.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/LocalSocket"));
		}
		internal static void InitJNI()
		{
		}
	}
}
