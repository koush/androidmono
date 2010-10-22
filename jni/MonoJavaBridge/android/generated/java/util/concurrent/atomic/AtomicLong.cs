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
		internal static global::MonoJavaBridge.MethodId _get27467;
		public virtual long get() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._get27467);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._get27467);
		}
		internal static global::MonoJavaBridge.MethodId _toString27468;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._toString27468)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._toString27468)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _set27469;
		public virtual void set(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._set27469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._set27469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _intValue27470;
		public override int intValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._intValue27470);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._intValue27470);
		}
		internal static global::MonoJavaBridge.MethodId _longValue27471;
		public override long longValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._longValue27471);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._longValue27471);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue27472;
		public override float floatValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._floatValue27472);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._floatValue27472);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue27473;
		public override double doubleValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._doubleValue27473);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._doubleValue27473);
		}
		internal static global::MonoJavaBridge.MethodId _getAndAdd27474;
		public virtual long getAndAdd(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._getAndAdd27474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._getAndAdd27474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lazySet27475;
		public virtual void lazySet(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._lazySet27475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._lazySet27475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAndSet27476;
		public virtual long getAndSet(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._getAndSet27476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._getAndSet27476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareAndSet27477;
		public virtual bool compareAndSet(long arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._compareAndSet27477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._compareAndSet27477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _weakCompareAndSet27478;
		public virtual bool weakCompareAndSet(long arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._weakCompareAndSet27478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._weakCompareAndSet27478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new long AndIncrement
		{
			get
			{
				return getAndIncrement();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAndIncrement27479;
		public virtual long getAndIncrement() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._getAndIncrement27479);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._getAndIncrement27479);
		}
		public new long AndDecrement
		{
			get
			{
				return getAndDecrement();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAndDecrement27480;
		public virtual long getAndDecrement() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._getAndDecrement27480);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._getAndDecrement27480);
		}
		internal static global::MonoJavaBridge.MethodId _incrementAndGet27481;
		public virtual long incrementAndGet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._incrementAndGet27481);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._incrementAndGet27481);
		}
		internal static global::MonoJavaBridge.MethodId _decrementAndGet27482;
		public virtual long decrementAndGet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._decrementAndGet27482);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._decrementAndGet27482);
		}
		internal static global::MonoJavaBridge.MethodId _addAndGet27483;
		public virtual long addAndGet(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._addAndGet27483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._addAndGet27483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AtomicLong27484;
		public AtomicLong(long arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._AtomicLong27484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AtomicLong27485;
		public AtomicLong()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._AtomicLong27485);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicLong.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicLong"));
			global::java.util.concurrent.atomic.AtomicLong._get27467 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "get", "()J");
			global::java.util.concurrent.atomic.AtomicLong._toString27468 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.atomic.AtomicLong._set27469 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "set", "(J)V");
			global::java.util.concurrent.atomic.AtomicLong._intValue27470 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "intValue", "()I");
			global::java.util.concurrent.atomic.AtomicLong._longValue27471 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "longValue", "()J");
			global::java.util.concurrent.atomic.AtomicLong._floatValue27472 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "floatValue", "()F");
			global::java.util.concurrent.atomic.AtomicLong._doubleValue27473 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "doubleValue", "()D");
			global::java.util.concurrent.atomic.AtomicLong._getAndAdd27474 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "getAndAdd", "(J)J");
			global::java.util.concurrent.atomic.AtomicLong._lazySet27475 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "lazySet", "(J)V");
			global::java.util.concurrent.atomic.AtomicLong._getAndSet27476 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "getAndSet", "(J)J");
			global::java.util.concurrent.atomic.AtomicLong._compareAndSet27477 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "compareAndSet", "(JJ)Z");
			global::java.util.concurrent.atomic.AtomicLong._weakCompareAndSet27478 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "weakCompareAndSet", "(JJ)Z");
			global::java.util.concurrent.atomic.AtomicLong._getAndIncrement27479 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "getAndIncrement", "()J");
			global::java.util.concurrent.atomic.AtomicLong._getAndDecrement27480 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "getAndDecrement", "()J");
			global::java.util.concurrent.atomic.AtomicLong._incrementAndGet27481 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "incrementAndGet", "()J");
			global::java.util.concurrent.atomic.AtomicLong._decrementAndGet27482 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "decrementAndGet", "()J");
			global::java.util.concurrent.atomic.AtomicLong._addAndGet27483 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "addAndGet", "(J)J");
			global::java.util.concurrent.atomic.AtomicLong._AtomicLong27484 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "<init>", "(J)V");
			global::java.util.concurrent.atomic.AtomicLong._AtomicLong27485 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "<init>", "()V");
		}
	}
}
