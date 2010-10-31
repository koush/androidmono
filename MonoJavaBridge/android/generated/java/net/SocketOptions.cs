namespace java.net
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.net.SocketOptions_))]
	public partial interface SocketOptions  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object getOption(int arg0);
		void setOption(int arg0, java.lang.Object arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.SocketOptions))]
	internal sealed partial class SocketOptions_ : java.lang.Object, SocketOptions
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SocketOptions_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.Object java.net.SocketOptions.getOption(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.SocketOptions_.staticClass, "getOption", "(I)Ljava/lang/Object;", ref global::java.net.SocketOptions_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void java.net.SocketOptions.setOption(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.SocketOptions_.staticClass, "setOption", "(ILjava/lang/Object;)V", ref global::java.net.SocketOptions_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static SocketOptions_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.SocketOptions_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/SocketOptions"));
		}
	}
}
