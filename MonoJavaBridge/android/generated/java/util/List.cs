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
		internal List_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add26389;
		void java.util.List.add(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._add26389.native == global::System.IntPtr.Zero)
				global::java.util.List_._add26389 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "add", "(ILjava/lang/Object;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.util.List_._add26389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _add26390;
		bool java.util.List.add(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._add26390.native == global::System.IntPtr.Zero)
				global::java.util.List_._add26390 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "add", "(Ljava/lang/Object;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._add26390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _get26391;
		global::java.lang.Object java.util.List.get(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._get26391.native == global::System.IntPtr.Zero)
				global::java.util.List_._get26391 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "get", "(I)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._get26391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals26392;
		bool java.util.List.equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._equals26392.native == global::System.IntPtr.Zero)
				global::java.util.List_._equals26392 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._equals26392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26393;
		int java.util.List.hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._hashCode26393.native == global::System.IntPtr.Zero)
				global::java.util.List_._hashCode26393 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "hashCode", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::java.util.List_._hashCode26393);
		}
		internal static global::MonoJavaBridge.MethodId _indexOf26394;
		int java.util.List.indexOf(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._indexOf26394.native == global::System.IntPtr.Zero)
				global::java.util.List_._indexOf26394 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "indexOf", "(Ljava/lang/Object;)I");
			return @__env.CallIntMethod(this.JvmHandle, global::java.util.List_._indexOf26394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear26395;
		void java.util.List.clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._clear26395.native == global::System.IntPtr.Zero)
				global::java.util.List_._clear26395 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "clear", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.util.List_._clear26395);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26396;
		bool java.util.List.isEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._isEmpty26396.native == global::System.IntPtr.Zero)
				global::java.util.List_._isEmpty26396 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "isEmpty", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._isEmpty26396);
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf26397;
		int java.util.List.lastIndexOf(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._lastIndexOf26397.native == global::System.IntPtr.Zero)
				global::java.util.List_._lastIndexOf26397 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "lastIndexOf", "(Ljava/lang/Object;)I");
			return @__env.CallIntMethod(this.JvmHandle, global::java.util.List_._lastIndexOf26397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _contains26398;
		bool java.util.List.contains(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._contains26398.native == global::System.IntPtr.Zero)
				global::java.util.List_._contains26398 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._contains26398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26399;
		bool java.util.List.addAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._addAll26399.native == global::System.IntPtr.Zero)
				global::java.util.List_._addAll26399 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._addAll26399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26400;
		bool java.util.List.addAll(int arg0, java.util.Collection arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._addAll26400.native == global::System.IntPtr.Zero)
				global::java.util.List_._addAll26400 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "addAll", "(ILjava/util/Collection;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._addAll26400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _size26401;
		int java.util.List.size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._size26401.native == global::System.IntPtr.Zero)
				global::java.util.List_._size26401 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "size", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::java.util.List_._size26401);
		}
		internal static global::MonoJavaBridge.MethodId _toArray26402;
		global::java.lang.Object[] java.util.List.toArray(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._toArray26402.native == global::System.IntPtr.Zero)
				global::java.util.List_._toArray26402 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._toArray26402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray26403;
		global::java.lang.Object[] java.util.List.toArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._toArray26403.native == global::System.IntPtr.Zero)
				global::java.util.List_._toArray26403 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "toArray", "()[Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._toArray26403)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator26404;
		global::java.util.Iterator java.util.List.iterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._iterator26404.native == global::System.IntPtr.Zero)
				global::java.util.List_._iterator26404 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "iterator", "()Ljava/util/Iterator;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._iterator26404)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove26405;
		bool java.util.List.remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._remove26405.native == global::System.IntPtr.Zero)
				global::java.util.List_._remove26405 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._remove26405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove26406;
		global::java.lang.Object java.util.List.remove(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._remove26406.native == global::System.IntPtr.Zero)
				global::java.util.List_._remove26406 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "remove", "(I)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._remove26406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _set26407;
		global::java.lang.Object java.util.List.set(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._set26407.native == global::System.IntPtr.Zero)
				global::java.util.List_._set26407 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "set", "(ILjava/lang/Object;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._set26407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _containsAll26408;
		bool java.util.List.containsAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._containsAll26408.native == global::System.IntPtr.Zero)
				global::java.util.List_._containsAll26408 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._containsAll26408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll26409;
		bool java.util.List.removeAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._removeAll26409.native == global::System.IntPtr.Zero)
				global::java.util.List_._removeAll26409 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._removeAll26409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll26410;
		bool java.util.List.retainAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._retainAll26410.native == global::System.IntPtr.Zero)
				global::java.util.List_._retainAll26410 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._retainAll26410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _subList26411;
		global::java.util.List java.util.List.subList(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._subList26411.native == global::System.IntPtr.Zero)
				global::java.util.List_._subList26411 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "subList", "(II)Ljava/util/List;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._subList26411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _listIterator26412;
		global::java.util.ListIterator java.util.List.listIterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._listIterator26412.native == global::System.IntPtr.Zero)
				global::java.util.List_._listIterator26412 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "listIterator", "()Ljava/util/ListIterator;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._listIterator26412)) as java.util.ListIterator;
		}
		internal static global::MonoJavaBridge.MethodId _listIterator26413;
		global::java.util.ListIterator java.util.List.listIterator(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._listIterator26413.native == global::System.IntPtr.Zero)
				global::java.util.List_._listIterator26413 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "listIterator", "(I)Ljava/util/ListIterator;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._listIterator26413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ListIterator;
		}
		internal static global::MonoJavaBridge.MethodId _add26414;
		bool java.util.Collection.add(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._add26414.native == global::System.IntPtr.Zero)
				global::java.util.List_._add26414 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "add", "(Ljava/lang/Object;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._add26414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals26415;
		bool java.util.Collection.equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._equals26415.native == global::System.IntPtr.Zero)
				global::java.util.List_._equals26415 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._equals26415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26416;
		int java.util.Collection.hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._hashCode26416.native == global::System.IntPtr.Zero)
				global::java.util.List_._hashCode26416 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "hashCode", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::java.util.List_._hashCode26416);
		}
		internal static global::MonoJavaBridge.MethodId _clear26417;
		void java.util.Collection.clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._clear26417.native == global::System.IntPtr.Zero)
				global::java.util.List_._clear26417 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "clear", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.util.List_._clear26417);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26418;
		bool java.util.Collection.isEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._isEmpty26418.native == global::System.IntPtr.Zero)
				global::java.util.List_._isEmpty26418 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "isEmpty", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._isEmpty26418);
		}
		internal static global::MonoJavaBridge.MethodId _contains26419;
		bool java.util.Collection.contains(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._contains26419.native == global::System.IntPtr.Zero)
				global::java.util.List_._contains26419 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._contains26419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26420;
		bool java.util.Collection.addAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._addAll26420.native == global::System.IntPtr.Zero)
				global::java.util.List_._addAll26420 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._addAll26420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size26421;
		int java.util.Collection.size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._size26421.native == global::System.IntPtr.Zero)
				global::java.util.List_._size26421 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "size", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::java.util.List_._size26421);
		}
		internal static global::MonoJavaBridge.MethodId _toArray26422;
		global::java.lang.Object[] java.util.Collection.toArray(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._toArray26422.native == global::System.IntPtr.Zero)
				global::java.util.List_._toArray26422 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._toArray26422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray26423;
		global::java.lang.Object[] java.util.Collection.toArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._toArray26423.native == global::System.IntPtr.Zero)
				global::java.util.List_._toArray26423 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "toArray", "()[Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._toArray26423)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator26424;
		global::java.util.Iterator java.util.Collection.iterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._iterator26424.native == global::System.IntPtr.Zero)
				global::java.util.List_._iterator26424 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "iterator", "()Ljava/util/Iterator;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._iterator26424)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove26425;
		bool java.util.Collection.remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._remove26425.native == global::System.IntPtr.Zero)
				global::java.util.List_._remove26425 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._remove26425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll26426;
		bool java.util.Collection.containsAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._containsAll26426.native == global::System.IntPtr.Zero)
				global::java.util.List_._containsAll26426 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._containsAll26426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll26427;
		bool java.util.Collection.removeAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._removeAll26427.native == global::System.IntPtr.Zero)
				global::java.util.List_._removeAll26427 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._removeAll26427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll26428;
		bool java.util.Collection.retainAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._retainAll26428.native == global::System.IntPtr.Zero)
				global::java.util.List_._retainAll26428 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.List_._retainAll26428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(((global::java.lang.Iterable)this).iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator26429;
		global::java.util.Iterator java.lang.Iterable.iterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.List_._iterator26429.native == global::System.IntPtr.Zero)
				global::java.util.List_._iterator26429 = @__env.GetMethodIDNoThrow(global::java.util.List_.staticClass, "iterator", "()Ljava/util/Iterator;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.List_._iterator26429)) as java.util.Iterator;
		}
		static List_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.List_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/List"));
		}
		internal static void InitJNI()
		{
		}
	}
}
