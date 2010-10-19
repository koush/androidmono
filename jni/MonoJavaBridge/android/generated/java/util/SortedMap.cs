namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.SortedMap_))]
	public interface SortedMap : Map
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
		internal static global::MonoJavaBridge.MethodId _values20812;
		 global::java.util.Collection java.util.SortedMap.values() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._values20812)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._values20812)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _entrySet20813;
		 global::java.util.Set java.util.SortedMap.entrySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._entrySet20813)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._entrySet20813)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _keySet20814;
		 global::java.util.Set java.util.SortedMap.keySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._keySet20814)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._keySet20814)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _comparator20815;
		 global::java.util.Comparator java.util.SortedMap.comparator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._comparator20815)) as java.util.Comparator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._comparator20815)) as java.util.Comparator;
		}
		internal static global::MonoJavaBridge.MethodId _subMap20816;
		 global::java.util.SortedMap java.util.SortedMap.subMap(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._subMap20816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.SortedMap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._subMap20816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.SortedMap;
		}
		internal static global::MonoJavaBridge.MethodId _headMap20817;
		 global::java.util.SortedMap java.util.SortedMap.headMap(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._headMap20817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedMap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._headMap20817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedMap;
		}
		internal static global::MonoJavaBridge.MethodId _tailMap20818;
		 global::java.util.SortedMap java.util.SortedMap.tailMap(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._tailMap20818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedMap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._tailMap20818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedMap;
		}
		internal static global::MonoJavaBridge.MethodId _firstKey20819;
		 global::java.lang.Object java.util.SortedMap.firstKey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._firstKey20819)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._firstKey20819)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _lastKey20820;
		 global::java.lang.Object java.util.SortedMap.lastKey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._lastKey20820)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._lastKey20820)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _get20821;
		 global::java.lang.Object java.util.Map.get(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._get20821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._get20821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put20822;
		 global::java.lang.Object java.util.Map.put(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._put20822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._put20822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals20823;
		 bool java.util.Map.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedMap_._equals20823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._equals20823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _values20824;
		 global::java.util.Collection java.util.Map.values() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._values20824)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._values20824)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20825;
		 int java.util.Map.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.SortedMap_._hashCode20825);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._hashCode20825);
		}
		internal static global::MonoJavaBridge.MethodId _clear20826;
		 void java.util.Map.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.SortedMap_._clear20826);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._clear20826);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty20827;
		 bool java.util.Map.isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedMap_._isEmpty20827);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._isEmpty20827);
		}
		internal static global::MonoJavaBridge.MethodId _size20828;
		 int java.util.Map.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.SortedMap_._size20828);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._size20828);
		}
		internal static global::MonoJavaBridge.MethodId _entrySet20829;
		 global::java.util.Set java.util.Map.entrySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._entrySet20829)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._entrySet20829)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _putAll20830;
		 void java.util.Map.putAll(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.SortedMap_._putAll20830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._putAll20830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove20831;
		 global::java.lang.Object java.util.Map.remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._remove20831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._remove20831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _keySet20832;
		 global::java.util.Set java.util.Map.keySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._keySet20832)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._keySet20832)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsValue20833;
		 bool java.util.Map.containsValue(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedMap_._containsValue20833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._containsValue20833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey20834;
		 bool java.util.Map.containsKey(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedMap_._containsKey20834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._containsKey20834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.SortedMap_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/SortedMap"));
			global::java.util.SortedMap_._values20812 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "values", "()Ljava/util/Collection;");
			global::java.util.SortedMap_._entrySet20813 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.util.SortedMap_._keySet20814 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.util.SortedMap_._comparator20815 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "comparator", "()Ljava/util/Comparator;");
			global::java.util.SortedMap_._subMap20816 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "subMap", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedMap;");
			global::java.util.SortedMap_._headMap20817 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "headMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;");
			global::java.util.SortedMap_._tailMap20818 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "tailMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;");
			global::java.util.SortedMap_._firstKey20819 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "firstKey", "()Ljava/lang/Object;");
			global::java.util.SortedMap_._lastKey20820 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "lastKey", "()Ljava/lang/Object;");
			global::java.util.SortedMap_._get20821 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.SortedMap_._put20822 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.SortedMap_._equals20823 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.SortedMap_._values20824 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "values", "()Ljava/util/Collection;");
			global::java.util.SortedMap_._hashCode20825 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "hashCode", "()I");
			global::java.util.SortedMap_._clear20826 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "clear", "()V");
			global::java.util.SortedMap_._isEmpty20827 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "isEmpty", "()Z");
			global::java.util.SortedMap_._size20828 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "size", "()I");
			global::java.util.SortedMap_._entrySet20829 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.util.SortedMap_._putAll20830 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "putAll", "(Ljava/util/Map;)V");
			global::java.util.SortedMap_._remove20831 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.SortedMap_._keySet20832 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.util.SortedMap_._containsValue20833 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
			global::java.util.SortedMap_._containsKey20834 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "containsKey", "(Ljava/lang/Object;)Z");
		}
	}
}
