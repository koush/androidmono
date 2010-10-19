namespace java.util.concurrent.atomic
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.concurrent.atomic.AtomicLongFieldUpdater_))]
	public abstract partial class AtomicLongFieldUpdater : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AtomicLongFieldUpdater()
		{
			InitJNI();
		}
		protected AtomicLongFieldUpdater(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get21672;
		public abstract long get(java.lang.Object arg0);
		internal static global::MonoJavaBridge.MethodId _set21673;
		public abstract void set(java.lang.Object arg0, long arg1);
		internal static global::MonoJavaBridge.MethodId _getAndAdd21674;
		public virtual long getAndAdd(java.lang.Object arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater._getAndAdd21674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicLongFieldUpdater._getAndAdd21674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lazySet21675;
		public abstract void lazySet(java.lang.Object arg0, long arg1);
		internal static global::MonoJavaBridge.MethodId _getAndSet21676;
		public virtual long getAndSet(java.lang.Object arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater._getAndSet21676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicLongFieldUpdater._getAndSet21676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _compareAndSet21677;
		public abstract bool compareAndSet(java.lang.Object arg0, long arg1, long arg2);
		internal static global::MonoJavaBridge.MethodId _weakCompareAndSet21678;
		public abstract bool weakCompareAndSet(java.lang.Object arg0, long arg1, long arg2);
		internal static global::MonoJavaBridge.MethodId _getAndIncrement21679;
		public virtual long getAndIncrement(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater._getAndIncrement21679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicLongFieldUpdater._getAndIncrement21679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAndDecrement21680;
		public virtual long getAndDecrement(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater._getAndDecrement21680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicLongFieldUpdater._getAndDecrement21680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _incrementAndGet21681;
		public virtual long incrementAndGet(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater._incrementAndGet21681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicLongFieldUpdater._incrementAndGet21681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _decrementAndGet21682;
		public virtual long decrementAndGet(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater._decrementAndGet21682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicLongFieldUpdater._decrementAndGet21682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAndGet21683;
		public virtual long addAndGet(java.lang.Object arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater._addAndGet21683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicLongFieldUpdater._addAndGet21683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _newUpdater21684;
		public static global::java.util.concurrent.atomic.AtomicLongFieldUpdater newUpdater(java.lang.Class arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicLongFieldUpdater._newUpdater21684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.atomic.AtomicLongFieldUpdater;
		}
		internal static global::MonoJavaBridge.MethodId _AtomicLongFieldUpdater21685;
		protected AtomicLongFieldUpdater()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicLongFieldUpdater._AtomicLongFieldUpdater21685);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicLongFieldUpdater"));
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater._get21672 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, "get", "(Ljava/lang/Object;)J");
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater._set21673 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, "set", "(Ljava/lang/Object;J)V");
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater._getAndAdd21674 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, "getAndAdd", "(Ljava/lang/Object;J)J");
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater._lazySet21675 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, "lazySet", "(Ljava/lang/Object;J)V");
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater._getAndSet21676 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, "getAndSet", "(Ljava/lang/Object;J)J");
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater._compareAndSet21677 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, "compareAndSet", "(Ljava/lang/Object;JJ)Z");
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater._weakCompareAndSet21678 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, "weakCompareAndSet", "(Ljava/lang/Object;JJ)Z");
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater._getAndIncrement21679 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, "getAndIncrement", "(Ljava/lang/Object;)J");
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater._getAndDecrement21680 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, "getAndDecrement", "(Ljava/lang/Object;)J");
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater._incrementAndGet21681 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, "incrementAndGet", "(Ljava/lang/Object;)J");
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater._decrementAndGet21682 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, "decrementAndGet", "(Ljava/lang/Object;)J");
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater._addAndGet21683 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, "addAndGet", "(Ljava/lang/Object;J)J");
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater._newUpdater21684 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, "newUpdater", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/util/concurrent/atomic/AtomicLongFieldUpdater;");
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater._AtomicLongFieldUpdater21685 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.atomic.AtomicLongFieldUpdater))]
	public sealed partial class AtomicLongFieldUpdater_ : java.util.concurrent.atomic.AtomicLongFieldUpdater
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AtomicLongFieldUpdater_()
		{
			InitJNI();
		}
		internal AtomicLongFieldUpdater_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get21686;
		public override long get(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater_._get21686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater_.staticClass, global::java.util.concurrent.atomic.AtomicLongFieldUpdater_._get21686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _set21687;
		public override void set(java.lang.Object arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater_._set21687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater_.staticClass, global::java.util.concurrent.atomic.AtomicLongFieldUpdater_._set21687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lazySet21688;
		public override void lazySet(java.lang.Object arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater_._lazySet21688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater_.staticClass, global::java.util.concurrent.atomic.AtomicLongFieldUpdater_._lazySet21688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _compareAndSet21689;
		public override bool compareAndSet(java.lang.Object arg0, long arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater_._compareAndSet21689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater_.staticClass, global::java.util.concurrent.atomic.AtomicLongFieldUpdater_._compareAndSet21689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _weakCompareAndSet21690;
		public override bool weakCompareAndSet(java.lang.Object arg0, long arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater_._weakCompareAndSet21690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater_.staticClass, global::java.util.concurrent.atomic.AtomicLongFieldUpdater_._weakCompareAndSet21690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicLongFieldUpdater"));
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater_._get21686 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater_.staticClass, "get", "(Ljava/lang/Object;)J");
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater_._set21687 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater_.staticClass, "set", "(Ljava/lang/Object;J)V");
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater_._lazySet21688 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater_.staticClass, "lazySet", "(Ljava/lang/Object;J)V");
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater_._compareAndSet21689 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater_.staticClass, "compareAndSet", "(Ljava/lang/Object;JJ)Z");
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater_._weakCompareAndSet21690 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater_.staticClass, "weakCompareAndSet", "(Ljava/lang/Object;JJ)Z");
		}
	}
}
