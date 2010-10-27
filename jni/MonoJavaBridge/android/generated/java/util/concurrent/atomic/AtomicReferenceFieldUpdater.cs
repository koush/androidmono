namespace java.util.concurrent.atomic
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_))]
	public abstract partial class AtomicReferenceFieldUpdater : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AtomicReferenceFieldUpdater()
		{
			InitJNI();
		}
		protected AtomicReferenceFieldUpdater(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get27666;
		public abstract global::java.lang.Object get(java.lang.Object arg0);
		internal static global::MonoJavaBridge.MethodId _set27667;
		public abstract void set(java.lang.Object arg0, java.lang.Object arg1);
		internal static global::MonoJavaBridge.MethodId _lazySet27668;
		public abstract void lazySet(java.lang.Object arg0, java.lang.Object arg1);
		internal static global::MonoJavaBridge.MethodId _getAndSet27669;
		public virtual global::java.lang.Object getAndSet(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater._getAndSet27669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater._getAndSet27669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _compareAndSet27670;
		public abstract bool compareAndSet(java.lang.Object arg0, java.lang.Object arg1, java.lang.Object arg2);
		internal static global::MonoJavaBridge.MethodId _weakCompareAndSet27671;
		public abstract bool weakCompareAndSet(java.lang.Object arg0, java.lang.Object arg1, java.lang.Object arg2);
		internal static global::MonoJavaBridge.MethodId _newUpdater27672;
		public static global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater newUpdater(java.lang.Class arg0, java.lang.Class arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.concurrent.atomic.AtomicReferenceFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater._newUpdater27672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.concurrent.atomic.AtomicReferenceFieldUpdater;
		}
		internal static global::MonoJavaBridge.MethodId _AtomicReferenceFieldUpdater27673;
		protected AtomicReferenceFieldUpdater() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicReferenceFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater._AtomicReferenceFieldUpdater27673);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicReferenceFieldUpdater"));
			global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater._get27666 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater._set27667 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater.staticClass, "set", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater._lazySet27668 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater.staticClass, "lazySet", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater._getAndSet27669 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater.staticClass, "getAndSet", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater._compareAndSet27670 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater.staticClass, "compareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z");
			global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater._weakCompareAndSet27671 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater.staticClass, "weakCompareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z");
			global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater._newUpdater27672 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater.staticClass, "newUpdater", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/String;)Ljava/util/concurrent/atomic/AtomicReferenceFieldUpdater;");
			global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater._AtomicReferenceFieldUpdater27673 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater))]
	internal sealed partial class AtomicReferenceFieldUpdater_ : java.util.concurrent.atomic.AtomicReferenceFieldUpdater
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AtomicReferenceFieldUpdater_()
		{
			InitJNI();
		}
		internal AtomicReferenceFieldUpdater_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get27674;
		public override global::java.lang.Object get(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_._get27674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_.staticClass, global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_._get27674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _set27675;
		public override void set(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_._set27675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_.staticClass, global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_._set27675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lazySet27676;
		public override void lazySet(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_._lazySet27676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_.staticClass, global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_._lazySet27676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _compareAndSet27677;
		public override bool compareAndSet(java.lang.Object arg0, java.lang.Object arg1, java.lang.Object arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_._compareAndSet27677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_.staticClass, global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_._compareAndSet27677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _weakCompareAndSet27678;
		public override bool weakCompareAndSet(java.lang.Object arg0, java.lang.Object arg1, java.lang.Object arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_._weakCompareAndSet27678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_.staticClass, global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_._weakCompareAndSet27678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicReferenceFieldUpdater"));
			global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_._get27674 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_._set27675 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_.staticClass, "set", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_._lazySet27676 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_.staticClass, "lazySet", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_._compareAndSet27677 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_.staticClass, "compareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z");
			global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_._weakCompareAndSet27678 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_.staticClass, "weakCompareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z");
		}
	}
}
