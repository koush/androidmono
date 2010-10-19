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
		internal static global::MonoJavaBridge.MethodId _add21014;
		public override void add(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Vector._add21014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._add21014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _add21015;
		public override bool add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Vector._add21015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._add21015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _get21016;
		public override global::java.lang.Object get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Vector._get21016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._get21016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals21017;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Vector._equals21017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._equals21017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString21018;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Vector._toString21018)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._toString21018)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode21019;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Vector._hashCode21019);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._hashCode21019);
		}
		internal static global::MonoJavaBridge.MethodId _clone21020;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Vector._clone21020)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._clone21020)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _indexOf21021;
		public override int indexOf(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Vector._indexOf21021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._indexOf21021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf21022;
		public virtual int indexOf(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Vector._indexOf21022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._indexOf21022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clear21023;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Vector._clear21023);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._clear21023);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty21024;
		public override bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Vector._isEmpty21024);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._isEmpty21024);
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf21025;
		public virtual int lastIndexOf(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Vector._lastIndexOf21025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._lastIndexOf21025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf21026;
		public override int lastIndexOf(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Vector._lastIndexOf21026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._lastIndexOf21026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _contains21027;
		public override bool contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Vector._contains21027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._contains21027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll21028;
		public override bool addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Vector._addAll21028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._addAll21028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll21029;
		public override bool addAll(int arg0, java.util.Collection arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Vector._addAll21029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._addAll21029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _size21030;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Vector._size21030);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._size21030);
		}
		internal static global::MonoJavaBridge.MethodId _toArray21031;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Vector._toArray21031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._toArray21031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray21032;
		public override global::java.lang.Object[] toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Vector._toArray21032)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._toArray21032)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _addElement21033;
		public virtual void addElement(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Vector._addElement21033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._addElement21033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _elementAt21034;
		public virtual global::java.lang.Object elementAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Vector._elementAt21034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._elementAt21034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove21035;
		public override global::java.lang.Object remove(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Vector._remove21035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._remove21035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove21036;
		public override bool remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Vector._remove21036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._remove21036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _elements21037;
		public virtual global::java.util.Enumeration elements() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Vector._elements21037)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._elements21037)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _set21038;
		public override global::java.lang.Object set(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Vector._set21038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._set21038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _copyInto21039;
		public virtual void copyInto(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Vector._copyInto21039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._copyInto21039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _trimToSize21040;
		public virtual void trimToSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Vector._trimToSize21040);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._trimToSize21040);
		}
		internal static global::MonoJavaBridge.MethodId _ensureCapacity21041;
		public virtual void ensureCapacity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Vector._ensureCapacity21041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._ensureCapacity21041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSize21042;
		public virtual void setSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Vector._setSize21042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._setSize21042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _capacity21043;
		public virtual int capacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Vector._capacity21043);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._capacity21043);
		}
		internal static global::MonoJavaBridge.MethodId _firstElement21044;
		public virtual global::java.lang.Object firstElement() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Vector._firstElement21044)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._firstElement21044)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _lastElement21045;
		public virtual global::java.lang.Object lastElement() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Vector._lastElement21045)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._lastElement21045)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setElementAt21046;
		public virtual void setElementAt(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Vector._setElementAt21046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._setElementAt21046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeElementAt21047;
		public virtual void removeElementAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Vector._removeElementAt21047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._removeElementAt21047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _insertElementAt21048;
		public virtual void insertElementAt(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Vector._insertElementAt21048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._insertElementAt21048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeElement21049;
		public virtual bool removeElement(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Vector._removeElement21049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._removeElement21049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAllElements21050;
		public virtual void removeAllElements() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Vector._removeAllElements21050);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._removeAllElements21050);
		}
		internal static global::MonoJavaBridge.MethodId _containsAll21051;
		public override bool containsAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Vector._containsAll21051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._containsAll21051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll21052;
		public override bool removeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Vector._removeAll21052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._removeAll21052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll21053;
		public override bool retainAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Vector._retainAll21053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._retainAll21053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _subList21054;
		public override global::java.util.List subList(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Vector._subList21054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._subList21054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _removeRange21055;
		protected override void removeRange(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Vector._removeRange21055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._removeRange21055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _Vector21056;
		public Vector(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Vector.staticClass, global::java.util.Vector._Vector21056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Vector21057;
		public Vector(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Vector.staticClass, global::java.util.Vector._Vector21057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Vector21058;
		public Vector()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Vector.staticClass, global::java.util.Vector._Vector21058);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Vector21059;
		public Vector(java.util.Collection arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Vector.staticClass, global::java.util.Vector._Vector21059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Vector.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Vector"));
			global::java.util.Vector._add21014 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "add", "(ILjava/lang/Object;)V");
			global::java.util.Vector._add21015 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.Vector._get21016 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "get", "(I)Ljava/lang/Object;");
			global::java.util.Vector._equals21017 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Vector._toString21018 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.Vector._hashCode21019 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "hashCode", "()I");
			global::java.util.Vector._clone21020 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.Vector._indexOf21021 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "indexOf", "(Ljava/lang/Object;)I");
			global::java.util.Vector._indexOf21022 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "indexOf", "(Ljava/lang/Object;I)I");
			global::java.util.Vector._clear21023 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "clear", "()V");
			global::java.util.Vector._isEmpty21024 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "isEmpty", "()Z");
			global::java.util.Vector._lastIndexOf21025 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "lastIndexOf", "(Ljava/lang/Object;I)I");
			global::java.util.Vector._lastIndexOf21026 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "lastIndexOf", "(Ljava/lang/Object;)I");
			global::java.util.Vector._contains21027 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.Vector._addAll21028 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.Vector._addAll21029 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "addAll", "(ILjava/util/Collection;)Z");
			global::java.util.Vector._size21030 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "size", "()I");
			global::java.util.Vector._toArray21031 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.Vector._toArray21032 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.Vector._addElement21033 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "addElement", "(Ljava/lang/Object;)V");
			global::java.util.Vector._elementAt21034 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "elementAt", "(I)Ljava/lang/Object;");
			global::java.util.Vector._remove21035 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "remove", "(I)Ljava/lang/Object;");
			global::java.util.Vector._remove21036 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.Vector._elements21037 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "elements", "()Ljava/util/Enumeration;");
			global::java.util.Vector._set21038 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "set", "(ILjava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Vector._copyInto21039 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "copyInto", "([Ljava/lang/Object;)V");
			global::java.util.Vector._trimToSize21040 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "trimToSize", "()V");
			global::java.util.Vector._ensureCapacity21041 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "ensureCapacity", "(I)V");
			global::java.util.Vector._setSize21042 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "setSize", "(I)V");
			global::java.util.Vector._capacity21043 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "capacity", "()I");
			global::java.util.Vector._firstElement21044 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "firstElement", "()Ljava/lang/Object;");
			global::java.util.Vector._lastElement21045 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "lastElement", "()Ljava/lang/Object;");
			global::java.util.Vector._setElementAt21046 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "setElementAt", "(Ljava/lang/Object;I)V");
			global::java.util.Vector._removeElementAt21047 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "removeElementAt", "(I)V");
			global::java.util.Vector._insertElementAt21048 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "insertElementAt", "(Ljava/lang/Object;I)V");
			global::java.util.Vector._removeElement21049 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "removeElement", "(Ljava/lang/Object;)Z");
			global::java.util.Vector._removeAllElements21050 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "removeAllElements", "()V");
			global::java.util.Vector._containsAll21051 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.Vector._removeAll21052 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.Vector._retainAll21053 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.Vector._subList21054 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "subList", "(II)Ljava/util/List;");
			global::java.util.Vector._removeRange21055 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "removeRange", "(II)V");
			global::java.util.Vector._Vector21056 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "<init>", "(II)V");
			global::java.util.Vector._Vector21057 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "<init>", "(I)V");
			global::java.util.Vector._Vector21058 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "<init>", "()V");
			global::java.util.Vector._Vector21059 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "<init>", "(Ljava/util/Collection;)V");
		}
	}
}
