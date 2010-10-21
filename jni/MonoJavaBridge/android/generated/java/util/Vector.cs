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
		internal static global::MonoJavaBridge.MethodId _add26844;
		public override void add(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Vector._add26844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._add26844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _add26845;
		public override bool add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Vector._add26845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._add26845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _get26846;
		public override global::java.lang.Object get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Vector._get26846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._get26846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals26847;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Vector._equals26847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._equals26847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString26848;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Vector._toString26848)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._toString26848)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26849;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Vector._hashCode26849);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._hashCode26849);
		}
		internal static global::MonoJavaBridge.MethodId _clone26850;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Vector._clone26850)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._clone26850)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _indexOf26851;
		public override int indexOf(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Vector._indexOf26851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._indexOf26851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf26852;
		public virtual int indexOf(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Vector._indexOf26852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._indexOf26852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clear26853;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Vector._clear26853);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._clear26853);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26854;
		public override bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Vector._isEmpty26854);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._isEmpty26854);
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf26855;
		public virtual int lastIndexOf(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Vector._lastIndexOf26855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._lastIndexOf26855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf26856;
		public override int lastIndexOf(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Vector._lastIndexOf26856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._lastIndexOf26856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _contains26857;
		public override bool contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Vector._contains26857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._contains26857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26858;
		public override bool addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Vector._addAll26858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._addAll26858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26859;
		public override bool addAll(int arg0, java.util.Collection arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Vector._addAll26859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._addAll26859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _size26860;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Vector._size26860);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._size26860);
		}
		internal static global::MonoJavaBridge.MethodId _toArray26861;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Vector._toArray26861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._toArray26861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray26862;
		public override global::java.lang.Object[] toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Vector._toArray26862)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._toArray26862)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _addElement26863;
		public virtual void addElement(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Vector._addElement26863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._addElement26863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _elementAt26864;
		public virtual global::java.lang.Object elementAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Vector._elementAt26864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._elementAt26864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove26865;
		public override global::java.lang.Object remove(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Vector._remove26865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._remove26865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove26866;
		public override bool remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Vector._remove26866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._remove26866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _elements26867;
		public virtual global::java.util.Enumeration elements() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Vector._elements26867)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._elements26867)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _set26868;
		public override global::java.lang.Object set(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Vector._set26868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._set26868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _copyInto26869;
		public virtual void copyInto(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Vector._copyInto26869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._copyInto26869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _trimToSize26870;
		public virtual void trimToSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Vector._trimToSize26870);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._trimToSize26870);
		}
		internal static global::MonoJavaBridge.MethodId _ensureCapacity26871;
		public virtual void ensureCapacity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Vector._ensureCapacity26871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._ensureCapacity26871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSize26872;
		public virtual void setSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Vector._setSize26872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._setSize26872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _capacity26873;
		public virtual int capacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Vector._capacity26873);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._capacity26873);
		}
		internal static global::MonoJavaBridge.MethodId _firstElement26874;
		public virtual global::java.lang.Object firstElement() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Vector._firstElement26874)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._firstElement26874)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _lastElement26875;
		public virtual global::java.lang.Object lastElement() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Vector._lastElement26875)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._lastElement26875)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setElementAt26876;
		public virtual void setElementAt(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Vector._setElementAt26876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._setElementAt26876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeElementAt26877;
		public virtual void removeElementAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Vector._removeElementAt26877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._removeElementAt26877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _insertElementAt26878;
		public virtual void insertElementAt(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Vector._insertElementAt26878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._insertElementAt26878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeElement26879;
		public virtual bool removeElement(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Vector._removeElement26879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._removeElement26879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAllElements26880;
		public virtual void removeAllElements() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Vector._removeAllElements26880);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._removeAllElements26880);
		}
		internal static global::MonoJavaBridge.MethodId _containsAll26881;
		public override bool containsAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Vector._containsAll26881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._containsAll26881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll26882;
		public override bool removeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Vector._removeAll26882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._removeAll26882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll26883;
		public override bool retainAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Vector._retainAll26883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._retainAll26883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _subList26884;
		public override global::java.util.List subList(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Vector._subList26884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._subList26884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _removeRange26885;
		protected override void removeRange(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Vector._removeRange26885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Vector.staticClass, global::java.util.Vector._removeRange26885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _Vector26886;
		public Vector(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Vector.staticClass, global::java.util.Vector._Vector26886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Vector26887;
		public Vector(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Vector.staticClass, global::java.util.Vector._Vector26887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Vector26888;
		public Vector()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Vector.staticClass, global::java.util.Vector._Vector26888);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Vector26889;
		public Vector(java.util.Collection arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Vector.staticClass, global::java.util.Vector._Vector26889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Vector.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Vector"));
			global::java.util.Vector._add26844 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "add", "(ILjava/lang/Object;)V");
			global::java.util.Vector._add26845 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.Vector._get26846 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "get", "(I)Ljava/lang/Object;");
			global::java.util.Vector._equals26847 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Vector._toString26848 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.Vector._hashCode26849 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "hashCode", "()I");
			global::java.util.Vector._clone26850 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.Vector._indexOf26851 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "indexOf", "(Ljava/lang/Object;)I");
			global::java.util.Vector._indexOf26852 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "indexOf", "(Ljava/lang/Object;I)I");
			global::java.util.Vector._clear26853 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "clear", "()V");
			global::java.util.Vector._isEmpty26854 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "isEmpty", "()Z");
			global::java.util.Vector._lastIndexOf26855 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "lastIndexOf", "(Ljava/lang/Object;I)I");
			global::java.util.Vector._lastIndexOf26856 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "lastIndexOf", "(Ljava/lang/Object;)I");
			global::java.util.Vector._contains26857 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.Vector._addAll26858 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.Vector._addAll26859 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "addAll", "(ILjava/util/Collection;)Z");
			global::java.util.Vector._size26860 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "size", "()I");
			global::java.util.Vector._toArray26861 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.Vector._toArray26862 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.Vector._addElement26863 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "addElement", "(Ljava/lang/Object;)V");
			global::java.util.Vector._elementAt26864 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "elementAt", "(I)Ljava/lang/Object;");
			global::java.util.Vector._remove26865 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "remove", "(I)Ljava/lang/Object;");
			global::java.util.Vector._remove26866 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.Vector._elements26867 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "elements", "()Ljava/util/Enumeration;");
			global::java.util.Vector._set26868 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "set", "(ILjava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Vector._copyInto26869 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "copyInto", "([Ljava/lang/Object;)V");
			global::java.util.Vector._trimToSize26870 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "trimToSize", "()V");
			global::java.util.Vector._ensureCapacity26871 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "ensureCapacity", "(I)V");
			global::java.util.Vector._setSize26872 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "setSize", "(I)V");
			global::java.util.Vector._capacity26873 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "capacity", "()I");
			global::java.util.Vector._firstElement26874 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "firstElement", "()Ljava/lang/Object;");
			global::java.util.Vector._lastElement26875 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "lastElement", "()Ljava/lang/Object;");
			global::java.util.Vector._setElementAt26876 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "setElementAt", "(Ljava/lang/Object;I)V");
			global::java.util.Vector._removeElementAt26877 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "removeElementAt", "(I)V");
			global::java.util.Vector._insertElementAt26878 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "insertElementAt", "(Ljava/lang/Object;I)V");
			global::java.util.Vector._removeElement26879 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "removeElement", "(Ljava/lang/Object;)Z");
			global::java.util.Vector._removeAllElements26880 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "removeAllElements", "()V");
			global::java.util.Vector._containsAll26881 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.Vector._removeAll26882 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.Vector._retainAll26883 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.Vector._subList26884 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "subList", "(II)Ljava/util/List;");
			global::java.util.Vector._removeRange26885 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "removeRange", "(II)V");
			global::java.util.Vector._Vector26886 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "<init>", "(II)V");
			global::java.util.Vector._Vector26887 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "<init>", "(I)V");
			global::java.util.Vector._Vector26888 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "<init>", "()V");
			global::java.util.Vector._Vector26889 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "<init>", "(Ljava/util/Collection;)V");
		}
	}
}
