namespace android.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LocalServerSocket : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LocalServerSocket(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.LocalServerSocket.staticClass, "close", "()V", ref global::android.net.LocalServerSocket._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::android.net.LocalSocket accept()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.LocalServerSocket.staticClass, "accept", "()Landroid/net/LocalSocket;", ref global::android.net.LocalServerSocket._m1) as android.net.LocalSocket;
		}
		public new global::java.io.FileDescriptor FileDescriptor
		{
			get
			{
				return getFileDescriptor();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.io.FileDescriptor getFileDescriptor()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.io.FileDescriptor>(this, global::android.net.LocalServerSocket.staticClass, "getFileDescriptor", "()Ljava/io/FileDescriptor;", ref global::android.net.LocalServerSocket._m2) as java.io.FileDescriptor;
		}
		public new global::android.net.LocalSocketAddress LocalSocketAddress
		{
			get
			{
				return getLocalSocketAddress();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::android.net.LocalSocketAddress getLocalSocketAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.LocalServerSocket.staticClass, "getLocalSocketAddress", "()Landroid/net/LocalSocketAddress;", ref global::android.net.LocalServerSocket._m3) as android.net.LocalSocketAddress;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public LocalServerSocket(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.LocalServerSocket._m4.native == global::System.IntPtr.Zero)
				global::android.net.LocalServerSocket._m4 = @__env.GetMethodIDNoThrow(global::android.net.LocalServerSocket.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.LocalServerSocket.staticClass, global::android.net.LocalServerSocket._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public LocalServerSocket(java.io.FileDescriptor arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.LocalServerSocket._m5.native == global::System.IntPtr.Zero)
				global::android.net.LocalServerSocket._m5 = @__env.GetMethodIDNoThrow(global::android.net.LocalServerSocket.staticClass, "<init>", "(Ljava/io/FileDescriptor;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.LocalServerSocket.staticClass, global::android.net.LocalServerSocket._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static LocalServerSocket()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.LocalServerSocket.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/LocalServerSocket"));
		}
	}
}
