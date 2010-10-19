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
		internal static global::MonoJavaBridge.MethodId _toString5154;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.LocalSocket._toString5154)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._toString5154)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _close5155;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.LocalSocket._close5155);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._close5155);
		}
		public new global::java.io.InputStream InputStream
		{
			get
			{
				return getInputStream();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputStream5156;
		public virtual global::java.io.InputStream getInputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.LocalSocket._getInputStream5156)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getInputStream5156)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _connect5157;
		public virtual void connect(android.net.LocalSocketAddress arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.LocalSocket._connect5157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._connect5157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _connect5158;
		public virtual void connect(android.net.LocalSocketAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.LocalSocket._connect5158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._connect5158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isClosed5159;
		public virtual bool isClosed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.LocalSocket._isClosed5159);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._isClosed5159);
		}
		public new global::java.io.OutputStream OutputStream
		{
			get
			{
				return getOutputStream();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOutputStream5160;
		public virtual global::java.io.OutputStream getOutputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.LocalSocket._getOutputStream5160)) as java.io.OutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getOutputStream5160)) as java.io.OutputStream;
		}
		public new global::java.io.FileDescriptor FileDescriptor
		{
			get
			{
				return getFileDescriptor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFileDescriptor5161;
		public virtual global::java.io.FileDescriptor getFileDescriptor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.LocalSocket._getFileDescriptor5161)) as java.io.FileDescriptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getFileDescriptor5161)) as java.io.FileDescriptor;
		}
		internal static global::MonoJavaBridge.MethodId _bind5162;
		public virtual void bind(android.net.LocalSocketAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.LocalSocket._bind5162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._bind5162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isConnected5163;
		public virtual bool isConnected() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.LocalSocket._isConnected5163);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._isConnected5163);
		}
		public new global::android.net.LocalSocketAddress LocalSocketAddress
		{
			get
			{
				return getLocalSocketAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalSocketAddress5164;
		public virtual global::android.net.LocalSocketAddress getLocalSocketAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.LocalSocket._getLocalSocketAddress5164)) as android.net.LocalSocketAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getLocalSocketAddress5164)) as android.net.LocalSocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _shutdownInput5165;
		public virtual void shutdownInput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.LocalSocket._shutdownInput5165);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._shutdownInput5165);
		}
		internal static global::MonoJavaBridge.MethodId _shutdownOutput5166;
		public virtual void shutdownOutput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.LocalSocket._shutdownOutput5166);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._shutdownOutput5166);
		}
		internal static global::MonoJavaBridge.MethodId _setReceiveBufferSize5167;
		public virtual void setReceiveBufferSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.LocalSocket._setReceiveBufferSize5167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._setReceiveBufferSize5167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getReceiveBufferSize5168;
		public virtual int getReceiveBufferSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.LocalSocket._getReceiveBufferSize5168);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getReceiveBufferSize5168);
		}
		internal static global::MonoJavaBridge.MethodId _setSoTimeout5169;
		public virtual void setSoTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.LocalSocket._setSoTimeout5169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._setSoTimeout5169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSoTimeout5170;
		public virtual int getSoTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.LocalSocket._getSoTimeout5170);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getSoTimeout5170);
		}
		internal static global::MonoJavaBridge.MethodId _setSendBufferSize5171;
		public virtual void setSendBufferSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.LocalSocket._setSendBufferSize5171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._setSendBufferSize5171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSendBufferSize5172;
		public virtual int getSendBufferSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.LocalSocket._getSendBufferSize5172);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getSendBufferSize5172);
		}
		public new global::android.net.LocalSocketAddress RemoteSocketAddress
		{
			get
			{
				return getRemoteSocketAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRemoteSocketAddress5173;
		public virtual global::android.net.LocalSocketAddress getRemoteSocketAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.LocalSocket._getRemoteSocketAddress5173)) as android.net.LocalSocketAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getRemoteSocketAddress5173)) as android.net.LocalSocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _isBound5174;
		public virtual bool isBound() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.LocalSocket._isBound5174);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._isBound5174);
		}
		internal static global::MonoJavaBridge.MethodId _isOutputShutdown5175;
		public virtual bool isOutputShutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.LocalSocket._isOutputShutdown5175);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._isOutputShutdown5175);
		}
		internal static global::MonoJavaBridge.MethodId _isInputShutdown5176;
		public virtual bool isInputShutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.LocalSocket._isInputShutdown5176);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._isInputShutdown5176);
		}
		internal static global::MonoJavaBridge.MethodId _setFileDescriptorsForSend5177;
		public virtual void setFileDescriptorsForSend(java.io.FileDescriptor[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.LocalSocket._setFileDescriptorsForSend5177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._setFileDescriptorsForSend5177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.io.FileDescriptor[] AncillaryFileDescriptors
		{
			get
			{
				return getAncillaryFileDescriptors();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAncillaryFileDescriptors5178;
		public virtual global::java.io.FileDescriptor[] getAncillaryFileDescriptors() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.FileDescriptor>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.LocalSocket._getAncillaryFileDescriptors5178)) as java.io.FileDescriptor[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.FileDescriptor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getAncillaryFileDescriptors5178)) as java.io.FileDescriptor[];
		}
		public new global::android.net.Credentials PeerCredentials
		{
			get
			{
				return getPeerCredentials();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPeerCredentials5179;
		public virtual global::android.net.Credentials getPeerCredentials() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.LocalSocket._getPeerCredentials5179)) as android.net.Credentials;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getPeerCredentials5179)) as android.net.Credentials;
		}
		internal static global::MonoJavaBridge.MethodId _LocalSocket5180;
		public LocalSocket()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.LocalSocket.staticClass, global::android.net.LocalSocket._LocalSocket5180);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.LocalSocket.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/LocalSocket"));
			global::android.net.LocalSocket._toString5154 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "toString", "()Ljava/lang/String;");
			global::android.net.LocalSocket._close5155 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "close", "()V");
			global::android.net.LocalSocket._getInputStream5156 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "getInputStream", "()Ljava/io/InputStream;");
			global::android.net.LocalSocket._connect5157 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "connect", "(Landroid/net/LocalSocketAddress;I)V");
			global::android.net.LocalSocket._connect5158 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "connect", "(Landroid/net/LocalSocketAddress;)V");
			global::android.net.LocalSocket._isClosed5159 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "isClosed", "()Z");
			global::android.net.LocalSocket._getOutputStream5160 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "getOutputStream", "()Ljava/io/OutputStream;");
			global::android.net.LocalSocket._getFileDescriptor5161 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "getFileDescriptor", "()Ljava/io/FileDescriptor;");
			global::android.net.LocalSocket._bind5162 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "bind", "(Landroid/net/LocalSocketAddress;)V");
			global::android.net.LocalSocket._isConnected5163 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "isConnected", "()Z");
			global::android.net.LocalSocket._getLocalSocketAddress5164 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "getLocalSocketAddress", "()Landroid/net/LocalSocketAddress;");
			global::android.net.LocalSocket._shutdownInput5165 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "shutdownInput", "()V");
			global::android.net.LocalSocket._shutdownOutput5166 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "shutdownOutput", "()V");
			global::android.net.LocalSocket._setReceiveBufferSize5167 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "setReceiveBufferSize", "(I)V");
			global::android.net.LocalSocket._getReceiveBufferSize5168 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "getReceiveBufferSize", "()I");
			global::android.net.LocalSocket._setSoTimeout5169 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "setSoTimeout", "(I)V");
			global::android.net.LocalSocket._getSoTimeout5170 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "getSoTimeout", "()I");
			global::android.net.LocalSocket._setSendBufferSize5171 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "setSendBufferSize", "(I)V");
			global::android.net.LocalSocket._getSendBufferSize5172 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "getSendBufferSize", "()I");
			global::android.net.LocalSocket._getRemoteSocketAddress5173 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "getRemoteSocketAddress", "()Landroid/net/LocalSocketAddress;");
			global::android.net.LocalSocket._isBound5174 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "isBound", "()Z");
			global::android.net.LocalSocket._isOutputShutdown5175 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "isOutputShutdown", "()Z");
			global::android.net.LocalSocket._isInputShutdown5176 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "isInputShutdown", "()Z");
			global::android.net.LocalSocket._setFileDescriptorsForSend5177 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "setFileDescriptorsForSend", "([Ljava/io/FileDescriptor;)V");
			global::android.net.LocalSocket._getAncillaryFileDescriptors5178 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "getAncillaryFileDescriptors", "()[Ljava/io/FileDescriptor;");
			global::android.net.LocalSocket._getPeerCredentials5179 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "getPeerCredentials", "()Landroid/net/Credentials;");
			global::android.net.LocalSocket._LocalSocket5180 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "<init>", "()V");
		}
	}
}
