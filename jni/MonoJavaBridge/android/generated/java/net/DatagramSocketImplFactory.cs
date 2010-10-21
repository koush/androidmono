namespace java.net
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.net.DatagramSocketImplFactory_))]
	public interface DatagramSocketImplFactory  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.net.DatagramSocketImpl createDatagramSocketImpl();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.DatagramSocketImplFactory))]
	public sealed partial class DatagramSocketImplFactory_ : java.lang.Object, DatagramSocketImplFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DatagramSocketImplFactory_()
		{
			InitJNI();
		}
		internal DatagramSocketImplFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _createDatagramSocketImpl21346;
		 global::java.net.DatagramSocketImpl java.net.DatagramSocketImplFactory.createDatagramSocketImpl() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.DatagramSocketImplFactory_._createDatagramSocketImpl21346)) as java.net.DatagramSocketImpl;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.DatagramSocketImplFactory_.staticClass, global::java.net.DatagramSocketImplFactory_._createDatagramSocketImpl21346)) as java.net.DatagramSocketImpl;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.DatagramSocketImplFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/DatagramSocketImplFactory"));
			global::java.net.DatagramSocketImplFactory_._createDatagramSocketImpl21346 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImplFactory_.staticClass, "createDatagramSocketImpl", "()Ljava/net/DatagramSocketImpl;");
		}
	}
}
