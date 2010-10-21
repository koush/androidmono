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
		internal static global::MonoJavaBridge.MethodId _getOption21657;
		public abstract global::java.lang.Object getOption(int arg0);
		internal static global::MonoJavaBridge.MethodId _setOption21658;
		public abstract void setOption(int arg0, java.lang.Object arg1);
		internal static global::MonoJavaBridge.MethodId _toString21659;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.SocketImpl._toString21659)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.SocketImpl.staticClass, global::java.net.SocketImpl._toString21659)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _close21660;
		protected abstract void close();
		internal static global::MonoJavaBridge.MethodId _accept21661;
		protected abstract void accept(java.net.SocketImpl arg0);
		internal static global::MonoJavaBridge.MethodId _getPort21662;
		protected virtual int getPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.SocketImpl._getPort21662);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.SocketImpl.staticClass, global::java.net.SocketImpl._getPort21662);
		}
		internal static global::MonoJavaBridge.MethodId _create21663;
		protected abstract void create(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getInputStream21664;
		protected abstract global::java.io.InputStream getInputStream();
		internal static global::MonoJavaBridge.MethodId _available21665;
		protected abstract int available();
		internal static global::MonoJavaBridge.MethodId _connect21666;
		protected abstract void connect(java.net.SocketAddress arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _connect21667;
		protected abstract void connect(java.net.InetAddress arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _connect21668;
		protected abstract void connect(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getOutputStream21669;
		protected abstract global::java.io.OutputStream getOutputStream();
		internal static global::MonoJavaBridge.MethodId _getFileDescriptor21670;
		protected virtual global::java.io.FileDescriptor getFileDescriptor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.SocketImpl._getFileDescriptor21670)) as java.io.FileDescriptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.SocketImpl.staticClass, global::java.net.SocketImpl._getFileDescriptor21670)) as java.io.FileDescriptor;
		}
		internal static global::MonoJavaBridge.MethodId _listen21671;
		protected abstract void listen(int arg0);
		internal static global::MonoJavaBridge.MethodId _bind21672;
		protected abstract void bind(java.net.InetAddress arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _shutdownInput21673;
		protected virtual void shutdownInput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl._shutdownInput21673);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl.staticClass, global::java.net.SocketImpl._shutdownInput21673);
		}
		internal static global::MonoJavaBridge.MethodId _shutdownOutput21674;
		protected virtual void shutdownOutput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl._shutdownOutput21674);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl.staticClass, global::java.net.SocketImpl._shutdownOutput21674);
		}
		internal static global::MonoJavaBridge.MethodId _getInetAddress21675;
		protected virtual global::java.net.InetAddress getInetAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.SocketImpl._getInetAddress21675)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.SocketImpl.staticClass, global::java.net.SocketImpl._getInetAddress21675)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort21676;
		protected virtual int getLocalPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.SocketImpl._getLocalPort21676);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.SocketImpl.staticClass, global::java.net.SocketImpl._getLocalPort21676);
		}
		internal static global::MonoJavaBridge.MethodId _sendUrgentData21677;
		protected abstract void sendUrgentData(int arg0);
		internal static global::MonoJavaBridge.MethodId _setPerformancePreferences21678;
		protected virtual void setPerformancePreferences(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl._setPerformancePreferences21678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl.staticClass, global::java.net.SocketImpl._setPerformancePreferences21678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _supportsUrgentData21679;
		protected virtual bool supportsUrgentData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.SocketImpl._supportsUrgentData21679);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.SocketImpl.staticClass, global::java.net.SocketImpl._supportsUrgentData21679);
		}
		internal static global::MonoJavaBridge.MethodId _SocketImpl21680;
		public SocketImpl()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.SocketImpl.staticClass, global::java.net.SocketImpl._SocketImpl21680);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.SocketImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/SocketImpl"));
			global::java.net.SocketImpl._getOption21657 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "getOption", "(I)Ljava/lang/Object;");
			global::java.net.SocketImpl._setOption21658 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "setOption", "(ILjava/lang/Object;)V");
			global::java.net.SocketImpl._toString21659 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "toString", "()Ljava/lang/String;");
			global::java.net.SocketImpl._close21660 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "close", "()V");
			global::java.net.SocketImpl._accept21661 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "accept", "(Ljava/net/SocketImpl;)V");
			global::java.net.SocketImpl._getPort21662 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "getPort", "()I");
			global::java.net.SocketImpl._create21663 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "create", "(Z)V");
			global::java.net.SocketImpl._getInputStream21664 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "getInputStream", "()Ljava/io/InputStream;");
			global::java.net.SocketImpl._available21665 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "available", "()I");
			global::java.net.SocketImpl._connect21666 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "connect", "(Ljava/net/SocketAddress;I)V");
			global::java.net.SocketImpl._connect21667 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "connect", "(Ljava/net/InetAddress;I)V");
			global::java.net.SocketImpl._connect21668 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "connect", "(Ljava/lang/String;I)V");
			global::java.net.SocketImpl._getOutputStream21669 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "getOutputStream", "()Ljava/io/OutputStream;");
			global::java.net.SocketImpl._getFileDescriptor21670 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "getFileDescriptor", "()Ljava/io/FileDescriptor;");
			global::java.net.SocketImpl._listen21671 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "listen", "(I)V");
			global::java.net.SocketImpl._bind21672 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "bind", "(Ljava/net/InetAddress;I)V");
			global::java.net.SocketImpl._shutdownInput21673 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "shutdownInput", "()V");
			global::java.net.SocketImpl._shutdownOutput21674 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "shutdownOutput", "()V");
			global::java.net.SocketImpl._getInetAddress21675 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "getInetAddress", "()Ljava/net/InetAddress;");
			global::java.net.SocketImpl._getLocalPort21676 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "getLocalPort", "()I");
			global::java.net.SocketImpl._sendUrgentData21677 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "sendUrgentData", "(I)V");
			global::java.net.SocketImpl._setPerformancePreferences21678 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "setPerformancePreferences", "(III)V");
			global::java.net.SocketImpl._supportsUrgentData21679 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "supportsUrgentData", "()Z");
			global::java.net.SocketImpl._SocketImpl21680 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _getOption21681;
		public override global::java.lang.Object getOption(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.SocketImpl_._getOption21681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._getOption21681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setOption21682;
		public override void setOption(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl_._setOption21682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._setOption21682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _close21683;
		protected override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl_._close21683);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._close21683);
		}
		internal static global::MonoJavaBridge.MethodId _accept21684;
		protected override void accept(java.net.SocketImpl arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl_._accept21684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._accept21684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _create21685;
		protected override void create(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl_._create21685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._create21685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInputStream21686;
		protected override global::java.io.InputStream getInputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.SocketImpl_._getInputStream21686)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._getInputStream21686)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _available21687;
		protected override int available() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.SocketImpl_._available21687);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._available21687);
		}
		internal static global::MonoJavaBridge.MethodId _connect21688;
		protected override void connect(java.net.SocketAddress arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl_._connect21688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._connect21688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _connect21689;
		protected override void connect(java.net.InetAddress arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl_._connect21689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._connect21689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _connect21690;
		protected override void connect(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl_._connect21690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._connect21690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getOutputStream21691;
		protected override global::java.io.OutputStream getOutputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.SocketImpl_._getOutputStream21691)) as java.io.OutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._getOutputStream21691)) as java.io.OutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _listen21692;
		protected override void listen(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl_._listen21692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._listen21692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bind21693;
		protected override void bind(java.net.InetAddress arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl_._bind21693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._bind21693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sendUrgentData21694;
		protected override void sendUrgentData(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl_._sendUrgentData21694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._sendUrgentData21694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.SocketImpl_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/SocketImpl"));
			global::java.net.SocketImpl_._getOption21681 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "getOption", "(I)Ljava/lang/Object;");
			global::java.net.SocketImpl_._setOption21682 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "setOption", "(ILjava/lang/Object;)V");
			global::java.net.SocketImpl_._close21683 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "close", "()V");
			global::java.net.SocketImpl_._accept21684 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "accept", "(Ljava/net/SocketImpl;)V");
			global::java.net.SocketImpl_._create21685 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "create", "(Z)V");
			global::java.net.SocketImpl_._getInputStream21686 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "getInputStream", "()Ljava/io/InputStream;");
			global::java.net.SocketImpl_._available21687 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "available", "()I");
			global::java.net.SocketImpl_._connect21688 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "connect", "(Ljava/net/SocketAddress;I)V");
			global::java.net.SocketImpl_._connect21689 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "connect", "(Ljava/net/InetAddress;I)V");
			global::java.net.SocketImpl_._connect21690 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "connect", "(Ljava/lang/String;I)V");
			global::java.net.SocketImpl_._getOutputStream21691 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "getOutputStream", "()Ljava/io/OutputStream;");
			global::java.net.SocketImpl_._listen21692 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "listen", "(I)V");
			global::java.net.SocketImpl_._bind21693 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "bind", "(Ljava/net/InetAddress;I)V");
			global::java.net.SocketImpl_._sendUrgentData21694 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "sendUrgentData", "(I)V");
		}
	}
}
