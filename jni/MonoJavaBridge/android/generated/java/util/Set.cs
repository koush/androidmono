namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.Set_))]
	public partial interface Set : Collection
	{
		bool add(java.lang.Object arg0);
		bool equals(java.lang.Object arg0);
		int hashCode();
		void clear();
		bool isEmpty();
		bool contains(java.lang.Object arg0);
		bool addAll(java.util.Collection arg0);
		int size();
		global::java.lang.Object[] toArray();
		global::java.lang.Object[] toArray(java.lang.Object[] arg0);
		global::java.util.Iterator iterator();
		bool remove(java.lang.Object arg0);
		bool containsAll(java.util.Collection arg0);
		bool removeAll(java.util.Collection arg0);
		bool retainAll(java.util.Collection arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.Set))]
	internal sealed partial class Set_ : java.lang.Object, Set
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Set_()
		{
			InitJNI();
		}
		internal Set_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add26700;
		bool java.util.Set.add(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._add26700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._add26700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals26701;
		bool java.util.Set.equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._equals26701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._equals26701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26702;
		int java.util.Set.hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Set_._hashCode26702);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._hashCode26702);
		}
		internal static global::MonoJavaBridge.MethodId _clear26703;
		void java.util.Set.clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Set_._clear26703);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._clear26703);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26704;
		bool java.util.Set.isEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._isEmpty26704);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._isEmpty26704);
		}
		internal static global::MonoJavaBridge.MethodId _contains26705;
		bool java.util.Set.contains(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._contains26705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._contains26705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26706;
		bool java.util.Set.addAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._addAll26706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._addAll26706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size26707;
		int java.util.Set.size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Set_._size26707);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._size26707);
		}
		internal static global::MonoJavaBridge.MethodId _toArray26708;
		global::java.lang.Object[] java.util.Set.toArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Set_._toArray26708)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._toArray26708)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray26709;
		global::java.lang.Object[] java.util.Set.toArray(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Set_._toArray26709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._toArray26709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator26710;
		global::java.util.Iterator java.util.Set.iterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Set_._iterator26710)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._iterator26710)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove26711;
		bool java.util.Set.remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._remove26711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._remove26711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll26712;
		bool java.util.Set.containsAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._containsAll26712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._containsAll26712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll26713;
		bool java.util.Set.removeAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._removeAll26713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._removeAll26713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll26714;
		bool java.util.Set.retainAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._retainAll26714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._retainAll26714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _add26715;
		bool java.util.Collection.add(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._add26715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._add26715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals26716;
		bool java.util.Collection.equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._equals26716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._equals26716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26717;
		int java.util.Collection.hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Set_._hashCode26717);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._hashCode26717);
		}
		internal static global::MonoJavaBridge.MethodId _clear26718;
		void java.util.Collection.clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Set_._clear26718);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._clear26718);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26719;
		bool java.util.Collection.isEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._isEmpty26719);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._isEmpty26719);
		}
		internal static global::MonoJavaBridge.MethodId _contains26720;
		bool java.util.Collection.contains(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._contains26720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._contains26720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26721;
		bool java.util.Collection.addAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._addAll26721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._addAll26721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size26722;
		int java.util.Collection.size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Set_._size26722);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._size26722);
		}
		internal static global::MonoJavaBridge.MethodId _toArray26723;
		global::java.lang.Object[] java.util.Collection.toArray(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Set_._toArray26723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._toArray26723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray26724;
		global::java.lang.Object[] java.util.Collection.toArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Set_._toArray26724)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._toArray26724)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator26725;
		global::java.util.Iterator java.util.Collection.iterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Set_._iterator26725)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._iterator26725)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove26726;
		bool java.util.Collection.remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._remove26726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._remove26726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll26727;
		bool java.util.Collection.containsAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._containsAll26727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._containsAll26727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll26728;
		bool java.util.Collection.removeAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._removeAll26728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._removeAll26728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll26729;
		bool java.util.Collection.retainAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._retainAll26729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._retainAll26729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(((global::java.lang.Iterable)this).iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator26730;
		global::java.util.Iterator java.lang.Iterable.iterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Set_._iterator26730)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._iterator26730)) as java.util.Iterator;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Set_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Set"));
			global::java.util.Set_._add26700 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._equals26701 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._hashCode26702 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "hashCode", "()I");
			global::java.util.Set_._clear26703 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "clear", "()V");
			global::java.util.Set_._isEmpty26704 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "isEmpty", "()Z");
			global::java.util.Set_._contains26705 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._addAll26706 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._size26707 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "size", "()I");
			global::java.util.Set_._toArray26708 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.Set_._toArray26709 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.Set_._iterator26710 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.Set_._remove26711 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._containsAll26712 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._removeAll26713 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._retainAll26714 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._add26715 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._equals26716 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._hashCode26717 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "hashCode", "()I");
			global::java.util.Set_._clear26718 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "clear", "()V");
			global::java.util.Set_._isEmpty26719 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "isEmpty", "()Z");
			global::java.util.Set_._contains26720 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._addAll26721 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._size26722 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "size", "()I");
			global::java.util.Set_._toArray26723 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.Set_._toArray26724 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.Set_._iterator26725 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.Set_._remove26726 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._containsAll26727 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._removeAll26728 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._retainAll26729 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._iterator26730 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "iterator", "()Ljava/util/Iterator;");
		}
	}
}
