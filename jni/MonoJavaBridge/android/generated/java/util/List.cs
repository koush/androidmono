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
		static List_()
		{
			InitJNI();
		}
		internal List_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add26388;
		void java.util.List.add(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.List_._add26388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._add26388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _add26389;
		bool java.util.List.add(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._add26389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._add26389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _get26390;
		global::java.lang.Object java.util.List.get(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._get26390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._get26390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals26391;
		bool java.util.List.equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._equals26391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._equals26391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26392;
		int java.util.List.hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.List_._hashCode26392);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._hashCode26392);
		}
		internal static global::MonoJavaBridge.MethodId _indexOf26393;
		int java.util.List.indexOf(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.List_._indexOf26393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._indexOf26393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear26394;
		void java.util.List.clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.List_._clear26394);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._clear26394);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26395;
		bool java.util.List.isEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._isEmpty26395);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._isEmpty26395);
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf26396;
		int java.util.List.lastIndexOf(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.List_._lastIndexOf26396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._lastIndexOf26396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _contains26397;
		bool java.util.List.contains(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._contains26397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._contains26397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26398;
		bool java.util.List.addAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._addAll26398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._addAll26398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26399;
		bool java.util.List.addAll(int arg0, java.util.Collection arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._addAll26399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._addAll26399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _size26400;
		int java.util.List.size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.List_._size26400);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._size26400);
		}
		internal static global::MonoJavaBridge.MethodId _toArray26401;
		global::java.lang.Object[] java.util.List.toArray(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._toArray26401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._toArray26401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray26402;
		global::java.lang.Object[] java.util.List.toArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._toArray26402)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._toArray26402)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator26403;
		global::java.util.Iterator java.util.List.iterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._iterator26403)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._iterator26403)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove26404;
		bool java.util.List.remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._remove26404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._remove26404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove26405;
		global::java.lang.Object java.util.List.remove(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._remove26405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._remove26405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _set26406;
		global::java.lang.Object java.util.List.set(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._set26406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._set26406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _containsAll26407;
		bool java.util.List.containsAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._containsAll26407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._containsAll26407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll26408;
		bool java.util.List.removeAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._removeAll26408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._removeAll26408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll26409;
		bool java.util.List.retainAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._retainAll26409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._retainAll26409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _subList26410;
		global::java.util.List java.util.List.subList(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._subList26410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._subList26410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _listIterator26411;
		global::java.util.ListIterator java.util.List.listIterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._listIterator26411)) as java.util.ListIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._listIterator26411)) as java.util.ListIterator;
		}
		internal static global::MonoJavaBridge.MethodId _listIterator26412;
		global::java.util.ListIterator java.util.List.listIterator(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._listIterator26412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ListIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._listIterator26412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ListIterator;
		}
		internal static global::MonoJavaBridge.MethodId _add26413;
		bool java.util.Collection.add(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._add26413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._add26413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals26414;
		bool java.util.Collection.equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._equals26414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._equals26414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26415;
		int java.util.Collection.hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.List_._hashCode26415);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._hashCode26415);
		}
		internal static global::MonoJavaBridge.MethodId _clear26416;
		void java.util.Collection.clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.List_._clear26416);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._clear26416);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26417;
		bool java.util.Collection.isEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._isEmpty26417);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._isEmpty26417);
		}
		internal static global::MonoJavaBridge.MethodId _contains26418;
		bool java.util.Collection.contains(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._contains26418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._contains26418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26419;
		bool java.util.Collection.addAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._addAll26419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._addAll26419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size26420;
		int java.util.Collection.size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.List_._size26420);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._size26420);
		}
		internal static global::MonoJavaBridge.MethodId _toArray26421;
		global::java.lang.Object[] java.util.Collection.toArray(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._toArray26421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._toArray26421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray26422;
		global::java.lang.Object[] java.util.Collection.toArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._toArray26422)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._toArray26422)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator26423;
		global::java.util.Iterator java.util.Collection.iterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._iterator26423)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._iterator26423)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove26424;
		bool java.util.Collection.remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._remove26424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._remove26424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll26425;
		bool java.util.Collection.containsAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._containsAll26425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._containsAll26425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll26426;
		bool java.util.Collection.removeAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._removeAll26426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._removeAll26426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll26427;
		bool java.util.Collection.retainAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._retainAll26427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._retainAll26427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(((global::java.lang.Iterable)this).iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator26428;
		global::java.util.Iterator java.lang.Iterable.iterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._iterator26428)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._iterator26428)) as java.util.Iterator;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.List_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/List"));
			global::java.util.List_._add26388 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "add", "(ILjava/lang/Object;)V");
			global::java.util.List_._add26389 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.List_._get26390 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "get", "(I)Ljava/lang/Object;");
			global::java.util.List_._equals26391 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.List_._hashCode26392 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "hashCode", "()I");
			global::java.util.List_._indexOf26393 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "indexOf", "(Ljava/lang/Object;)I");
			global::java.util.List_._clear26394 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "clear", "()V");
			global::java.util.List_._isEmpty26395 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "isEmpty", "()Z");
			global::java.util.List_._lastIndexOf26396 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "lastIndexOf", "(Ljava/lang/Object;)I");
			global::java.util.List_._contains26397 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.List_._addAll26398 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.List_._addAll26399 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "addAll", "(ILjava/util/Collection;)Z");
			global::java.util.List_._size26400 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "size", "()I");
			global::java.util.List_._toArray26401 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.List_._toArray26402 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.List_._iterator26403 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.List_._remove26404 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.List_._remove26405 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "remove", "(I)Ljava/lang/Object;");
			global::java.util.List_._set26406 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "set", "(ILjava/lang/Object;)Ljava/lang/Object;");
			global::java.util.List_._containsAll26407 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.List_._removeAll26408 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.List_._retainAll26409 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.List_._subList26410 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "subList", "(II)Ljava/util/List;");
			global::java.util.List_._listIterator26411 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "listIterator", "()Ljava/util/ListIterator;");
			global::java.util.List_._listIterator26412 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "listIterator", "(I)Ljava/util/ListIterator;");
			global::java.util.List_._add26413 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.List_._equals26414 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.List_._hashCode26415 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "hashCode", "()I");
			global::java.util.List_._clear26416 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "clear", "()V");
			global::java.util.List_._isEmpty26417 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "isEmpty", "()Z");
			global::java.util.List_._contains26418 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.List_._addAll26419 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.List_._size26420 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "size", "()I");
			global::java.util.List_._toArray26421 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.List_._toArray26422 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.List_._iterator26423 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.List_._remove26424 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.List_._containsAll26425 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.List_._removeAll26426 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.List_._retainAll26427 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.List_._iterator26428 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "iterator", "()Ljava/util/Iterator;");
		}
	}
}
