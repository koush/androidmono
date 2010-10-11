namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.List_))]
	public interface List : Collection
	{
		void add(int arg0, java.lang.Object arg1);
		new bool add(java.lang.Object arg0);
		global::java.lang.Object get(int arg0);
		new bool equals(java.lang.Object arg0);
		new int hashCode();
		int indexOf(java.lang.Object arg0);
		new void clear();
		new bool isEmpty();
		int lastIndexOf(java.lang.Object arg0);
		new bool contains(java.lang.Object arg0);
		new bool addAll(java.util.Collection arg0);
		bool addAll(int arg0, java.util.Collection arg1);
		new int size();
		new global::java.lang.Object[] toArray(java.lang.Object[] arg0);
		new global::java.lang.Object[] toArray();
		new global::java.util.Iterator iterator();
		new bool remove(java.lang.Object arg0);
		global::java.lang.Object remove(int arg0);
		global::java.lang.Object set(int arg0, java.lang.Object arg1);
		new bool containsAll(java.util.Collection arg0);
		new bool removeAll(java.util.Collection arg0);
		new bool retainAll(java.util.Collection arg0);
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
		internal static global::MonoJavaBridge.MethodId _add15478;
		 void java.util.List.add(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.List_._add15478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._add15478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _add15479;
		 bool java.util.List.add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._add15479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._add15479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _get15480;
		 global::java.lang.Object java.util.List.get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._get15480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._get15480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals15481;
		 bool java.util.List.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._equals15481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._equals15481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode15482;
		 int java.util.List.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.List_._hashCode15482);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._hashCode15482);
		}
		internal static global::MonoJavaBridge.MethodId _indexOf15483;
		 int java.util.List.indexOf(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.List_._indexOf15483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._indexOf15483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear15484;
		 void java.util.List.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.List_._clear15484);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._clear15484);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty15485;
		 bool java.util.List.isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._isEmpty15485);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._isEmpty15485);
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf15486;
		 int java.util.List.lastIndexOf(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.List_._lastIndexOf15486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._lastIndexOf15486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _contains15487;
		 bool java.util.List.contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._contains15487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._contains15487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll15488;
		 bool java.util.List.addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._addAll15488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._addAll15488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll15489;
		 bool java.util.List.addAll(int arg0, java.util.Collection arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._addAll15489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._addAll15489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _size15490;
		 int java.util.List.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.List_._size15490);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._size15490);
		}
		internal static global::MonoJavaBridge.MethodId _toArray15491;
		 global::java.lang.Object[] java.util.List.toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._toArray15491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._toArray15491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray15492;
		 global::java.lang.Object[] java.util.List.toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._toArray15492)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._toArray15492)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator15493;
		 global::java.util.Iterator java.util.List.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._iterator15493)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._iterator15493)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove15494;
		 bool java.util.List.remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._remove15494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._remove15494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove15495;
		 global::java.lang.Object java.util.List.remove(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._remove15495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._remove15495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _set15496;
		 global::java.lang.Object java.util.List.set(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._set15496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._set15496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _containsAll15497;
		 bool java.util.List.containsAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._containsAll15497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._containsAll15497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll15498;
		 bool java.util.List.removeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._removeAll15498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._removeAll15498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll15499;
		 bool java.util.List.retainAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._retainAll15499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._retainAll15499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _subList15500;
		 global::java.util.List java.util.List.subList(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._subList15500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._subList15500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _listIterator15501;
		 global::java.util.ListIterator java.util.List.listIterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._listIterator15501)) as java.util.ListIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._listIterator15501)) as java.util.ListIterator;
		}
		internal static global::MonoJavaBridge.MethodId _listIterator15502;
		 global::java.util.ListIterator java.util.List.listIterator(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._listIterator15502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ListIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._listIterator15502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ListIterator;
		}
		internal static global::MonoJavaBridge.MethodId _add15503;
		 bool java.util.Collection.add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._add15503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._add15503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals15504;
		 bool java.util.Collection.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._equals15504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._equals15504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode15505;
		 int java.util.Collection.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.List_._hashCode15505);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._hashCode15505);
		}
		internal static global::MonoJavaBridge.MethodId _clear15506;
		 void java.util.Collection.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.List_._clear15506);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._clear15506);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty15507;
		 bool java.util.Collection.isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._isEmpty15507);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._isEmpty15507);
		}
		internal static global::MonoJavaBridge.MethodId _contains15508;
		 bool java.util.Collection.contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._contains15508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._contains15508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll15509;
		 bool java.util.Collection.addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._addAll15509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._addAll15509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size15510;
		 int java.util.Collection.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.List_._size15510);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._size15510);
		}
		internal static global::MonoJavaBridge.MethodId _toArray15511;
		 global::java.lang.Object[] java.util.Collection.toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._toArray15511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._toArray15511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray15512;
		 global::java.lang.Object[] java.util.Collection.toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._toArray15512)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._toArray15512)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator15513;
		 global::java.util.Iterator java.util.Collection.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._iterator15513)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._iterator15513)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove15514;
		 bool java.util.Collection.remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._remove15514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._remove15514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll15515;
		 bool java.util.Collection.containsAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._containsAll15515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._containsAll15515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll15516;
		 bool java.util.Collection.removeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._removeAll15516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._removeAll15516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll15517;
		 bool java.util.Collection.retainAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._retainAll15517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._retainAll15517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _iterator15518;
		 global::java.util.Iterator java.lang.Iterable.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._iterator15518)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.List_.staticClass, global::java.util.List_._iterator15518)) as java.util.Iterator;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.List_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/List"));
			global::java.util.List_._add15478 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "add", "(ILjava/lang/Object;)V");
			global::java.util.List_._add15479 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.List_._get15480 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "get", "(I)Ljava/lang/Object;");
			global::java.util.List_._equals15481 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.List_._hashCode15482 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "hashCode", "()I");
			global::java.util.List_._indexOf15483 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "indexOf", "(Ljava/lang/Object;)I");
			global::java.util.List_._clear15484 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "clear", "()V");
			global::java.util.List_._isEmpty15485 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "isEmpty", "()Z");
			global::java.util.List_._lastIndexOf15486 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "lastIndexOf", "(Ljava/lang/Object;)I");
			global::java.util.List_._contains15487 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.List_._addAll15488 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.List_._addAll15489 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "addAll", "(ILjava/util/Collection;)Z");
			global::java.util.List_._size15490 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "size", "()I");
			global::java.util.List_._toArray15491 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.List_._toArray15492 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.List_._iterator15493 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.List_._remove15494 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.List_._remove15495 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "remove", "(I)Ljava/lang/Object;");
			global::java.util.List_._set15496 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "set", "(ILjava/lang/Object;)Ljava/lang/Object;");
			global::java.util.List_._containsAll15497 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.List_._removeAll15498 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.List_._retainAll15499 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.List_._subList15500 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "subList", "(II)Ljava/util/List;");
			global::java.util.List_._listIterator15501 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "listIterator", "()Ljava/util/ListIterator;");
			global::java.util.List_._listIterator15502 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "listIterator", "(I)Ljava/util/ListIterator;");
			global::java.util.List_._add15503 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.List_._equals15504 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.List_._hashCode15505 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "hashCode", "()I");
			global::java.util.List_._clear15506 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "clear", "()V");
			global::java.util.List_._isEmpty15507 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "isEmpty", "()Z");
			global::java.util.List_._contains15508 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.List_._addAll15509 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.List_._size15510 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "size", "()I");
			global::java.util.List_._toArray15511 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.List_._toArray15512 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.List_._iterator15513 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.List_._remove15514 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.List_._containsAll15515 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.List_._removeAll15516 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.List_._retainAll15517 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.List_._iterator15518 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "iterator", "()Ljava/util/Iterator;");
		}
	}
}
