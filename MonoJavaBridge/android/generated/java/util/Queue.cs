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
	internal sealed partial class Queue_ : java.lang.Object, Queue
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Queue_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add26586;
		bool java.util.Queue.add(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Queue_.staticClass, "add", "(Ljava/lang/Object;)Z", ref global::java.util.Queue_._add26586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove26587;
		global::java.lang.Object java.util.Queue.remove()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Queue_.staticClass, "remove", "()Ljava/lang/Object;", ref global::java.util.Queue_._remove26587) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _poll26588;
		global::java.lang.Object java.util.Queue.poll()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Queue_.staticClass, "poll", "()Ljava/lang/Object;", ref global::java.util.Queue_._poll26588) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peek26589;
		global::java.lang.Object java.util.Queue.peek()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Queue_.staticClass, "peek", "()Ljava/lang/Object;", ref global::java.util.Queue_._peek26589) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _element26590;
		global::java.lang.Object java.util.Queue.element()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Queue_.staticClass, "element", "()Ljava/lang/Object;", ref global::java.util.Queue_._element26590) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer26591;
		bool java.util.Queue.offer(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Queue_.staticClass, "offer", "(Ljava/lang/Object;)Z", ref global::java.util.Queue_._offer26591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _add26592;
		bool java.util.Collection.add(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Queue_.staticClass, "add", "(Ljava/lang/Object;)Z", ref global::java.util.Queue_._add26592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals26593;
		bool java.util.Collection.equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Queue_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.Queue_._equals26593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26594;
		int java.util.Collection.hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Queue_.staticClass, "hashCode", "()I", ref global::java.util.Queue_._hashCode26594);
		}
		internal static global::MonoJavaBridge.MethodId _clear26595;
		void java.util.Collection.clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Queue_.staticClass, "clear", "()V", ref global::java.util.Queue_._clear26595);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26596;
		bool java.util.Collection.isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Queue_.staticClass, "isEmpty", "()Z", ref global::java.util.Queue_._isEmpty26596);
		}
		internal static global::MonoJavaBridge.MethodId _contains26597;
		bool java.util.Collection.contains(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Queue_.staticClass, "contains", "(Ljava/lang/Object;)Z", ref global::java.util.Queue_._contains26597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26598;
		bool java.util.Collection.addAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Queue_.staticClass, "addAll", "(Ljava/util/Collection;)Z", ref global::java.util.Queue_._addAll26598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size26599;
		int java.util.Collection.size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Queue_.staticClass, "size", "()I", ref global::java.util.Queue_._size26599);
		}
		internal static global::MonoJavaBridge.MethodId _toArray26600;
		global::java.lang.Object[] java.util.Collection.toArray(java.lang.Object[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.Queue_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", ref global::java.util.Queue_._toArray26600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray26601;
		global::java.lang.Object[] java.util.Collection.toArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.Queue_.staticClass, "toArray", "()[Ljava/lang/Object;", ref global::java.util.Queue_._toArray26601) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator26602;
		global::java.util.Iterator java.util.Collection.iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.Queue_.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.util.Queue_._iterator26602) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove26603;
		bool java.util.Collection.remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Queue_.staticClass, "remove", "(Ljava/lang/Object;)Z", ref global::java.util.Queue_._remove26603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll26604;
		bool java.util.Collection.containsAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Queue_.staticClass, "containsAll", "(Ljava/util/Collection;)Z", ref global::java.util.Queue_._containsAll26604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll26605;
		bool java.util.Collection.removeAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Queue_.staticClass, "removeAll", "(Ljava/util/Collection;)Z", ref global::java.util.Queue_._removeAll26605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll26606;
		bool java.util.Collection.retainAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Queue_.staticClass, "retainAll", "(Ljava/util/Collection;)Z", ref global::java.util.Queue_._retainAll26606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(((global::java.lang.Iterable)this).iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator26607;
		global::java.util.Iterator java.lang.Iterable.iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.Queue_.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.util.Queue_._iterator26607) as java.util.Iterator;
		}
		static Queue_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Queue_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Queue"));
		}
		internal static void InitJNI()
		{
		}
	}
}
