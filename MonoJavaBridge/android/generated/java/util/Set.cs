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
		internal Set_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add26701;
		bool java.util.Set.add(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._add26701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals26702;
		bool java.util.Set.equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._equals26702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26703;
		int java.util.Set.hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.util.Set_._hashCode26703);
		}
		internal static global::MonoJavaBridge.MethodId _clear26704;
		void java.util.Set.clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.util.Set_._clear26704);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26705;
		bool java.util.Set.isEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._isEmpty26705);
		}
		internal static global::MonoJavaBridge.MethodId _contains26706;
		bool java.util.Set.contains(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._contains26706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26707;
		bool java.util.Set.addAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._addAll26707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size26708;
		int java.util.Set.size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.util.Set_._size26708);
		}
		internal static global::MonoJavaBridge.MethodId _toArray26709;
		global::java.lang.Object[] java.util.Set.toArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Set_._toArray26709)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray26710;
		global::java.lang.Object[] java.util.Set.toArray(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Set_._toArray26710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator26711;
		global::java.util.Iterator java.util.Set.iterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Set_._iterator26711)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove26712;
		bool java.util.Set.remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._remove26712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll26713;
		bool java.util.Set.containsAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._containsAll26713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll26714;
		bool java.util.Set.removeAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._removeAll26714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll26715;
		bool java.util.Set.retainAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._retainAll26715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _add26716;
		bool java.util.Collection.add(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._add26716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals26717;
		bool java.util.Collection.equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._equals26717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26718;
		int java.util.Collection.hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.util.Set_._hashCode26718);
		}
		internal static global::MonoJavaBridge.MethodId _clear26719;
		void java.util.Collection.clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.util.Set_._clear26719);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26720;
		bool java.util.Collection.isEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._isEmpty26720);
		}
		internal static global::MonoJavaBridge.MethodId _contains26721;
		bool java.util.Collection.contains(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._contains26721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26722;
		bool java.util.Collection.addAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._addAll26722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size26723;
		int java.util.Collection.size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.util.Set_._size26723);
		}
		internal static global::MonoJavaBridge.MethodId _toArray26724;
		global::java.lang.Object[] java.util.Collection.toArray(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Set_._toArray26724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray26725;
		global::java.lang.Object[] java.util.Collection.toArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Set_._toArray26725)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator26726;
		global::java.util.Iterator java.util.Collection.iterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Set_._iterator26726)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove26727;
		bool java.util.Collection.remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._remove26727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll26728;
		bool java.util.Collection.containsAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._containsAll26728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll26729;
		bool java.util.Collection.removeAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._removeAll26729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll26730;
		bool java.util.Collection.retainAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._retainAll26730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(((global::java.lang.Iterable)this).iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator26731;
		global::java.util.Iterator java.lang.Iterable.iterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Set_._iterator26731)) as java.util.Iterator;
		}
		static Set_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Set_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Set"));
			global::java.util.Set_._add26701 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._equals26702 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._hashCode26703 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "hashCode", "()I");
			global::java.util.Set_._clear26704 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "clear", "()V");
			global::java.util.Set_._isEmpty26705 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "isEmpty", "()Z");
			global::java.util.Set_._contains26706 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._addAll26707 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._size26708 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "size", "()I");
			global::java.util.Set_._toArray26709 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.Set_._toArray26710 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.Set_._iterator26711 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.Set_._remove26712 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._containsAll26713 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._removeAll26714 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._retainAll26715 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._add26716 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._equals26717 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._hashCode26718 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "hashCode", "()I");
			global::java.util.Set_._clear26719 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "clear", "()V");
			global::java.util.Set_._isEmpty26720 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "isEmpty", "()Z");
			global::java.util.Set_._contains26721 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._addAll26722 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._size26723 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "size", "()I");
			global::java.util.Set_._toArray26724 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.Set_._toArray26725 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.Set_._iterator26726 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.Set_._remove26727 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._containsAll26728 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._removeAll26729 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._retainAll26730 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._iterator26731 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "iterator", "()Ljava/util/Iterator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
