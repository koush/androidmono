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
		internal static global::MonoJavaBridge.MethodId _get27413;
		public virtual int get() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger._get27413);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._get27413);
		}
		internal static global::MonoJavaBridge.MethodId _toString27414;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger._toString27414)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._toString27414)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _set27415;
		public virtual void set(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger._set27415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._set27415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _intValue27416;
		public override int intValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger._intValue27416);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._intValue27416);
		}
		internal static global::MonoJavaBridge.MethodId _longValue27417;
		public override long longValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger._longValue27417);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._longValue27417);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue27418;
		public override float floatValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger._floatValue27418);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._floatValue27418);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue27419;
		public override double doubleValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger._doubleValue27419);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._doubleValue27419);
		}
		internal static global::MonoJavaBridge.MethodId _getAndAdd27420;
		public virtual int getAndAdd(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger._getAndAdd27420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._getAndAdd27420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lazySet27421;
		public virtual void lazySet(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger._lazySet27421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._lazySet27421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAndSet27422;
		public virtual int getAndSet(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger._getAndSet27422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._getAndSet27422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareAndSet27423;
		public virtual bool compareAndSet(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger._compareAndSet27423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._compareAndSet27423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _weakCompareAndSet27424;
		public virtual bool weakCompareAndSet(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger._weakCompareAndSet27424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._weakCompareAndSet27424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int AndIncrement
		{
			get
			{
				return getAndIncrement();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAndIncrement27425;
		public virtual int getAndIncrement() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger._getAndIncrement27425);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._getAndIncrement27425);
		}
		public new int AndDecrement
		{
			get
			{
				return getAndDecrement();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAndDecrement27426;
		public virtual int getAndDecrement() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger._getAndDecrement27426);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._getAndDecrement27426);
		}
		internal static global::MonoJavaBridge.MethodId _incrementAndGet27427;
		public virtual int incrementAndGet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger._incrementAndGet27427);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._incrementAndGet27427);
		}
		internal static global::MonoJavaBridge.MethodId _decrementAndGet27428;
		public virtual int decrementAndGet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger._decrementAndGet27428);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._decrementAndGet27428);
		}
		internal static global::MonoJavaBridge.MethodId _addAndGet27429;
		public virtual int addAndGet(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger._addAndGet27429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._addAndGet27429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AtomicInteger27430;
		public AtomicInteger(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._AtomicInteger27430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AtomicInteger27431;
		public AtomicInteger()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._AtomicInteger27431);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicInteger.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicInteger"));
			global::java.util.concurrent.atomic.AtomicInteger._get27413 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "get", "()I");
			global::java.util.concurrent.atomic.AtomicInteger._toString27414 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.atomic.AtomicInteger._set27415 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "set", "(I)V");
			global::java.util.concurrent.atomic.AtomicInteger._intValue27416 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "intValue", "()I");
			global::java.util.concurrent.atomic.AtomicInteger._longValue27417 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "longValue", "()J");
			global::java.util.concurrent.atomic.AtomicInteger._floatValue27418 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "floatValue", "()F");
			global::java.util.concurrent.atomic.AtomicInteger._doubleValue27419 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "doubleValue", "()D");
			global::java.util.concurrent.atomic.AtomicInteger._getAndAdd27420 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "getAndAdd", "(I)I");
			global::java.util.concurrent.atomic.AtomicInteger._lazySet27421 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "lazySet", "(I)V");
			global::java.util.concurrent.atomic.AtomicInteger._getAndSet27422 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "getAndSet", "(I)I");
			global::java.util.concurrent.atomic.AtomicInteger._compareAndSet27423 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "compareAndSet", "(II)Z");
			global::java.util.concurrent.atomic.AtomicInteger._weakCompareAndSet27424 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "weakCompareAndSet", "(II)Z");
			global::java.util.concurrent.atomic.AtomicInteger._getAndIncrement27425 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "getAndIncrement", "()I");
			global::java.util.concurrent.atomic.AtomicInteger._getAndDecrement27426 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "getAndDecrement", "()I");
			global::java.util.concurrent.atomic.AtomicInteger._incrementAndGet27427 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "incrementAndGet", "()I");
			global::java.util.concurrent.atomic.AtomicInteger._decrementAndGet27428 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "decrementAndGet", "()I");
			global::java.util.concurrent.atomic.AtomicInteger._addAndGet27429 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "addAndGet", "(I)I");
			global::java.util.concurrent.atomic.AtomicInteger._AtomicInteger27430 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "<init>", "(I)V");
			global::java.util.concurrent.atomic.AtomicInteger._AtomicInteger27431 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "<init>", "()V");
		}
	}
}
