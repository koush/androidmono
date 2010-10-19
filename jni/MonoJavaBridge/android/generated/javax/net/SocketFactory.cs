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
		internal static global::MonoJavaBridge.MethodId _getDefault23268;
		public static global::javax.net.SocketFactory getDefault() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.SocketFactory.staticClass, global::javax.net.SocketFactory._getDefault23268)) as javax.net.SocketFactory;
		}
		internal static global::MonoJavaBridge.MethodId _createSocket23269;
		public virtual global::java.net.Socket createSocket() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.SocketFactory._createSocket23269)) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.SocketFactory.staticClass, global::javax.net.SocketFactory._createSocket23269)) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _createSocket23270;
		public abstract global::java.net.Socket createSocket(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _createSocket23271;
		public abstract global::java.net.Socket createSocket(java.lang.String arg0, int arg1, java.net.InetAddress arg2, int arg3);
		internal static global::MonoJavaBridge.MethodId _createSocket23272;
		public abstract global::java.net.Socket createSocket(java.net.InetAddress arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _createSocket23273;
		public abstract global::java.net.Socket createSocket(java.net.InetAddress arg0, int arg1, java.net.InetAddress arg2, int arg3);
		internal static global::MonoJavaBridge.MethodId _SocketFactory23274;
		protected SocketFactory()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.SocketFactory.staticClass, global::javax.net.SocketFactory._SocketFactory23274);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.SocketFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/SocketFactory"));
			global::javax.net.SocketFactory._getDefault23268 = @__env.GetStaticMethodIDNoThrow(global::javax.net.SocketFactory.staticClass, "getDefault", "()Ljavax/net/SocketFactory;");
			global::javax.net.SocketFactory._createSocket23269 = @__env.GetMethodIDNoThrow(global::javax.net.SocketFactory.staticClass, "createSocket", "()Ljava/net/Socket;");
			global::javax.net.SocketFactory._createSocket23270 = @__env.GetMethodIDNoThrow(global::javax.net.SocketFactory.staticClass, "createSocket", "(Ljava/lang/String;I)Ljava/net/Socket;");
			global::javax.net.SocketFactory._createSocket23271 = @__env.GetMethodIDNoThrow(global::javax.net.SocketFactory.staticClass, "createSocket", "(Ljava/lang/String;ILjava/net/InetAddress;I)Ljava/net/Socket;");
			global::javax.net.SocketFactory._createSocket23272 = @__env.GetMethodIDNoThrow(global::javax.net.SocketFactory.staticClass, "createSocket", "(Ljava/net/InetAddress;I)Ljava/net/Socket;");
			global::javax.net.SocketFactory._createSocket23273 = @__env.GetMethodIDNoThrow(global::javax.net.SocketFactory.staticClass, "createSocket", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)Ljava/net/Socket;");
			global::javax.net.SocketFactory._SocketFactory23274 = @__env.GetMethodIDNoThrow(global::javax.net.SocketFactory.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _createSocket23275;
		public override global::java.net.Socket createSocket(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.SocketFactory_._createSocket23275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.SocketFactory_.staticClass, global::javax.net.SocketFactory_._createSocket23275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _createSocket23276;
		public override global::java.net.Socket createSocket(java.lang.String arg0, int arg1, java.net.InetAddress arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.SocketFactory_._createSocket23276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.SocketFactory_.staticClass, global::javax.net.SocketFactory_._createSocket23276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _createSocket23277;
		public override global::java.net.Socket createSocket(java.net.InetAddress arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.SocketFactory_._createSocket23277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.SocketFactory_.staticClass, global::javax.net.SocketFactory_._createSocket23277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _createSocket23278;
		public override global::java.net.Socket createSocket(java.net.InetAddress arg0, int arg1, java.net.InetAddress arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.SocketFactory_._createSocket23278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.SocketFactory_.staticClass, global::javax.net.SocketFactory_._createSocket23278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.net.Socket;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.SocketFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/SocketFactory"));
			global::javax.net.SocketFactory_._createSocket23275 = @__env.GetMethodIDNoThrow(global::javax.net.SocketFactory_.staticClass, "createSocket", "(Ljava/lang/String;I)Ljava/net/Socket;");
			global::javax.net.SocketFactory_._createSocket23276 = @__env.GetMethodIDNoThrow(global::javax.net.SocketFactory_.staticClass, "createSocket", "(Ljava/lang/String;ILjava/net/InetAddress;I)Ljava/net/Socket;");
			global::javax.net.SocketFactory_._createSocket23277 = @__env.GetMethodIDNoThrow(global::javax.net.SocketFactory_.staticClass, "createSocket", "(Ljava/net/InetAddress;I)Ljava/net/Socket;");
			global::javax.net.SocketFactory_._createSocket23278 = @__env.GetMethodIDNoThrow(global::javax.net.SocketFactory_.staticClass, "createSocket", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)Ljava/net/Socket;");
		}
	}
}
