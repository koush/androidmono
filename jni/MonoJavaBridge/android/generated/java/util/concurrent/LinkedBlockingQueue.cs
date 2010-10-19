namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LinkedBlockingQueue : java.util.AbstractQueue, BlockingQueue, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LinkedBlockingQueue()
		{
			InitJNI();
		}
		protected LinkedBlockingQueue(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _put21370;
		public virtual void put(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue._put21370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._put21370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString21371;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue._toString21371)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._toString21371)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clear21372;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue._clear21372);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._clear21372);
		}
		internal static global::MonoJavaBridge.MethodId _size21373;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue._size21373);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._size21373);
		}
		internal static global::MonoJavaBridge.MethodId _toArray21374;
		public override global::java.lang.Object[] toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue._toArray21374)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._toArray21374)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray21375;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue._toArray21375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._toArray21375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator21376;
		public override global::java.util.Iterator iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue._iterator21376)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._iterator21376)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove21377;
		public override bool remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue._remove21377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._remove21377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _poll21378;
		public virtual global::java.lang.Object poll(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue._poll21378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._poll21378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _poll21379;
		public override global::java.lang.Object poll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue._poll21379)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._poll21379)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peek21380;
		public override global::java.lang.Object peek() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue._peek21380)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._peek21380)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer21381;
		public override bool offer(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue._offer21381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._offer21381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _offer21382;
		public virtual bool offer(java.lang.Object arg0, long arg1, java.util.concurrent.TimeUnit arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue._offer21382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._offer21382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _take21383;
		public virtual global::java.lang.Object take() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue._take21383)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._take21383)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remainingCapacity21384;
		public virtual int remainingCapacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue._remainingCapacity21384);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._remainingCapacity21384);
		}
		internal static global::MonoJavaBridge.MethodId _drainTo21385;
		public virtual int drainTo(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue._drainTo21385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._drainTo21385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drainTo21386;
		public virtual int drainTo(java.util.Collection arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue._drainTo21386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._drainTo21386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _LinkedBlockingQueue21387;
		public LinkedBlockingQueue()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._LinkedBlockingQueue21387);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LinkedBlockingQueue21388;
		public LinkedBlockingQueue(java.util.Collection arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._LinkedBlockingQueue21388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LinkedBlockingQueue21389;
		public LinkedBlockingQueue(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._LinkedBlockingQueue21389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.LinkedBlockingQueue.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/LinkedBlockingQueue"));
			global::java.util.concurrent.LinkedBlockingQueue._put21370 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "put", "(Ljava/lang/Object;)V");
			global::java.util.concurrent.LinkedBlockingQueue._toString21371 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.LinkedBlockingQueue._clear21372 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "clear", "()V");
			global::java.util.concurrent.LinkedBlockingQueue._size21373 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "size", "()I");
			global::java.util.concurrent.LinkedBlockingQueue._toArray21374 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.concurrent.LinkedBlockingQueue._toArray21375 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.concurrent.LinkedBlockingQueue._iterator21376 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.concurrent.LinkedBlockingQueue._remove21377 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.LinkedBlockingQueue._poll21378 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			global::java.util.concurrent.LinkedBlockingQueue._poll21379 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "poll", "()Ljava/lang/Object;");
			global::java.util.concurrent.LinkedBlockingQueue._peek21380 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "peek", "()Ljava/lang/Object;");
			global::java.util.concurrent.LinkedBlockingQueue._offer21381 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "offer", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.LinkedBlockingQueue._offer21382 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.LinkedBlockingQueue._take21383 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "take", "()Ljava/lang/Object;");
			global::java.util.concurrent.LinkedBlockingQueue._remainingCapacity21384 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "remainingCapacity", "()I");
			global::java.util.concurrent.LinkedBlockingQueue._drainTo21385 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "drainTo", "(Ljava/util/Collection;)I");
			global::java.util.concurrent.LinkedBlockingQueue._drainTo21386 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "drainTo", "(Ljava/util/Collection;I)I");
			global::java.util.concurrent.LinkedBlockingQueue._LinkedBlockingQueue21387 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "<init>", "()V");
			global::java.util.concurrent.LinkedBlockingQueue._LinkedBlockingQueue21388 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::java.util.concurrent.LinkedBlockingQueue._LinkedBlockingQueue21389 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "<init>", "(I)V");
		}
	}
}
