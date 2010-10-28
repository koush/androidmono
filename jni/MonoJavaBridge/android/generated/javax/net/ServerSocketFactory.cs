namespace javax.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.net.ServerSocketFactory_))]
	public abstract partial class ServerSocketFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ServerSocketFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getDefault29809;
		public static global::javax.net.ServerSocketFactory getDefault()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ServerSocketFactory.staticClass, global::javax.net.ServerSocketFactory._getDefault29809)) as javax.net.ServerSocketFactory;
		}
		internal static global::MonoJavaBridge.MethodId _createServerSocket29810;
		public virtual global::java.net.ServerSocket createServerSocket()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ServerSocketFactory._createServerSocket29810)) as java.net.ServerSocket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ServerSocketFactory.staticClass, global::javax.net.ServerSocketFactory._createServerSocket29810)) as java.net.ServerSocket;
		}
		internal static global::MonoJavaBridge.MethodId _createServerSocket29811;
		public abstract global::java.net.ServerSocket createServerSocket(int arg0);
		internal static global::MonoJavaBridge.MethodId _createServerSocket29812;
		public abstract global::java.net.ServerSocket createServerSocket(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _createServerSocket29813;
		public abstract global::java.net.ServerSocket createServerSocket(int arg0, int arg1, java.net.InetAddress arg2);
		internal static global::MonoJavaBridge.MethodId _ServerSocketFactory29814;
		protected ServerSocketFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ServerSocketFactory.staticClass, global::javax.net.ServerSocketFactory._ServerSocketFactory29814);
			Init(@__env, handle);
		}
		static ServerSocketFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ServerSocketFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ServerSocketFactory"));
			global::javax.net.ServerSocketFactory._getDefault29809 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ServerSocketFactory.staticClass, "getDefault", "()Ljavax/net/ServerSocketFactory;");
			global::javax.net.ServerSocketFactory._createServerSocket29810 = @__env.GetMethodIDNoThrow(global::javax.net.ServerSocketFactory.staticClass, "createServerSocket", "()Ljava/net/ServerSocket;");
			global::javax.net.ServerSocketFactory._createServerSocket29811 = @__env.GetMethodIDNoThrow(global::javax.net.ServerSocketFactory.staticClass, "createServerSocket", "(I)Ljava/net/ServerSocket;");
			global::javax.net.ServerSocketFactory._createServerSocket29812 = @__env.GetMethodIDNoThrow(global::javax.net.ServerSocketFactory.staticClass, "createServerSocket", "(II)Ljava/net/ServerSocket;");
			global::javax.net.ServerSocketFactory._createServerSocket29813 = @__env.GetMethodIDNoThrow(global::javax.net.ServerSocketFactory.staticClass, "createServerSocket", "(IILjava/net/InetAddress;)Ljava/net/ServerSocket;");
			global::javax.net.ServerSocketFactory._ServerSocketFactory29814 = @__env.GetMethodIDNoThrow(global::javax.net.ServerSocketFactory.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ServerSocketFactory))]
	internal sealed partial class ServerSocketFactory_ : javax.net.ServerSocketFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ServerSocketFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _createServerSocket29815;
		public override global::java.net.ServerSocket createServerSocket(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ServerSocketFactory_._createServerSocket29815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.ServerSocket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ServerSocketFactory_.staticClass, global::javax.net.ServerSocketFactory_._createServerSocket29815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.ServerSocket;
		}
		internal static global::MonoJavaBridge.MethodId _createServerSocket29816;
		public override global::java.net.ServerSocket createServerSocket(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ServerSocketFactory_._createServerSocket29816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.ServerSocket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ServerSocketFactory_.staticClass, global::javax.net.ServerSocketFactory_._createServerSocket29816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.ServerSocket;
		}
		internal static global::MonoJavaBridge.MethodId _createServerSocket29817;
		public override global::java.net.ServerSocket createServerSocket(int arg0, int arg1, java.net.InetAddress arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ServerSocketFactory_._createServerSocket29817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.net.ServerSocket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ServerSocketFactory_.staticClass, global::javax.net.ServerSocketFactory_._createServerSocket29817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.net.ServerSocket;
		}
		static ServerSocketFactory_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ServerSocketFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ServerSocketFactory"));
			global::javax.net.ServerSocketFactory_._createServerSocket29815 = @__env.GetMethodIDNoThrow(global::javax.net.ServerSocketFactory_.staticClass, "createServerSocket", "(I)Ljava/net/ServerSocket;");
			global::javax.net.ServerSocketFactory_._createServerSocket29816 = @__env.GetMethodIDNoThrow(global::javax.net.ServerSocketFactory_.staticClass, "createServerSocket", "(II)Ljava/net/ServerSocket;");
			global::javax.net.ServerSocketFactory_._createServerSocket29817 = @__env.GetMethodIDNoThrow(global::javax.net.ServerSocketFactory_.staticClass, "createServerSocket", "(IILjava/net/InetAddress;)Ljava/net/ServerSocket;");
		}
		internal static void InitJNI()
		{
		}
	}
}
