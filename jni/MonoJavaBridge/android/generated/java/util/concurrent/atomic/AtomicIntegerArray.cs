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
		internal static global::MonoJavaBridge.MethodId _get27550;
		public virtual int get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray._get27550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._get27550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString27551;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray._toString27551)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._toString27551)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _length27552;
		public virtual int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray._length27552);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._length27552);
		}
		internal static global::MonoJavaBridge.MethodId _set27553;
		public virtual void set(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray._set27553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._set27553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAndAdd27554;
		public virtual int getAndAdd(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray._getAndAdd27554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._getAndAdd27554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lazySet27555;
		public virtual void lazySet(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray._lazySet27555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._lazySet27555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAndSet27556;
		public virtual int getAndSet(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray._getAndSet27556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._getAndSet27556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _compareAndSet27557;
		public virtual bool compareAndSet(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray._compareAndSet27557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._compareAndSet27557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _weakCompareAndSet27558;
		public virtual bool weakCompareAndSet(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray._weakCompareAndSet27558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._weakCompareAndSet27558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getAndIncrement27559;
		public virtual int getAndIncrement(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray._getAndIncrement27559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._getAndIncrement27559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAndDecrement27560;
		public virtual int getAndDecrement(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray._getAndDecrement27560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._getAndDecrement27560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _incrementAndGet27561;
		public virtual int incrementAndGet(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray._incrementAndGet27561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._incrementAndGet27561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _decrementAndGet27562;
		public virtual int decrementAndGet(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray._decrementAndGet27562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._decrementAndGet27562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAndGet27563;
		public virtual int addAndGet(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray._addAndGet27563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._addAndGet27563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _AtomicIntegerArray27564;
		public AtomicIntegerArray(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._AtomicIntegerArray27564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AtomicIntegerArray27565;
		public AtomicIntegerArray(int[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._AtomicIntegerArray27565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicIntegerArray"));
			global::java.util.concurrent.atomic.AtomicIntegerArray._get27550 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "get", "(I)I");
			global::java.util.concurrent.atomic.AtomicIntegerArray._toString27551 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.atomic.AtomicIntegerArray._length27552 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "length", "()I");
			global::java.util.concurrent.atomic.AtomicIntegerArray._set27553 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "set", "(II)V");
			global::java.util.concurrent.atomic.AtomicIntegerArray._getAndAdd27554 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "getAndAdd", "(II)I");
			global::java.util.concurrent.atomic.AtomicIntegerArray._lazySet27555 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "lazySet", "(II)V");
			global::java.util.concurrent.atomic.AtomicIntegerArray._getAndSet27556 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "getAndSet", "(II)I");
			global::java.util.concurrent.atomic.AtomicIntegerArray._compareAndSet27557 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "compareAndSet", "(III)Z");
			global::java.util.concurrent.atomic.AtomicIntegerArray._weakCompareAndSet27558 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "weakCompareAndSet", "(III)Z");
			global::java.util.concurrent.atomic.AtomicIntegerArray._getAndIncrement27559 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "getAndIncrement", "(I)I");
			global::java.util.concurrent.atomic.AtomicIntegerArray._getAndDecrement27560 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "getAndDecrement", "(I)I");
			global::java.util.concurrent.atomic.AtomicIntegerArray._incrementAndGet27561 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "incrementAndGet", "(I)I");
			global::java.util.concurrent.atomic.AtomicIntegerArray._decrementAndGet27562 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "decrementAndGet", "(I)I");
			global::java.util.concurrent.atomic.AtomicIntegerArray._addAndGet27563 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "addAndGet", "(II)I");
			global::java.util.concurrent.atomic.AtomicIntegerArray._AtomicIntegerArray27564 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "<init>", "(I)V");
			global::java.util.concurrent.atomic.AtomicIntegerArray._AtomicIntegerArray27565 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "<init>", "([I)V");
		}
	}
}
