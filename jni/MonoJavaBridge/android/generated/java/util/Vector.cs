namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Vector : java.util.AbstractList, List, RandomAccess, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Vector()
		{
			InitJNI();
		}
		protected Vector(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add26962;
		public override void add(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Vector._add26962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._add26962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _add26963;
		public override bool add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Vector._add26963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._add26963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _get26964;
		public override global::java.lang.Object get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Vector._get26964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._get26964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals26965;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Vector._equals26965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._equals26965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString26966;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Vector._toString26966)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._toString26966)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26967;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Vector._hashCode26967);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._hashCode26967);
		}
		internal static global::MonoJavaBridge.MethodId _clone26968;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Vector._clone26968)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._clone26968)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _indexOf26969;
		public override int indexOf(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Vector._indexOf26969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._indexOf26969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf26970;
		public virtual int indexOf(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Vector._indexOf26970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._indexOf26970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clear26971;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Vector._clear26971);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._clear26971);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26972;
		public override bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Vector._isEmpty26972);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._isEmpty26972);
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf26973;
		public virtual int lastIndexOf(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Vector._lastIndexOf26973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._lastIndexOf26973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf26974;
		public override int lastIndexOf(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Vector._lastIndexOf26974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._lastIndexOf26974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _contains26975;
		public override bool contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Vector._contains26975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._contains26975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26976;
		public override bool addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Vector._addAll26976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._addAll26976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26977;
		public override bool addAll(int arg0, java.util.Collection arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Vector._addAll26977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._addAll26977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _size26978;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Vector._size26978);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._size26978);
		}
		internal static global::MonoJavaBridge.MethodId _toArray26979;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Vector._toArray26979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._toArray26979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray26980;
		public override global::java.lang.Object[] toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Vector._toArray26980)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._toArray26980)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _addElement26981;
		public virtual void addElement(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Vector._addElement26981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._addElement26981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _elementAt26982;
		public virtual global::java.lang.Object elementAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Vector._elementAt26982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._elementAt26982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove26983;
		public override global::java.lang.Object remove(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Vector._remove26983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._remove26983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove26984;
		public override bool remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Vector._remove26984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._remove26984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _elements26985;
		public virtual global::java.util.Enumeration elements() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Vector._elements26985)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._elements26985)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _set26986;
		public override global::java.lang.Object set(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Vector._set26986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._set26986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _copyInto26987;
		public virtual void copyInto(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Vector._copyInto26987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._copyInto26987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _trimToSize26988;
		public virtual void trimToSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Vector._trimToSize26988);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._trimToSize26988);
		}
		internal static global::MonoJavaBridge.MethodId _ensureCapacity26989;
		public virtual void ensureCapacity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Vector._ensureCapacity26989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._ensureCapacity26989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSize26990;
		public virtual void setSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Vector._setSize26990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._setSize26990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _capacity26991;
		public virtual int capacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Vector._capacity26991);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._capacity26991);
		}
		internal static global::MonoJavaBridge.MethodId _firstElement26992;
		public virtual global::java.lang.Object firstElement() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Vector._firstElement26992)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._firstElement26992)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _lastElement26993;
		public virtual global::java.lang.Object lastElement() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Vector._lastElement26993)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._lastElement26993)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setElementAt26994;
		public virtual void setElementAt(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Vector._setElementAt26994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._setElementAt26994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeElementAt26995;
		public virtual void removeElementAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Vector._removeElementAt26995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._removeElementAt26995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _insertElementAt26996;
		public virtual void insertElementAt(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Vector._insertElementAt26996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._insertElementAt26996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeElement26997;
		public virtual bool removeElement(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Vector._removeElement26997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._removeElement26997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAllElements26998;
		public virtual void removeAllElements() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Vector._removeAllElements26998);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._removeAllElements26998);
		}
		internal static global::MonoJavaBridge.MethodId _containsAll26999;
		public override bool containsAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Vector._containsAll26999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._containsAll26999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll27000;
		public override bool removeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Vector._removeAll27000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._removeAll27000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll27001;
		public override bool retainAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Vector._retainAll27001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._retainAll27001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _subList27002;
		public override global::java.util.List subList(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Vector._subList27002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._subList27002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _removeRange27003;
		protected override void removeRange(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Vector._removeRange27003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._removeRange27003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _Vector27004;
		public Vector(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Vector.staticClass, global::java.util.Vector._Vector27004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Vector27005;
		public Vector(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Vector.staticClass, global::java.util.Vector._Vector27005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Vector27006;
		public Vector()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Vector.staticClass, global::java.util.Vector._Vector27006);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Vector27007;
		public Vector(java.util.Collection arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Vector.staticClass, global::java.util.Vector._Vector27007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Vector.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Vector"));
			global::java.util.Vector._add26962 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "add", "(ILjava/lang/Object;)V");
			global::java.util.Vector._add26963 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.Vector._get26964 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "get", "(I)Ljava/lang/Object;");
			global::java.util.Vector._equals26965 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Vector._toString26966 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.Vector._hashCode26967 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "hashCode", "()I");
			global::java.util.Vector._clone26968 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.Vector._indexOf26969 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "indexOf", "(Ljava/lang/Object;)I");
			global::java.util.Vector._indexOf26970 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "indexOf", "(Ljava/lang/Object;I)I");
			global::java.util.Vector._clear26971 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "clear", "()V");
			global::java.util.Vector._isEmpty26972 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "isEmpty", "()Z");
			global::java.util.Vector._lastIndexOf26973 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "lastIndexOf", "(Ljava/lang/Object;I)I");
			global::java.util.Vector._lastIndexOf26974 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "lastIndexOf", "(Ljava/lang/Object;)I");
			global::java.util.Vector._contains26975 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.Vector._addAll26976 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.Vector._addAll26977 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "addAll", "(ILjava/util/Collection;)Z");
			global::java.util.Vector._size26978 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "size", "()I");
			global::java.util.Vector._toArray26979 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.Vector._toArray26980 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.Vector._addElement26981 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "addElement", "(Ljava/lang/Object;)V");
			global::java.util.Vector._elementAt26982 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "elementAt", "(I)Ljava/lang/Object;");
			global::java.util.Vector._remove26983 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "remove", "(I)Ljava/lang/Object;");
			global::java.util.Vector._remove26984 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.Vector._elements26985 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "elements", "()Ljava/util/Enumeration;");
			global::java.util.Vector._set26986 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "set", "(ILjava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Vector._copyInto26987 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "copyInto", "([Ljava/lang/Object;)V");
			global::java.util.Vector._trimToSize26988 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "trimToSize", "()V");
			global::java.util.Vector._ensureCapacity26989 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "ensureCapacity", "(I)V");
			global::java.util.Vector._setSize26990 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "setSize", "(I)V");
			global::java.util.Vector._capacity26991 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "capacity", "()I");
			global::java.util.Vector._firstElement26992 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "firstElement", "()Ljava/lang/Object;");
			global::java.util.Vector._lastElement26993 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "lastElement", "()Ljava/lang/Object;");
			global::java.util.Vector._setElementAt26994 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "setElementAt", "(Ljava/lang/Object;I)V");
			global::java.util.Vector._removeElementAt26995 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "removeElementAt", "(I)V");
			global::java.util.Vector._insertElementAt26996 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "insertElementAt", "(Ljava/lang/Object;I)V");
			global::java.util.Vector._removeElement26997 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "removeElement", "(Ljava/lang/Object;)Z");
			global::java.util.Vector._removeAllElements26998 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "removeAllElements", "()V");
			global::java.util.Vector._containsAll26999 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.Vector._removeAll27000 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.Vector._retainAll27001 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.Vector._subList27002 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "subList", "(II)Ljava/util/List;");
			global::java.util.Vector._removeRange27003 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "removeRange", "(II)V");
			global::java.util.Vector._Vector27004 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "<init>", "(II)V");
			global::java.util.Vector._Vector27005 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "<init>", "(I)V");
			global::java.util.Vector._Vector27006 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "<init>", "()V");
			global::java.util.Vector._Vector27007 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "<init>", "(Ljava/util/Collection;)V");
		}
	}
}
