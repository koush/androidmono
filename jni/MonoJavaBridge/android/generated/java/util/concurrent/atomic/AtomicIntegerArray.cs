namespace java.util.concurrent.atomic
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AtomicIntegerArray : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AtomicIntegerArray()
		{
			InitJNI();
		}
		protected AtomicIntegerArray(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get21602;
		public virtual int get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray._get21602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._get21602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString21603;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray._toString21603)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._toString21603)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _length21604;
		public virtual int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray._length21604);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._length21604);
		}
		internal static global::MonoJavaBridge.MethodId _set21605;
		public virtual void set(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray._set21605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._set21605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAndAdd21606;
		public virtual int getAndAdd(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray._getAndAdd21606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._getAndAdd21606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lazySet21607;
		public virtual void lazySet(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray._lazySet21607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._lazySet21607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAndSet21608;
		public virtual int getAndSet(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray._getAndSet21608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._getAndSet21608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _compareAndSet21609;
		public virtual bool compareAndSet(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray._compareAndSet21609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._compareAndSet21609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _weakCompareAndSet21610;
		public virtual bool weakCompareAndSet(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray._weakCompareAndSet21610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._weakCompareAndSet21610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getAndIncrement21611;
		public virtual int getAndIncrement(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray._getAndIncrement21611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._getAndIncrement21611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAndDecrement21612;
		public virtual int getAndDecrement(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray._getAndDecrement21612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._getAndDecrement21612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _incrementAndGet21613;
		public virtual int incrementAndGet(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray._incrementAndGet21613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._incrementAndGet21613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _decrementAndGet21614;
		public virtual int decrementAndGet(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray._decrementAndGet21614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._decrementAndGet21614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAndGet21615;
		public virtual int addAndGet(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray._addAndGet21615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._addAndGet21615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _AtomicIntegerArray21616;
		public AtomicIntegerArray(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._AtomicIntegerArray21616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AtomicIntegerArray21617;
		public AtomicIntegerArray(int[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._AtomicIntegerArray21617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicIntegerArray"));
			global::java.util.concurrent.atomic.AtomicIntegerArray._get21602 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "get", "(I)I");
			global::java.util.concurrent.atomic.AtomicIntegerArray._toString21603 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.atomic.AtomicIntegerArray._length21604 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "length", "()I");
			global::java.util.concurrent.atomic.AtomicIntegerArray._set21605 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "set", "(II)V");
			global::java.util.concurrent.atomic.AtomicIntegerArray._getAndAdd21606 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "getAndAdd", "(II)I");
			global::java.util.concurrent.atomic.AtomicIntegerArray._lazySet21607 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "lazySet", "(II)V");
			global::java.util.concurrent.atomic.AtomicIntegerArray._getAndSet21608 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "getAndSet", "(II)I");
			global::java.util.concurrent.atomic.AtomicIntegerArray._compareAndSet21609 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "compareAndSet", "(III)Z");
			global::java.util.concurrent.atomic.AtomicIntegerArray._weakCompareAndSet21610 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "weakCompareAndSet", "(III)Z");
			global::java.util.concurrent.atomic.AtomicIntegerArray._getAndIncrement21611 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "getAndIncrement", "(I)I");
			global::java.util.concurrent.atomic.AtomicIntegerArray._getAndDecrement21612 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "getAndDecrement", "(I)I");
			global::java.util.concurrent.atomic.AtomicIntegerArray._incrementAndGet21613 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "incrementAndGet", "(I)I");
			global::java.util.concurrent.atomic.AtomicIntegerArray._decrementAndGet21614 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "decrementAndGet", "(I)I");
			global::java.util.concurrent.atomic.AtomicIntegerArray._addAndGet21615 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "addAndGet", "(II)I");
			global::java.util.concurrent.atomic.AtomicIntegerArray._AtomicIntegerArray21616 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "<init>", "(I)V");
			global::java.util.concurrent.atomic.AtomicIntegerArray._AtomicIntegerArray21617 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "<init>", "([I)V");
		}
	}
}
