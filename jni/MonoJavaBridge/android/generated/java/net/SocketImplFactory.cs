namespace java.net
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.net.SocketImplFactory_))]
	public partial interface SocketImplFactory  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.net.SocketImpl createSocketImpl();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.SocketImplFactory))]
	internal sealed partial class SocketImplFactory_ : java.lang.Object, SocketImplFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SocketImplFactory_()
		{
			InitJNI();
		}
		internal SocketImplFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _createSocketImpl21813;
		 global::java.net.SocketImpl java.net.SocketImplFactory.createSocketImpl() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.SocketImplFactory_._createSocketImpl21813)) as java.net.SocketImpl;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.SocketImplFactory_.staticClass, global::java.net.SocketImplFactory_._createSocketImpl21813)) as java.net.SocketImpl;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.SocketImplFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/SocketImplFactory"));
			global::java.net.SocketImplFactory_._createSocketImpl21813 = @__env.GetMethodIDNoThrow(global::java.net.SocketImplFactory_.staticClass, "createSocketImpl", "()Ljava/net/SocketImpl;");
		}
	}
}
