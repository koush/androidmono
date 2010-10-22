namespace java.util.concurrent.atomic
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AtomicLongArray : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AtomicLongArray()
		{
			InitJNI();
		}
		protected AtomicLongArray(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get27486;
		public virtual long get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._get27486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._get27486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString27487;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._toString27487)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._toString27487)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _length27488;
		public virtual int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._length27488);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._length27488);
		}
		internal static global::MonoJavaBridge.MethodId _set27489;
		public virtual void set(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._set27489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._set27489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAndAdd27490;
		public virtual long getAndAdd(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._getAndAdd27490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._getAndAdd27490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lazySet27491;
		public virtual void lazySet(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._lazySet27491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._lazySet27491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAndSet27492;
		public virtual long getAndSet(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._getAndSet27492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._getAndSet27492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _compareAndSet27493;
		public virtual bool compareAndSet(int arg0, long arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._compareAndSet27493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._compareAndSet27493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _weakCompareAndSet27494;
		public virtual bool weakCompareAndSet(int arg0, long arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._weakCompareAndSet27494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._weakCompareAndSet27494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getAndIncrement27495;
		public virtual long getAndIncrement(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._getAndIncrement27495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._getAndIncrement27495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAndDecrement27496;
		public virtual long getAndDecrement(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._getAndDecrement27496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._getAndDecrement27496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _incrementAndGet27497;
		public virtual long incrementAndGet(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._incrementAndGet27497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._incrementAndGet27497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _decrementAndGet27498;
		public virtual long decrementAndGet(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._decrementAndGet27498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._decrementAndGet27498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAndGet27499;
		public virtual long addAndGet(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._addAndGet27499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._addAndGet27499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _AtomicLongArray27500;
		public AtomicLongArray(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._AtomicLongArray27500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AtomicLongArray27501;
		public AtomicLongArray(long[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._AtomicLongArray27501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicLongArray.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicLongArray"));
			global::java.util.concurrent.atomic.AtomicLongArray._get27486 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "get", "(I)J");
			global::java.util.concurrent.atomic.AtomicLongArray._toString27487 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.atomic.AtomicLongArray._length27488 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "length", "()I");
			global::java.util.concurrent.atomic.AtomicLongArray._set27489 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "set", "(IJ)V");
			global::java.util.concurrent.atomic.AtomicLongArray._getAndAdd27490 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "getAndAdd", "(IJ)J");
			global::java.util.concurrent.atomic.AtomicLongArray._lazySet27491 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "lazySet", "(IJ)V");
			global::java.util.concurrent.atomic.AtomicLongArray._getAndSet27492 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "getAndSet", "(IJ)J");
			global::java.util.concurrent.atomic.AtomicLongArray._compareAndSet27493 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "compareAndSet", "(IJJ)Z");
			global::java.util.concurrent.atomic.AtomicLongArray._weakCompareAndSet27494 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "weakCompareAndSet", "(IJJ)Z");
			global::java.util.concurrent.atomic.AtomicLongArray._getAndIncrement27495 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "getAndIncrement", "(I)J");
			global::java.util.concurrent.atomic.AtomicLongArray._getAndDecrement27496 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "getAndDecrement", "(I)J");
			global::java.util.concurrent.atomic.AtomicLongArray._incrementAndGet27497 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "incrementAndGet", "(I)J");
			global::java.util.concurrent.atomic.AtomicLongArray._decrementAndGet27498 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "decrementAndGet", "(I)J");
			global::java.util.concurrent.atomic.AtomicLongArray._addAndGet27499 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "addAndGet", "(IJ)J");
			global::java.util.concurrent.atomic.AtomicLongArray._AtomicLongArray27500 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "<init>", "(I)V");
			global::java.util.concurrent.atomic.AtomicLongArray._AtomicLongArray27501 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "<init>", "([J)V");
		}
	}
}
