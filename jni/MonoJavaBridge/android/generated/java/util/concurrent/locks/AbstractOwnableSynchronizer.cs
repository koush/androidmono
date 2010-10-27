namespace java.util.concurrent.locks
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.concurrent.locks.AbstractOwnableSynchronizer_))]
	public abstract partial class AbstractOwnableSynchronizer : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractOwnableSynchronizer()
		{
			InitJNI();
		}
		protected AbstractOwnableSynchronizer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setExclusiveOwnerThread27687;
		protected virtual void setExclusiveOwnerThread(java.lang.Thread arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractOwnableSynchronizer._setExclusiveOwnerThread27687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractOwnableSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractOwnableSynchronizer._setExclusiveOwnerThread27687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getExclusiveOwnerThread27688;
		protected virtual global::java.lang.Thread getExclusiveOwnerThread()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractOwnableSynchronizer._getExclusiveOwnerThread27688)) as java.lang.Thread;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractOwnableSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractOwnableSynchronizer._getExclusiveOwnerThread27688)) as java.lang.Thread;
		}
		internal static global::MonoJavaBridge.MethodId _AbstractOwnableSynchronizer27689;
		protected AbstractOwnableSynchronizer() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.locks.AbstractOwnableSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractOwnableSynchronizer._AbstractOwnableSynchronizer27689);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.locks.AbstractOwnableSynchronizer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/AbstractOwnableSynchronizer"));
			global::java.util.concurrent.locks.AbstractOwnableSynchronizer._setExclusiveOwnerThread27687 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractOwnableSynchronizer.staticClass, "setExclusiveOwnerThread", "(Ljava/lang/Thread;)V");
			global::java.util.concurrent.locks.AbstractOwnableSynchronizer._getExclusiveOwnerThread27688 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractOwnableSynchronizer.staticClass, "getExclusiveOwnerThread", "()Ljava/lang/Thread;");
			global::java.util.concurrent.locks.AbstractOwnableSynchronizer._AbstractOwnableSynchronizer27689 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractOwnableSynchronizer.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.locks.AbstractOwnableSynchronizer))]
	internal sealed partial class AbstractOwnableSynchronizer_ : java.util.concurrent.locks.AbstractOwnableSynchronizer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractOwnableSynchronizer_()
		{
			InitJNI();
		}
		internal AbstractOwnableSynchronizer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.locks.AbstractOwnableSynchronizer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/AbstractOwnableSynchronizer"));
		}
	}
}
