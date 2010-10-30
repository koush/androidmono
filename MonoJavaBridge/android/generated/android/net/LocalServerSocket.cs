namespace android.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LocalServerSocket : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LocalServerSocket(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close7659;
		public virtual void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.LocalServerSocket.staticClass, global::android.net.LocalServerSocket._close7659);
		}
		internal static global::MonoJavaBridge.MethodId _accept7660;
		public virtual global::android.net.LocalSocket accept()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.LocalServerSocket.staticClass, global::android.net.LocalServerSocket._accept7660)) as android.net.LocalSocket;
		}
		public new global::java.io.FileDescriptor FileDescriptor
		{
			get
			{
				return getFileDescriptor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFileDescriptor7661;
		public virtual global::java.io.FileDescriptor getFileDescriptor()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.io.FileDescriptor>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.LocalServerSocket.staticClass, global::android.net.LocalServerSocket._getFileDescriptor7661)) as java.io.FileDescriptor;
		}
		public new global::android.net.LocalSocketAddress LocalSocketAddress
		{
			get
			{
				return getLocalSocketAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalSocketAddress7662;
		public virtual global::android.net.LocalSocketAddress getLocalSocketAddress()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.LocalServerSocket.staticClass, global::android.net.LocalServerSocket._getLocalSocketAddress7662)) as android.net.LocalSocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _LocalServerSocket7663;
		public LocalServerSocket(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.LocalServerSocket.staticClass, global::android.net.LocalServerSocket._LocalServerSocket7663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LocalServerSocket7664;
		public LocalServerSocket(java.io.FileDescriptor arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.LocalServerSocket.staticClass, global::android.net.LocalServerSocket._LocalServerSocket7664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static LocalServerSocket()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.LocalServerSocket.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/LocalServerSocket"));
			global::android.net.LocalServerSocket._close7659 = @__env.GetMethodIDNoThrow(global::android.net.LocalServerSocket.staticClass, "close", "()V");
			global::android.net.LocalServerSocket._accept7660 = @__env.GetMethodIDNoThrow(global::android.net.LocalServerSocket.staticClass, "accept", "()Landroid/net/LocalSocket;");
			global::android.net.LocalServerSocket._getFileDescriptor7661 = @__env.GetMethodIDNoThrow(global::android.net.LocalServerSocket.staticClass, "getFileDescriptor", "()Ljava/io/FileDescriptor;");
			global::android.net.LocalServerSocket._getLocalSocketAddress7662 = @__env.GetMethodIDNoThrow(global::android.net.LocalServerSocket.staticClass, "getLocalSocketAddress", "()Landroid/net/LocalSocketAddress;");
			global::android.net.LocalServerSocket._LocalServerSocket7663 = @__env.GetMethodIDNoThrow(global::android.net.LocalServerSocket.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.net.LocalServerSocket._LocalServerSocket7664 = @__env.GetMethodIDNoThrow(global::android.net.LocalServerSocket.staticClass, "<init>", "(Ljava/io/FileDescriptor;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
