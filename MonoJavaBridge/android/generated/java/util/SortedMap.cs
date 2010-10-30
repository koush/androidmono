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
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.SortedMap_.staticClass, "values", "()Ljava/util/Collection;", ref global::java.util.SortedMap_._values26759) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _entrySet26760;
		global::java.util.Set java.util.SortedMap.entrySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.SortedMap_.staticClass, "entrySet", "()Ljava/util/Set;", ref global::java.util.SortedMap_._entrySet26760) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _keySet26761;
		global::java.util.Set java.util.SortedMap.keySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.SortedMap_.staticClass, "keySet", "()Ljava/util/Set;", ref global::java.util.SortedMap_._keySet26761) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _comparator26762;
		global::java.util.Comparator java.util.SortedMap.comparator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Comparator>(this, global::java.util.SortedMap_.staticClass, "comparator", "()Ljava/util/Comparator;", ref global::java.util.SortedMap_._comparator26762) as java.util.Comparator;
		}
		internal static global::MonoJavaBridge.MethodId _subMap26763;
		global::java.util.SortedMap java.util.SortedMap.subMap(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.SortedMap>(this, global::java.util.SortedMap_.staticClass, "subMap", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedMap;", ref global::java.util.SortedMap_._subMap26763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.SortedMap;
		}
		internal static global::MonoJavaBridge.MethodId _headMap26764;
		global::java.util.SortedMap java.util.SortedMap.headMap(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.SortedMap>(this, global::java.util.SortedMap_.staticClass, "headMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", ref global::java.util.SortedMap_._headMap26764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.SortedMap;
		}
		internal static global::MonoJavaBridge.MethodId _tailMap26765;
		global::java.util.SortedMap java.util.SortedMap.tailMap(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.SortedMap>(this, global::java.util.SortedMap_.staticClass, "tailMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", ref global::java.util.SortedMap_._tailMap26765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.SortedMap;
		}
		internal static global::MonoJavaBridge.MethodId _firstKey26766;
		global::java.lang.Object java.util.SortedMap.firstKey()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.SortedMap_.staticClass, "firstKey", "()Ljava/lang/Object;", ref global::java.util.SortedMap_._firstKey26766) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _lastKey26767;
		global::java.lang.Object java.util.SortedMap.lastKey()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.SortedMap_.staticClass, "lastKey", "()Ljava/lang/Object;", ref global::java.util.SortedMap_._lastKey26767) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _get26768;
		global::java.lang.Object java.util.Map.get(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.SortedMap_.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.SortedMap_._get26768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put26769;
		global::java.lang.Object java.util.Map.put(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.SortedMap_.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.SortedMap_._put26769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals26770;
		bool java.util.Map.equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.SortedMap_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.SortedMap_._equals26770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _values26771;
		global::java.util.Collection java.util.Map.values()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.SortedMap_.staticClass, "values", "()Ljava/util/Collection;", ref global::java.util.SortedMap_._values26771) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26772;
		int java.util.Map.hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.SortedMap_.staticClass, "hashCode", "()I", ref global::java.util.SortedMap_._hashCode26772);
		}
		internal static global::MonoJavaBridge.MethodId _clear26773;
		void java.util.Map.clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.SortedMap_.staticClass, "clear", "()V", ref global::java.util.SortedMap_._clear26773);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26774;
		bool java.util.Map.isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.SortedMap_.staticClass, "isEmpty", "()Z", ref global::java.util.SortedMap_._isEmpty26774);
		}
		internal static global::MonoJavaBridge.MethodId _size26775;
		int java.util.Map.size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.SortedMap_.staticClass, "size", "()I", ref global::java.util.SortedMap_._size26775);
		}
		internal static global::MonoJavaBridge.MethodId _entrySet26776;
		global::java.util.Set java.util.Map.entrySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.SortedMap_.staticClass, "entrySet", "()Ljava/util/Set;", ref global::java.util.SortedMap_._entrySet26776) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _putAll26777;
		void java.util.Map.putAll(java.util.Map arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.SortedMap_.staticClass, "putAll", "(Ljava/util/Map;)V", ref global::java.util.SortedMap_._putAll26777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove26778;
		global::java.lang.Object java.util.Map.remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.SortedMap_.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.SortedMap_._remove26778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _keySet26779;
		global::java.util.Set java.util.Map.keySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.SortedMap_.staticClass, "keySet", "()Ljava/util/Set;", ref global::java.util.SortedMap_._keySet26779) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsValue26780;
		bool java.util.Map.containsValue(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.SortedMap_.staticClass, "containsValue", "(Ljava/lang/Object;)Z", ref global::java.util.SortedMap_._containsValue26780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey26781;
		bool java.util.Map.containsKey(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.SortedMap_.staticClass, "containsKey", "(Ljava/lang/Object;)Z", ref global::java.util.SortedMap_._containsKey26781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static SortedMap_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.SortedMap_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/SortedMap"));
		}
		internal static void InitJNI()
		{
		}
	}
}
