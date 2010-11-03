namespace java.util.concurrent.locks
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.concurrent.locks.AbstractOwnableSynchronizer_))]
	public abstract partial class AbstractOwnableSynchronizer : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractOwnableSynchronizer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected virtual void setExclusiveOwnerThread(java.lang.Thread arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.AbstractOwnableSynchronizer.staticClass, "setExclusiveOwnerThread", "(Ljava/lang/Thread;)V", ref global::java.util.concurrent.locks.AbstractOwnableSynchronizer._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected virtual global::java.lang.Thread getExclusiveOwnerThread()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.locks.AbstractOwnableSynchronizer.staticClass, "getExclusiveOwnerThread", "()Ljava/lang/Thread;", ref global::java.util.concurrent.locks.AbstractOwnableSynchronizer._m1) as java.lang.Thread;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected AbstractOwnableSynchronizer() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.locks.AbstractOwnableSynchronizer._m2.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.locks.AbstractOwnableSynchronizer._m2 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractOwnableSynchronizer.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.locks.AbstractOwnableSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractOwnableSynchronizer._m2);
			Init(@__env, handle);
		}
		static AbstractOwnableSynchronizer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.locks.AbstractOwnableSynchronizer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/AbstractOwnableSynchronizer"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.locks.AbstractOwnableSynchronizer))]
	internal sealed partial class AbstractOwnableSynchronizer_ : java.util.concurrent.locks.AbstractOwnableSynchronizer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractOwnableSynchronizer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static AbstractOwnableSynchronizer_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.locks.AbstractOwnableSynchronizer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/AbstractOwnableSynchronizer"));
		}
	}
}
