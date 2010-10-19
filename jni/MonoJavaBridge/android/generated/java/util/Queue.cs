namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.Queue_))]
	public interface Queue : Collection
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
		internal static global::MonoJavaBridge.MethodId _add20642;
		 bool java.util.Queue.add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._add20642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._add20642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove20643;
		 global::java.lang.Object java.util.Queue.remove() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Queue_._remove20643)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._remove20643)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _poll20644;
		 global::java.lang.Object java.util.Queue.poll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Queue_._poll20644)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._poll20644)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peek20645;
		 global::java.lang.Object java.util.Queue.peek() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Queue_._peek20645)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._peek20645)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _element20646;
		 global::java.lang.Object java.util.Queue.element() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Queue_._element20646)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._element20646)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer20647;
		 bool java.util.Queue.offer(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._offer20647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._offer20647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _add20648;
		 bool java.util.Collection.add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._add20648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._add20648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals20649;
		 bool java.util.Collection.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._equals20649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._equals20649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20650;
		 int java.util.Collection.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Queue_._hashCode20650);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._hashCode20650);
		}
		internal static global::MonoJavaBridge.MethodId _clear20651;
		 void java.util.Collection.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Queue_._clear20651);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._clear20651);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty20652;
		 bool java.util.Collection.isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._isEmpty20652);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._isEmpty20652);
		}
		internal static global::MonoJavaBridge.MethodId _contains20653;
		 bool java.util.Collection.contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._contains20653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._contains20653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll20654;
		 bool java.util.Collection.addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._addAll20654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._addAll20654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size20655;
		 int java.util.Collection.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Queue_._size20655);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._size20655);
		}
		internal static global::MonoJavaBridge.MethodId _toArray20656;
		 global::java.lang.Object[] java.util.Collection.toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Queue_._toArray20656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._toArray20656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray20657;
		 global::java.lang.Object[] java.util.Collection.toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Queue_._toArray20657)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._toArray20657)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator20658;
		 global::java.util.Iterator java.util.Collection.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Queue_._iterator20658)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._iterator20658)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove20659;
		 bool java.util.Collection.remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._remove20659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._remove20659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll20660;
		 bool java.util.Collection.containsAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._containsAll20660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._containsAll20660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll20661;
		 bool java.util.Collection.removeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._removeAll20661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._removeAll20661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll20662;
		 bool java.util.Collection.retainAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._retainAll20662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._retainAll20662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _iterator20663;
		 global::java.util.Iterator java.lang.Iterable.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Queue_._iterator20663)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._iterator20663)) as java.util.Iterator;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Queue_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Queue"));
			global::java.util.Queue_._add20642 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.Queue_._remove20643 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "remove", "()Ljava/lang/Object;");
			global::java.util.Queue_._poll20644 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "poll", "()Ljava/lang/Object;");
			global::java.util.Queue_._peek20645 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "peek", "()Ljava/lang/Object;");
			global::java.util.Queue_._element20646 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "element", "()Ljava/lang/Object;");
			global::java.util.Queue_._offer20647 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "offer", "(Ljava/lang/Object;)Z");
			global::java.util.Queue_._add20648 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.Queue_._equals20649 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Queue_._hashCode20650 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "hashCode", "()I");
			global::java.util.Queue_._clear20651 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "clear", "()V");
			global::java.util.Queue_._isEmpty20652 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "isEmpty", "()Z");
			global::java.util.Queue_._contains20653 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.Queue_._addAll20654 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.Queue_._size20655 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "size", "()I");
			global::java.util.Queue_._toArray20656 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.Queue_._toArray20657 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.Queue_._iterator20658 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.Queue_._remove20659 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.Queue_._containsAll20660 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.Queue_._removeAll20661 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.Queue_._retainAll20662 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.Queue_._iterator20663 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "iterator", "()Ljava/util/Iterator;");
		}
	}
}
