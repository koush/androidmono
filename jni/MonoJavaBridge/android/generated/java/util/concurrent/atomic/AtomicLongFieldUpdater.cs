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
		internal static global::MonoJavaBridge.MethodId _get27502;
		public abstract long get(java.lang.Object arg0);
		internal static global::MonoJavaBridge.MethodId _set27503;
		public abstract void set(java.lang.Object arg0, long arg1);
		internal static global::MonoJavaBridge.MethodId _getAndAdd27504;
		public virtual long getAndAdd(java.lang.Object arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater._getAndAdd27504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicLongFieldUpdater._getAndAdd27504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lazySet27505;
		public abstract void lazySet(java.lang.Object arg0, long arg1);
		internal static global::MonoJavaBridge.MethodId _getAndSet27506;
		public virtual long getAndSet(java.lang.Object arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater._getAndSet27506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicLongFieldUpdater._getAndSet27506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _compareAndSet27507;
		public abstract bool compareAndSet(java.lang.Object arg0, long arg1, long arg2);
		internal static global::MonoJavaBridge.MethodId _weakCompareAndSet27508;
		public abstract bool weakCompareAndSet(java.lang.Object arg0, long arg1, long arg2);
		internal static global::MonoJavaBridge.MethodId _getAndIncrement27509;
		public virtual long getAndIncrement(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater._getAndIncrement27509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicLongFieldUpdater._getAndIncrement27509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAndDecrement27510;
		public virtual long getAndDecrement(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater._getAndDecrement27510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicLongFieldUpdater._getAndDecrement27510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _incrementAndGet27511;
		public virtual long incrementAndGet(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater._incrementAndGet27511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicLongFieldUpdater._incrementAndGet27511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _decrementAndGet27512;
		public virtual long decrementAndGet(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater._decrementAndGet27512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicLongFieldUpdater._decrementAndGet27512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAndGet27513;
		public virtual long addAndGet(java.lang.Object arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater._addAndGet27513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicLongFieldUpdater._addAndGet27513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _newUpdater27514;
		public static global::java.util.concurrent.atomic.AtomicLongFieldUpdater newUpdater(java.lang.Class arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicLongFieldUpdater._newUpdater27514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.atomic.AtomicLongFieldUpdater;
		}
		internal static global::MonoJavaBridge.MethodId _AtomicLongFieldUpdater27515;
		protected AtomicLongFieldUpdater()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicLongFieldUpdater._AtomicLongFieldUpdater27515);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicLongFieldUpdater"));
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater._get27502 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, "get", "(Ljava/lang/Object;)J");
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater._set27503 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, "set", "(Ljava/lang/Object;J)V");
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater._getAndAdd27504 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, "getAndAdd", "(Ljava/lang/Object;J)J");
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater._lazySet27505 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, "lazySet", "(Ljava/lang/Object;J)V");
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater._getAndSet27506 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, "getAndSet", "(Ljava/lang/Object;J)J");
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater._compareAndSet27507 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, "compareAndSet", "(Ljava/lang/Object;JJ)Z");
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater._weakCompareAndSet27508 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, "weakCompareAndSet", "(Ljava/lang/Object;JJ)Z");
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater._getAndIncrement27509 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, "getAndIncrement", "(Ljava/lang/Object;)J");
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater._getAndDecrement27510 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, "getAndDecrement", "(Ljava/lang/Object;)J");
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater._incrementAndGet27511 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, "incrementAndGet", "(Ljava/lang/Object;)J");
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater._decrementAndGet27512 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, "decrementAndGet", "(Ljava/lang/Object;)J");
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater._addAndGet27513 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, "addAndGet", "(Ljava/lang/Object;J)J");
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater._newUpdater27514 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, "newUpdater", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/util/concurrent/atomic/AtomicLongFieldUpdater;");
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater._AtomicLongFieldUpdater27515 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _get27516;
		public override long get(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater_._get27516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater_.staticClass, global::java.util.concurrent.atomic.AtomicLongFieldUpdater_._get27516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _set27517;
		public override void set(java.lang.Object arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater_._set27517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater_.staticClass, global::java.util.concurrent.atomic.AtomicLongFieldUpdater_._set27517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lazySet27518;
		public override void lazySet(java.lang.Object arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater_._lazySet27518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater_.staticClass, global::java.util.concurrent.atomic.AtomicLongFieldUpdater_._lazySet27518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _compareAndSet27519;
		public override bool compareAndSet(java.lang.Object arg0, long arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater_._compareAndSet27519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater_.staticClass, global::java.util.concurrent.atomic.AtomicLongFieldUpdater_._compareAndSet27519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _weakCompareAndSet27520;
		public override bool weakCompareAndSet(java.lang.Object arg0, long arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater_._weakCompareAndSet27520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongFieldUpdater_.staticClass, global::java.util.concurrent.atomic.AtomicLongFieldUpdater_._weakCompareAndSet27520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicLongFieldUpdater"));
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater_._get27516 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater_.staticClass, "get", "(Ljava/lang/Object;)J");
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater_._set27517 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater_.staticClass, "set", "(Ljava/lang/Object;J)V");
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater_._lazySet27518 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater_.staticClass, "lazySet", "(Ljava/lang/Object;J)V");
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater_._compareAndSet27519 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater_.staticClass, "compareAndSet", "(Ljava/lang/Object;JJ)Z");
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater_._weakCompareAndSet27520 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater_.staticClass, "weakCompareAndSet", "(Ljava/lang/Object;JJ)Z");
		}
	}
}
