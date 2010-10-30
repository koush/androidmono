namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Vector : java.util.AbstractList, List, RandomAccess, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Vector(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add26963;
		public override void add(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._add26963.native == global::System.IntPtr.Zero)
				global::java.util.Vector._add26963 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "add", "(ILjava/lang/Object;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Vector.staticClass, global::java.util.Vector._add26963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _add26964;
		public override bool add(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._add26964.native == global::System.IntPtr.Zero)
				global::java.util.Vector._add26964 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "add", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Vector.staticClass, global::java.util.Vector._add26964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _get26965;
		public override global::java.lang.Object get(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._get26965.native == global::System.IntPtr.Zero)
				global::java.util.Vector._get26965 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "get", "(I)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Vector.staticClass, global::java.util.Vector._get26965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals26966;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._equals26966.native == global::System.IntPtr.Zero)
				global::java.util.Vector._equals26966 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Vector.staticClass, global::java.util.Vector._equals26966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString26967;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._toString26967.native == global::System.IntPtr.Zero)
				global::java.util.Vector._toString26967 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Vector.staticClass, global::java.util.Vector._toString26967) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26968;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._hashCode26968.native == global::System.IntPtr.Zero)
				global::java.util.Vector._hashCode26968 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "hashCode", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Vector.staticClass, global::java.util.Vector._hashCode26968);
		}
		internal static global::MonoJavaBridge.MethodId _clone26969;
		public virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._clone26969.native == global::System.IntPtr.Zero)
				global::java.util.Vector._clone26969 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "clone", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Vector.staticClass, global::java.util.Vector._clone26969) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _indexOf26970;
		public override int indexOf(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._indexOf26970.native == global::System.IntPtr.Zero)
				global::java.util.Vector._indexOf26970 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "indexOf", "(Ljava/lang/Object;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Vector.staticClass, global::java.util.Vector._indexOf26970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf26971;
		public virtual int indexOf(java.lang.Object arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._indexOf26971.native == global::System.IntPtr.Zero)
				global::java.util.Vector._indexOf26971 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "indexOf", "(Ljava/lang/Object;I)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Vector.staticClass, global::java.util.Vector._indexOf26971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clear26972;
		public override void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._clear26972.native == global::System.IntPtr.Zero)
				global::java.util.Vector._clear26972 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "clear", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Vector.staticClass, global::java.util.Vector._clear26972);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26973;
		public override bool isEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._isEmpty26973.native == global::System.IntPtr.Zero)
				global::java.util.Vector._isEmpty26973 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "isEmpty", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Vector.staticClass, global::java.util.Vector._isEmpty26973);
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf26974;
		public virtual int lastIndexOf(java.lang.Object arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._lastIndexOf26974.native == global::System.IntPtr.Zero)
				global::java.util.Vector._lastIndexOf26974 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "lastIndexOf", "(Ljava/lang/Object;I)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Vector.staticClass, global::java.util.Vector._lastIndexOf26974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf26975;
		public override int lastIndexOf(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._lastIndexOf26975.native == global::System.IntPtr.Zero)
				global::java.util.Vector._lastIndexOf26975 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "lastIndexOf", "(Ljava/lang/Object;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Vector.staticClass, global::java.util.Vector._lastIndexOf26975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _contains26976;
		public override bool contains(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._contains26976.native == global::System.IntPtr.Zero)
				global::java.util.Vector._contains26976 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "contains", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Vector.staticClass, global::java.util.Vector._contains26976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26977;
		public override bool addAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._addAll26977.native == global::System.IntPtr.Zero)
				global::java.util.Vector._addAll26977 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Vector.staticClass, global::java.util.Vector._addAll26977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26978;
		public override bool addAll(int arg0, java.util.Collection arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._addAll26978.native == global::System.IntPtr.Zero)
				global::java.util.Vector._addAll26978 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "addAll", "(ILjava/util/Collection;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Vector.staticClass, global::java.util.Vector._addAll26978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _size26979;
		public override int size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._size26979.native == global::System.IntPtr.Zero)
				global::java.util.Vector._size26979 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "size", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Vector.staticClass, global::java.util.Vector._size26979);
		}
		internal static global::MonoJavaBridge.MethodId _toArray26980;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._toArray26980.native == global::System.IntPtr.Zero)
				global::java.util.Vector._toArray26980 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.Vector.staticClass, global::java.util.Vector._toArray26980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray26981;
		public override global::java.lang.Object[] toArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._toArray26981.native == global::System.IntPtr.Zero)
				global::java.util.Vector._toArray26981 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "toArray", "()[Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.Vector.staticClass, global::java.util.Vector._toArray26981) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _addElement26982;
		public virtual void addElement(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._addElement26982.native == global::System.IntPtr.Zero)
				global::java.util.Vector._addElement26982 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "addElement", "(Ljava/lang/Object;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Vector.staticClass, global::java.util.Vector._addElement26982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _elementAt26983;
		public virtual global::java.lang.Object elementAt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._elementAt26983.native == global::System.IntPtr.Zero)
				global::java.util.Vector._elementAt26983 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "elementAt", "(I)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Vector.staticClass, global::java.util.Vector._elementAt26983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove26984;
		public override global::java.lang.Object remove(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._remove26984.native == global::System.IntPtr.Zero)
				global::java.util.Vector._remove26984 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "remove", "(I)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Vector.staticClass, global::java.util.Vector._remove26984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove26985;
		public override bool remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._remove26985.native == global::System.IntPtr.Zero)
				global::java.util.Vector._remove26985 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "remove", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Vector.staticClass, global::java.util.Vector._remove26985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _elements26986;
		public virtual global::java.util.Enumeration elements()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._elements26986.native == global::System.IntPtr.Zero)
				global::java.util.Vector._elements26986 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "elements", "()Ljava/util/Enumeration;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.util.Vector.staticClass, global::java.util.Vector._elements26986) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _set26987;
		public override global::java.lang.Object set(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._set26987.native == global::System.IntPtr.Zero)
				global::java.util.Vector._set26987 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "set", "(ILjava/lang/Object;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Vector.staticClass, global::java.util.Vector._set26987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _copyInto26988;
		public virtual void copyInto(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._copyInto26988.native == global::System.IntPtr.Zero)
				global::java.util.Vector._copyInto26988 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "copyInto", "([Ljava/lang/Object;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Vector.staticClass, global::java.util.Vector._copyInto26988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _trimToSize26989;
		public virtual void trimToSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._trimToSize26989.native == global::System.IntPtr.Zero)
				global::java.util.Vector._trimToSize26989 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "trimToSize", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Vector.staticClass, global::java.util.Vector._trimToSize26989);
		}
		internal static global::MonoJavaBridge.MethodId _ensureCapacity26990;
		public virtual void ensureCapacity(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._ensureCapacity26990.native == global::System.IntPtr.Zero)
				global::java.util.Vector._ensureCapacity26990 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "ensureCapacity", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Vector.staticClass, global::java.util.Vector._ensureCapacity26990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSize26991;
		public virtual void setSize(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._setSize26991.native == global::System.IntPtr.Zero)
				global::java.util.Vector._setSize26991 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "setSize", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Vector.staticClass, global::java.util.Vector._setSize26991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _capacity26992;
		public virtual int capacity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._capacity26992.native == global::System.IntPtr.Zero)
				global::java.util.Vector._capacity26992 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "capacity", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Vector.staticClass, global::java.util.Vector._capacity26992);
		}
		internal static global::MonoJavaBridge.MethodId _firstElement26993;
		public virtual global::java.lang.Object firstElement()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._firstElement26993.native == global::System.IntPtr.Zero)
				global::java.util.Vector._firstElement26993 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "firstElement", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Vector.staticClass, global::java.util.Vector._firstElement26993) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _lastElement26994;
		public virtual global::java.lang.Object lastElement()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._lastElement26994.native == global::System.IntPtr.Zero)
				global::java.util.Vector._lastElement26994 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "lastElement", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Vector.staticClass, global::java.util.Vector._lastElement26994) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setElementAt26995;
		public virtual void setElementAt(java.lang.Object arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._setElementAt26995.native == global::System.IntPtr.Zero)
				global::java.util.Vector._setElementAt26995 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "setElementAt", "(Ljava/lang/Object;I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Vector.staticClass, global::java.util.Vector._setElementAt26995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeElementAt26996;
		public virtual void removeElementAt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._removeElementAt26996.native == global::System.IntPtr.Zero)
				global::java.util.Vector._removeElementAt26996 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "removeElementAt", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Vector.staticClass, global::java.util.Vector._removeElementAt26996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _insertElementAt26997;
		public virtual void insertElementAt(java.lang.Object arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._insertElementAt26997.native == global::System.IntPtr.Zero)
				global::java.util.Vector._insertElementAt26997 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "insertElementAt", "(Ljava/lang/Object;I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Vector.staticClass, global::java.util.Vector._insertElementAt26997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeElement26998;
		public virtual bool removeElement(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._removeElement26998.native == global::System.IntPtr.Zero)
				global::java.util.Vector._removeElement26998 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "removeElement", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Vector.staticClass, global::java.util.Vector._removeElement26998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAllElements26999;
		public virtual void removeAllElements()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._removeAllElements26999.native == global::System.IntPtr.Zero)
				global::java.util.Vector._removeAllElements26999 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "removeAllElements", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Vector.staticClass, global::java.util.Vector._removeAllElements26999);
		}
		internal static global::MonoJavaBridge.MethodId _containsAll27000;
		public override bool containsAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._containsAll27000.native == global::System.IntPtr.Zero)
				global::java.util.Vector._containsAll27000 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Vector.staticClass, global::java.util.Vector._containsAll27000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll27001;
		public override bool removeAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._removeAll27001.native == global::System.IntPtr.Zero)
				global::java.util.Vector._removeAll27001 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Vector.staticClass, global::java.util.Vector._removeAll27001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll27002;
		public override bool retainAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._retainAll27002.native == global::System.IntPtr.Zero)
				global::java.util.Vector._retainAll27002 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Vector.staticClass, global::java.util.Vector._retainAll27002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _subList27003;
		public override global::java.util.List subList(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._subList27003.native == global::System.IntPtr.Zero)
				global::java.util.Vector._subList27003 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "subList", "(II)Ljava/util/List;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::java.util.Vector.staticClass, global::java.util.Vector._subList27003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _removeRange27004;
		protected override void removeRange(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._removeRange27004.native == global::System.IntPtr.Zero)
				global::java.util.Vector._removeRange27004 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "removeRange", "(II)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Vector.staticClass, global::java.util.Vector._removeRange27004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _Vector27005;
		public Vector(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._Vector27005.native == global::System.IntPtr.Zero)
				global::java.util.Vector._Vector27005 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "<init>", "(II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Vector.staticClass, global::java.util.Vector._Vector27005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Vector27006;
		public Vector(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._Vector27006.native == global::System.IntPtr.Zero)
				global::java.util.Vector._Vector27006 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Vector.staticClass, global::java.util.Vector._Vector27006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Vector27007;
		public Vector() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._Vector27007.native == global::System.IntPtr.Zero)
				global::java.util.Vector._Vector27007 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Vector.staticClass, global::java.util.Vector._Vector27007);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Vector27008;
		public Vector(java.util.Collection arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._Vector27008.native == global::System.IntPtr.Zero)
				global::java.util.Vector._Vector27008 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Vector.staticClass, global::java.util.Vector._Vector27008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Vector()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Vector.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Vector"));
		}
		internal static void InitJNI()
		{
		}
	}
}
