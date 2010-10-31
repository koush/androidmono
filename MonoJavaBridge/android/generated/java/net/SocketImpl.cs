namespace java.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.net.SocketImpl_))]
	public abstract partial class SocketImpl : java.lang.Object, SocketOptions
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SocketImpl(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract global::java.lang.Object getOption(int arg0);
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract void setOption(int arg0, java.lang.Object arg1);
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.SocketImpl.staticClass, "toString", "()Ljava/lang/String;", ref global::java.net.SocketImpl._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected abstract void close();
		private static global::MonoJavaBridge.MethodId _m4;
		protected abstract void accept(java.net.SocketImpl arg0);
		private static global::MonoJavaBridge.MethodId _m5;
		protected virtual int getPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.SocketImpl.staticClass, "getPort", "()I", ref global::java.net.SocketImpl._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected abstract void create(bool arg0);
		private static global::MonoJavaBridge.MethodId _m7;
		protected abstract global::java.io.InputStream getInputStream();
		private static global::MonoJavaBridge.MethodId _m8;
		protected abstract int available();
		private static global::MonoJavaBridge.MethodId _m9;
		protected abstract void connect(java.net.SocketAddress arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m10;
		protected abstract void connect(java.net.InetAddress arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m11;
		protected abstract void connect(java.lang.String arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m12;
		protected abstract global::java.io.OutputStream getOutputStream();
		private static global::MonoJavaBridge.MethodId _m13;
		protected virtual global::java.io.FileDescriptor getFileDescriptor()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.io.FileDescriptor>(this, global::java.net.SocketImpl.staticClass, "getFileDescriptor", "()Ljava/io/FileDescriptor;", ref global::java.net.SocketImpl._m13) as java.io.FileDescriptor;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		protected abstract void listen(int arg0);
		private static global::MonoJavaBridge.MethodId _m15;
		protected abstract void bind(java.net.InetAddress arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m16;
		protected virtual void shutdownInput()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.SocketImpl.staticClass, "shutdownInput", "()V", ref global::java.net.SocketImpl._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		protected virtual void shutdownOutput()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.SocketImpl.staticClass, "shutdownOutput", "()V", ref global::java.net.SocketImpl._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		protected virtual global::java.net.InetAddress getInetAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.SocketImpl.staticClass, "getInetAddress", "()Ljava/net/InetAddress;", ref global::java.net.SocketImpl._m18) as java.net.InetAddress;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		protected virtual int getLocalPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.SocketImpl.staticClass, "getLocalPort", "()I", ref global::java.net.SocketImpl._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		protected abstract void sendUrgentData(int arg0);
		private static global::MonoJavaBridge.MethodId _m21;
		protected virtual void setPerformancePreferences(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.SocketImpl.staticClass, "setPerformancePreferences", "(III)V", ref global::java.net.SocketImpl._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		protected virtual bool supportsUrgentData()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.SocketImpl.staticClass, "supportsUrgentData", "()Z", ref global::java.net.SocketImpl._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public SocketImpl() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.SocketImpl._m23.native == global::System.IntPtr.Zero)
				global::java.net.SocketImpl._m23 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.SocketImpl.staticClass, global::java.net.SocketImpl._m23);
			Init(@__env, handle);
		}
		static SocketImpl()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.SocketImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/SocketImpl"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.SocketImpl))]
	internal sealed partial class SocketImpl_ : java.net.SocketImpl
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SocketImpl_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.Object getOption(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.SocketImpl_.staticClass, "getOption", "(I)Ljava/lang/Object;", ref global::java.net.SocketImpl_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void setOption(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.SocketImpl_.staticClass, "setOption", "(ILjava/lang/Object;)V", ref global::java.net.SocketImpl_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.SocketImpl_.staticClass, "close", "()V", ref global::java.net.SocketImpl_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override void accept(java.net.SocketImpl arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.SocketImpl_.staticClass, "accept", "(Ljava/net/SocketImpl;)V", ref global::java.net.SocketImpl_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected override void create(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.SocketImpl_.staticClass, "create", "(Z)V", ref global::java.net.SocketImpl_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override global::java.io.InputStream getInputStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.SocketImpl_.staticClass, "getInputStream", "()Ljava/io/InputStream;", ref global::java.net.SocketImpl_._m5) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected override int available()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.SocketImpl_.staticClass, "available", "()I", ref global::java.net.SocketImpl_._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected override void connect(java.net.SocketAddress arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.SocketImpl_.staticClass, "connect", "(Ljava/net/SocketAddress;I)V", ref global::java.net.SocketImpl_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected override void connect(java.net.InetAddress arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.SocketImpl_.staticClass, "connect", "(Ljava/net/InetAddress;I)V", ref global::java.net.SocketImpl_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected override void connect(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.SocketImpl_.staticClass, "connect", "(Ljava/lang/String;I)V", ref global::java.net.SocketImpl_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected override global::java.io.OutputStream getOutputStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.SocketImpl_.staticClass, "getOutputStream", "()Ljava/io/OutputStream;", ref global::java.net.SocketImpl_._m10) as java.io.OutputStream;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		protected override void listen(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.SocketImpl_.staticClass, "listen", "(I)V", ref global::java.net.SocketImpl_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		protected override void bind(java.net.InetAddress arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.SocketImpl_.staticClass, "bind", "(Ljava/net/InetAddress;I)V", ref global::java.net.SocketImpl_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		protected override void sendUrgentData(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.SocketImpl_.staticClass, "sendUrgentData", "(I)V", ref global::java.net.SocketImpl_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static SocketImpl_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.SocketImpl_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/SocketImpl"));
		}
	}
}
