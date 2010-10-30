namespace android.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LocalSocket : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LocalSocket(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.LocalSocket.staticClass, "toString", "()Ljava/lang/String;", ref global::android.net.LocalSocket._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.LocalSocket.staticClass, "close", "()V", ref global::android.net.LocalSocket._m1);
		}
		public new global::java.io.InputStream InputStream
		{
			get
			{
				return getInputStream();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.io.InputStream getInputStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.LocalSocket.staticClass, "getInputStream", "()Ljava/io/InputStream;", ref global::android.net.LocalSocket._m2) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void connect(android.net.LocalSocketAddress arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.LocalSocket.staticClass, "connect", "(Landroid/net/LocalSocketAddress;I)V", ref global::android.net.LocalSocket._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void connect(android.net.LocalSocketAddress arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.LocalSocket.staticClass, "connect", "(Landroid/net/LocalSocketAddress;)V", ref global::android.net.LocalSocket._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool isClosed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.LocalSocket.staticClass, "isClosed", "()Z", ref global::android.net.LocalSocket._m5);
		}
		public new global::java.io.OutputStream OutputStream
		{
			get
			{
				return getOutputStream();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.io.OutputStream getOutputStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.LocalSocket.staticClass, "getOutputStream", "()Ljava/io/OutputStream;", ref global::android.net.LocalSocket._m6) as java.io.OutputStream;
		}
		public new global::java.io.FileDescriptor FileDescriptor
		{
			get
			{
				return getFileDescriptor();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.io.FileDescriptor getFileDescriptor()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.io.FileDescriptor>(this, global::android.net.LocalSocket.staticClass, "getFileDescriptor", "()Ljava/io/FileDescriptor;", ref global::android.net.LocalSocket._m7) as java.io.FileDescriptor;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void bind(android.net.LocalSocketAddress arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.LocalSocket.staticClass, "bind", "(Landroid/net/LocalSocketAddress;)V", ref global::android.net.LocalSocket._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual bool isConnected()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.LocalSocket.staticClass, "isConnected", "()Z", ref global::android.net.LocalSocket._m9);
		}
		public new global::android.net.LocalSocketAddress LocalSocketAddress
		{
			get
			{
				return getLocalSocketAddress();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::android.net.LocalSocketAddress getLocalSocketAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.LocalSocket.staticClass, "getLocalSocketAddress", "()Landroid/net/LocalSocketAddress;", ref global::android.net.LocalSocket._m10) as android.net.LocalSocketAddress;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void shutdownInput()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.LocalSocket.staticClass, "shutdownInput", "()V", ref global::android.net.LocalSocket._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void shutdownOutput()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.LocalSocket.staticClass, "shutdownOutput", "()V", ref global::android.net.LocalSocket._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void setReceiveBufferSize(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.LocalSocket.staticClass, "setReceiveBufferSize", "(I)V", ref global::android.net.LocalSocket._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual int getReceiveBufferSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.LocalSocket.staticClass, "getReceiveBufferSize", "()I", ref global::android.net.LocalSocket._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setSoTimeout(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.LocalSocket.staticClass, "setSoTimeout", "(I)V", ref global::android.net.LocalSocket._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual int getSoTimeout()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.LocalSocket.staticClass, "getSoTimeout", "()I", ref global::android.net.LocalSocket._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setSendBufferSize(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.LocalSocket.staticClass, "setSendBufferSize", "(I)V", ref global::android.net.LocalSocket._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual int getSendBufferSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.LocalSocket.staticClass, "getSendBufferSize", "()I", ref global::android.net.LocalSocket._m18);
		}
		public new global::android.net.LocalSocketAddress RemoteSocketAddress
		{
			get
			{
				return getRemoteSocketAddress();
			}
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual global::android.net.LocalSocketAddress getRemoteSocketAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.LocalSocket.staticClass, "getRemoteSocketAddress", "()Landroid/net/LocalSocketAddress;", ref global::android.net.LocalSocket._m19) as android.net.LocalSocketAddress;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual bool isBound()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.LocalSocket.staticClass, "isBound", "()Z", ref global::android.net.LocalSocket._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual bool isOutputShutdown()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.LocalSocket.staticClass, "isOutputShutdown", "()Z", ref global::android.net.LocalSocket._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual bool isInputShutdown()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.LocalSocket.staticClass, "isInputShutdown", "()Z", ref global::android.net.LocalSocket._m22);
		}
		public new global::java.io.FileDescriptor[] FileDescriptorsForSend
		{
			set
			{
				setFileDescriptorsForSend(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual void setFileDescriptorsForSend(java.io.FileDescriptor[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.LocalSocket.staticClass, "setFileDescriptorsForSend", "([Ljava/io/FileDescriptor;)V", ref global::android.net.LocalSocket._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.io.FileDescriptor[] AncillaryFileDescriptors
		{
			get
			{
				return getAncillaryFileDescriptors();
			}
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual global::java.io.FileDescriptor[] getAncillaryFileDescriptors()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.io.FileDescriptor>(this, global::android.net.LocalSocket.staticClass, "getAncillaryFileDescriptors", "()[Ljava/io/FileDescriptor;", ref global::android.net.LocalSocket._m24) as java.io.FileDescriptor[];
		}
		public new global::android.net.Credentials PeerCredentials
		{
			get
			{
				return getPeerCredentials();
			}
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual global::android.net.Credentials getPeerCredentials()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.LocalSocket.staticClass, "getPeerCredentials", "()Landroid/net/Credentials;", ref global::android.net.LocalSocket._m25) as android.net.Credentials;
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public LocalSocket() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.LocalSocket._m26.native == global::System.IntPtr.Zero)
				global::android.net.LocalSocket._m26 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.LocalSocket.staticClass, global::android.net.LocalSocket._m26);
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
