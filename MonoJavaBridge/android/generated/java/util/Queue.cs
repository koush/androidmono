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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Queue_._add26586.native == global::System.IntPtr.Zero)
				global::java.util.Queue_._add26586 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "add", "(Ljava/lang/Object;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._add26586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove26587;
		global::java.lang.Object java.util.Queue.remove()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Queue_._remove26587.native == global::System.IntPtr.Zero)
				global::java.util.Queue_._remove26587 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "remove", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Queue_._remove26587)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _poll26588;
		global::java.lang.Object java.util.Queue.poll()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Queue_._poll26588.native == global::System.IntPtr.Zero)
				global::java.util.Queue_._poll26588 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "poll", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Queue_._poll26588)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peek26589;
		global::java.lang.Object java.util.Queue.peek()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Queue_._peek26589.native == global::System.IntPtr.Zero)
				global::java.util.Queue_._peek26589 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "peek", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Queue_._peek26589)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _element26590;
		global::java.lang.Object java.util.Queue.element()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Queue_._element26590.native == global::System.IntPtr.Zero)
				global::java.util.Queue_._element26590 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "element", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Queue_._element26590)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer26591;
		bool java.util.Queue.offer(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Queue_._offer26591.native == global::System.IntPtr.Zero)
				global::java.util.Queue_._offer26591 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "offer", "(Ljava/lang/Object;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._offer26591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _add26592;
		bool java.util.Collection.add(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Queue_._add26592.native == global::System.IntPtr.Zero)
				global::java.util.Queue_._add26592 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "add", "(Ljava/lang/Object;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._add26592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals26593;
		bool java.util.Collection.equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Queue_._equals26593.native == global::System.IntPtr.Zero)
				global::java.util.Queue_._equals26593 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._equals26593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26594;
		int java.util.Collection.hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Queue_._hashCode26594.native == global::System.IntPtr.Zero)
				global::java.util.Queue_._hashCode26594 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "hashCode", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::java.util.Queue_._hashCode26594);
		}
		internal static global::MonoJavaBridge.MethodId _clear26595;
		void java.util.Collection.clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Queue_._clear26595.native == global::System.IntPtr.Zero)
				global::java.util.Queue_._clear26595 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "clear", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.util.Queue_._clear26595);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26596;
		bool java.util.Collection.isEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Queue_._isEmpty26596.native == global::System.IntPtr.Zero)
				global::java.util.Queue_._isEmpty26596 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "isEmpty", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._isEmpty26596);
		}
		internal static global::MonoJavaBridge.MethodId _contains26597;
		bool java.util.Collection.contains(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Queue_._contains26597.native == global::System.IntPtr.Zero)
				global::java.util.Queue_._contains26597 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._contains26597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26598;
		bool java.util.Collection.addAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Queue_._addAll26598.native == global::System.IntPtr.Zero)
				global::java.util.Queue_._addAll26598 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._addAll26598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size26599;
		int java.util.Collection.size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Queue_._size26599.native == global::System.IntPtr.Zero)
				global::java.util.Queue_._size26599 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "size", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::java.util.Queue_._size26599);
		}
		internal static global::MonoJavaBridge.MethodId _toArray26600;
		global::java.lang.Object[] java.util.Collection.toArray(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Queue_._toArray26600.native == global::System.IntPtr.Zero)
				global::java.util.Queue_._toArray26600 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Queue_._toArray26600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray26601;
		global::java.lang.Object[] java.util.Collection.toArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Queue_._toArray26601.native == global::System.IntPtr.Zero)
				global::java.util.Queue_._toArray26601 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "toArray", "()[Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Queue_._toArray26601)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator26602;
		global::java.util.Iterator java.util.Collection.iterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Queue_._iterator26602.native == global::System.IntPtr.Zero)
				global::java.util.Queue_._iterator26602 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "iterator", "()Ljava/util/Iterator;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Queue_._iterator26602)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove26603;
		bool java.util.Collection.remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Queue_._remove26603.native == global::System.IntPtr.Zero)
				global::java.util.Queue_._remove26603 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._remove26603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll26604;
		bool java.util.Collection.containsAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Queue_._containsAll26604.native == global::System.IntPtr.Zero)
				global::java.util.Queue_._containsAll26604 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._containsAll26604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll26605;
		bool java.util.Collection.removeAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Queue_._removeAll26605.native == global::System.IntPtr.Zero)
				global::java.util.Queue_._removeAll26605 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._removeAll26605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll26606;
		bool java.util.Collection.retainAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Queue_._retainAll26606.native == global::System.IntPtr.Zero)
				global::java.util.Queue_._retainAll26606 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._retainAll26606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(((global::java.lang.Iterable)this).iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator26607;
		global::java.util.Iterator java.lang.Iterable.iterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Queue_._iterator26607.native == global::System.IntPtr.Zero)
				global::java.util.Queue_._iterator26607 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "iterator", "()Ljava/util/Iterator;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Queue_._iterator26607)) as java.util.Iterator;
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
