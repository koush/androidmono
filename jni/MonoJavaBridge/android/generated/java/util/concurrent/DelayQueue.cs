namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DelayQueue : java.util.AbstractQueue, BlockingQueue
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DelayQueue()
		{
			InitJNI();
		}
		protected DelayQueue(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add21280;
		public override bool add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._add21280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._add21280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _add21281;
		public virtual bool add(java.util.concurrent.Delayed arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._add21281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._add21281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put21282;
		public virtual void put(java.util.concurrent.Delayed arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._put21282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._put21282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put21283;
		public virtual void put(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._put21283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._put21283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear21284;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._clear21284);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._clear21284);
		}
		internal static global::MonoJavaBridge.MethodId _size21285;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._size21285);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._size21285);
		}
		internal static global::MonoJavaBridge.MethodId _toArray21286;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._toArray21286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._toArray21286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray21287;
		public override global::java.lang.Object[] toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._toArray21287)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._toArray21287)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator21288;
		public override global::java.util.Iterator iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._iterator21288)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._iterator21288)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove21289;
		public override bool remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._remove21289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._remove21289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _poll21290;
		public override global::java.lang.Object poll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._poll21290)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._poll21290)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _poll21291;
		public virtual global::java.lang.Object poll(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._poll21291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._poll21291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peek21292;
		public override global::java.lang.Object peek() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._peek21292)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._peek21292)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer21293;
		public virtual bool offer(java.lang.Object arg0, long arg1, java.util.concurrent.TimeUnit arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._offer21293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._offer21293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _offer21294;
		public override bool offer(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._offer21294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._offer21294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _offer21295;
		public virtual bool offer(java.util.concurrent.Delayed arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._offer21295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._offer21295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _offer21296;
		public virtual bool offer(java.util.concurrent.Delayed arg0, long arg1, java.util.concurrent.TimeUnit arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._offer21296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._offer21296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _take21297;
		public virtual global::java.lang.Object take() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._take21297)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._take21297)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remainingCapacity21298;
		public virtual int remainingCapacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._remainingCapacity21298);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._remainingCapacity21298);
		}
		internal static global::MonoJavaBridge.MethodId _drainTo21299;
		public virtual int drainTo(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._drainTo21299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._drainTo21299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drainTo21300;
		public virtual int drainTo(java.util.Collection arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._drainTo21300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._drainTo21300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _DelayQueue21301;
		public DelayQueue()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._DelayQueue21301);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DelayQueue21302;
		public DelayQueue(java.util.Collection arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._DelayQueue21302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.DelayQueue.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/DelayQueue"));
			global::java.util.concurrent.DelayQueue._add21280 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.DelayQueue._add21281 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "add", "(Ljava/util/concurrent/Delayed;)Z");
			global::java.util.concurrent.DelayQueue._put21282 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "put", "(Ljava/util/concurrent/Delayed;)V");
			global::java.util.concurrent.DelayQueue._put21283 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "put", "(Ljava/lang/Object;)V");
			global::java.util.concurrent.DelayQueue._clear21284 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "clear", "()V");
			global::java.util.concurrent.DelayQueue._size21285 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "size", "()I");
			global::java.util.concurrent.DelayQueue._toArray21286 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.concurrent.DelayQueue._toArray21287 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.concurrent.DelayQueue._iterator21288 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.concurrent.DelayQueue._remove21289 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.DelayQueue._poll21290 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "poll", "()Ljava/lang/Object;");
			global::java.util.concurrent.DelayQueue._poll21291 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			global::java.util.concurrent.DelayQueue._peek21292 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "peek", "()Ljava/lang/Object;");
			global::java.util.concurrent.DelayQueue._offer21293 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.DelayQueue._offer21294 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "offer", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.DelayQueue._offer21295 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "offer", "(Ljava/util/concurrent/Delayed;)Z");
			global::java.util.concurrent.DelayQueue._offer21296 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "offer", "(Ljava/util/concurrent/Delayed;JLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.DelayQueue._take21297 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "take", "()Ljava/lang/Object;");
			global::java.util.concurrent.DelayQueue._remainingCapacity21298 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "remainingCapacity", "()I");
			global::java.util.concurrent.DelayQueue._drainTo21299 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "drainTo", "(Ljava/util/Collection;)I");
			global::java.util.concurrent.DelayQueue._drainTo21300 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "drainTo", "(Ljava/util/Collection;I)I");
			global::java.util.concurrent.DelayQueue._DelayQueue21301 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "<init>", "()V");
			global::java.util.concurrent.DelayQueue._DelayQueue21302 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "<init>", "(Ljava/util/Collection;)V");
		}
	}
}
