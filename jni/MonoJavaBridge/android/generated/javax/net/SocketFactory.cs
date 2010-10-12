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
		internal static global::MonoJavaBridge.MethodId _getDefault15950;
		public static global::javax.net.SocketFactory getDefault() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.SocketFactory.staticClass, global::javax.net.SocketFactory._getDefault15950)) as javax.net.SocketFactory;
		}
		internal static global::MonoJavaBridge.MethodId _createSocket15951;
		public virtual global::java.net.Socket createSocket() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.SocketFactory._createSocket15951)) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.SocketFactory.staticClass, global::javax.net.SocketFactory._createSocket15951)) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _createSocket15952;
		public abstract global::java.net.Socket createSocket(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _createSocket15953;
		public abstract global::java.net.Socket createSocket(java.lang.String arg0, int arg1, java.net.InetAddress arg2, int arg3);
		internal static global::MonoJavaBridge.MethodId _createSocket15954;
		public abstract global::java.net.Socket createSocket(java.net.InetAddress arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _createSocket15955;
		public abstract global::java.net.Socket createSocket(java.net.InetAddress arg0, int arg1, java.net.InetAddress arg2, int arg3);
		internal static global::MonoJavaBridge.MethodId _SocketFactory15956;
		protected SocketFactory()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.SocketFactory.staticClass, global::javax.net.SocketFactory._SocketFactory15956);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.SocketFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/SocketFactory"));
			global::javax.net.SocketFactory._getDefault15950 = @__env.GetStaticMethodIDNoThrow(global::javax.net.SocketFactory.staticClass, "getDefault", "()Ljavax/net/SocketFactory;");
			global::javax.net.SocketFactory._createSocket15951 = @__env.GetMethodIDNoThrow(global::javax.net.SocketFactory.staticClass, "createSocket", "()Ljava/net/Socket;");
			global::javax.net.SocketFactory._createSocket15952 = @__env.GetMethodIDNoThrow(global::javax.net.SocketFactory.staticClass, "createSocket", "(Ljava/lang/String;I)Ljava/net/Socket;");
			global::javax.net.SocketFactory._createSocket15953 = @__env.GetMethodIDNoThrow(global::javax.net.SocketFactory.staticClass, "createSocket", "(Ljava/lang/String;ILjava/net/InetAddress;I)Ljava/net/Socket;");
			global::javax.net.SocketFactory._createSocket15954 = @__env.GetMethodIDNoThrow(global::javax.net.SocketFactory.staticClass, "createSocket", "(Ljava/net/InetAddress;I)Ljava/net/Socket;");
			global::javax.net.SocketFactory._createSocket15955 = @__env.GetMethodIDNoThrow(global::javax.net.SocketFactory.staticClass, "createSocket", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)Ljava/net/Socket;");
			global::javax.net.SocketFactory._SocketFactory15956 = @__env.GetMethodIDNoThrow(global::javax.net.SocketFactory.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.SocketFactory))]
	public sealed partial class SocketFactory_ : javax.net.SocketFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SocketFactory_()
		{
			InitJNI();
		}
		internal SocketFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _createSocket15957;
		public override global::java.net.Socket createSocket(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.SocketFactory_._createSocket15957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.SocketFactory_.staticClass, global::javax.net.SocketFactory_._createSocket15957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _createSocket15958;
		public override global::java.net.Socket createSocket(java.lang.String arg0, int arg1, java.net.InetAddress arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.SocketFactory_._createSocket15958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.SocketFactory_.staticClass, global::javax.net.SocketFactory_._createSocket15958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _createSocket15959;
		public override global::java.net.Socket createSocket(java.net.InetAddress arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.SocketFactory_._createSocket15959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.SocketFactory_.staticClass, global::javax.net.SocketFactory_._createSocket15959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _createSocket15960;
		public override global::java.net.Socket createSocket(java.net.InetAddress arg0, int arg1, java.net.InetAddress arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.SocketFactory_._createSocket15960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.SocketFactory_.staticClass, global::javax.net.SocketFactory_._createSocket15960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.net.Socket;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.SocketFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/SocketFactory"));
			global::javax.net.SocketFactory_._createSocket15957 = @__env.GetMethodIDNoThrow(global::javax.net.SocketFactory_.staticClass, "createSocket", "(Ljava/lang/String;I)Ljava/net/Socket;");
			global::javax.net.SocketFactory_._createSocket15958 = @__env.GetMethodIDNoThrow(global::javax.net.SocketFactory_.staticClass, "createSocket", "(Ljava/lang/String;ILjava/net/InetAddress;I)Ljava/net/Socket;");
			global::javax.net.SocketFactory_._createSocket15959 = @__env.GetMethodIDNoThrow(global::javax.net.SocketFactory_.staticClass, "createSocket", "(Ljava/net/InetAddress;I)Ljava/net/Socket;");
			global::javax.net.SocketFactory_._createSocket15960 = @__env.GetMethodIDNoThrow(global::javax.net.SocketFactory_.staticClass, "createSocket", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)Ljava/net/Socket;");
		}
	}
}
