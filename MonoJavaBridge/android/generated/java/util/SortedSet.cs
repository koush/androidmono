namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.SortedSet_))]
	public partial interface SortedSet : Set
	{
		global::java.lang.Object last();
		global::java.lang.Object first();
		global::java.util.Comparator comparator();
		global::java.util.SortedSet subSet(java.lang.Object arg0, java.lang.Object arg1);
		global::java.util.SortedSet headSet(java.lang.Object arg0);
		global::java.util.SortedSet tailSet(java.lang.Object arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.SortedSet))]
	internal sealed partial class SortedSet_ : java.lang.Object, SortedSet
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SortedSet_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.Object java.util.SortedSet.last()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.SortedSet_.staticClass, "last", "()Ljava/lang/Object;", ref global::java.util.SortedSet_._m0) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.Object java.util.SortedSet.first()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.SortedSet_.staticClass, "first", "()Ljava/lang/Object;", ref global::java.util.SortedSet_._m1) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.util.Comparator java.util.SortedSet.comparator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Comparator>(this, global::java.util.SortedSet_.staticClass, "comparator", "()Ljava/util/Comparator;", ref global::java.util.SortedSet_._m2) as java.util.Comparator;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.util.SortedSet java.util.SortedSet.subSet(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.SortedSet>(this, global::java.util.SortedSet_.staticClass, "subSet", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedSet;", ref global::java.util.SortedSet_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.SortedSet;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::java.util.SortedSet java.util.SortedSet.headSet(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.SortedSet>(this, global::java.util.SortedSet_.staticClass, "headSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;", ref global::java.util.SortedSet_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.SortedSet;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		global::java.util.SortedSet java.util.SortedSet.tailSet(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.SortedSet>(this, global::java.util.SortedSet_.staticClass, "tailSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;", ref global::java.util.SortedSet_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.SortedSet;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		bool java.util.Set.add(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.SortedSet_.staticClass, "add", "(Ljava/lang/Object;)Z", ref global::java.util.SortedSet_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		bool java.util.Set.equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.SortedSet_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.SortedSet_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		int java.util.Set.hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.SortedSet_.staticClass, "hashCode", "()I", ref global::java.util.SortedSet_._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		void java.util.Set.clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.SortedSet_.staticClass, "clear", "()V", ref global::java.util.SortedSet_._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		bool java.util.Set.isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.SortedSet_.staticClass, "isEmpty", "()Z", ref global::java.util.SortedSet_._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		bool java.util.Set.contains(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.SortedSet_.staticClass, "contains", "(Ljava/lang/Object;)Z", ref global::java.util.SortedSet_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		bool java.util.Set.addAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.SortedSet_.staticClass, "addAll", "(Ljava/util/Collection;)Z", ref global::java.util.SortedSet_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		int java.util.Set.size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.SortedSet_.staticClass, "size", "()I", ref global::java.util.SortedSet_._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		global::java.lang.Object[] java.util.Set.toArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.SortedSet_.staticClass, "toArray", "()[Ljava/lang/Object;", ref global::java.util.SortedSet_._m14) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m15;
		global::java.lang.Object[] java.util.Set.toArray(java.lang.Object[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.SortedSet_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", ref global::java.util.SortedSet_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m16;
		global::java.util.Iterator java.util.Set.iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.SortedSet_.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.util.SortedSet_._m16) as java.util.Iterator;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		bool java.util.Set.remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.SortedSet_.staticClass, "remove", "(Ljava/lang/Object;)Z", ref global::java.util.SortedSet_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		bool java.util.Set.containsAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.SortedSet_.staticClass, "containsAll", "(Ljava/util/Collection;)Z", ref global::java.util.SortedSet_._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		bool java.util.Set.removeAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.SortedSet_.staticClass, "removeAll", "(Ljava/util/Collection;)Z", ref global::java.util.SortedSet_._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		bool java.util.Set.retainAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.SortedSet_.staticClass, "retainAll", "(Ljava/util/Collection;)Z", ref global::java.util.SortedSet_._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		bool java.util.Collection.add(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.SortedSet_.staticClass, "add", "(Ljava/lang/Object;)Z", ref global::java.util.SortedSet_._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		bool java.util.Collection.equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.SortedSet_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.SortedSet_._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		int java.util.Collection.hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.SortedSet_.staticClass, "hashCode", "()I", ref global::java.util.SortedSet_._m23);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		void java.util.Collection.clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.SortedSet_.staticClass, "clear", "()V", ref global::java.util.SortedSet_._m24);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		bool java.util.Collection.isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.SortedSet_.staticClass, "isEmpty", "()Z", ref global::java.util.SortedSet_._m25);
		}
		private static global::MonoJavaBridge.MethodId _m26;
		bool java.util.Collection.contains(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.SortedSet_.staticClass, "contains", "(Ljava/lang/Object;)Z", ref global::java.util.SortedSet_._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		bool java.util.Collection.addAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.SortedSet_.staticClass, "addAll", "(Ljava/util/Collection;)Z", ref global::java.util.SortedSet_._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		int java.util.Collection.size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.SortedSet_.staticClass, "size", "()I", ref global::java.util.SortedSet_._m28);
		}
		private static global::MonoJavaBridge.MethodId _m29;
		global::java.lang.Object[] java.util.Collection.toArray(java.lang.Object[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.SortedSet_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", ref global::java.util.SortedSet_._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m30;
		global::java.lang.Object[] java.util.Collection.toArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.SortedSet_.staticClass, "toArray", "()[Ljava/lang/Object;", ref global::java.util.SortedSet_._m30) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m31;
		global::java.util.Iterator java.util.Collection.iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.SortedSet_.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.util.SortedSet_._m31) as java.util.Iterator;
		}
		private static global::MonoJavaBridge.MethodId _m32;
		bool java.util.Collection.remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.SortedSet_.staticClass, "remove", "(Ljava/lang/Object;)Z", ref global::java.util.SortedSet_._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		bool java.util.Collection.containsAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.SortedSet_.staticClass, "containsAll", "(Ljava/util/Collection;)Z", ref global::java.util.SortedSet_._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		bool java.util.Collection.removeAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.SortedSet_.staticClass, "removeAll", "(Ljava/util/Collection;)Z", ref global::java.util.SortedSet_._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		bool java.util.Collection.retainAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.SortedSet_.staticClass, "retainAll", "(Ljava/util/Collection;)Z", ref global::java.util.SortedSet_._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(((global::java.lang.Iterable)this).iterator());
		}
		private static global::MonoJavaBridge.MethodId _m36;
		global::java.util.Iterator java.lang.Iterable.iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.SortedSet_.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.util.SortedSet_._m36) as java.util.Iterator;
		}
		static SortedSet_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.SortedSet_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/SortedSet"));
		}
	}
}
