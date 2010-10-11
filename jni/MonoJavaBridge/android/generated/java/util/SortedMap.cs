namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.SortedMap_))]
	public interface SortedMap : Map
	{
		new global::java.util.Collection values();
		new global::java.util.Set entrySet();
		new global::java.util.Set keySet();
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
		internal static global::MonoJavaBridge.MethodId _values15663;
		 global::java.util.Collection java.util.SortedMap.values() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._values15663)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._values15663)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _entrySet15664;
		 global::java.util.Set java.util.SortedMap.entrySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._entrySet15664)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._entrySet15664)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _keySet15665;
		 global::java.util.Set java.util.SortedMap.keySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._keySet15665)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._keySet15665)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _comparator15666;
		 global::java.util.Comparator java.util.SortedMap.comparator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._comparator15666)) as java.util.Comparator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._comparator15666)) as java.util.Comparator;
		}
		internal static global::MonoJavaBridge.MethodId _subMap15667;
		 global::java.util.SortedMap java.util.SortedMap.subMap(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._subMap15667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.SortedMap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._subMap15667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.SortedMap;
		}
		internal static global::MonoJavaBridge.MethodId _headMap15668;
		 global::java.util.SortedMap java.util.SortedMap.headMap(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._headMap15668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedMap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._headMap15668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedMap;
		}
		internal static global::MonoJavaBridge.MethodId _tailMap15669;
		 global::java.util.SortedMap java.util.SortedMap.tailMap(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._tailMap15669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedMap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._tailMap15669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedMap;
		}
		internal static global::MonoJavaBridge.MethodId _firstKey15670;
		 global::java.lang.Object java.util.SortedMap.firstKey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._firstKey15670)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._firstKey15670)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _lastKey15671;
		 global::java.lang.Object java.util.SortedMap.lastKey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._lastKey15671)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._lastKey15671)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _get15672;
		 global::java.lang.Object java.util.Map.get(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._get15672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._get15672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put15673;
		 global::java.lang.Object java.util.Map.put(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._put15673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._put15673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals15674;
		 bool java.util.Map.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedMap_._equals15674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._equals15674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _values15675;
		 global::java.util.Collection java.util.Map.values() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._values15675)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._values15675)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode15676;
		 int java.util.Map.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.SortedMap_._hashCode15676);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._hashCode15676);
		}
		internal static global::MonoJavaBridge.MethodId _clear15677;
		 void java.util.Map.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.SortedMap_._clear15677);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._clear15677);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty15678;
		 bool java.util.Map.isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedMap_._isEmpty15678);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._isEmpty15678);
		}
		internal static global::MonoJavaBridge.MethodId _size15679;
		 int java.util.Map.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.SortedMap_._size15679);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._size15679);
		}
		internal static global::MonoJavaBridge.MethodId _entrySet15680;
		 global::java.util.Set java.util.Map.entrySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._entrySet15680)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._entrySet15680)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _putAll15681;
		 void java.util.Map.putAll(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.SortedMap_._putAll15681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._putAll15681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove15682;
		 global::java.lang.Object java.util.Map.remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._remove15682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._remove15682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _keySet15683;
		 global::java.util.Set java.util.Map.keySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._keySet15683)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._keySet15683)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsValue15684;
		 bool java.util.Map.containsValue(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedMap_._containsValue15684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._containsValue15684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey15685;
		 bool java.util.Map.containsKey(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedMap_._containsKey15685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedMap_.staticClass, global::java.util.SortedMap_._containsKey15685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.SortedMap_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/SortedMap"));
			global::java.util.SortedMap_._values15663 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "values", "()Ljava/util/Collection;");
			global::java.util.SortedMap_._entrySet15664 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.util.SortedMap_._keySet15665 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.util.SortedMap_._comparator15666 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "comparator", "()Ljava/util/Comparator;");
			global::java.util.SortedMap_._subMap15667 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "subMap", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedMap;");
			global::java.util.SortedMap_._headMap15668 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "headMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;");
			global::java.util.SortedMap_._tailMap15669 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "tailMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;");
			global::java.util.SortedMap_._firstKey15670 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "firstKey", "()Ljava/lang/Object;");
			global::java.util.SortedMap_._lastKey15671 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "lastKey", "()Ljava/lang/Object;");
			global::java.util.SortedMap_._get15672 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.SortedMap_._put15673 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.SortedMap_._equals15674 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.SortedMap_._values15675 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "values", "()Ljava/util/Collection;");
			global::java.util.SortedMap_._hashCode15676 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "hashCode", "()I");
			global::java.util.SortedMap_._clear15677 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "clear", "()V");
			global::java.util.SortedMap_._isEmpty15678 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "isEmpty", "()Z");
			global::java.util.SortedMap_._size15679 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "size", "()I");
			global::java.util.SortedMap_._entrySet15680 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.util.SortedMap_._putAll15681 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "putAll", "(Ljava/util/Map;)V");
			global::java.util.SortedMap_._remove15682 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.SortedMap_._keySet15683 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.util.SortedMap_._containsValue15684 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
			global::java.util.SortedMap_._containsKey15685 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "containsKey", "(Ljava/lang/Object;)Z");
		}
	}
}
