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
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.util.Collection java.util.SortedMap.values()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.SortedMap_.staticClass, "values", "()Ljava/util/Collection;", ref global::java.util.SortedMap_._m0) as java.util.Collection;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.util.Set java.util.SortedMap.entrySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.SortedMap_.staticClass, "entrySet", "()Ljava/util/Set;", ref global::java.util.SortedMap_._m1) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.util.Set java.util.SortedMap.keySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.SortedMap_.staticClass, "keySet", "()Ljava/util/Set;", ref global::java.util.SortedMap_._m2) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.util.Comparator java.util.SortedMap.comparator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Comparator>(this, global::java.util.SortedMap_.staticClass, "comparator", "()Ljava/util/Comparator;", ref global::java.util.SortedMap_._m3) as java.util.Comparator;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::java.util.SortedMap java.util.SortedMap.subMap(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.SortedMap>(this, global::java.util.SortedMap_.staticClass, "subMap", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedMap;", ref global::java.util.SortedMap_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.SortedMap;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		global::java.util.SortedMap java.util.SortedMap.headMap(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.SortedMap>(this, global::java.util.SortedMap_.staticClass, "headMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", ref global::java.util.SortedMap_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.SortedMap;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		global::java.util.SortedMap java.util.SortedMap.tailMap(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.SortedMap>(this, global::java.util.SortedMap_.staticClass, "tailMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", ref global::java.util.SortedMap_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.SortedMap;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		global::java.lang.Object java.util.SortedMap.firstKey()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.SortedMap_.staticClass, "firstKey", "()Ljava/lang/Object;", ref global::java.util.SortedMap_._m7) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		global::java.lang.Object java.util.SortedMap.lastKey()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.SortedMap_.staticClass, "lastKey", "()Ljava/lang/Object;", ref global::java.util.SortedMap_._m8) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		global::java.lang.Object java.util.Map.get(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.SortedMap_.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.SortedMap_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		global::java.lang.Object java.util.Map.put(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.SortedMap_.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.SortedMap_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		bool java.util.Map.equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.SortedMap_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.SortedMap_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		global::java.util.Collection java.util.Map.values()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.SortedMap_.staticClass, "values", "()Ljava/util/Collection;", ref global::java.util.SortedMap_._m12) as java.util.Collection;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		int java.util.Map.hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.SortedMap_.staticClass, "hashCode", "()I", ref global::java.util.SortedMap_._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		void java.util.Map.clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.SortedMap_.staticClass, "clear", "()V", ref global::java.util.SortedMap_._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		bool java.util.Map.isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.SortedMap_.staticClass, "isEmpty", "()Z", ref global::java.util.SortedMap_._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		int java.util.Map.size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.SortedMap_.staticClass, "size", "()I", ref global::java.util.SortedMap_._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		global::java.util.Set java.util.Map.entrySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.SortedMap_.staticClass, "entrySet", "()Ljava/util/Set;", ref global::java.util.SortedMap_._m17) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		void java.util.Map.putAll(java.util.Map arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.SortedMap_.staticClass, "putAll", "(Ljava/util/Map;)V", ref global::java.util.SortedMap_._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		global::java.lang.Object java.util.Map.remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.SortedMap_.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.SortedMap_._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		global::java.util.Set java.util.Map.keySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.SortedMap_.staticClass, "keySet", "()Ljava/util/Set;", ref global::java.util.SortedMap_._m20) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		bool java.util.Map.containsValue(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.SortedMap_.staticClass, "containsValue", "(Ljava/lang/Object;)Z", ref global::java.util.SortedMap_._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		bool java.util.Map.containsKey(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.SortedMap_.staticClass, "containsKey", "(Ljava/lang/Object;)Z", ref global::java.util.SortedMap_._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
