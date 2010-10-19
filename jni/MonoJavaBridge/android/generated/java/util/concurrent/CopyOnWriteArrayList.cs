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
		internal static global::MonoJavaBridge.MethodId _add21216;
		public virtual bool add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._add21216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._add21216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _add21217;
		public virtual void add(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._add21217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._add21217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _get21218;
		public virtual global::java.lang.Object get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._get21218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._get21218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals21219;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._equals21219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._equals21219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString21220;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._toString21220)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._toString21220)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode21221;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._hashCode21221);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._hashCode21221);
		}
		internal static global::MonoJavaBridge.MethodId _clone21222;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._clone21222)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._clone21222)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _indexOf21223;
		public virtual int indexOf(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._indexOf21223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._indexOf21223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf21224;
		public virtual int indexOf(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._indexOf21224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._indexOf21224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clear21225;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._clear21225);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._clear21225);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty21226;
		public virtual bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._isEmpty21226);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._isEmpty21226);
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf21227;
		public virtual int lastIndexOf(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._lastIndexOf21227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._lastIndexOf21227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf21228;
		public virtual int lastIndexOf(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._lastIndexOf21228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._lastIndexOf21228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _contains21229;
		public virtual bool contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._contains21229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._contains21229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll21230;
		public virtual bool addAll(int arg0, java.util.Collection arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._addAll21230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._addAll21230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addAll21231;
		public virtual bool addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._addAll21231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._addAll21231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size21232;
		public virtual int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._size21232);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._size21232);
		}
		internal static global::MonoJavaBridge.MethodId _toArray21233;
		public virtual global::java.lang.Object[] toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._toArray21233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._toArray21233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray21234;
		public virtual global::java.lang.Object[] toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._toArray21234)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._toArray21234)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator21235;
		public virtual global::java.util.Iterator iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._iterator21235)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._iterator21235)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove21236;
		public virtual global::java.lang.Object remove(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._remove21236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._remove21236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove21237;
		public virtual bool remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._remove21237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._remove21237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _set21238;
		public virtual global::java.lang.Object set(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._set21238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._set21238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _containsAll21239;
		public virtual bool containsAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._containsAll21239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._containsAll21239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll21240;
		public virtual bool removeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._removeAll21240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._removeAll21240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll21241;
		public virtual bool retainAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._retainAll21241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._retainAll21241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _subList21242;
		public virtual global::java.util.List subList(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._subList21242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._subList21242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _listIterator21243;
		public virtual global::java.util.ListIterator listIterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._listIterator21243)) as java.util.ListIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._listIterator21243)) as java.util.ListIterator;
		}
		internal static global::MonoJavaBridge.MethodId _listIterator21244;
		public virtual global::java.util.ListIterator listIterator(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._listIterator21244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ListIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._listIterator21244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ListIterator;
		}
		internal static global::MonoJavaBridge.MethodId _addIfAbsent21245;
		public virtual bool addIfAbsent(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._addIfAbsent21245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._addIfAbsent21245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAllAbsent21246;
		public virtual int addAllAbsent(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList._addAllAbsent21246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._addAllAbsent21246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _CopyOnWriteArrayList21247;
		public CopyOnWriteArrayList(java.lang.Object[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._CopyOnWriteArrayList21247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CopyOnWriteArrayList21248;
		public CopyOnWriteArrayList()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._CopyOnWriteArrayList21248);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CopyOnWriteArrayList21249;
		public CopyOnWriteArrayList(java.util.Collection arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._CopyOnWriteArrayList21249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.CopyOnWriteArrayList.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/CopyOnWriteArrayList"));
			global::java.util.concurrent.CopyOnWriteArrayList._add21216 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.CopyOnWriteArrayList._add21217 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "add", "(ILjava/lang/Object;)V");
			global::java.util.concurrent.CopyOnWriteArrayList._get21218 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "get", "(I)Ljava/lang/Object;");
			global::java.util.concurrent.CopyOnWriteArrayList._equals21219 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.CopyOnWriteArrayList._toString21220 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.CopyOnWriteArrayList._hashCode21221 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "hashCode", "()I");
			global::java.util.concurrent.CopyOnWriteArrayList._clone21222 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.concurrent.CopyOnWriteArrayList._indexOf21223 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "indexOf", "(Ljava/lang/Object;)I");
			global::java.util.concurrent.CopyOnWriteArrayList._indexOf21224 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "indexOf", "(Ljava/lang/Object;I)I");
			global::java.util.concurrent.CopyOnWriteArrayList._clear21225 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "clear", "()V");
			global::java.util.concurrent.CopyOnWriteArrayList._isEmpty21226 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "isEmpty", "()Z");
			global::java.util.concurrent.CopyOnWriteArrayList._lastIndexOf21227 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "lastIndexOf", "(Ljava/lang/Object;I)I");
			global::java.util.concurrent.CopyOnWriteArrayList._lastIndexOf21228 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "lastIndexOf", "(Ljava/lang/Object;)I");
			global::java.util.concurrent.CopyOnWriteArrayList._contains21229 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.CopyOnWriteArrayList._addAll21230 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "addAll", "(ILjava/util/Collection;)Z");
			global::java.util.concurrent.CopyOnWriteArrayList._addAll21231 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.CopyOnWriteArrayList._size21232 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "size", "()I");
			global::java.util.concurrent.CopyOnWriteArrayList._toArray21233 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.concurrent.CopyOnWriteArrayList._toArray21234 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.concurrent.CopyOnWriteArrayList._iterator21235 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.concurrent.CopyOnWriteArrayList._remove21236 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "remove", "(I)Ljava/lang/Object;");
			global::java.util.concurrent.CopyOnWriteArrayList._remove21237 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.CopyOnWriteArrayList._set21238 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "set", "(ILjava/lang/Object;)Ljava/lang/Object;");
			global::java.util.concurrent.CopyOnWriteArrayList._containsAll21239 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.CopyOnWriteArrayList._removeAll21240 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.CopyOnWriteArrayList._retainAll21241 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.CopyOnWriteArrayList._subList21242 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "subList", "(II)Ljava/util/List;");
			global::java.util.concurrent.CopyOnWriteArrayList._listIterator21243 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "listIterator", "()Ljava/util/ListIterator;");
			global::java.util.concurrent.CopyOnWriteArrayList._listIterator21244 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "listIterator", "(I)Ljava/util/ListIterator;");
			global::java.util.concurrent.CopyOnWriteArrayList._addIfAbsent21245 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "addIfAbsent", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.CopyOnWriteArrayList._addAllAbsent21246 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "addAllAbsent", "(Ljava/util/Collection;)I");
			global::java.util.concurrent.CopyOnWriteArrayList._CopyOnWriteArrayList21247 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "<init>", "([Ljava/lang/Object;)V");
			global::java.util.concurrent.CopyOnWriteArrayList._CopyOnWriteArrayList21248 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "<init>", "()V");
			global::java.util.concurrent.CopyOnWriteArrayList._CopyOnWriteArrayList21249 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "<init>", "(Ljava/util/Collection;)V");
		}
	}
}
