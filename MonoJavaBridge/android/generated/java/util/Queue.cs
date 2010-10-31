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
		private static global::MonoJavaBridge.MethodId _m0;
		bool java.util.Queue.add(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Queue_.staticClass, "add", "(Ljava/lang/Object;)Z", ref global::java.util.Queue_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.Object java.util.Queue.remove()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Queue_.staticClass, "remove", "()Ljava/lang/Object;", ref global::java.util.Queue_._m1) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.lang.Object java.util.Queue.poll()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Queue_.staticClass, "poll", "()Ljava/lang/Object;", ref global::java.util.Queue_._m2) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.lang.Object java.util.Queue.peek()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Queue_.staticClass, "peek", "()Ljava/lang/Object;", ref global::java.util.Queue_._m3) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::java.lang.Object java.util.Queue.element()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Queue_.staticClass, "element", "()Ljava/lang/Object;", ref global::java.util.Queue_._m4) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		bool java.util.Queue.offer(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Queue_.staticClass, "offer", "(Ljava/lang/Object;)Z", ref global::java.util.Queue_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		bool java.util.Collection.add(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Queue_.staticClass, "add", "(Ljava/lang/Object;)Z", ref global::java.util.Queue_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		bool java.util.Collection.equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Queue_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.Queue_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		int java.util.Collection.hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Queue_.staticClass, "hashCode", "()I", ref global::java.util.Queue_._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		void java.util.Collection.clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Queue_.staticClass, "clear", "()V", ref global::java.util.Queue_._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		bool java.util.Collection.isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Queue_.staticClass, "isEmpty", "()Z", ref global::java.util.Queue_._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		bool java.util.Collection.contains(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Queue_.staticClass, "contains", "(Ljava/lang/Object;)Z", ref global::java.util.Queue_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		bool java.util.Collection.addAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Queue_.staticClass, "addAll", "(Ljava/util/Collection;)Z", ref global::java.util.Queue_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		int java.util.Collection.size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Queue_.staticClass, "size", "()I", ref global::java.util.Queue_._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		global::java.lang.Object[] java.util.Collection.toArray(java.lang.Object[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.Queue_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", ref global::java.util.Queue_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m15;
		global::java.lang.Object[] java.util.Collection.toArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.Queue_.staticClass, "toArray", "()[Ljava/lang/Object;", ref global::java.util.Queue_._m15) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m16;
		global::java.util.Iterator java.util.Collection.iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.Queue_.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.util.Queue_._m16) as java.util.Iterator;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		bool java.util.Collection.remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Queue_.staticClass, "remove", "(Ljava/lang/Object;)Z", ref global::java.util.Queue_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		bool java.util.Collection.containsAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Queue_.staticClass, "containsAll", "(Ljava/util/Collection;)Z", ref global::java.util.Queue_._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		bool java.util.Collection.removeAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Queue_.staticClass, "removeAll", "(Ljava/util/Collection;)Z", ref global::java.util.Queue_._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		bool java.util.Collection.retainAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Queue_.staticClass, "retainAll", "(Ljava/util/Collection;)Z", ref global::java.util.Queue_._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(((global::java.lang.Iterable)this).iterator());
		}
		private static global::MonoJavaBridge.MethodId _m21;
		global::java.util.Iterator java.lang.Iterable.iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.Queue_.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.util.Queue_._m21) as java.util.Iterator;
		}
		static Queue_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Queue_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Queue"));
		}
	}
}
