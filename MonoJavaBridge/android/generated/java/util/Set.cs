namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.Set_))]
	public partial interface Set : Collection
	{
		bool add(java.lang.Object arg0);
		bool equals(java.lang.Object arg0);
		int hashCode();
		void clear();
		bool isEmpty();
		bool contains(java.lang.Object arg0);
		bool addAll(java.util.Collection arg0);
		int size();
		global::java.lang.Object[] toArray();
		global::java.lang.Object[] toArray(java.lang.Object[] arg0);
		global::java.util.Iterator iterator();
		bool remove(java.lang.Object arg0);
		bool containsAll(java.util.Collection arg0);
		bool removeAll(java.util.Collection arg0);
		bool retainAll(java.util.Collection arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.Set))]
	internal sealed partial class Set_ : java.lang.Object, Set
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Set_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		bool java.util.Set.add(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Set_.staticClass, "add", "(Ljava/lang/Object;)Z", ref global::java.util.Set_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		bool java.util.Set.equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Set_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.Set_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		int java.util.Set.hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Set_.staticClass, "hashCode", "()I", ref global::java.util.Set_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void java.util.Set.clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Set_.staticClass, "clear", "()V", ref global::java.util.Set_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		bool java.util.Set.isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Set_.staticClass, "isEmpty", "()Z", ref global::java.util.Set_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		bool java.util.Set.contains(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Set_.staticClass, "contains", "(Ljava/lang/Object;)Z", ref global::java.util.Set_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		bool java.util.Set.addAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Set_.staticClass, "addAll", "(Ljava/util/Collection;)Z", ref global::java.util.Set_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		int java.util.Set.size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Set_.staticClass, "size", "()I", ref global::java.util.Set_._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		global::java.lang.Object[] java.util.Set.toArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.Set_.staticClass, "toArray", "()[Ljava/lang/Object;", ref global::java.util.Set_._m8) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m9;
		global::java.lang.Object[] java.util.Set.toArray(java.lang.Object[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.Set_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", ref global::java.util.Set_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m10;
		global::java.util.Iterator java.util.Set.iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.Set_.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.util.Set_._m10) as java.util.Iterator;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		bool java.util.Set.remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Set_.staticClass, "remove", "(Ljava/lang/Object;)Z", ref global::java.util.Set_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		bool java.util.Set.containsAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Set_.staticClass, "containsAll", "(Ljava/util/Collection;)Z", ref global::java.util.Set_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		bool java.util.Set.removeAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Set_.staticClass, "removeAll", "(Ljava/util/Collection;)Z", ref global::java.util.Set_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		bool java.util.Set.retainAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Set_.staticClass, "retainAll", "(Ljava/util/Collection;)Z", ref global::java.util.Set_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		bool java.util.Collection.add(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Set_.staticClass, "add", "(Ljava/lang/Object;)Z", ref global::java.util.Set_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		bool java.util.Collection.equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Set_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.Set_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		int java.util.Collection.hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Set_.staticClass, "hashCode", "()I", ref global::java.util.Set_._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		void java.util.Collection.clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Set_.staticClass, "clear", "()V", ref global::java.util.Set_._m18);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		bool java.util.Collection.isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Set_.staticClass, "isEmpty", "()Z", ref global::java.util.Set_._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		bool java.util.Collection.contains(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Set_.staticClass, "contains", "(Ljava/lang/Object;)Z", ref global::java.util.Set_._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		bool java.util.Collection.addAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Set_.staticClass, "addAll", "(Ljava/util/Collection;)Z", ref global::java.util.Set_._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		int java.util.Collection.size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Set_.staticClass, "size", "()I", ref global::java.util.Set_._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		global::java.lang.Object[] java.util.Collection.toArray(java.lang.Object[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.Set_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", ref global::java.util.Set_._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m24;
		global::java.lang.Object[] java.util.Collection.toArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.Set_.staticClass, "toArray", "()[Ljava/lang/Object;", ref global::java.util.Set_._m24) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m25;
		global::java.util.Iterator java.util.Collection.iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.Set_.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.util.Set_._m25) as java.util.Iterator;
		}
		private static global::MonoJavaBridge.MethodId _m26;
		bool java.util.Collection.remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Set_.staticClass, "remove", "(Ljava/lang/Object;)Z", ref global::java.util.Set_._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		bool java.util.Collection.containsAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Set_.staticClass, "containsAll", "(Ljava/util/Collection;)Z", ref global::java.util.Set_._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		bool java.util.Collection.removeAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Set_.staticClass, "removeAll", "(Ljava/util/Collection;)Z", ref global::java.util.Set_._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		bool java.util.Collection.retainAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Set_.staticClass, "retainAll", "(Ljava/util/Collection;)Z", ref global::java.util.Set_._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(((global::java.lang.Iterable)this).iterator());
		}
		private static global::MonoJavaBridge.MethodId _m30;
		global::java.util.Iterator java.lang.Iterable.iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.Set_.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.util.Set_._m30) as java.util.Iterator;
		}
		static Set_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Set_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Set"));
		}
	}
}
