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
		internal SocketImplFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _createSocketImpl21814;
		global::java.net.SocketImpl java.net.SocketImplFactory.createSocketImpl()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.SocketImplFactory_.staticClass, "createSocketImpl", "()Ljava/net/SocketImpl;", ref global::java.net.SocketImplFactory_._createSocketImpl21814) as java.net.SocketImpl;
		}
		static SocketImplFactory_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.SocketImplFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/SocketImplFactory"));
		}
		internal static void InitJNI()
		{
		}
	}
}
