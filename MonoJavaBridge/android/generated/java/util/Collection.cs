namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.Collection_))]
	public partial interface Collection : java.lang.Iterable
	{
		bool add(java.lang.Object arg0);
		bool equals(java.lang.Object arg0);
		int hashCode();
		void clear();
		bool isEmpty();
		bool contains(java.lang.Object arg0);
		bool addAll(java.util.Collection arg0);
		int size();
		global::java.lang.Object[] toArray(java.lang.Object[] arg0);
		global::java.lang.Object[] toArray();
		global::java.util.Iterator iterator();
		bool remove(java.lang.Object arg0);
		bool containsAll(java.util.Collection arg0);
		bool removeAll(java.util.Collection arg0);
		bool retainAll(java.util.Collection arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.Collection))]
	internal sealed partial class Collection_ : java.lang.Object, Collection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Collection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add26006;
		bool java.util.Collection.add(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Collection_.staticClass, "add", "(Ljava/lang/Object;)Z", ref global::java.util.Collection_._add26006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals26007;
		bool java.util.Collection.equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Collection_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.Collection_._equals26007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26008;
		int java.util.Collection.hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Collection_.staticClass, "hashCode", "()I", ref global::java.util.Collection_._hashCode26008);
		}
		internal static global::MonoJavaBridge.MethodId _clear26009;
		void java.util.Collection.clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Collection_.staticClass, "clear", "()V", ref global::java.util.Collection_._clear26009);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26010;
		bool java.util.Collection.isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Collection_.staticClass, "isEmpty", "()Z", ref global::java.util.Collection_._isEmpty26010);
		}
		internal static global::MonoJavaBridge.MethodId _contains26011;
		bool java.util.Collection.contains(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Collection_.staticClass, "contains", "(Ljava/lang/Object;)Z", ref global::java.util.Collection_._contains26011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26012;
		bool java.util.Collection.addAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Collection_.staticClass, "addAll", "(Ljava/util/Collection;)Z", ref global::java.util.Collection_._addAll26012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size26013;
		int java.util.Collection.size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Collection_.staticClass, "size", "()I", ref global::java.util.Collection_._size26013);
		}
		internal static global::MonoJavaBridge.MethodId _toArray26014;
		global::java.lang.Object[] java.util.Collection.toArray(java.lang.Object[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.Collection_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", ref global::java.util.Collection_._toArray26014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray26015;
		global::java.lang.Object[] java.util.Collection.toArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.Collection_.staticClass, "toArray", "()[Ljava/lang/Object;", ref global::java.util.Collection_._toArray26015) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator26016;
		global::java.util.Iterator java.util.Collection.iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.Collection_.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.util.Collection_._iterator26016) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove26017;
		bool java.util.Collection.remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Collection_.staticClass, "remove", "(Ljava/lang/Object;)Z", ref global::java.util.Collection_._remove26017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll26018;
		bool java.util.Collection.containsAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Collection_.staticClass, "containsAll", "(Ljava/util/Collection;)Z", ref global::java.util.Collection_._containsAll26018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll26019;
		bool java.util.Collection.removeAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Collection_.staticClass, "removeAll", "(Ljava/util/Collection;)Z", ref global::java.util.Collection_._removeAll26019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll26020;
		bool java.util.Collection.retainAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Collection_.staticClass, "retainAll", "(Ljava/util/Collection;)Z", ref global::java.util.Collection_._retainAll26020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(((global::java.lang.Iterable)this).iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator26021;
		global::java.util.Iterator java.lang.Iterable.iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.Collection_.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.util.Collection_._iterator26021) as java.util.Iterator;
		}
		static Collection_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Collection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Collection"));
		}
		internal static void InitJNI()
		{
		}
	}
}
