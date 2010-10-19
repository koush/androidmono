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
		internal static global::MonoJavaBridge.MethodId _add20445;
		 void java.util.List.add(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.List_._add20445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._add20445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _add20446;
		 bool java.util.List.add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._add20446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._add20446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _get20447;
		 global::java.lang.Object java.util.List.get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._get20447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._get20447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals20448;
		 bool java.util.List.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._equals20448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._equals20448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20449;
		 int java.util.List.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.List_._hashCode20449);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._hashCode20449);
		}
		internal static global::MonoJavaBridge.MethodId _indexOf20450;
		 int java.util.List.indexOf(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.List_._indexOf20450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._indexOf20450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear20451;
		 void java.util.List.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.List_._clear20451);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._clear20451);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty20452;
		 bool java.util.List.isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._isEmpty20452);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._isEmpty20452);
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf20453;
		 int java.util.List.lastIndexOf(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.List_._lastIndexOf20453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._lastIndexOf20453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _contains20454;
		 bool java.util.List.contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._contains20454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._contains20454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll20455;
		 bool java.util.List.addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._addAll20455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._addAll20455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll20456;
		 bool java.util.List.addAll(int arg0, java.util.Collection arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._addAll20456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._addAll20456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _size20457;
		 int java.util.List.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.List_._size20457);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._size20457);
		}
		internal static global::MonoJavaBridge.MethodId _toArray20458;
		 global::java.lang.Object[] java.util.List.toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._toArray20458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._toArray20458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray20459;
		 global::java.lang.Object[] java.util.List.toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._toArray20459)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._toArray20459)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator20460;
		 global::java.util.Iterator java.util.List.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._iterator20460)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._iterator20460)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove20461;
		 bool java.util.List.remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._remove20461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._remove20461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove20462;
		 global::java.lang.Object java.util.List.remove(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._remove20462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._remove20462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _set20463;
		 global::java.lang.Object java.util.List.set(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._set20463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._set20463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _containsAll20464;
		 bool java.util.List.containsAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._containsAll20464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._containsAll20464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll20465;
		 bool java.util.List.removeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._removeAll20465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._removeAll20465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll20466;
		 bool java.util.List.retainAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._retainAll20466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._retainAll20466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _subList20467;
		 global::java.util.List java.util.List.subList(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._subList20467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._subList20467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _listIterator20468;
		 global::java.util.ListIterator java.util.List.listIterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._listIterator20468)) as java.util.ListIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._listIterator20468)) as java.util.ListIterator;
		}
		internal static global::MonoJavaBridge.MethodId _listIterator20469;
		 global::java.util.ListIterator java.util.List.listIterator(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._listIterator20469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ListIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._listIterator20469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ListIterator;
		}
		internal static global::MonoJavaBridge.MethodId _add20470;
		 bool java.util.Collection.add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._add20470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._add20470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals20471;
		 bool java.util.Collection.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._equals20471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._equals20471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20472;
		 int java.util.Collection.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.List_._hashCode20472);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._hashCode20472);
		}
		internal static global::MonoJavaBridge.MethodId _clear20473;
		 void java.util.Collection.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.List_._clear20473);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._clear20473);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty20474;
		 bool java.util.Collection.isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._isEmpty20474);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._isEmpty20474);
		}
		internal static global::MonoJavaBridge.MethodId _contains20475;
		 bool java.util.Collection.contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._contains20475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._contains20475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll20476;
		 bool java.util.Collection.addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._addAll20476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._addAll20476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size20477;
		 int java.util.Collection.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.List_._size20477);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._size20477);
		}
		internal static global::MonoJavaBridge.MethodId _toArray20478;
		 global::java.lang.Object[] java.util.Collection.toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._toArray20478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._toArray20478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray20479;
		 global::java.lang.Object[] java.util.Collection.toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._toArray20479)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._toArray20479)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator20480;
		 global::java.util.Iterator java.util.Collection.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._iterator20480)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._iterator20480)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove20481;
		 bool java.util.Collection.remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._remove20481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._remove20481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll20482;
		 bool java.util.Collection.containsAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._containsAll20482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._containsAll20482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll20483;
		 bool java.util.Collection.removeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._removeAll20483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._removeAll20483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll20484;
		 bool java.util.Collection.retainAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._retainAll20484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._retainAll20484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _iterator20485;
		 global::java.util.Iterator java.lang.Iterable.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._iterator20485)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._iterator20485)) as java.util.Iterator;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.List_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/List"));
			global::java.util.List_._add20445 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "add", "(ILjava/lang/Object;)V");
			global::java.util.List_._add20446 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.List_._get20447 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "get", "(I)Ljava/lang/Object;");
			global::java.util.List_._equals20448 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.List_._hashCode20449 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "hashCode", "()I");
			global::java.util.List_._indexOf20450 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "indexOf", "(Ljava/lang/Object;)I");
			global::java.util.List_._clear20451 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "clear", "()V");
			global::java.util.List_._isEmpty20452 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "isEmpty", "()Z");
			global::java.util.List_._lastIndexOf20453 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "lastIndexOf", "(Ljava/lang/Object;)I");
			global::java.util.List_._contains20454 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.List_._addAll20455 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.List_._addAll20456 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "addAll", "(ILjava/util/Collection;)Z");
			global::java.util.List_._size20457 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "size", "()I");
			global::java.util.List_._toArray20458 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.List_._toArray20459 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.List_._iterator20460 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.List_._remove20461 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.List_._remove20462 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "remove", "(I)Ljava/lang/Object;");
			global::java.util.List_._set20463 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "set", "(ILjava/lang/Object;)Ljava/lang/Object;");
			global::java.util.List_._containsAll20464 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.List_._removeAll20465 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.List_._retainAll20466 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.List_._subList20467 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "subList", "(II)Ljava/util/List;");
			global::java.util.List_._listIterator20468 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "listIterator", "()Ljava/util/ListIterator;");
			global::java.util.List_._listIterator20469 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "listIterator", "(I)Ljava/util/ListIterator;");
			global::java.util.List_._add20470 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.List_._equals20471 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.List_._hashCode20472 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "hashCode", "()I");
			global::java.util.List_._clear20473 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "clear", "()V");
			global::java.util.List_._isEmpty20474 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "isEmpty", "()Z");
			global::java.util.List_._contains20475 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.List_._addAll20476 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.List_._size20477 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "size", "()I");
			global::java.util.List_._toArray20478 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.List_._toArray20479 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.List_._iterator20480 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.List_._remove20481 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.List_._containsAll20482 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.List_._removeAll20483 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.List_._retainAll20484 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.List_._iterator20485 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "iterator", "()Ljava/util/Iterator;");
		}
	}
}
