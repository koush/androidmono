namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.concurrent.ThreadFactory_))]
	public partial interface ThreadFactory  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Thread newThread(java.lang.Runnable arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.ThreadFactory))]
	internal sealed partial class ThreadFactory_ : java.lang.Object, ThreadFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ThreadFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newThread27455;
		global::java.lang.Thread java.util.concurrent.ThreadFactory.newThread(java.lang.Runnable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadFactory_._newThread27455.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadFactory_._newThread27455 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadFactory_.staticClass, "newThread", "(Ljava/lang/Runnable;)Ljava/lang/Thread;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ThreadFactory_._newThread27455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Thread;
		}
		static ThreadFactory_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.ThreadFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ThreadFactory"));
		}
		internal static void InitJNI()
		{
		}
	}
}
