namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CopyOnWriteArrayList : java.lang.Object, List, RandomAccess, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CopyOnWriteArrayList()
		{
			InitJNI();
		}
		protected CopyOnWriteArrayList(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add27046;
		public virtual bool add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._add27046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._add27046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _add27047;
		public virtual void add(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._add27047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._add27047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _get27048;
		public virtual global::java.lang.Object get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._get27048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._get27048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals27049;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._equals27049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._equals27049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString27050;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._toString27050)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._toString27050)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode27051;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._hashCode27051);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._hashCode27051);
		}
		internal static global::MonoJavaBridge.MethodId _clone27052;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._clone27052)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._clone27052)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _indexOf27053;
		public virtual int indexOf(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._indexOf27053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._indexOf27053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf27054;
		public virtual int indexOf(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._indexOf27054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._indexOf27054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clear27055;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._clear27055);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._clear27055);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty27056;
		public virtual bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._isEmpty27056);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._isEmpty27056);
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf27057;
		public virtual int lastIndexOf(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._lastIndexOf27057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._lastIndexOf27057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf27058;
		public virtual int lastIndexOf(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._lastIndexOf27058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._lastIndexOf27058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _contains27059;
		public virtual bool contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._contains27059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._contains27059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll27060;
		public virtual bool addAll(int arg0, java.util.Collection arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._addAll27060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._addAll27060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addAll27061;
		public virtual bool addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._addAll27061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._addAll27061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size27062;
		public virtual int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._size27062);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._size27062);
		}
		internal static global::MonoJavaBridge.MethodId _toArray27063;
		public virtual global::java.lang.Object[] toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._toArray27063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._toArray27063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray27064;
		public virtual global::java.lang.Object[] toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._toArray27064)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._toArray27064)) as java.lang.Object[];
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator27065;
		public virtual global::java.util.Iterator iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._iterator27065)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._iterator27065)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove27066;
		public virtual global::java.lang.Object remove(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._remove27066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._remove27066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove27067;
		public virtual bool remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._remove27067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._remove27067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _set27068;
		public virtual global::java.lang.Object set(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._set27068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._set27068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _containsAll27069;
		public virtual bool containsAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._containsAll27069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._containsAll27069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll27070;
		public virtual bool removeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._removeAll27070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._removeAll27070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll27071;
		public virtual bool retainAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._retainAll27071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._retainAll27071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _subList27072;
		public virtual global::java.util.List subList(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._subList27072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._subList27072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _listIterator27073;
		public virtual global::java.util.ListIterator listIterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._listIterator27073)) as java.util.ListIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._listIterator27073)) as java.util.ListIterator;
		}
		internal static global::MonoJavaBridge.MethodId _listIterator27074;
		public virtual global::java.util.ListIterator listIterator(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._listIterator27074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ListIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._listIterator27074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ListIterator;
		}
		internal static global::MonoJavaBridge.MethodId _addIfAbsent27075;
		public virtual bool addIfAbsent(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._addIfAbsent27075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._addIfAbsent27075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAllAbsent27076;
		public virtual int addAllAbsent(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._addAllAbsent27076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._addAllAbsent27076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _CopyOnWriteArrayList27077;
		public CopyOnWriteArrayList(java.lang.Object[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._CopyOnWriteArrayList27077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CopyOnWriteArrayList27078;
		public CopyOnWriteArrayList()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._CopyOnWriteArrayList27078);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CopyOnWriteArrayList27079;
		public CopyOnWriteArrayList(java.util.Collection arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._CopyOnWriteArrayList27079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.CopyOnWriteArrayList.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/CopyOnWriteArrayList"));
			global::java.util.concurrent.CopyOnWriteArrayList._add27046 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.CopyOnWriteArrayList._add27047 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "add", "(ILjava/lang/Object;)V");
			global::java.util.concurrent.CopyOnWriteArrayList._get27048 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "get", "(I)Ljava/lang/Object;");
			global::java.util.concurrent.CopyOnWriteArrayList._equals27049 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.CopyOnWriteArrayList._toString27050 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.CopyOnWriteArrayList._hashCode27051 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "hashCode", "()I");
			global::java.util.concurrent.CopyOnWriteArrayList._clone27052 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.concurrent.CopyOnWriteArrayList._indexOf27053 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "indexOf", "(Ljava/lang/Object;)I");
			global::java.util.concurrent.CopyOnWriteArrayList._indexOf27054 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "indexOf", "(Ljava/lang/Object;I)I");
			global::java.util.concurrent.CopyOnWriteArrayList._clear27055 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "clear", "()V");
			global::java.util.concurrent.CopyOnWriteArrayList._isEmpty27056 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "isEmpty", "()Z");
			global::java.util.concurrent.CopyOnWriteArrayList._lastIndexOf27057 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "lastIndexOf", "(Ljava/lang/Object;I)I");
			global::java.util.concurrent.CopyOnWriteArrayList._lastIndexOf27058 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "lastIndexOf", "(Ljava/lang/Object;)I");
			global::java.util.concurrent.CopyOnWriteArrayList._contains27059 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.CopyOnWriteArrayList._addAll27060 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "addAll", "(ILjava/util/Collection;)Z");
			global::java.util.concurrent.CopyOnWriteArrayList._addAll27061 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.CopyOnWriteArrayList._size27062 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "size", "()I");
			global::java.util.concurrent.CopyOnWriteArrayList._toArray27063 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.concurrent.CopyOnWriteArrayList._toArray27064 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.concurrent.CopyOnWriteArrayList._iterator27065 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.concurrent.CopyOnWriteArrayList._remove27066 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "remove", "(I)Ljava/lang/Object;");
			global::java.util.concurrent.CopyOnWriteArrayList._remove27067 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.CopyOnWriteArrayList._set27068 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "set", "(ILjava/lang/Object;)Ljava/lang/Object;");
			global::java.util.concurrent.CopyOnWriteArrayList._containsAll27069 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.CopyOnWriteArrayList._removeAll27070 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.CopyOnWriteArrayList._retainAll27071 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.CopyOnWriteArrayList._subList27072 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "subList", "(II)Ljava/util/List;");
			global::java.util.concurrent.CopyOnWriteArrayList._listIterator27073 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "listIterator", "()Ljava/util/ListIterator;");
			global::java.util.concurrent.CopyOnWriteArrayList._listIterator27074 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "listIterator", "(I)Ljava/util/ListIterator;");
			global::java.util.concurrent.CopyOnWriteArrayList._addIfAbsent27075 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "addIfAbsent", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.CopyOnWriteArrayList._addAllAbsent27076 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "addAllAbsent", "(Ljava/util/Collection;)I");
			global::java.util.concurrent.CopyOnWriteArrayList._CopyOnWriteArrayList27077 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "<init>", "([Ljava/lang/Object;)V");
			global::java.util.concurrent.CopyOnWriteArrayList._CopyOnWriteArrayList27078 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "<init>", "()V");
			global::java.util.concurrent.CopyOnWriteArrayList._CopyOnWriteArrayList27079 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "<init>", "(Ljava/util/Collection;)V");
		}
	}
}
