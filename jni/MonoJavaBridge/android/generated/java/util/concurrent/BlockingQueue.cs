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
		internal static global::MonoJavaBridge.MethodId _add21118;
		 bool java.util.concurrent.BlockingQueue.add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._add21118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._add21118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put21119;
		 void java.util.concurrent.BlockingQueue.put(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._put21119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._put21119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _contains21120;
		 bool java.util.concurrent.BlockingQueue.contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._contains21120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._contains21120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove21121;
		 bool java.util.concurrent.BlockingQueue.remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._remove21121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._remove21121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _poll21122;
		 global::java.lang.Object java.util.concurrent.BlockingQueue.poll(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._poll21122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._poll21122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer21123;
		 bool java.util.concurrent.BlockingQueue.offer(java.lang.Object arg0, long arg1, java.util.concurrent.TimeUnit arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._offer21123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._offer21123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _offer21124;
		 bool java.util.concurrent.BlockingQueue.offer(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._offer21124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._offer21124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _take21125;
		 global::java.lang.Object java.util.concurrent.BlockingQueue.take() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._take21125)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._take21125)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remainingCapacity21126;
		 int java.util.concurrent.BlockingQueue.remainingCapacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._remainingCapacity21126);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._remainingCapacity21126);
		}
		internal static global::MonoJavaBridge.MethodId _drainTo21127;
		 int java.util.concurrent.BlockingQueue.drainTo(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._drainTo21127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._drainTo21127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drainTo21128;
		 int java.util.concurrent.BlockingQueue.drainTo(java.util.Collection arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._drainTo21128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._drainTo21128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _add21129;
		 bool java.util.Queue.add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._add21129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._add21129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove21130;
		 global::java.lang.Object java.util.Queue.remove() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._remove21130)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._remove21130)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _poll21131;
		 global::java.lang.Object java.util.Queue.poll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._poll21131)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._poll21131)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peek21132;
		 global::java.lang.Object java.util.Queue.peek() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._peek21132)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._peek21132)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _element21133;
		 global::java.lang.Object java.util.Queue.element() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._element21133)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._element21133)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer21134;
		 bool java.util.Queue.offer(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._offer21134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._offer21134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _add21135;
		 bool java.util.Collection.add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._add21135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._add21135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals21136;
		 bool java.util.Collection.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._equals21136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._equals21136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode21137;
		 int java.util.Collection.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._hashCode21137);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._hashCode21137);
		}
		internal static global::MonoJavaBridge.MethodId _clear21138;
		 void java.util.Collection.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._clear21138);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._clear21138);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty21139;
		 bool java.util.Collection.isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._isEmpty21139);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._isEmpty21139);
		}
		internal static global::MonoJavaBridge.MethodId _contains21140;
		 bool java.util.Collection.contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._contains21140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._contains21140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll21141;
		 bool java.util.Collection.addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._addAll21141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._addAll21141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size21142;
		 int java.util.Collection.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._size21142);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._size21142);
		}
		internal static global::MonoJavaBridge.MethodId _toArray21143;
		 global::java.lang.Object[] java.util.Collection.toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._toArray21143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._toArray21143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray21144;
		 global::java.lang.Object[] java.util.Collection.toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._toArray21144)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._toArray21144)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator21145;
		 global::java.util.Iterator java.util.Collection.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._iterator21145)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._iterator21145)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove21146;
		 bool java.util.Collection.remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._remove21146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._remove21146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll21147;
		 bool java.util.Collection.containsAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._containsAll21147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._containsAll21147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll21148;
		 bool java.util.Collection.removeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._removeAll21148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._removeAll21148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll21149;
		 bool java.util.Collection.retainAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._retainAll21149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._retainAll21149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _iterator21150;
		 global::java.util.Iterator java.lang.Iterable.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_._iterator21150)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.BlockingQueue_.staticClass, global::java.util.concurrent.BlockingQueue_._iterator21150)) as java.util.Iterator;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.BlockingQueue_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/BlockingQueue"));
			global::java.util.concurrent.BlockingQueue_._add21118 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._put21119 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "put", "(Ljava/lang/Object;)V");
			global::java.util.concurrent.BlockingQueue_._contains21120 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._remove21121 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._poll21122 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			global::java.util.concurrent.BlockingQueue_._offer21123 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.BlockingQueue_._offer21124 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "offer", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._take21125 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "take", "()Ljava/lang/Object;");
			global::java.util.concurrent.BlockingQueue_._remainingCapacity21126 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "remainingCapacity", "()I");
			global::java.util.concurrent.BlockingQueue_._drainTo21127 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "drainTo", "(Ljava/util/Collection;)I");
			global::java.util.concurrent.BlockingQueue_._drainTo21128 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "drainTo", "(Ljava/util/Collection;I)I");
			global::java.util.concurrent.BlockingQueue_._add21129 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._remove21130 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "remove", "()Ljava/lang/Object;");
			global::java.util.concurrent.BlockingQueue_._poll21131 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "poll", "()Ljava/lang/Object;");
			global::java.util.concurrent.BlockingQueue_._peek21132 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "peek", "()Ljava/lang/Object;");
			global::java.util.concurrent.BlockingQueue_._element21133 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "element", "()Ljava/lang/Object;");
			global::java.util.concurrent.BlockingQueue_._offer21134 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "offer", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._add21135 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._equals21136 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._hashCode21137 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "hashCode", "()I");
			global::java.util.concurrent.BlockingQueue_._clear21138 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "clear", "()V");
			global::java.util.concurrent.BlockingQueue_._isEmpty21139 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "isEmpty", "()Z");
			global::java.util.concurrent.BlockingQueue_._contains21140 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._addAll21141 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.BlockingQueue_._size21142 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "size", "()I");
			global::java.util.concurrent.BlockingQueue_._toArray21143 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.concurrent.BlockingQueue_._toArray21144 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.concurrent.BlockingQueue_._iterator21145 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.concurrent.BlockingQueue_._remove21146 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.BlockingQueue_._containsAll21147 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.BlockingQueue_._removeAll21148 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.BlockingQueue_._retainAll21149 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.BlockingQueue_._iterator21150 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BlockingQueue_.staticClass, "iterator", "()Ljava/util/Iterator;");
		}
	}
}
