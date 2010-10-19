namespace java.util.concurrent.atomic
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AtomicLong : java.lang.Number, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AtomicLong()
		{
			InitJNI();
		}
		protected AtomicLong(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get21637;
		public virtual long get() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._get21637);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._get21637);
		}
		internal static global::MonoJavaBridge.MethodId _toString21638;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._toString21638)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._toString21638)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _set21639;
		public virtual void set(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._set21639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._set21639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _intValue21640;
		public override int intValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._intValue21640);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._intValue21640);
		}
		internal static global::MonoJavaBridge.MethodId _longValue21641;
		public override long longValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._longValue21641);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._longValue21641);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue21642;
		public override float floatValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._floatValue21642);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._floatValue21642);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue21643;
		public override double doubleValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._doubleValue21643);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._doubleValue21643);
		}
		internal static global::MonoJavaBridge.MethodId _getAndAdd21644;
		public virtual long getAndAdd(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._getAndAdd21644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._getAndAdd21644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lazySet21645;
		public virtual void lazySet(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._lazySet21645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._lazySet21645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAndSet21646;
		public virtual long getAndSet(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._getAndSet21646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._getAndSet21646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareAndSet21647;
		public virtual bool compareAndSet(long arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._compareAndSet21647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._compareAndSet21647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _weakCompareAndSet21648;
		public virtual bool weakCompareAndSet(long arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._weakCompareAndSet21648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._weakCompareAndSet21648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new long AndIncrement
		{
			get
			{
				return getAndIncrement();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAndIncrement21649;
		public virtual long getAndIncrement() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._getAndIncrement21649);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._getAndIncrement21649);
		}
		public new long AndDecrement
		{
			get
			{
				return getAndDecrement();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAndDecrement21650;
		public virtual long getAndDecrement() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._getAndDecrement21650);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._getAndDecrement21650);
		}
		internal static global::MonoJavaBridge.MethodId _incrementAndGet21651;
		public virtual long incrementAndGet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._incrementAndGet21651);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._incrementAndGet21651);
		}
		internal static global::MonoJavaBridge.MethodId _decrementAndGet21652;
		public virtual long decrementAndGet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._decrementAndGet21652);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._decrementAndGet21652);
		}
		internal static global::MonoJavaBridge.MethodId _addAndGet21653;
		public virtual long addAndGet(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._addAndGet21653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._addAndGet21653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AtomicLong21654;
		public AtomicLong(long arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._AtomicLong21654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AtomicLong21655;
		public AtomicLong()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._AtomicLong21655);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicLong.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicLong"));
			global::java.util.concurrent.atomic.AtomicLong._get21637 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "get", "()J");
			global::java.util.concurrent.atomic.AtomicLong._toString21638 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.atomic.AtomicLong._set21639 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "set", "(J)V");
			global::java.util.concurrent.atomic.AtomicLong._intValue21640 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "intValue", "()I");
			global::java.util.concurrent.atomic.AtomicLong._longValue21641 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "longValue", "()J");
			global::java.util.concurrent.atomic.AtomicLong._floatValue21642 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "floatValue", "()F");
			global::java.util.concurrent.atomic.AtomicLong._doubleValue21643 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "doubleValue", "()D");
			global::java.util.concurrent.atomic.AtomicLong._getAndAdd21644 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "getAndAdd", "(J)J");
			global::java.util.concurrent.atomic.AtomicLong._lazySet21645 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "lazySet", "(J)V");
			global::java.util.concurrent.atomic.AtomicLong._getAndSet21646 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "getAndSet", "(J)J");
			global::java.util.concurrent.atomic.AtomicLong._compareAndSet21647 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "compareAndSet", "(JJ)Z");
			global::java.util.concurrent.atomic.AtomicLong._weakCompareAndSet21648 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "weakCompareAndSet", "(JJ)Z");
			global::java.util.concurrent.atomic.AtomicLong._getAndIncrement21649 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "getAndIncrement", "()J");
			global::java.util.concurrent.atomic.AtomicLong._getAndDecrement21650 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "getAndDecrement", "()J");
			global::java.util.concurrent.atomic.AtomicLong._incrementAndGet21651 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "incrementAndGet", "()J");
			global::java.util.concurrent.atomic.AtomicLong._decrementAndGet21652 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "decrementAndGet", "()J");
			global::java.util.concurrent.atomic.AtomicLong._addAndGet21653 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "addAndGet", "(J)J");
			global::java.util.concurrent.atomic.AtomicLong._AtomicLong21654 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "<init>", "(J)V");
			global::java.util.concurrent.atomic.AtomicLong._AtomicLong21655 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "<init>", "()V");
		}
	}
}
