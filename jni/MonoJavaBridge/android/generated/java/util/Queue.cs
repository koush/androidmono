namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.Queue_))]
	public partial interface Queue : Collection
	{
		bool add(java.lang.Object arg0);
		global::java.lang.Object remove();
		global::java.lang.Object poll();
		global::java.lang.Object peek();
		global::java.lang.Object element();
		bool offer(java.lang.Object arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.Queue))]
	public sealed partial class Queue_ : java.lang.Object, Queue
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Queue_()
		{
			InitJNI();
		}
		internal Queue_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add26467;
		 bool java.util.Queue.add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._add26467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._add26467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove26468;
		 global::java.lang.Object java.util.Queue.remove() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Queue_._remove26468)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._remove26468)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _poll26469;
		 global::java.lang.Object java.util.Queue.poll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Queue_._poll26469)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._poll26469)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peek26470;
		 global::java.lang.Object java.util.Queue.peek() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Queue_._peek26470)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._peek26470)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _element26471;
		 global::java.lang.Object java.util.Queue.element() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Queue_._element26471)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._element26471)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer26472;
		 bool java.util.Queue.offer(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._offer26472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._offer26472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _add26473;
		 bool java.util.Collection.add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._add26473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._add26473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals26474;
		 bool java.util.Collection.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._equals26474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._equals26474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26475;
		 int java.util.Collection.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Queue_._hashCode26475);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._hashCode26475);
		}
		internal static global::MonoJavaBridge.MethodId _clear26476;
		 void java.util.Collection.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Queue_._clear26476);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._clear26476);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26477;
		 bool java.util.Collection.isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._isEmpty26477);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._isEmpty26477);
		}
		internal static global::MonoJavaBridge.MethodId _contains26478;
		 bool java.util.Collection.contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._contains26478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._contains26478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26479;
		 bool java.util.Collection.addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._addAll26479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._addAll26479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size26480;
		 int java.util.Collection.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Queue_._size26480);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._size26480);
		}
		internal static global::MonoJavaBridge.MethodId _toArray26481;
		 global::java.lang.Object[] java.util.Collection.toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Queue_._toArray26481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._toArray26481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray26482;
		 global::java.lang.Object[] java.util.Collection.toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Queue_._toArray26482)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._toArray26482)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator26483;
		 global::java.util.Iterator java.util.Collection.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Queue_._iterator26483)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._iterator26483)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove26484;
		 bool java.util.Collection.remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._remove26484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._remove26484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll26485;
		 bool java.util.Collection.containsAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._containsAll26485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._containsAll26485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll26486;
		 bool java.util.Collection.removeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._removeAll26486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._removeAll26486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll26487;
		 bool java.util.Collection.retainAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._retainAll26487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._retainAll26487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(((global::java.lang.Iterable)this).iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator26488;
		 global::java.util.Iterator java.lang.Iterable.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Queue_._iterator26488)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._iterator26488)) as java.util.Iterator;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Queue_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Queue"));
			global::java.util.Queue_._add26467 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.Queue_._remove26468 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "remove", "()Ljava/lang/Object;");
			global::java.util.Queue_._poll26469 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "poll", "()Ljava/lang/Object;");
			global::java.util.Queue_._peek26470 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "peek", "()Ljava/lang/Object;");
			global::java.util.Queue_._element26471 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "element", "()Ljava/lang/Object;");
			global::java.util.Queue_._offer26472 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "offer", "(Ljava/lang/Object;)Z");
			global::java.util.Queue_._add26473 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.Queue_._equals26474 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Queue_._hashCode26475 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "hashCode", "()I");
			global::java.util.Queue_._clear26476 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "clear", "()V");
			global::java.util.Queue_._isEmpty26477 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "isEmpty", "()Z");
			global::java.util.Queue_._contains26478 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.Queue_._addAll26479 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.Queue_._size26480 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "size", "()I");
			global::java.util.Queue_._toArray26481 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.Queue_._toArray26482 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.Queue_._iterator26483 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.Queue_._remove26484 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.Queue_._containsAll26485 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.Queue_._removeAll26486 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.Queue_._retainAll26487 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.Queue_._iterator26488 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "iterator", "()Ljava/util/Iterator;");
		}
	}
}
