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
	internal sealed partial class SortedMap_ : java.lang.Object, SortedMap
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SortedMap_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _values26759;
		global::java.util.Collection java.util.SortedMap.values()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._values26759)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _entrySet26760;
		global::java.util.Set java.util.SortedMap.entrySet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._entrySet26760)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _keySet26761;
		global::java.util.Set java.util.SortedMap.keySet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._keySet26761)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _comparator26762;
		global::java.util.Comparator java.util.SortedMap.comparator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._comparator26762)) as java.util.Comparator;
		}
		internal static global::MonoJavaBridge.MethodId _subMap26763;
		global::java.util.SortedMap java.util.SortedMap.subMap(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._subMap26763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.SortedMap;
		}
		internal static global::MonoJavaBridge.MethodId _headMap26764;
		global::java.util.SortedMap java.util.SortedMap.headMap(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._headMap26764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedMap;
		}
		internal static global::MonoJavaBridge.MethodId _tailMap26765;
		global::java.util.SortedMap java.util.SortedMap.tailMap(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._tailMap26765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedMap;
		}
		internal static global::MonoJavaBridge.MethodId _firstKey26766;
		global::java.lang.Object java.util.SortedMap.firstKey()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._firstKey26766)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _lastKey26767;
		global::java.lang.Object java.util.SortedMap.lastKey()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._lastKey26767)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _get26768;
		global::java.lang.Object java.util.Map.get(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._get26768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put26769;
		global::java.lang.Object java.util.Map.put(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._put26769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals26770;
		bool java.util.Map.equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedMap_._equals26770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _values26771;
		global::java.util.Collection java.util.Map.values()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._values26771)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26772;
		int java.util.Map.hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.util.SortedMap_._hashCode26772);
		}
		internal static global::MonoJavaBridge.MethodId _clear26773;
		void java.util.Map.clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.util.SortedMap_._clear26773);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26774;
		bool java.util.Map.isEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedMap_._isEmpty26774);
		}
		internal static global::MonoJavaBridge.MethodId _size26775;
		int java.util.Map.size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.util.SortedMap_._size26775);
		}
		internal static global::MonoJavaBridge.MethodId _entrySet26776;
		global::java.util.Set java.util.Map.entrySet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._entrySet26776)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _putAll26777;
		void java.util.Map.putAll(java.util.Map arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.util.SortedMap_._putAll26777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove26778;
		global::java.lang.Object java.util.Map.remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._remove26778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _keySet26779;
		global::java.util.Set java.util.Map.keySet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedMap_._keySet26779)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsValue26780;
		bool java.util.Map.containsValue(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedMap_._containsValue26780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey26781;
		bool java.util.Map.containsKey(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedMap_._containsKey26781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static SortedMap_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.SortedMap_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/SortedMap"));
			global::java.util.SortedMap_._values26759 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "values", "()Ljava/util/Collection;");
			global::java.util.SortedMap_._entrySet26760 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.util.SortedMap_._keySet26761 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.util.SortedMap_._comparator26762 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "comparator", "()Ljava/util/Comparator;");
			global::java.util.SortedMap_._subMap26763 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "subMap", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedMap;");
			global::java.util.SortedMap_._headMap26764 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "headMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;");
			global::java.util.SortedMap_._tailMap26765 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "tailMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;");
			global::java.util.SortedMap_._firstKey26766 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "firstKey", "()Ljava/lang/Object;");
			global::java.util.SortedMap_._lastKey26767 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "lastKey", "()Ljava/lang/Object;");
			global::java.util.SortedMap_._get26768 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.SortedMap_._put26769 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.SortedMap_._equals26770 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.SortedMap_._values26771 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "values", "()Ljava/util/Collection;");
			global::java.util.SortedMap_._hashCode26772 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "hashCode", "()I");
			global::java.util.SortedMap_._clear26773 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "clear", "()V");
			global::java.util.SortedMap_._isEmpty26774 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "isEmpty", "()Z");
			global::java.util.SortedMap_._size26775 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "size", "()I");
			global::java.util.SortedMap_._entrySet26776 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.util.SortedMap_._putAll26777 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "putAll", "(Ljava/util/Map;)V");
			global::java.util.SortedMap_._remove26778 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.SortedMap_._keySet26779 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.util.SortedMap_._containsValue26780 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
			global::java.util.SortedMap_._containsKey26781 = @__env.GetMethodIDNoThrow(global::java.util.SortedMap_.staticClass, "containsKey", "(Ljava/lang/Object;)Z");
		}
		internal static void InitJNI()
		{
		}
	}
}
