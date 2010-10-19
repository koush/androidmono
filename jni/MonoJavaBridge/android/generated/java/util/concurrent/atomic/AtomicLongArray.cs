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
		internal static global::MonoJavaBridge.MethodId _get21656;
		public virtual long get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._get21656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._get21656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString21657;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._toString21657)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._toString21657)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _length21658;
		public virtual int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._length21658);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._length21658);
		}
		internal static global::MonoJavaBridge.MethodId _set21659;
		public virtual void set(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._set21659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._set21659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAndAdd21660;
		public virtual long getAndAdd(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._getAndAdd21660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._getAndAdd21660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lazySet21661;
		public virtual void lazySet(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._lazySet21661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._lazySet21661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAndSet21662;
		public virtual long getAndSet(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._getAndSet21662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._getAndSet21662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _compareAndSet21663;
		public virtual bool compareAndSet(int arg0, long arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._compareAndSet21663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._compareAndSet21663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _weakCompareAndSet21664;
		public virtual bool weakCompareAndSet(int arg0, long arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._weakCompareAndSet21664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._weakCompareAndSet21664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getAndIncrement21665;
		public virtual long getAndIncrement(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._getAndIncrement21665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._getAndIncrement21665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAndDecrement21666;
		public virtual long getAndDecrement(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._getAndDecrement21666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._getAndDecrement21666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _incrementAndGet21667;
		public virtual long incrementAndGet(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._incrementAndGet21667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._incrementAndGet21667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _decrementAndGet21668;
		public virtual long decrementAndGet(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._decrementAndGet21668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._decrementAndGet21668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAndGet21669;
		public virtual long addAndGet(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._addAndGet21669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._addAndGet21669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _AtomicLongArray21670;
		public AtomicLongArray(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._AtomicLongArray21670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AtomicLongArray21671;
		public AtomicLongArray(long[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._AtomicLongArray21671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicLongArray.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicLongArray"));
			global::java.util.concurrent.atomic.AtomicLongArray._get21656 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "get", "(I)J");
			global::java.util.concurrent.atomic.AtomicLongArray._toString21657 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.atomic.AtomicLongArray._length21658 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "length", "()I");
			global::java.util.concurrent.atomic.AtomicLongArray._set21659 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "set", "(IJ)V");
			global::java.util.concurrent.atomic.AtomicLongArray._getAndAdd21660 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "getAndAdd", "(IJ)J");
			global::java.util.concurrent.atomic.AtomicLongArray._lazySet21661 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "lazySet", "(IJ)V");
			global::java.util.concurrent.atomic.AtomicLongArray._getAndSet21662 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "getAndSet", "(IJ)J");
			global::java.util.concurrent.atomic.AtomicLongArray._compareAndSet21663 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "compareAndSet", "(IJJ)Z");
			global::java.util.concurrent.atomic.AtomicLongArray._weakCompareAndSet21664 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "weakCompareAndSet", "(IJJ)Z");
			global::java.util.concurrent.atomic.AtomicLongArray._getAndIncrement21665 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "getAndIncrement", "(I)J");
			global::java.util.concurrent.atomic.AtomicLongArray._getAndDecrement21666 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "getAndDecrement", "(I)J");
			global::java.util.concurrent.atomic.AtomicLongArray._incrementAndGet21667 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "incrementAndGet", "(I)J");
			global::java.util.concurrent.atomic.AtomicLongArray._decrementAndGet21668 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "decrementAndGet", "(I)J");
			global::java.util.concurrent.atomic.AtomicLongArray._addAndGet21669 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "addAndGet", "(IJ)J");
			global::java.util.concurrent.atomic.AtomicLongArray._AtomicLongArray21670 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "<init>", "(I)V");
			global::java.util.concurrent.atomic.AtomicLongArray._AtomicLongArray21671 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "<init>", "([J)V");
		}
	}
}
