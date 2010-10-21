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
		internal static global::MonoJavaBridge.MethodId _add27110;
		public override bool add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._add27110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._add27110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _add27111;
		public virtual bool add(java.util.concurrent.Delayed arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._add27111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._add27111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put27112;
		public virtual void put(java.util.concurrent.Delayed arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._put27112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._put27112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put27113;
		public virtual void put(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._put27113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._put27113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear27114;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._clear27114);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._clear27114);
		}
		internal static global::MonoJavaBridge.MethodId _size27115;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._size27115);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._size27115);
		}
		internal static global::MonoJavaBridge.MethodId _toArray27116;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._toArray27116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._toArray27116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray27117;
		public override global::java.lang.Object[] toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._toArray27117)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._toArray27117)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator27118;
		public override global::java.util.Iterator iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._iterator27118)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._iterator27118)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove27119;
		public override bool remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._remove27119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._remove27119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _poll27120;
		public override global::java.lang.Object poll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._poll27120)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._poll27120)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _poll27121;
		public virtual global::java.lang.Object poll(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._poll27121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._poll27121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peek27122;
		public override global::java.lang.Object peek() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._peek27122)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._peek27122)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer27123;
		public virtual bool offer(java.lang.Object arg0, long arg1, java.util.concurrent.TimeUnit arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._offer27123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._offer27123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _offer27124;
		public override bool offer(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._offer27124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._offer27124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _offer27125;
		public virtual bool offer(java.util.concurrent.Delayed arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._offer27125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._offer27125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _offer27126;
		public virtual bool offer(java.util.concurrent.Delayed arg0, long arg1, java.util.concurrent.TimeUnit arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._offer27126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._offer27126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _take27127;
		public virtual global::java.lang.Object take() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._take27127)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._take27127)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remainingCapacity27128;
		public virtual int remainingCapacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._remainingCapacity27128);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._remainingCapacity27128);
		}
		internal static global::MonoJavaBridge.MethodId _drainTo27129;
		public virtual int drainTo(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._drainTo27129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._drainTo27129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drainTo27130;
		public virtual int drainTo(java.util.Collection arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._drainTo27130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._drainTo27130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _DelayQueue27131;
		public DelayQueue()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._DelayQueue27131);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DelayQueue27132;
		public DelayQueue(java.util.Collection arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._DelayQueue27132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.DelayQueue.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/DelayQueue"));
			global::java.util.concurrent.DelayQueue._add27110 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.DelayQueue._add27111 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "add", "(Ljava/util/concurrent/Delayed;)Z");
			global::java.util.concurrent.DelayQueue._put27112 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "put", "(Ljava/util/concurrent/Delayed;)V");
			global::java.util.concurrent.DelayQueue._put27113 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "put", "(Ljava/lang/Object;)V");
			global::java.util.concurrent.DelayQueue._clear27114 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "clear", "()V");
			global::java.util.concurrent.DelayQueue._size27115 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "size", "()I");
			global::java.util.concurrent.DelayQueue._toArray27116 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.concurrent.DelayQueue._toArray27117 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.concurrent.DelayQueue._iterator27118 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.concurrent.DelayQueue._remove27119 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.DelayQueue._poll27120 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "poll", "()Ljava/lang/Object;");
			global::java.util.concurrent.DelayQueue._poll27121 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			global::java.util.concurrent.DelayQueue._peek27122 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "peek", "()Ljava/lang/Object;");
			global::java.util.concurrent.DelayQueue._offer27123 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.DelayQueue._offer27124 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "offer", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.DelayQueue._offer27125 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "offer", "(Ljava/util/concurrent/Delayed;)Z");
			global::java.util.concurrent.DelayQueue._offer27126 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "offer", "(Ljava/util/concurrent/Delayed;JLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.DelayQueue._take27127 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "take", "()Ljava/lang/Object;");
			global::java.util.concurrent.DelayQueue._remainingCapacity27128 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "remainingCapacity", "()I");
			global::java.util.concurrent.DelayQueue._drainTo27129 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "drainTo", "(Ljava/util/Collection;)I");
			global::java.util.concurrent.DelayQueue._drainTo27130 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "drainTo", "(Ljava/util/Collection;I)I");
			global::java.util.concurrent.DelayQueue._DelayQueue27131 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "<init>", "()V");
			global::java.util.concurrent.DelayQueue._DelayQueue27132 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "<init>", "(Ljava/util/Collection;)V");
		}
	}
}
