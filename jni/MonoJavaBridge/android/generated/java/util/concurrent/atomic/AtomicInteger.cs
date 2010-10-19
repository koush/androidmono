namespace java.util.concurrent.atomic
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AtomicInteger : java.lang.Number, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AtomicInteger()
		{
			InitJNI();
		}
		protected AtomicInteger(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get21583;
		public virtual int get() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger._get21583);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._get21583);
		}
		internal static global::MonoJavaBridge.MethodId _toString21584;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger._toString21584)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._toString21584)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _set21585;
		public virtual void set(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger._set21585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._set21585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _intValue21586;
		public override int intValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger._intValue21586);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._intValue21586);
		}
		internal static global::MonoJavaBridge.MethodId _longValue21587;
		public override long longValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger._longValue21587);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._longValue21587);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue21588;
		public override float floatValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger._floatValue21588);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._floatValue21588);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue21589;
		public override double doubleValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger._doubleValue21589);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._doubleValue21589);
		}
		internal static global::MonoJavaBridge.MethodId _getAndAdd21590;
		public virtual int getAndAdd(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger._getAndAdd21590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._getAndAdd21590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lazySet21591;
		public virtual void lazySet(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger._lazySet21591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._lazySet21591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAndSet21592;
		public virtual int getAndSet(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger._getAndSet21592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._getAndSet21592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareAndSet21593;
		public virtual bool compareAndSet(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger._compareAndSet21593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._compareAndSet21593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _weakCompareAndSet21594;
		public virtual bool weakCompareAndSet(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger._weakCompareAndSet21594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._weakCompareAndSet21594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int AndIncrement
		{
			get
			{
				return getAndIncrement();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAndIncrement21595;
		public virtual int getAndIncrement() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger._getAndIncrement21595);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._getAndIncrement21595);
		}
		public new int AndDecrement
		{
			get
			{
				return getAndDecrement();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAndDecrement21596;
		public virtual int getAndDecrement() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger._getAndDecrement21596);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._getAndDecrement21596);
		}
		internal static global::MonoJavaBridge.MethodId _incrementAndGet21597;
		public virtual int incrementAndGet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger._incrementAndGet21597);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._incrementAndGet21597);
		}
		internal static global::MonoJavaBridge.MethodId _decrementAndGet21598;
		public virtual int decrementAndGet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger._decrementAndGet21598);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._decrementAndGet21598);
		}
		internal static global::MonoJavaBridge.MethodId _addAndGet21599;
		public virtual int addAndGet(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger._addAndGet21599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._addAndGet21599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AtomicInteger21600;
		public AtomicInteger(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._AtomicInteger21600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AtomicInteger21601;
		public AtomicInteger()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._AtomicInteger21601);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicInteger.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicInteger"));
			global::java.util.concurrent.atomic.AtomicInteger._get21583 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "get", "()I");
			global::java.util.concurrent.atomic.AtomicInteger._toString21584 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.atomic.AtomicInteger._set21585 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "set", "(I)V");
			global::java.util.concurrent.atomic.AtomicInteger._intValue21586 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "intValue", "()I");
			global::java.util.concurrent.atomic.AtomicInteger._longValue21587 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "longValue", "()J");
			global::java.util.concurrent.atomic.AtomicInteger._floatValue21588 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "floatValue", "()F");
			global::java.util.concurrent.atomic.AtomicInteger._doubleValue21589 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "doubleValue", "()D");
			global::java.util.concurrent.atomic.AtomicInteger._getAndAdd21590 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "getAndAdd", "(I)I");
			global::java.util.concurrent.atomic.AtomicInteger._lazySet21591 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "lazySet", "(I)V");
			global::java.util.concurrent.atomic.AtomicInteger._getAndSet21592 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "getAndSet", "(I)I");
			global::java.util.concurrent.atomic.AtomicInteger._compareAndSet21593 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "compareAndSet", "(II)Z");
			global::java.util.concurrent.atomic.AtomicInteger._weakCompareAndSet21594 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "weakCompareAndSet", "(II)Z");
			global::java.util.concurrent.atomic.AtomicInteger._getAndIncrement21595 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "getAndIncrement", "()I");
			global::java.util.concurrent.atomic.AtomicInteger._getAndDecrement21596 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "getAndDecrement", "()I");
			global::java.util.concurrent.atomic.AtomicInteger._incrementAndGet21597 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "incrementAndGet", "()I");
			global::java.util.concurrent.atomic.AtomicInteger._decrementAndGet21598 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "decrementAndGet", "()I");
			global::java.util.concurrent.atomic.AtomicInteger._addAndGet21599 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "addAndGet", "(I)I");
			global::java.util.concurrent.atomic.AtomicInteger._AtomicInteger21600 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "<init>", "(I)V");
			global::java.util.concurrent.atomic.AtomicInteger._AtomicInteger21601 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "<init>", "()V");
		}
	}
}
