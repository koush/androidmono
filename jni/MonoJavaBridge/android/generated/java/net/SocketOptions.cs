namespace java.net
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.net.SocketOptions_))]
	public interface SocketOptions  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object getOption(int arg0);
		void setOption(int arg0, java.lang.Object arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.SocketOptions))]
	public sealed partial class SocketOptions_ : java.lang.Object, SocketOptions
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SocketOptions_()
		{
			InitJNI();
		}
		internal SocketOptions_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getOption21696;
		 global::java.lang.Object java.net.SocketOptions.getOption(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.SocketOptions_._getOption21696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.SocketOptions_.staticClass, global::java.net.SocketOptions_._getOption21696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setOption21697;
		 void java.net.SocketOptions.setOption(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketOptions_._setOption21697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketOptions_.staticClass, global::java.net.SocketOptions_._setOption21697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.SocketOptions_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/SocketOptions"));
			global::java.net.SocketOptions_._getOption21696 = @__env.GetMethodIDNoThrow(global::java.net.SocketOptions_.staticClass, "getOption", "(I)Ljava/lang/Object;");
			global::java.net.SocketOptions_._setOption21697 = @__env.GetMethodIDNoThrow(global::java.net.SocketOptions_.staticClass, "setOption", "(ILjava/lang/Object;)V");
		}
	}
}
