namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.concurrent.BlockingQueue_))]
	public partial interface BlockingQueue : Queue
	{
		bool add(java.lang.Object arg0);
		void put(java.lang.Object arg0);
		bool contains(java.lang.Object arg0);
		bool remove(java.lang.Object arg0);
		global::java.lang.Object poll(long arg0, java.util.concurrent.TimeUnit arg1);
		bool offer(java.lang.Object arg0, long arg1, java.util.concurrent.TimeUnit arg2);
		bool offer(java.lang.Object arg0);
		global::java.lang.Object take();
		int remainingCapacity();
		int drainTo(java.util.Collection arg0);
		int drainTo(java.util.Collection arg0, int arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.BlockingQueue))]
	internal sealed partial class BlockingQueue_ : java.lang.Object, BlockingQueue
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BlockingQueue_()
		{
			InitJNI();
		}
		internal BlockingQueue_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add27066;
		 bool java.util.concurrent.BlockingQueue.add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._add27066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._add27066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put27067;
		 void java.util.concurrent.BlockingQueue.put(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._put27067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._put27067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _contains27068;
		 bool java.util.concurrent.BlockingQueue.contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._contains27068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._contains27068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove27069;
		 bool java.util.concurrent.BlockingQueue.remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._remove27069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._remove27069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _poll27070;
		 global::java.lang.Object java.util.concurrent.BlockingQueue.poll(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._poll27070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._poll27070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer27071;
		 bool java.util.concurrent.BlockingQueue.offer(java.lang.Object arg0, long arg1, java.util.concurrent.TimeUnit arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._offer27071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._offer27071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _offer27072;
		 bool java.util.concurrent.BlockingQueue.offer(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._offer27072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._offer27072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _take27073;
		 global::java.lang.Object java.util.concurrent.BlockingQueue.take() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._take27073)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._take27073)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remainingCapacity27074;
		 int java.util.concurrent.BlockingQueue.remainingCapacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._remainingCapacity27074);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._remainingCapacity27074);
		}
		internal static global::MonoJavaBridge.MethodId _drainTo27075;
		 int java.util.concurrent.BlockingQueue.drainTo(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._drainTo27075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._drainTo27075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drainTo27076;
		 int java.util.concurrent.BlockingQueue.drainTo(java.util.Collection arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._drainTo27076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._drainTo27076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _add27077;
		 bool java.util.Queue.add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._add27077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._add27077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove27078;
		 global::java.lang.Object java.util.Queue.remove() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._remove27078)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._remove27078)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _poll27079;
		 global::java.lang.Object java.util.Queue.poll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._poll27079)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._poll27079)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peek27080;
		 global::java.lang.Object java.util.Queue.peek() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._peek27080)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._peek27080)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _element27081;
		 global::java.lang.Object java.util.Queue.element() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._element27081)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._element27081)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer27082;
		 bool java.util.Queue.offer(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._offer27082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._offer27082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _add27083;
		 bool java.util.Collection.add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._add27083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._add27083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals27084;
		 bool java.util.Collection.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._equals27084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._equals27084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode27085;
		 int java.util.Collection.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._hashCode27085);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._hashCode27085);
		}
		internal static global::MonoJavaBridge.MethodId _clear27086;
		 void java.util.Collection.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._clear27086);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._clear27086);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty27087;
		 bool java.util.Collection.isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._isEmpty27087);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._isEmpty27087);
		}
		internal static global::MonoJavaBridge.MethodId _contains27088;
		 bool java.util.Collection.contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._contains27088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._contains27088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll27089;
		 bool java.util.Collection.addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._addAll27089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._addAll27089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size27090;
		 int java.util.Collection.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._size27090);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._size27090);
		}
		internal static global::MonoJavaBridge.MethodId _toArray27091;
		 global::java.lang.Object[] java.util.Collection.toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._toArray27091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._toArray27091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray27092;
		 global::java.lang.Object[] java.util.Collection.toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._toArray27092)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._toArray27092)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator27093;
		 global::java.util.Iterator java.util.Collection.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._iterator27093)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._iterator27093)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove27094;
		 bool java.util.Collection.remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._remove27094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._remove27094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll27095;
		 bool java.util.Collection.containsAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._containsAll27095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._containsAll27095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll27096;
		 bool java.util.Collection.removeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._removeAll27096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._removeAll27096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll27097;
		 bool java.util.Collection.retainAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._retainAll27097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._retainAll27097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(((global::java.lang.Iterable)this).iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator27098;
		 global::java.util.Iterator java.lang.Iterable.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._iterator27098)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._iterator27098)) as java.util.Iterator;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.BlockingQueue_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/BlockingQueue"));
			global::java.util.concurrent.BlockingQueue_._add27066 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._put27067 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "put", "(Ljava/lang/Object;)V");
			global::java.util.concurrent.BlockingQueue_._contains27068 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._remove27069 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._poll27070 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			global::java.util.concurrent.BlockingQueue_._offer27071 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.BlockingQueue_._offer27072 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "offer", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._take27073 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "take", "()Ljava/lang/Object;");
			global::java.util.concurrent.BlockingQueue_._remainingCapacity27074 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "remainingCapacity", "()I");
			global::java.util.concurrent.BlockingQueue_._drainTo27075 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "drainTo", "(Ljava/util/Collection;)I");
			global::java.util.concurrent.BlockingQueue_._drainTo27076 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "drainTo", "(Ljava/util/Collection;I)I");
			global::java.util.concurrent.BlockingQueue_._add27077 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._remove27078 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "remove", "()Ljava/lang/Object;");
			global::java.util.concurrent.BlockingQueue_._poll27079 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "poll", "()Ljava/lang/Object;");
			global::java.util.concurrent.BlockingQueue_._peek27080 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "peek", "()Ljava/lang/Object;");
			global::java.util.concurrent.BlockingQueue_._element27081 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "element", "()Ljava/lang/Object;");
			global::java.util.concurrent.BlockingQueue_._offer27082 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "offer", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._add27083 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._equals27084 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._hashCode27085 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "hashCode", "()I");
			global::java.util.concurrent.BlockingQueue_._clear27086 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "clear", "()V");
			global::java.util.concurrent.BlockingQueue_._isEmpty27087 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "isEmpty", "()Z");
			global::java.util.concurrent.BlockingQueue_._contains27088 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._addAll27089 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.BlockingQueue_._size27090 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "size", "()I");
			global::java.util.concurrent.BlockingQueue_._toArray27091 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.concurrent.BlockingQueue_._toArray27092 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.concurrent.BlockingQueue_._iterator27093 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.concurrent.BlockingQueue_._remove27094 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._containsAll27095 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.BlockingQueue_._removeAll27096 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.BlockingQueue_._retainAll27097 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.BlockingQueue_._iterator27098 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "iterator", "()Ljava/util/Iterator;");
		}
	}
}
