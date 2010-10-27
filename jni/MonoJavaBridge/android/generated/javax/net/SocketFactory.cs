namespace javax.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.net.SocketFactory_))]
	public abstract partial class SocketFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SocketFactory()
		{
			InitJNI();
		}
		protected SocketFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getDefault29817;
		public static global::javax.net.SocketFactory getDefault()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.SocketFactory.staticClass, global::javax.net.SocketFactory._getDefault29817)) as javax.net.SocketFactory;
		}
		internal static global::MonoJavaBridge.MethodId _createSocket29818;
		public virtual global::java.net.Socket createSocket()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.SocketFactory._createSocket29818)) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.SocketFactory.staticClass, global::javax.net.SocketFactory._createSocket29818)) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _createSocket29819;
		public abstract global::java.net.Socket createSocket(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _createSocket29820;
		public abstract global::java.net.Socket createSocket(java.lang.String arg0, int arg1, java.net.InetAddress arg2, int arg3);
		internal static global::MonoJavaBridge.MethodId _createSocket29821;
		public abstract global::java.net.Socket createSocket(java.net.InetAddress arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _createSocket29822;
		public abstract global::java.net.Socket createSocket(java.net.InetAddress arg0, int arg1, java.net.InetAddress arg2, int arg3);
		internal static global::MonoJavaBridge.MethodId _SocketFactory29823;
		protected SocketFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.SocketFactory.staticClass, global::javax.net.SocketFactory._SocketFactory29823);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.SocketFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/SocketFactory"));
			global::javax.net.SocketFactory._getDefault29817 = @__env.GetStaticMethodIDNoThrow(global::javax.net.SocketFactory.staticClass, "getDefault", "()Ljavax/net/SocketFactory;");
			global::javax.net.SocketFactory._createSocket29818 = @__env.GetMethodIDNoThrow(global::javax.net.SocketFactory.staticClass, "createSocket", "()Ljava/net/Socket;");
			global::javax.net.SocketFactory._createSocket29819 = @__env.GetMethodIDNoThrow(global::javax.net.SocketFactory.staticClass, "createSocket", "(Ljava/lang/String;I)Ljava/net/Socket;");
			global::javax.net.SocketFactory._createSocket29820 = @__env.GetMethodIDNoThrow(global::javax.net.SocketFactory.staticClass, "createSocket", "(Ljava/lang/String;ILjava/net/InetAddress;I)Ljava/net/Socket;");
			global::javax.net.SocketFactory._createSocket29821 = @__env.GetMethodIDNoThrow(global::javax.net.SocketFactory.staticClass, "createSocket", "(Ljava/net/InetAddress;I)Ljava/net/Socket;");
			global::javax.net.SocketFactory._createSocket29822 = @__env.GetMethodIDNoThrow(global::javax.net.SocketFactory.staticClass, "createSocket", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)Ljava/net/Socket;");
			global::javax.net.SocketFactory._SocketFactory29823 = @__env.GetMethodIDNoThrow(global::javax.net.SocketFactory.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.SocketFactory))]
	internal sealed partial class SocketFactory_ : javax.net.SocketFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SocketFactory_()
		{
			InitJNI();
		}
		internal SocketFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _createSocket29824;
		public override global::java.net.Socket createSocket(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.SocketFactory_._createSocket29824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.SocketFactory_.staticClass, global::javax.net.SocketFactory_._createSocket29824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _createSocket29825;
		public override global::java.net.Socket createSocket(java.lang.String arg0, int arg1, java.net.InetAddress arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.SocketFactory_._createSocket29825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.SocketFactory_.staticClass, global::javax.net.SocketFactory_._createSocket29825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _createSocket29826;
		public override global::java.net.Socket createSocket(java.net.InetAddress arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.SocketFactory_._createSocket29826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.SocketFactory_.staticClass, global::javax.net.SocketFactory_._createSocket29826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _createSocket29827;
		public override global::java.net.Socket createSocket(java.net.InetAddress arg0, int arg1, java.net.InetAddress arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.SocketFactory_._createSocket29827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.SocketFactory_.staticClass, global::javax.net.SocketFactory_._createSocket29827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.net.Socket;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.SocketFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/SocketFactory"));
			global::javax.net.SocketFactory_._createSocket29824 = @__env.GetMethodIDNoThrow(global::javax.net.SocketFactory_.staticClass, "createSocket", "(Ljava/lang/String;I)Ljava/net/Socket;");
			global::javax.net.SocketFactory_._createSocket29825 = @__env.GetMethodIDNoThrow(global::javax.net.SocketFactory_.staticClass, "createSocket", "(Ljava/lang/String;ILjava/net/InetAddress;I)Ljava/net/Socket;");
			global::javax.net.SocketFactory_._createSocket29826 = @__env.GetMethodIDNoThrow(global::javax.net.SocketFactory_.staticClass, "createSocket", "(Ljava/net/InetAddress;I)Ljava/net/Socket;");
			global::javax.net.SocketFactory_._createSocket29827 = @__env.GetMethodIDNoThrow(global::javax.net.SocketFactory_.staticClass, "createSocket", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)Ljava/net/Socket;");
		}
	}
}
