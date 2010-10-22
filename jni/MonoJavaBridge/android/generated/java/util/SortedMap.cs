namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.SortedMap_))]
	public partial interface SortedMap : Map
	{
		global::java.util.Collection values();
		global::java.util.Set entrySet();
		global::java.util.Set keySet();
		global::java.util.Comparator comparator();
		global::java.util.SortedMap subMap(java.lang.Object arg0, java.lang.Object arg1);
		global::java.util.SortedMap headMap(java.lang.Object arg0);
		global::java.util.SortedMap tailMap(java.lang.Object arg0);
		global::java.lang.Object firstKey();
		global::java.lang.Object lastKey();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.SortedMap))]
	public sealed partial class SortedMap_ : java.lang.Object, SortedMap
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SortedMap_()
		{
			InitJNI();
		}
		internal SortedMap_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _values26640;
		 global::java.util.Collection java.util.SortedMap.values() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._values26640)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._values26640)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _entrySet26641;
		 global::java.util.Set java.util.SortedMap.entrySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._entrySet26641)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._entrySet26641)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _keySet26642;
		 global::java.util.Set java.util.SortedMap.keySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._keySet26642)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._keySet26642)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _comparator26643;
		 global::java.util.Comparator java.util.SortedMap.comparator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._comparator26643)) as java.util.Comparator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._comparator26643)) as java.util.Comparator;
		}
		internal static global::MonoJavaBridge.MethodId _subMap26644;
		 global::java.util.SortedMap java.util.SortedMap.subMap(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._subMap26644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.SortedMap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._subMap26644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.SortedMap;
		}
		internal static global::MonoJavaBridge.MethodId _headMap26645;
		 global::java.util.SortedMap java.util.SortedMap.headMap(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._headMap26645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedMap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._headMap26645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedMap;
		}
		internal static global::MonoJavaBridge.MethodId _tailMap26646;
		 global::java.util.SortedMap java.util.SortedMap.tailMap(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._tailMap26646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedMap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._tailMap26646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedMap;
		}
		internal static global::MonoJavaBridge.MethodId _firstKey26647;
		 global::java.lang.Object java.util.SortedMap.firstKey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._firstKey26647)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._firstKey26647)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _lastKey26648;
		 global::java.lang.Object java.util.SortedMap.lastKey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._lastKey26648)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._lastKey26648)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _get26649;
		 global::java.lang.Object java.util.Map.get(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._get26649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._get26649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put26650;
		 global::java.lang.Object java.util.Map.put(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._put26650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._put26650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals26651;
		 bool java.util.Map.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedMap_._equals26651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._equals26651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _values26652;
		 global::java.util.Collection java.util.Map.values() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._values26652)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._values26652)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26653;
		 int java.util.Map.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.SortedMap_._hashCode26653);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._hashCode26653);
		}
		internal static global::MonoJavaBridge.MethodId _clear26654;
		 void java.util.Map.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.SortedMap_._clear26654);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._clear26654);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26655;
		 bool java.util.Map.isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedMap_._isEmpty26655);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._isEmpty26655);
		}
		internal static global::MonoJavaBridge.MethodId _size26656;
		 int java.util.Map.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.SortedMap_._size26656);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._size26656);
		}
		internal static global::MonoJavaBridge.MethodId _entrySet26657;
		 global::java.util.Set java.util.Map.entrySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._entrySet26657)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._entrySet26657)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _putAll26658;
		 void java.util.Map.putAll(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.SortedMap_._putAll26658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._putAll26658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove26659;
		 global::java.lang.Object java.util.Map.remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._remove26659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._remove26659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _keySet26660;
		 global::java.util.Set java.util.Map.keySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._keySet26660)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._keySet26660)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsValue26661;
		 bool java.util.Map.containsValue(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedMap_._containsValue26661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._containsValue26661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey26662;
		 bool java.util.Map.containsKey(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedMap_._containsKey26662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._containsKey26662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.SortedMap_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/SortedMap"));
			global::java.util.SortedMap_._values26640 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "values", "()Ljava/util/Collection;");
			global::java.util.SortedMap_._entrySet26641 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.util.SortedMap_._keySet26642 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.util.SortedMap_._comparator26643 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "comparator", "()Ljava/util/Comparator;");
			global::java.util.SortedMap_._subMap26644 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "subMap", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedMap;");
			global::java.util.SortedMap_._headMap26645 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "headMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;");
			global::java.util.SortedMap_._tailMap26646 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "tailMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;");
			global::java.util.SortedMap_._firstKey26647 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "firstKey", "()Ljava/lang/Object;");
			global::java.util.SortedMap_._lastKey26648 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "lastKey", "()Ljava/lang/Object;");
			global::java.util.SortedMap_._get26649 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.SortedMap_._put26650 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.SortedMap_._equals26651 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.SortedMap_._values26652 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "values", "()Ljava/util/Collection;");
			global::java.util.SortedMap_._hashCode26653 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "hashCode", "()I");
			global::java.util.SortedMap_._clear26654 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "clear", "()V");
			global::java.util.SortedMap_._isEmpty26655 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "isEmpty", "()Z");
			global::java.util.SortedMap_._size26656 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "size", "()I");
			global::java.util.SortedMap_._entrySet26657 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.util.SortedMap_._putAll26658 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "putAll", "(Ljava/util/Map;)V");
			global::java.util.SortedMap_._remove26659 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.SortedMap_._keySet26660 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.util.SortedMap_._containsValue26661 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
			global::java.util.SortedMap_._containsKey26662 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "containsKey", "(Ljava/lang/Object;)Z");
		}
	}
}
