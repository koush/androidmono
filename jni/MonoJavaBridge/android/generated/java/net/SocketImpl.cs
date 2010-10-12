namespace java.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.net.SocketImpl_))]
	public abstract partial class SocketImpl : java.lang.Object, SocketOptions
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SocketImpl()
		{
			InitJNI();
		}
		protected SocketImpl(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getOption13810;
		public abstract global::java.lang.Object getOption(int arg0);
		internal static global::MonoJavaBridge.MethodId _setOption13811;
		public abstract void setOption(int arg0, java.lang.Object arg1);
		internal static global::MonoJavaBridge.MethodId _toString13812;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.SocketImpl._toString13812)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.SocketImpl.staticClass, global::java.net.SocketImpl._toString13812)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _close13813;
		protected abstract void close();
		internal static global::MonoJavaBridge.MethodId _accept13814;
		protected abstract void accept(java.net.SocketImpl arg0);
		internal static global::MonoJavaBridge.MethodId _getPort13815;
		protected virtual int getPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.SocketImpl._getPort13815);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.SocketImpl.staticClass, global::java.net.SocketImpl._getPort13815);
		}
		internal static global::MonoJavaBridge.MethodId _create13816;
		protected abstract void create(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getInputStream13817;
		protected abstract global::java.io.InputStream getInputStream();
		internal static global::MonoJavaBridge.MethodId _available13818;
		protected abstract int available();
		internal static global::MonoJavaBridge.MethodId _connect13819;
		protected abstract void connect(java.net.SocketAddress arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _connect13820;
		protected abstract void connect(java.net.InetAddress arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _connect13821;
		protected abstract void connect(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getOutputStream13822;
		protected abstract global::java.io.OutputStream getOutputStream();
		internal static global::MonoJavaBridge.MethodId _getFileDescriptor13823;
		protected virtual global::java.io.FileDescriptor getFileDescriptor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.SocketImpl._getFileDescriptor13823)) as java.io.FileDescriptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.SocketImpl.staticClass, global::java.net.SocketImpl._getFileDescriptor13823)) as java.io.FileDescriptor;
		}
		internal static global::MonoJavaBridge.MethodId _listen13824;
		protected abstract void listen(int arg0);
		internal static global::MonoJavaBridge.MethodId _bind13825;
		protected abstract void bind(java.net.InetAddress arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _shutdownInput13826;
		protected virtual void shutdownInput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl._shutdownInput13826);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl.staticClass, global::java.net.SocketImpl._shutdownInput13826);
		}
		internal static global::MonoJavaBridge.MethodId _shutdownOutput13827;
		protected virtual void shutdownOutput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl._shutdownOutput13827);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl.staticClass, global::java.net.SocketImpl._shutdownOutput13827);
		}
		internal static global::MonoJavaBridge.MethodId _getInetAddress13828;
		protected virtual global::java.net.InetAddress getInetAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.SocketImpl._getInetAddress13828)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.SocketImpl.staticClass, global::java.net.SocketImpl._getInetAddress13828)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort13829;
		protected virtual int getLocalPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.SocketImpl._getLocalPort13829);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.SocketImpl.staticClass, global::java.net.SocketImpl._getLocalPort13829);
		}
		internal static global::MonoJavaBridge.MethodId _sendUrgentData13830;
		protected abstract void sendUrgentData(int arg0);
		internal static global::MonoJavaBridge.MethodId _setPerformancePreferences13831;
		protected virtual void setPerformancePreferences(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl._setPerformancePreferences13831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl.staticClass, global::java.net.SocketImpl._setPerformancePreferences13831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _supportsUrgentData13832;
		protected virtual bool supportsUrgentData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.SocketImpl._supportsUrgentData13832);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.SocketImpl.staticClass, global::java.net.SocketImpl._supportsUrgentData13832);
		}
		internal static global::MonoJavaBridge.MethodId _SocketImpl13833;
		public SocketImpl()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.SocketImpl.staticClass, global::java.net.SocketImpl._SocketImpl13833);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.SocketImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/SocketImpl"));
			global::java.net.SocketImpl._getOption13810 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "getOption", "(I)Ljava/lang/Object;");
			global::java.net.SocketImpl._setOption13811 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "setOption", "(ILjava/lang/Object;)V");
			global::java.net.SocketImpl._toString13812 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "toString", "()Ljava/lang/String;");
			global::java.net.SocketImpl._close13813 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "close", "()V");
			global::java.net.SocketImpl._accept13814 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "accept", "(Ljava/net/SocketImpl;)V");
			global::java.net.SocketImpl._getPort13815 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "getPort", "()I");
			global::java.net.SocketImpl._create13816 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "create", "(Z)V");
			global::java.net.SocketImpl._getInputStream13817 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "getInputStream", "()Ljava/io/InputStream;");
			global::java.net.SocketImpl._available13818 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "available", "()I");
			global::java.net.SocketImpl._connect13819 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "connect", "(Ljava/net/SocketAddress;I)V");
			global::java.net.SocketImpl._connect13820 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "connect", "(Ljava/net/InetAddress;I)V");
			global::java.net.SocketImpl._connect13821 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "connect", "(Ljava/lang/String;I)V");
			global::java.net.SocketImpl._getOutputStream13822 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "getOutputStream", "()Ljava/io/OutputStream;");
			global::java.net.SocketImpl._getFileDescriptor13823 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "getFileDescriptor", "()Ljava/io/FileDescriptor;");
			global::java.net.SocketImpl._listen13824 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "listen", "(I)V");
			global::java.net.SocketImpl._bind13825 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "bind", "(Ljava/net/InetAddress;I)V");
			global::java.net.SocketImpl._shutdownInput13826 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "shutdownInput", "()V");
			global::java.net.SocketImpl._shutdownOutput13827 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "shutdownOutput", "()V");
			global::java.net.SocketImpl._getInetAddress13828 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "getInetAddress", "()Ljava/net/InetAddress;");
			global::java.net.SocketImpl._getLocalPort13829 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "getLocalPort", "()I");
			global::java.net.SocketImpl._sendUrgentData13830 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "sendUrgentData", "(I)V");
			global::java.net.SocketImpl._setPerformancePreferences13831 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "setPerformancePreferences", "(III)V");
			global::java.net.SocketImpl._supportsUrgentData13832 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "supportsUrgentData", "()Z");
			global::java.net.SocketImpl._SocketImpl13833 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.SocketImpl))]
	public sealed partial class SocketImpl_ : java.net.SocketImpl
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SocketImpl_()
		{
			InitJNI();
		}
		internal SocketImpl_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getOption13834;
		public override global::java.lang.Object getOption(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.SocketImpl_._getOption13834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._getOption13834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setOption13835;
		public override void setOption(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl_._setOption13835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._setOption13835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _close13836;
		protected override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl_._close13836);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._close13836);
		}
		internal static global::MonoJavaBridge.MethodId _accept13837;
		protected override void accept(java.net.SocketImpl arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl_._accept13837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._accept13837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _create13838;
		protected override void create(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl_._create13838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._create13838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInputStream13839;
		protected override global::java.io.InputStream getInputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.SocketImpl_._getInputStream13839)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._getInputStream13839)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _available13840;
		protected override int available() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.SocketImpl_._available13840);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._available13840);
		}
		internal static global::MonoJavaBridge.MethodId _connect13841;
		protected override void connect(java.net.SocketAddress arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl_._connect13841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._connect13841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _connect13842;
		protected override void connect(java.net.InetAddress arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl_._connect13842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._connect13842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _connect13843;
		protected override void connect(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl_._connect13843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._connect13843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getOutputStream13844;
		protected override global::java.io.OutputStream getOutputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.SocketImpl_._getOutputStream13844)) as java.io.OutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._getOutputStream13844)) as java.io.OutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _listen13845;
		protected override void listen(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl_._listen13845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._listen13845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bind13846;
		protected override void bind(java.net.InetAddress arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl_._bind13846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._bind13846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sendUrgentData13847;
		protected override void sendUrgentData(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl_._sendUrgentData13847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._sendUrgentData13847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.SocketImpl_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/SocketImpl"));
			global::java.net.SocketImpl_._getOption13834 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "getOption", "(I)Ljava/lang/Object;");
			global::java.net.SocketImpl_._setOption13835 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "setOption", "(ILjava/lang/Object;)V");
			global::java.net.SocketImpl_._close13836 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "close", "()V");
			global::java.net.SocketImpl_._accept13837 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "accept", "(Ljava/net/SocketImpl;)V");
			global::java.net.SocketImpl_._create13838 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "create", "(Z)V");
			global::java.net.SocketImpl_._getInputStream13839 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "getInputStream", "()Ljava/io/InputStream;");
			global::java.net.SocketImpl_._available13840 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "available", "()I");
			global::java.net.SocketImpl_._connect13841 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "connect", "(Ljava/net/SocketAddress;I)V");
			global::java.net.SocketImpl_._connect13842 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "connect", "(Ljava/net/InetAddress;I)V");
			global::java.net.SocketImpl_._connect13843 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "connect", "(Ljava/lang/String;I)V");
			global::java.net.SocketImpl_._getOutputStream13844 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "getOutputStream", "()Ljava/io/OutputStream;");
			global::java.net.SocketImpl_._listen13845 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "listen", "(I)V");
			global::java.net.SocketImpl_._bind13846 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "bind", "(Ljava/net/InetAddress;I)V");
			global::java.net.SocketImpl_._sendUrgentData13847 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "sendUrgentData", "(I)V");
		}
	}
}
