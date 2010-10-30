namespace java.util.concurrent.atomic
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_))]
	public abstract partial class AtomicReferenceFieldUpdater : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AtomicReferenceFieldUpdater(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get27667;
		public abstract global::java.lang.Object get(java.lang.Object arg0);
		internal static global::MonoJavaBridge.MethodId _set27668;
		public abstract void set(java.lang.Object arg0, java.lang.Object arg1);
		internal static global::MonoJavaBridge.MethodId _lazySet27669;
		public abstract void lazySet(java.lang.Object arg0, java.lang.Object arg1);
		internal static global::MonoJavaBridge.MethodId _getAndSet27670;
		public virtual global::java.lang.Object getAndSet(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater._getAndSet27670.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater._getAndSet27670 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater.staticClass, "getAndSet", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater._getAndSet27670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _compareAndSet27671;
		public abstract bool compareAndSet(java.lang.Object arg0, java.lang.Object arg1, java.lang.Object arg2);
		internal static global::MonoJavaBridge.MethodId _weakCompareAndSet27672;
		public abstract bool weakCompareAndSet(java.lang.Object arg0, java.lang.Object arg1, java.lang.Object arg2);
		internal static global::MonoJavaBridge.MethodId _newUpdater27673;
		public static global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater newUpdater(java.lang.Class arg0, java.lang.Class arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater._newUpdater27673.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater._newUpdater27673 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater.staticClass, "newUpdater", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/String;)Ljava/util/concurrent/atomic/AtomicReferenceFieldUpdater;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.concurrent.atomic.AtomicReferenceFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater._newUpdater27673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.concurrent.atomic.AtomicReferenceFieldUpdater;
		}
		internal static global::MonoJavaBridge.MethodId _AtomicReferenceFieldUpdater27674;
		protected AtomicReferenceFieldUpdater() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater._AtomicReferenceFieldUpdater27674.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater._AtomicReferenceFieldUpdater27674 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicReferenceFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater._AtomicReferenceFieldUpdater27674);
			Init(@__env, handle);
		}
		static AtomicReferenceFieldUpdater()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicReferenceFieldUpdater"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater))]
	internal sealed partial class AtomicReferenceFieldUpdater_ : java.util.concurrent.atomic.AtomicReferenceFieldUpdater
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AtomicReferenceFieldUpdater_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get27675;
		public override global::java.lang.Object get(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_._get27675.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_._get27675 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_._get27675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _set27676;
		public override void set(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_._set27676.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_._set27676 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_.staticClass, "set", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_._set27676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lazySet27677;
		public override void lazySet(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_._lazySet27677.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_._lazySet27677 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_.staticClass, "lazySet", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_._lazySet27677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _compareAndSet27678;
		public override bool compareAndSet(java.lang.Object arg0, java.lang.Object arg1, java.lang.Object arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_._compareAndSet27678.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_._compareAndSet27678 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_.staticClass, "compareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_._compareAndSet27678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _weakCompareAndSet27679;
		public override bool weakCompareAndSet(java.lang.Object arg0, java.lang.Object arg1, java.lang.Object arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_._weakCompareAndSet27679.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_._weakCompareAndSet27679 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_.staticClass, "weakCompareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_._weakCompareAndSet27679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		static AtomicReferenceFieldUpdater_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicReferenceFieldUpdater"));
		}
		internal static void InitJNI()
		{
		}
	}
}
