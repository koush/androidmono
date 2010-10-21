namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.List_))]
	public interface List : Collection
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
	public sealed partial class List_ : java.lang.Object, List
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static List_()
		{
			InitJNI();
		}
		internal List_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add26270;
		 void java.util.List.add(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.List_._add26270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._add26270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _add26271;
		 bool java.util.List.add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._add26271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._add26271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _get26272;
		 global::java.lang.Object java.util.List.get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._get26272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._get26272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals26273;
		 bool java.util.List.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._equals26273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._equals26273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26274;
		 int java.util.List.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.List_._hashCode26274);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._hashCode26274);
		}
		internal static global::MonoJavaBridge.MethodId _indexOf26275;
		 int java.util.List.indexOf(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.List_._indexOf26275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._indexOf26275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear26276;
		 void java.util.List.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.List_._clear26276);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._clear26276);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26277;
		 bool java.util.List.isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._isEmpty26277);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._isEmpty26277);
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf26278;
		 int java.util.List.lastIndexOf(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.List_._lastIndexOf26278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._lastIndexOf26278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _contains26279;
		 bool java.util.List.contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._contains26279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._contains26279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26280;
		 bool java.util.List.addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._addAll26280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._addAll26280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26281;
		 bool java.util.List.addAll(int arg0, java.util.Collection arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._addAll26281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._addAll26281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _size26282;
		 int java.util.List.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.List_._size26282);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._size26282);
		}
		internal static global::MonoJavaBridge.MethodId _toArray26283;
		 global::java.lang.Object[] java.util.List.toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._toArray26283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._toArray26283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray26284;
		 global::java.lang.Object[] java.util.List.toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._toArray26284)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._toArray26284)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator26285;
		 global::java.util.Iterator java.util.List.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._iterator26285)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._iterator26285)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove26286;
		 bool java.util.List.remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._remove26286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._remove26286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove26287;
		 global::java.lang.Object java.util.List.remove(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._remove26287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._remove26287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _set26288;
		 global::java.lang.Object java.util.List.set(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._set26288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._set26288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _containsAll26289;
		 bool java.util.List.containsAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._containsAll26289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._containsAll26289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll26290;
		 bool java.util.List.removeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._removeAll26290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._removeAll26290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll26291;
		 bool java.util.List.retainAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._retainAll26291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._retainAll26291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _subList26292;
		 global::java.util.List java.util.List.subList(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._subList26292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._subList26292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _listIterator26293;
		 global::java.util.ListIterator java.util.List.listIterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._listIterator26293)) as java.util.ListIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._listIterator26293)) as java.util.ListIterator;
		}
		internal static global::MonoJavaBridge.MethodId _listIterator26294;
		 global::java.util.ListIterator java.util.List.listIterator(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._listIterator26294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ListIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._listIterator26294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ListIterator;
		}
		internal static global::MonoJavaBridge.MethodId _add26295;
		 bool java.util.Collection.add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._add26295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._add26295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals26296;
		 bool java.util.Collection.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._equals26296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._equals26296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26297;
		 int java.util.Collection.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.List_._hashCode26297);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._hashCode26297);
		}
		internal static global::MonoJavaBridge.MethodId _clear26298;
		 void java.util.Collection.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.List_._clear26298);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._clear26298);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26299;
		 bool java.util.Collection.isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._isEmpty26299);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._isEmpty26299);
		}
		internal static global::MonoJavaBridge.MethodId _contains26300;
		 bool java.util.Collection.contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._contains26300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._contains26300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26301;
		 bool java.util.Collection.addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._addAll26301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._addAll26301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size26302;
		 int java.util.Collection.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.List_._size26302);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._size26302);
		}
		internal static global::MonoJavaBridge.MethodId _toArray26303;
		 global::java.lang.Object[] java.util.Collection.toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._toArray26303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._toArray26303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray26304;
		 global::java.lang.Object[] java.util.Collection.toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._toArray26304)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._toArray26304)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator26305;
		 global::java.util.Iterator java.util.Collection.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._iterator26305)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._iterator26305)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove26306;
		 bool java.util.Collection.remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._remove26306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._remove26306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll26307;
		 bool java.util.Collection.containsAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._containsAll26307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._containsAll26307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll26308;
		 bool java.util.Collection.removeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._removeAll26308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._removeAll26308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll26309;
		 bool java.util.Collection.retainAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._retainAll26309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._retainAll26309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _iterator26310;
		 global::java.util.Iterator java.lang.Iterable.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._iterator26310)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._iterator26310)) as java.util.Iterator;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.List_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/List"));
			global::java.util.List_._add26270 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "add", "(ILjava/lang/Object;)V");
			global::java.util.List_._add26271 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.List_._get26272 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "get", "(I)Ljava/lang/Object;");
			global::java.util.List_._equals26273 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.List_._hashCode26274 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "hashCode", "()I");
			global::java.util.List_._indexOf26275 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "indexOf", "(Ljava/lang/Object;)I");
			global::java.util.List_._clear26276 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "clear", "()V");
			global::java.util.List_._isEmpty26277 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "isEmpty", "()Z");
			global::java.util.List_._lastIndexOf26278 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "lastIndexOf", "(Ljava/lang/Object;)I");
			global::java.util.List_._contains26279 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.List_._addAll26280 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.List_._addAll26281 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "addAll", "(ILjava/util/Collection;)Z");
			global::java.util.List_._size26282 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "size", "()I");
			global::java.util.List_._toArray26283 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.List_._toArray26284 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.List_._iterator26285 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.List_._remove26286 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.List_._remove26287 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "remove", "(I)Ljava/lang/Object;");
			global::java.util.List_._set26288 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "set", "(ILjava/lang/Object;)Ljava/lang/Object;");
			global::java.util.List_._containsAll26289 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.List_._removeAll26290 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.List_._retainAll26291 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.List_._subList26292 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "subList", "(II)Ljava/util/List;");
			global::java.util.List_._listIterator26293 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "listIterator", "()Ljava/util/ListIterator;");
			global::java.util.List_._listIterator26294 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "listIterator", "(I)Ljava/util/ListIterator;");
			global::java.util.List_._add26295 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.List_._equals26296 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.List_._hashCode26297 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "hashCode", "()I");
			global::java.util.List_._clear26298 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "clear", "()V");
			global::java.util.List_._isEmpty26299 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "isEmpty", "()Z");
			global::java.util.List_._contains26300 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.List_._addAll26301 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.List_._size26302 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "size", "()I");
			global::java.util.List_._toArray26303 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.List_._toArray26304 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.List_._iterator26305 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.List_._remove26306 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.List_._containsAll26307 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.List_._removeAll26308 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.List_._retainAll26309 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.List_._iterator26310 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "iterator", "()Ljava/util/Iterator;");
		}
	}
}
