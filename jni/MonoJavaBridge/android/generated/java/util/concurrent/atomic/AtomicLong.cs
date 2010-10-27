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
		internal static global::MonoJavaBridge.MethodId _get27585;
		public virtual long get()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._get27585);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._get27585);
		}
		internal static global::MonoJavaBridge.MethodId _toString27586;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._toString27586)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._toString27586)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _set27587;
		public virtual void set(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._set27587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._set27587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _intValue27588;
		public override int intValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._intValue27588);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._intValue27588);
		}
		internal static global::MonoJavaBridge.MethodId _longValue27589;
		public override long longValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._longValue27589);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._longValue27589);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue27590;
		public override float floatValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._floatValue27590);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._floatValue27590);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue27591;
		public override double doubleValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._doubleValue27591);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._doubleValue27591);
		}
		internal static global::MonoJavaBridge.MethodId _getAndAdd27592;
		public virtual long getAndAdd(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._getAndAdd27592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._getAndAdd27592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lazySet27593;
		public virtual void lazySet(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._lazySet27593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._lazySet27593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAndSet27594;
		public virtual long getAndSet(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._getAndSet27594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._getAndSet27594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareAndSet27595;
		public virtual bool compareAndSet(long arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._compareAndSet27595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._compareAndSet27595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _weakCompareAndSet27596;
		public virtual bool weakCompareAndSet(long arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._weakCompareAndSet27596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._weakCompareAndSet27596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new long AndIncrement
		{
			get
			{
				return getAndIncrement();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAndIncrement27597;
		public virtual long getAndIncrement()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._getAndIncrement27597);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._getAndIncrement27597);
		}
		public new long AndDecrement
		{
			get
			{
				return getAndDecrement();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAndDecrement27598;
		public virtual long getAndDecrement()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._getAndDecrement27598);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._getAndDecrement27598);
		}
		internal static global::MonoJavaBridge.MethodId _incrementAndGet27599;
		public virtual long incrementAndGet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._incrementAndGet27599);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._incrementAndGet27599);
		}
		internal static global::MonoJavaBridge.MethodId _decrementAndGet27600;
		public virtual long decrementAndGet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._decrementAndGet27600);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._decrementAndGet27600);
		}
		internal static global::MonoJavaBridge.MethodId _addAndGet27601;
		public virtual long addAndGet(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong._addAndGet27601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._addAndGet27601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AtomicLong27602;
		public AtomicLong(long arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._AtomicLong27602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AtomicLong27603;
		public AtomicLong() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._AtomicLong27603);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicLong.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicLong"));
			global::java.util.concurrent.atomic.AtomicLong._get27585 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "get", "()J");
			global::java.util.concurrent.atomic.AtomicLong._toString27586 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.atomic.AtomicLong._set27587 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "set", "(J)V");
			global::java.util.concurrent.atomic.AtomicLong._intValue27588 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "intValue", "()I");
			global::java.util.concurrent.atomic.AtomicLong._longValue27589 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "longValue", "()J");
			global::java.util.concurrent.atomic.AtomicLong._floatValue27590 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "floatValue", "()F");
			global::java.util.concurrent.atomic.AtomicLong._doubleValue27591 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "doubleValue", "()D");
			global::java.util.concurrent.atomic.AtomicLong._getAndAdd27592 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "getAndAdd", "(J)J");
			global::java.util.concurrent.atomic.AtomicLong._lazySet27593 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "lazySet", "(J)V");
			global::java.util.concurrent.atomic.AtomicLong._getAndSet27594 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "getAndSet", "(J)J");
			global::java.util.concurrent.atomic.AtomicLong._compareAndSet27595 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "compareAndSet", "(JJ)Z");
			global::java.util.concurrent.atomic.AtomicLong._weakCompareAndSet27596 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "weakCompareAndSet", "(JJ)Z");
			global::java.util.concurrent.atomic.AtomicLong._getAndIncrement27597 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "getAndIncrement", "()J");
			global::java.util.concurrent.atomic.AtomicLong._getAndDecrement27598 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "getAndDecrement", "()J");
			global::java.util.concurrent.atomic.AtomicLong._incrementAndGet27599 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "incrementAndGet", "()J");
			global::java.util.concurrent.atomic.AtomicLong._decrementAndGet27600 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "decrementAndGet", "()J");
			global::java.util.concurrent.atomic.AtomicLong._addAndGet27601 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "addAndGet", "(J)J");
			global::java.util.concurrent.atomic.AtomicLong._AtomicLong27602 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "<init>", "(J)V");
			global::java.util.concurrent.atomic.AtomicLong._AtomicLong27603 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "<init>", "()V");
		}
	}
}
