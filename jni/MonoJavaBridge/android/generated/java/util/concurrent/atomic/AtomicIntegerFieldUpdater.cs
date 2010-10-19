namespace java.util.concurrent.atomic
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_))]
	public abstract partial class AtomicIntegerFieldUpdater : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AtomicIntegerFieldUpdater()
		{
			InitJNI();
		}
		protected AtomicIntegerFieldUpdater(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get21618;
		public abstract int get(java.lang.Object arg0);
		internal static global::MonoJavaBridge.MethodId _set21619;
		public abstract void set(java.lang.Object arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getAndAdd21620;
		public virtual int getAndAdd(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._getAndAdd21620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._getAndAdd21620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lazySet21621;
		public abstract void lazySet(java.lang.Object arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getAndSet21622;
		public virtual int getAndSet(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._getAndSet21622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._getAndSet21622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _compareAndSet21623;
		public abstract bool compareAndSet(java.lang.Object arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _weakCompareAndSet21624;
		public abstract bool weakCompareAndSet(java.lang.Object arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _getAndIncrement21625;
		public virtual int getAndIncrement(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._getAndIncrement21625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._getAndIncrement21625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAndDecrement21626;
		public virtual int getAndDecrement(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._getAndDecrement21626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._getAndDecrement21626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _incrementAndGet21627;
		public virtual int incrementAndGet(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._incrementAndGet21627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._incrementAndGet21627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _decrementAndGet21628;
		public virtual int decrementAndGet(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._decrementAndGet21628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._decrementAndGet21628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAndGet21629;
		public virtual int addAndGet(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._addAndGet21629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._addAndGet21629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _newUpdater21630;
		public static global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater newUpdater(java.lang.Class arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._newUpdater21630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.atomic.AtomicIntegerFieldUpdater;
		}
		internal static global::MonoJavaBridge.MethodId _AtomicIntegerFieldUpdater21631;
		protected AtomicIntegerFieldUpdater()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._AtomicIntegerFieldUpdater21631);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicIntegerFieldUpdater"));
			global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._get21618 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, "get", "(Ljava/lang/Object;)I");
			global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._set21619 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, "set", "(Ljava/lang/Object;I)V");
			global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._getAndAdd21620 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, "getAndAdd", "(Ljava/lang/Object;I)I");
			global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._lazySet21621 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, "lazySet", "(Ljava/lang/Object;I)V");
			global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._getAndSet21622 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, "getAndSet", "(Ljava/lang/Object;I)I");
			global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._compareAndSet21623 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, "compareAndSet", "(Ljava/lang/Object;II)Z");
			global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._weakCompareAndSet21624 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, "weakCompareAndSet", "(Ljava/lang/Object;II)Z");
			global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._getAndIncrement21625 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, "getAndIncrement", "(Ljava/lang/Object;)I");
			global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._getAndDecrement21626 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, "getAndDecrement", "(Ljava/lang/Object;)I");
			global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._incrementAndGet21627 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, "incrementAndGet", "(Ljava/lang/Object;)I");
			global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._decrementAndGet21628 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, "decrementAndGet", "(Ljava/lang/Object;)I");
			global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._addAndGet21629 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, "addAndGet", "(Ljava/lang/Object;I)I");
			global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._newUpdater21630 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, "newUpdater", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/util/concurrent/atomic/AtomicIntegerFieldUpdater;");
			global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._AtomicIntegerFieldUpdater21631 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater))]
	public sealed partial class AtomicIntegerFieldUpdater_ : java.util.concurrent.atomic.AtomicIntegerFieldUpdater
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AtomicIntegerFieldUpdater_()
		{
			InitJNI();
		}
		internal AtomicIntegerFieldUpdater_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get21632;
		public override int get(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_._get21632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_.staticClass, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_._get21632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _set21633;
		public override void set(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_._set21633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_.staticClass, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_._set21633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lazySet21634;
		public override void lazySet(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_._lazySet21634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_.staticClass, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_._lazySet21634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _compareAndSet21635;
		public override bool compareAndSet(java.lang.Object arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_._compareAndSet21635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_.staticClass, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_._compareAndSet21635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _weakCompareAndSet21636;
		public override bool weakCompareAndSet(java.lang.Object arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_._weakCompareAndSet21636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_.staticClass, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_._weakCompareAndSet21636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicIntegerFieldUpdater"));
			global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_._get21632 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_.staticClass, "get", "(Ljava/lang/Object;)I");
			global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_._set21633 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_.staticClass, "set", "(Ljava/lang/Object;I)V");
			global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_._lazySet21634 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_.staticClass, "lazySet", "(Ljava/lang/Object;I)V");
			global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_._compareAndSet21635 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_.staticClass, "compareAndSet", "(Ljava/lang/Object;II)Z");
			global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_._weakCompareAndSet21636 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_.staticClass, "weakCompareAndSet", "(Ljava/lang/Object;II)Z");
		}
	}
}
