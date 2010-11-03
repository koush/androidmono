namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.concurrent.ConcurrentMap_))]
	public partial interface ConcurrentMap : Map
	{
		bool replace(java.lang.Object arg0, java.lang.Object arg1, java.lang.Object arg2);
		global::java.lang.Object replace(java.lang.Object arg0, java.lang.Object arg1);
		bool remove(java.lang.Object arg0, java.lang.Object arg1);
		global::java.lang.Object putIfAbsent(java.lang.Object arg0, java.lang.Object arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.ConcurrentMap))]
	internal sealed partial class ConcurrentMap_ : java.lang.Object, ConcurrentMap
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ConcurrentMap_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		bool java.util.concurrent.ConcurrentMap.replace(java.lang.Object arg0, java.lang.Object arg1, java.lang.Object arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ConcurrentMap_.staticClass, "replace", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z", ref global::java.util.concurrent.ConcurrentMap_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.Object java.util.concurrent.ConcurrentMap.replace(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.ConcurrentMap_.staticClass, "replace", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.concurrent.ConcurrentMap_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		bool java.util.concurrent.ConcurrentMap.remove(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ConcurrentMap_.staticClass, "remove", "(Ljava/lang/Object;Ljava/lang/Object;)Z", ref global::java.util.concurrent.ConcurrentMap_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.lang.Object java.util.concurrent.ConcurrentMap.putIfAbsent(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.ConcurrentMap_.staticClass, "putIfAbsent", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.concurrent.ConcurrentMap_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::java.lang.Object java.util.Map.get(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.ConcurrentMap_.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.concurrent.ConcurrentMap_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		global::java.lang.Object java.util.Map.put(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.ConcurrentMap_.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.concurrent.ConcurrentMap_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		bool java.util.Map.equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ConcurrentMap_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.ConcurrentMap_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		global::java.util.Collection java.util.Map.values()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.concurrent.ConcurrentMap_.staticClass, "values", "()Ljava/util/Collection;", ref global::java.util.concurrent.ConcurrentMap_._m7) as java.util.Collection;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		int java.util.Map.hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.ConcurrentMap_.staticClass, "hashCode", "()I", ref global::java.util.concurrent.ConcurrentMap_._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		void java.util.Map.clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ConcurrentMap_.staticClass, "clear", "()V", ref global::java.util.concurrent.ConcurrentMap_._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		bool java.util.Map.isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ConcurrentMap_.staticClass, "isEmpty", "()Z", ref global::java.util.concurrent.ConcurrentMap_._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		int java.util.Map.size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.ConcurrentMap_.staticClass, "size", "()I", ref global::java.util.concurrent.ConcurrentMap_._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		global::java.util.Set java.util.Map.entrySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.concurrent.ConcurrentMap_.staticClass, "entrySet", "()Ljava/util/Set;", ref global::java.util.concurrent.ConcurrentMap_._m12) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		void java.util.Map.putAll(java.util.Map arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ConcurrentMap_.staticClass, "putAll", "(Ljava/util/Map;)V", ref global::java.util.concurrent.ConcurrentMap_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		global::java.lang.Object java.util.Map.remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.ConcurrentMap_.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.concurrent.ConcurrentMap_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		global::java.util.Set java.util.Map.keySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.concurrent.ConcurrentMap_.staticClass, "keySet", "()Ljava/util/Set;", ref global::java.util.concurrent.ConcurrentMap_._m15) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		bool java.util.Map.containsValue(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ConcurrentMap_.staticClass, "containsValue", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.ConcurrentMap_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		bool java.util.Map.containsKey(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ConcurrentMap_.staticClass, "containsKey", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.ConcurrentMap_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static ConcurrentMap_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.ConcurrentMap_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ConcurrentMap"));
		}
	}
}
