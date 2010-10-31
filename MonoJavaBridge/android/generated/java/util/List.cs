namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.List_))]
	public partial interface List : Collection
	{
		void add(int arg0, java.lang.Object arg1);
		bool add(java.lang.Object arg0);
		global::java.lang.Object get(int arg0);
		bool equals(java.lang.Object arg0);
		int hashCode();
		int indexOf(java.lang.Object arg0);
		void clear();
		bool isEmpty();
		int lastIndexOf(java.lang.Object arg0);
		bool contains(java.lang.Object arg0);
		bool addAll(java.util.Collection arg0);
		bool addAll(int arg0, java.util.Collection arg1);
		int size();
		global::java.lang.Object[] toArray(java.lang.Object[] arg0);
		global::java.lang.Object[] toArray();
		global::java.util.Iterator iterator();
		bool remove(java.lang.Object arg0);
		global::java.lang.Object remove(int arg0);
		global::java.lang.Object set(int arg0, java.lang.Object arg1);
		bool containsAll(java.util.Collection arg0);
		bool removeAll(java.util.Collection arg0);
		bool retainAll(java.util.Collection arg0);
		global::java.util.List subList(int arg0, int arg1);
		global::java.util.ListIterator listIterator();
		global::java.util.ListIterator listIterator(int arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.List))]
	internal sealed partial class List_ : java.lang.Object, List
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal List_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void java.util.List.add(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.List_.staticClass, "add", "(ILjava/lang/Object;)V", ref global::java.util.List_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		bool java.util.List.add(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.List_.staticClass, "add", "(Ljava/lang/Object;)Z", ref global::java.util.List_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.lang.Object java.util.List.get(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.List_.staticClass, "get", "(I)Ljava/lang/Object;", ref global::java.util.List_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		bool java.util.List.equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.List_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.List_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		int java.util.List.hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.List_.staticClass, "hashCode", "()I", ref global::java.util.List_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		int java.util.List.indexOf(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.List_.staticClass, "indexOf", "(Ljava/lang/Object;)I", ref global::java.util.List_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		void java.util.List.clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.List_.staticClass, "clear", "()V", ref global::java.util.List_._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		bool java.util.List.isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.List_.staticClass, "isEmpty", "()Z", ref global::java.util.List_._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		int java.util.List.lastIndexOf(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.List_.staticClass, "lastIndexOf", "(Ljava/lang/Object;)I", ref global::java.util.List_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		bool java.util.List.contains(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.List_.staticClass, "contains", "(Ljava/lang/Object;)Z", ref global::java.util.List_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		bool java.util.List.addAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.List_.staticClass, "addAll", "(Ljava/util/Collection;)Z", ref global::java.util.List_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		bool java.util.List.addAll(int arg0, java.util.Collection arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.List_.staticClass, "addAll", "(ILjava/util/Collection;)Z", ref global::java.util.List_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		int java.util.List.size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.List_.staticClass, "size", "()I", ref global::java.util.List_._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		global::java.lang.Object[] java.util.List.toArray(java.lang.Object[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.List_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", ref global::java.util.List_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m14;
		global::java.lang.Object[] java.util.List.toArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.List_.staticClass, "toArray", "()[Ljava/lang/Object;", ref global::java.util.List_._m14) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m15;
		global::java.util.Iterator java.util.List.iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.List_.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.util.List_._m15) as java.util.Iterator;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		bool java.util.List.remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.List_.staticClass, "remove", "(Ljava/lang/Object;)Z", ref global::java.util.List_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		global::java.lang.Object java.util.List.remove(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.List_.staticClass, "remove", "(I)Ljava/lang/Object;", ref global::java.util.List_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		global::java.lang.Object java.util.List.set(int arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.List_.staticClass, "set", "(ILjava/lang/Object;)Ljava/lang/Object;", ref global::java.util.List_._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		bool java.util.List.containsAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.List_.staticClass, "containsAll", "(Ljava/util/Collection;)Z", ref global::java.util.List_._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		bool java.util.List.removeAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.List_.staticClass, "removeAll", "(Ljava/util/Collection;)Z", ref global::java.util.List_._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		bool java.util.List.retainAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.List_.staticClass, "retainAll", "(Ljava/util/Collection;)Z", ref global::java.util.List_._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		global::java.util.List java.util.List.subList(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::java.util.List_.staticClass, "subList", "(II)Ljava/util/List;", ref global::java.util.List_._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		global::java.util.ListIterator java.util.List.listIterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.ListIterator>(this, global::java.util.List_.staticClass, "listIterator", "()Ljava/util/ListIterator;", ref global::java.util.List_._m23) as java.util.ListIterator;
		}
		private static global::MonoJavaBridge.MethodId _m24;
		global::java.util.ListIterator java.util.List.listIterator(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.ListIterator>(this, global::java.util.List_.staticClass, "listIterator", "(I)Ljava/util/ListIterator;", ref global::java.util.List_._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.ListIterator;
		}
		private static global::MonoJavaBridge.MethodId _m25;
		bool java.util.Collection.add(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.List_.staticClass, "add", "(Ljava/lang/Object;)Z", ref global::java.util.List_._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		bool java.util.Collection.equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.List_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.List_._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		int java.util.Collection.hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.List_.staticClass, "hashCode", "()I", ref global::java.util.List_._m27);
		}
		private static global::MonoJavaBridge.MethodId _m28;
		void java.util.Collection.clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.List_.staticClass, "clear", "()V", ref global::java.util.List_._m28);
		}
		private static global::MonoJavaBridge.MethodId _m29;
		bool java.util.Collection.isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.List_.staticClass, "isEmpty", "()Z", ref global::java.util.List_._m29);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		bool java.util.Collection.contains(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.List_.staticClass, "contains", "(Ljava/lang/Object;)Z", ref global::java.util.List_._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		bool java.util.Collection.addAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.List_.staticClass, "addAll", "(Ljava/util/Collection;)Z", ref global::java.util.List_._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		int java.util.Collection.size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.List_.staticClass, "size", "()I", ref global::java.util.List_._m32);
		}
		private static global::MonoJavaBridge.MethodId _m33;
		global::java.lang.Object[] java.util.Collection.toArray(java.lang.Object[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.List_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", ref global::java.util.List_._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m34;
		global::java.lang.Object[] java.util.Collection.toArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.List_.staticClass, "toArray", "()[Ljava/lang/Object;", ref global::java.util.List_._m34) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m35;
		global::java.util.Iterator java.util.Collection.iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.List_.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.util.List_._m35) as java.util.Iterator;
		}
		private static global::MonoJavaBridge.MethodId _m36;
		bool java.util.Collection.remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.List_.staticClass, "remove", "(Ljava/lang/Object;)Z", ref global::java.util.List_._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		bool java.util.Collection.containsAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.List_.staticClass, "containsAll", "(Ljava/util/Collection;)Z", ref global::java.util.List_._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m38;
		bool java.util.Collection.removeAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.List_.staticClass, "removeAll", "(Ljava/util/Collection;)Z", ref global::java.util.List_._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m39;
		bool java.util.Collection.retainAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.List_.staticClass, "retainAll", "(Ljava/util/Collection;)Z", ref global::java.util.List_._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(((global::java.lang.Iterable)this).iterator());
		}
		private static global::MonoJavaBridge.MethodId _m40;
		global::java.util.Iterator java.lang.Iterable.iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.List_.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.util.List_._m40) as java.util.Iterator;
		}
		static List_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.List_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/List"));
		}
	}
}
