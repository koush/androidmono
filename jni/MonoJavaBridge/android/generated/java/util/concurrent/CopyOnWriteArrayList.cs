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
		internal static global::MonoJavaBridge.MethodId _add27164;
		public virtual bool add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._add27164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._add27164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _add27165;
		public virtual void add(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._add27165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._add27165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _get27166;
		public virtual global::java.lang.Object get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._get27166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._get27166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals27167;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._equals27167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._equals27167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString27168;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._toString27168)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._toString27168)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode27169;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._hashCode27169);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._hashCode27169);
		}
		internal static global::MonoJavaBridge.MethodId _clone27170;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._clone27170)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._clone27170)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _indexOf27171;
		public virtual int indexOf(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._indexOf27171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._indexOf27171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf27172;
		public virtual int indexOf(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._indexOf27172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._indexOf27172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clear27173;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._clear27173);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._clear27173);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty27174;
		public virtual bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._isEmpty27174);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._isEmpty27174);
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf27175;
		public virtual int lastIndexOf(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._lastIndexOf27175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._lastIndexOf27175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf27176;
		public virtual int lastIndexOf(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._lastIndexOf27176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._lastIndexOf27176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _contains27177;
		public virtual bool contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._contains27177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._contains27177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll27178;
		public virtual bool addAll(int arg0, java.util.Collection arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._addAll27178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._addAll27178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addAll27179;
		public virtual bool addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._addAll27179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._addAll27179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size27180;
		public virtual int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._size27180);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._size27180);
		}
		internal static global::MonoJavaBridge.MethodId _toArray27181;
		public virtual global::java.lang.Object[] toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._toArray27181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._toArray27181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray27182;
		public virtual global::java.lang.Object[] toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._toArray27182)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._toArray27182)) as java.lang.Object[];
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator27183;
		public virtual global::java.util.Iterator iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._iterator27183)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._iterator27183)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove27184;
		public virtual global::java.lang.Object remove(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._remove27184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._remove27184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove27185;
		public virtual bool remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._remove27185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._remove27185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _set27186;
		public virtual global::java.lang.Object set(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._set27186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._set27186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _containsAll27187;
		public virtual bool containsAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._containsAll27187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._containsAll27187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll27188;
		public virtual bool removeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._removeAll27188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._removeAll27188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll27189;
		public virtual bool retainAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._retainAll27189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._retainAll27189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _subList27190;
		public virtual global::java.util.List subList(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._subList27190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._subList27190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _listIterator27191;
		public virtual global::java.util.ListIterator listIterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._listIterator27191)) as java.util.ListIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._listIterator27191)) as java.util.ListIterator;
		}
		internal static global::MonoJavaBridge.MethodId _listIterator27192;
		public virtual global::java.util.ListIterator listIterator(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._listIterator27192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ListIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._listIterator27192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ListIterator;
		}
		internal static global::MonoJavaBridge.MethodId _addIfAbsent27193;
		public virtual bool addIfAbsent(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._addIfAbsent27193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._addIfAbsent27193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAllAbsent27194;
		public virtual int addAllAbsent(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._addAllAbsent27194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._addAllAbsent27194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _CopyOnWriteArrayList27195;
		public CopyOnWriteArrayList(java.lang.Object[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._CopyOnWriteArrayList27195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CopyOnWriteArrayList27196;
		public CopyOnWriteArrayList()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._CopyOnWriteArrayList27196);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CopyOnWriteArrayList27197;
		public CopyOnWriteArrayList(java.util.Collection arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._CopyOnWriteArrayList27197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.CopyOnWriteArrayList.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/CopyOnWriteArrayList"));
			global::java.util.concurrent.CopyOnWriteArrayList._add27164 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.CopyOnWriteArrayList._add27165 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "add", "(ILjava/lang/Object;)V");
			global::java.util.concurrent.CopyOnWriteArrayList._get27166 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "get", "(I)Ljava/lang/Object;");
			global::java.util.concurrent.CopyOnWriteArrayList._equals27167 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.CopyOnWriteArrayList._toString27168 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.CopyOnWriteArrayList._hashCode27169 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "hashCode", "()I");
			global::java.util.concurrent.CopyOnWriteArrayList._clone27170 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.concurrent.CopyOnWriteArrayList._indexOf27171 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "indexOf", "(Ljava/lang/Object;)I");
			global::java.util.concurrent.CopyOnWriteArrayList._indexOf27172 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "indexOf", "(Ljava/lang/Object;I)I");
			global::java.util.concurrent.CopyOnWriteArrayList._clear27173 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "clear", "()V");
			global::java.util.concurrent.CopyOnWriteArrayList._isEmpty27174 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "isEmpty", "()Z");
			global::java.util.concurrent.CopyOnWriteArrayList._lastIndexOf27175 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "lastIndexOf", "(Ljava/lang/Object;I)I");
			global::java.util.concurrent.CopyOnWriteArrayList._lastIndexOf27176 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "lastIndexOf", "(Ljava/lang/Object;)I");
			global::java.util.concurrent.CopyOnWriteArrayList._contains27177 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.CopyOnWriteArrayList._addAll27178 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "addAll", "(ILjava/util/Collection;)Z");
			global::java.util.concurrent.CopyOnWriteArrayList._addAll27179 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.CopyOnWriteArrayList._size27180 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "size", "()I");
			global::java.util.concurrent.CopyOnWriteArrayList._toArray27181 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.concurrent.CopyOnWriteArrayList._toArray27182 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.concurrent.CopyOnWriteArrayList._iterator27183 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.concurrent.CopyOnWriteArrayList._remove27184 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "remove", "(I)Ljava/lang/Object;");
			global::java.util.concurrent.CopyOnWriteArrayList._remove27185 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.CopyOnWriteArrayList._set27186 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "set", "(ILjava/lang/Object;)Ljava/lang/Object;");
			global::java.util.concurrent.CopyOnWriteArrayList._containsAll27187 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.CopyOnWriteArrayList._removeAll27188 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.CopyOnWriteArrayList._retainAll27189 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.CopyOnWriteArrayList._subList27190 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "subList", "(II)Ljava/util/List;");
			global::java.util.concurrent.CopyOnWriteArrayList._listIterator27191 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "listIterator", "()Ljava/util/ListIterator;");
			global::java.util.concurrent.CopyOnWriteArrayList._listIterator27192 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "listIterator", "(I)Ljava/util/ListIterator;");
			global::java.util.concurrent.CopyOnWriteArrayList._addIfAbsent27193 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "addIfAbsent", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.CopyOnWriteArrayList._addAllAbsent27194 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "addAllAbsent", "(Ljava/util/Collection;)I");
			global::java.util.concurrent.CopyOnWriteArrayList._CopyOnWriteArrayList27195 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "<init>", "([Ljava/lang/Object;)V");
			global::java.util.concurrent.CopyOnWriteArrayList._CopyOnWriteArrayList27196 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "<init>", "()V");
			global::java.util.concurrent.CopyOnWriteArrayList._CopyOnWriteArrayList27197 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "<init>", "(Ljava/util/Collection;)V");
		}
	}
}
