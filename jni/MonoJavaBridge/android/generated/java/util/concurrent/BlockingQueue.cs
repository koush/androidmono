namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.concurrent.BlockingQueue_))]
	public interface BlockingQueue : Queue
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
	public sealed partial class BlockingQueue_ : java.lang.Object, BlockingQueue
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BlockingQueue_()
		{
			InitJNI();
		}
		internal BlockingQueue_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add26948;
		 bool java.util.concurrent.BlockingQueue.add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._add26948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._add26948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put26949;
		 void java.util.concurrent.BlockingQueue.put(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._put26949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._put26949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _contains26950;
		 bool java.util.concurrent.BlockingQueue.contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._contains26950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._contains26950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove26951;
		 bool java.util.concurrent.BlockingQueue.remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._remove26951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._remove26951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _poll26952;
		 global::java.lang.Object java.util.concurrent.BlockingQueue.poll(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._poll26952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._poll26952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer26953;
		 bool java.util.concurrent.BlockingQueue.offer(java.lang.Object arg0, long arg1, java.util.concurrent.TimeUnit arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._offer26953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._offer26953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _offer26954;
		 bool java.util.concurrent.BlockingQueue.offer(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._offer26954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._offer26954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _take26955;
		 global::java.lang.Object java.util.concurrent.BlockingQueue.take() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._take26955)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._take26955)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remainingCapacity26956;
		 int java.util.concurrent.BlockingQueue.remainingCapacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._remainingCapacity26956);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._remainingCapacity26956);
		}
		internal static global::MonoJavaBridge.MethodId _drainTo26957;
		 int java.util.concurrent.BlockingQueue.drainTo(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._drainTo26957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._drainTo26957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drainTo26958;
		 int java.util.concurrent.BlockingQueue.drainTo(java.util.Collection arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._drainTo26958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._drainTo26958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _add26959;
		 bool java.util.Queue.add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._add26959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._add26959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove26960;
		 global::java.lang.Object java.util.Queue.remove() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._remove26960)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._remove26960)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _poll26961;
		 global::java.lang.Object java.util.Queue.poll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._poll26961)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._poll26961)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peek26962;
		 global::java.lang.Object java.util.Queue.peek() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._peek26962)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._peek26962)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _element26963;
		 global::java.lang.Object java.util.Queue.element() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._element26963)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._element26963)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer26964;
		 bool java.util.Queue.offer(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._offer26964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._offer26964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _add26965;
		 bool java.util.Collection.add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._add26965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._add26965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals26966;
		 bool java.util.Collection.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._equals26966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._equals26966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26967;
		 int java.util.Collection.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._hashCode26967);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._hashCode26967);
		}
		internal static global::MonoJavaBridge.MethodId _clear26968;
		 void java.util.Collection.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._clear26968);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._clear26968);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26969;
		 bool java.util.Collection.isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._isEmpty26969);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._isEmpty26969);
		}
		internal static global::MonoJavaBridge.MethodId _contains26970;
		 bool java.util.Collection.contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._contains26970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._contains26970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26971;
		 bool java.util.Collection.addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._addAll26971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._addAll26971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size26972;
		 int java.util.Collection.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._size26972);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._size26972);
		}
		internal static global::MonoJavaBridge.MethodId _toArray26973;
		 global::java.lang.Object[] java.util.Collection.toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._toArray26973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._toArray26973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray26974;
		 global::java.lang.Object[] java.util.Collection.toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._toArray26974)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._toArray26974)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator26975;
		 global::java.util.Iterator java.util.Collection.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._iterator26975)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._iterator26975)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove26976;
		 bool java.util.Collection.remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._remove26976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._remove26976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll26977;
		 bool java.util.Collection.containsAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._containsAll26977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._containsAll26977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll26978;
		 bool java.util.Collection.removeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._removeAll26978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._removeAll26978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll26979;
		 bool java.util.Collection.retainAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._retainAll26979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._retainAll26979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _iterator26980;
		 global::java.util.Iterator java.lang.Iterable.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._iterator26980)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._iterator26980)) as java.util.Iterator;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.BlockingQueue_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/BlockingQueue"));
			global::java.util.concurrent.BlockingQueue_._add26948 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._put26949 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "put", "(Ljava/lang/Object;)V");
			global::java.util.concurrent.BlockingQueue_._contains26950 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._remove26951 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._poll26952 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			global::java.util.concurrent.BlockingQueue_._offer26953 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.BlockingQueue_._offer26954 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "offer", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._take26955 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "take", "()Ljava/lang/Object;");
			global::java.util.concurrent.BlockingQueue_._remainingCapacity26956 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "remainingCapacity", "()I");
			global::java.util.concurrent.BlockingQueue_._drainTo26957 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "drainTo", "(Ljava/util/Collection;)I");
			global::java.util.concurrent.BlockingQueue_._drainTo26958 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "drainTo", "(Ljava/util/Collection;I)I");
			global::java.util.concurrent.BlockingQueue_._add26959 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._remove26960 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "remove", "()Ljava/lang/Object;");
			global::java.util.concurrent.BlockingQueue_._poll26961 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "poll", "()Ljava/lang/Object;");
			global::java.util.concurrent.BlockingQueue_._peek26962 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "peek", "()Ljava/lang/Object;");
			global::java.util.concurrent.BlockingQueue_._element26963 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "element", "()Ljava/lang/Object;");
			global::java.util.concurrent.BlockingQueue_._offer26964 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "offer", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._add26965 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._equals26966 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._hashCode26967 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "hashCode", "()I");
			global::java.util.concurrent.BlockingQueue_._clear26968 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "clear", "()V");
			global::java.util.concurrent.BlockingQueue_._isEmpty26969 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "isEmpty", "()Z");
			global::java.util.concurrent.BlockingQueue_._contains26970 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._addAll26971 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.BlockingQueue_._size26972 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "size", "()I");
			global::java.util.concurrent.BlockingQueue_._toArray26973 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.concurrent.BlockingQueue_._toArray26974 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.concurrent.BlockingQueue_._iterator26975 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.concurrent.BlockingQueue_._remove26976 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._containsAll26977 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.BlockingQueue_._removeAll26978 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.BlockingQueue_._retainAll26979 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.BlockingQueue_._iterator26980 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "iterator", "()Ljava/util/Iterator;");
		}
	}
}
