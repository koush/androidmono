namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.Set_))]
	public interface Set : Collection
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
	public sealed partial class Set_ : java.lang.Object, Set
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Set_()
		{
			InitJNI();
		}
		internal Set_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add26582;
		 bool java.util.Set.add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._add26582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._add26582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals26583;
		 bool java.util.Set.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._equals26583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._equals26583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26584;
		 int java.util.Set.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Set_._hashCode26584);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._hashCode26584);
		}
		internal static global::MonoJavaBridge.MethodId _clear26585;
		 void java.util.Set.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Set_._clear26585);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._clear26585);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26586;
		 bool java.util.Set.isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._isEmpty26586);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._isEmpty26586);
		}
		internal static global::MonoJavaBridge.MethodId _contains26587;
		 bool java.util.Set.contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._contains26587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._contains26587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26588;
		 bool java.util.Set.addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._addAll26588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._addAll26588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size26589;
		 int java.util.Set.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Set_._size26589);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._size26589);
		}
		internal static global::MonoJavaBridge.MethodId _toArray26590;
		 global::java.lang.Object[] java.util.Set.toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Set_._toArray26590)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._toArray26590)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray26591;
		 global::java.lang.Object[] java.util.Set.toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Set_._toArray26591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._toArray26591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator26592;
		 global::java.util.Iterator java.util.Set.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Set_._iterator26592)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._iterator26592)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove26593;
		 bool java.util.Set.remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._remove26593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._remove26593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll26594;
		 bool java.util.Set.containsAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._containsAll26594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._containsAll26594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll26595;
		 bool java.util.Set.removeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._removeAll26595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._removeAll26595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll26596;
		 bool java.util.Set.retainAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._retainAll26596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._retainAll26596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _add26597;
		 bool java.util.Collection.add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._add26597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._add26597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals26598;
		 bool java.util.Collection.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._equals26598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._equals26598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26599;
		 int java.util.Collection.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Set_._hashCode26599);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._hashCode26599);
		}
		internal static global::MonoJavaBridge.MethodId _clear26600;
		 void java.util.Collection.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Set_._clear26600);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._clear26600);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26601;
		 bool java.util.Collection.isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._isEmpty26601);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._isEmpty26601);
		}
		internal static global::MonoJavaBridge.MethodId _contains26602;
		 bool java.util.Collection.contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._contains26602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._contains26602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26603;
		 bool java.util.Collection.addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._addAll26603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._addAll26603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size26604;
		 int java.util.Collection.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Set_._size26604);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._size26604);
		}
		internal static global::MonoJavaBridge.MethodId _toArray26605;
		 global::java.lang.Object[] java.util.Collection.toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Set_._toArray26605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._toArray26605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray26606;
		 global::java.lang.Object[] java.util.Collection.toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Set_._toArray26606)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._toArray26606)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator26607;
		 global::java.util.Iterator java.util.Collection.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Set_._iterator26607)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._iterator26607)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove26608;
		 bool java.util.Collection.remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._remove26608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._remove26608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll26609;
		 bool java.util.Collection.containsAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._containsAll26609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._containsAll26609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll26610;
		 bool java.util.Collection.removeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._removeAll26610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._removeAll26610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll26611;
		 bool java.util.Collection.retainAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._retainAll26611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._retainAll26611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _iterator26612;
		 global::java.util.Iterator java.lang.Iterable.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Set_._iterator26612)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._iterator26612)) as java.util.Iterator;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Set_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Set"));
			global::java.util.Set_._add26582 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._equals26583 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._hashCode26584 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "hashCode", "()I");
			global::java.util.Set_._clear26585 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "clear", "()V");
			global::java.util.Set_._isEmpty26586 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "isEmpty", "()Z");
			global::java.util.Set_._contains26587 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._addAll26588 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._size26589 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "size", "()I");
			global::java.util.Set_._toArray26590 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.Set_._toArray26591 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.Set_._iterator26592 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.Set_._remove26593 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._containsAll26594 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._removeAll26595 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._retainAll26596 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._add26597 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._equals26598 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._hashCode26599 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "hashCode", "()I");
			global::java.util.Set_._clear26600 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "clear", "()V");
			global::java.util.Set_._isEmpty26601 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "isEmpty", "()Z");
			global::java.util.Set_._contains26602 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._addAll26603 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._size26604 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "size", "()I");
			global::java.util.Set_._toArray26605 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.Set_._toArray26606 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.Set_._iterator26607 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.Set_._remove26608 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._containsAll26609 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._removeAll26610 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._retainAll26611 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._iterator26612 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "iterator", "()Ljava/util/Iterator;");
		}
	}
}
